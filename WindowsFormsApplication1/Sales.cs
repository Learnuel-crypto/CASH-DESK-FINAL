using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1
    {

    public class setSales
        {
        public int ItemID = 0;
        private int Quantity = 0;
        private string Amount;
        private string ItemName;
        public static long Total = 0;
        SqlConnection con = new DBConnection().getConnection();
         
        /// <summary>
        /// SALES ACTIVITIES
        /// </summary>
        /// <returns></returns>
        public int getItemID()
            {
            return this.ItemID;
            }
        public void SetItemName(string name)
            {
            checkItemName(name);
            this.ItemName = name;
            }
        public string GetItemName()
            {
            return ItemName;
            }
        public void SetQuantity(string quantity)
            {
            try
                {
                if (string.IsNullOrEmpty(quantity))
                    {
                    throw new Exception("Quantity can't be empty");
                    }
                if (quantity.StartsWith("0") || quantity.StartsWith("."))
                    {
                    throw new Exception("Quantity can't begin with 0 or dot(.)");
                    }
                var qty = int.Parse(quantity);
                if (qty < 1)
                    {
                    throw new Exception("Quantity must be greater than 0");
                    }
                this.Quantity = qty;
                }
            catch (ArgumentNullException ex)
                {
                throw new ExceptionHandling("Quantity is empty" , ex);
                }
            catch (Exception ex)
                {
                throw new ExceptionHandling("Quantity is not Valid" , ex);
                }
            }
        public int GetQuantity()
            {
            return Quantity;
            }
        public void SetSellinPrice(string amount)
            {
            try
                {
                if (string.IsNullOrEmpty(amount))
                    {
                    throw new Exception("Amount Can't be empty");
                    }
                if (amount.StartsWith("0") || amount.StartsWith("."))
                    {
                    throw new Exception("Quantity can't begin with 0 or dot(.)");
                    }
                var cost = Int32.Parse(amount);
                if (cost < 1)
                    {
                    throw new Exception("Quantity must be greater than 0");
                    }
                this.Amount = amount;
                }
            catch (Exception ex)
                {
                throw new ExceptionHandling("Amount is not Valid" , ex);
                }
            }
        public string GetSellingPrice()
            {
            return Amount;
            }
        private void checkItemName(string itemname)
            {
            try
                {
                //chenck to see if the item already exist

                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@item",SqlDbType.VarChar));
                cmd.Parameters["@item"].Value=itemname;
                cmd.CommandText = "SELECT Item FROM SetSales WHERE  Item=@item";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        reader.Close();
                        throw new Exception("Items have same name");
                        }

                    }
                reader.Close();
                con.Close();
            }
            catch (Exception Ex)
                {
                con.Close();
                throw new ExceptionHandling("Item Already Exist, Check the name entered" , Ex);
        }
    }
        public void RecordSaleItems(string name , int quantity , string price, string totalamount , DateTimePicker date_added)
            {
            try
                {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Item" , name); 
                cmd.Parameters.AddWithValue("@Quantity" , quantity);
                cmd.Parameters.AddWithValue("@Selling_Price" , price); 
                cmd.Parameters.AddWithValue("@Total_Amount" , totalamount);
                cmd.Parameters.AddWithValue("@Date_Added" , date_added.Value.ToString("MM/dd/yyy"));
                cmd.CommandText = "INSERT INTO SetSales(Item,Quantity,Selling_Price,Total_Amount,Date_Added) VALUES(@Item,@Quantity,@Selling_Price,@Total_Amount,@Date_Added);"+
                  "  INSERT INTO SalesStock(Item,Quantity,Selling_Price,Total_Amount,Date_Added) VALUES(@Item,@Quantity,@Selling_Price,@Total_Amount,@Date_Added)";
                cmd.ExecuteNonQuery();
                con.Close();
                dataAccess.Description = "Added " + name;
                dataAccess.Activities();
            } catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Could not record item" , ex);
        }
    }
        public static void Items(DataGridView view)
            {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM SetSales ORDER BY Date_Added DESC" , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            var total = 0;
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                view.Rows[n].Cells[3].Value = string.Format("{0:00}" , dr[3]);
                view.Rows[n].Cells[4].Value = string.Format("{0:00}" , dr[4]);
                total = total + Convert.ToInt32(dr[4]);
                view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                view.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , dr[6]);
                Total = total;
                }
            con.Close();
            }
        public static void DisplayStock(DataGridView view)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_display_stock", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            var total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00}" , dr[4]);
                total = total + Convert.ToInt32(dr[4]);
                view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                Total = total;
                }
            con.Close();
        }
        public static void DisplayStockThroughDate(DataGridView view,DateTimePicker from,DateTimePicker to,string searchText)
        {
            SqlConnection con = new DBConnection().getConnection();
            if(string.IsNullOrEmpty(searchText)){
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Stock_Id, Item,Quantity,Selling_Price,Total_Amount,Date_Added FROM SalesStock"+
                                " WHERE Date_Added BETWEEN @datefrom AND @dateto", con);
            da.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = from.Value.ToString();
            da.SelectCommand.Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = to.Value.ToString();
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            var total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00}", dr[4]);
                total = total + Convert.ToInt32(dr[4]);
                view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}", dr[5]);
                Total = total;
            }
            con.Close();
            }else{
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Stock_Id,Item,Quantity,Selling_Price,Total_Amount,Date_Added from SalesStock" +
                                   " WHERE Date_Added BETWEEN @datefrom AND @dateto AND Item =@item", con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = from.Value.ToString();
                da.SelectCommand.Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = to.Value.ToString();
                da.SelectCommand.Parameters.AddWithValue("@item", SqlDbType.VarChar).Value = searchText;
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            var total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00}", dr[4]);
                total = total + Convert.ToInt32(dr[4]);
                view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}", dr[5]);
                Total = total;
            }
            con.Close();
            }
        }
        public static void SearchStock(DataGridView view,string searchText)
        {
            try{  
        SqlConnection con = new DBConnection().getConnection();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = " SELECT Stock_Id, Item,Quantity,Selling_Price, Total_Amount,Date_Added FROM SalesStock WHERE Item=@search  ORDER BY Date_Added DESC";
                cmd.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmd.Parameters["@search"].Value = searchText;
                SqlDataReader reader = cmd.ExecuteReader();
                var total = 0;
                view.Rows.Clear();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = reader[0].ToString();
                        view.Rows[n].Cells[1].Value = reader[1].ToString();
                        view.Rows[n].Cells[2].Value = reader[2].ToString();
                        view.Rows[n].Cells[3].Value = reader[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00}" , reader[4]);
                        total = total + Convert.ToInt32(reader[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , reader[5]); 
                        Total = total;
                        }
                    }
                reader.Close();
                con.Close();
                } catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the search", ex);
            }
        }
        public static void SearchStockAllWithDate(DataGridView view,DateTimePicker datefrom,DateTimePicker dateto, string searchText)
        {
            try
            {

                if(string.IsNullOrEmpty(searchText)){

                     SqlConnection con = new DBConnection().getConnection();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = " SELECT Stock_Id,Item,Quantity,Selling_Price, Total_Amount,Date_Added FROM SalesStock WHERE Date_Added BETWEEN @datefrom AND @dateto  ORDER BY Date_Added DESC";
                cmd.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.VarChar));  
                cmd.Parameters["@datefrom"].Value = datefrom.Value.ToString();
                cmd.Parameters["@dateto"].Value = dateto.Value.ToString();
                SqlDataReader reader = cmd.ExecuteReader();
                var total = 0;
                view.Rows.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = reader[0].ToString();
                        view.Rows[n].Cells[1].Value = reader[1].ToString();
                        view.Rows[n].Cells[2].Value = reader[2].ToString();
                        view.Rows[n].Cells[3].Value = reader[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00}", reader[4]);
                        total = total + Convert.ToInt32(reader[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}", reader[5]);
                        Total = total;
                    }
                }
                reader.Close();
                con.Close();

                }else{
                SqlConnection con = new DBConnection().getConnection();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = " SELECT Stock_Id Item,Quantity,Selling_Price, Total_Amount,Date_Added FROM SalesStock WHERE Date_Added BETWEEN @datefrom AND  @dateto Item=@search  ORDER BY Date_Added DESC";
                cmd.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@dateto", SqlDbType.VarChar));
                cmd.Parameters["@search"].Value = searchText;
                cmd.Parameters["@datefrom"].Value = searchText;
                cmd.Parameters["@dateto"].Value = searchText;
                SqlDataReader reader = cmd.ExecuteReader();
                var total = 0;
                view.Rows.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = reader[0].ToString();
                        view.Rows[n].Cells[1].Value = reader[1].ToString();
                        view.Rows[n].Cells[2].Value = reader[2].ToString();
                        view.Rows[n].Cells[3].Value = reader[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00}", reader[4]);
                        total = total + Convert.ToInt32(reader[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}", reader[5]);
                        Total = total;
                    }
                }
                reader.Close();
                con.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     public static void SearchStockAll(DataGridView view , string search)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = " SELECT Stock_Id,Item,Quantity,Selling_Price, Total_Amount,Date_Added FROM SalesStock WHERE Item LIKE'%' + @search + '%' OR Quantity LIKE'%' + @search + '%' OR Total_Amount LIKE'%' + @search + '%' ORDER BY Date_Added DESC";
                cmd.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmd.Parameters["@search"].Value = search;
                SqlDataReader reader = cmd.ExecuteReader();
                var total = 0;
                view.Rows.Clear();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = reader[0].ToString();
                        view.Rows[n].Cells[1].Value = reader[1].ToString();
                        view.Rows[n].Cells[2].Value = reader[2].ToString();
                        view.Rows[n].Cells[3].Value = reader[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00}" , reader[4]);
                        total = total + Convert.ToInt32(reader[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , reader[5]); 
                        Total = total;
                        }
                    }
                reader.Close();
                con.Close();
                } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        public static void SearchItems(DataGridView view , string search)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT *FROM SetSales WHERE SetSales.Item LIKE'%' + @search + '%' OR Quantity LIKE'%' + @search + '%' OR Total_Amount LIKE'%' + @search + '%' ORDER BY Date_Added DESC";
                cmd.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmd.Parameters["@search"].Value = search;
                SqlDataReader reader = cmd.ExecuteReader();
                var total = 0;
                view.Rows.Clear();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = reader[0].ToString();
                        view.Rows[n].Cells[1].Value = reader[1].ToString();
                        view.Rows[n].Cells[2].Value = reader[2].ToString();
                        view.Rows[n].Cells[3].Value = string.Format("{0:00}" , reader[3]);
                        view.Rows[n].Cells[4].Value = string.Format("{0:00}" , reader[4]);
                        total = total + Convert.ToInt32(reader[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , reader[5]);
                        view.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , reader[6]);
                        Total = total;
                        }
                    }
                reader.Close();
                con.Close();
                } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        public static void DeleteStock(string stockid)
        {
            try
            {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM SalesStock WHERE Stock_Id ='" + stockid + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new ExceptionHandling("Delete was not successful", ex);
            }


        }
        public static void SearchItems(DataGridView view , DateTimePicker search)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT *FROM SetSales WHERE SetSales.Date_Added =@date ORDER BY Item DESC";
                cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmd.Parameters["@date"].Value = search.Value.ToString("M/dd/yyyy");
                SqlDataReader reader = cmd.ExecuteReader();
                var total = 0;
                view.Rows.Clear();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = reader[0].ToString();
                        view.Rows[n].Cells[1].Value = reader[1].ToString();
                        view.Rows[n].Cells[2].Value = reader[2].ToString();
                        view.Rows[n].Cells[3].Value = string.Format("{0:00}" , reader[3]);
                        view.Rows[n].Cells[4].Value = string.Format("{0:00}" , reader[4]);
                        total = total + Convert.ToInt32(reader[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , reader[5]);
                        view.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , reader[6]);
                        Total = total;
                        }
                    }
                reader.Close();
                con.Close();
                }
            catch (Exception)
                {

                }
            }
        public void UpdateSaleItems(int id,string name, int quantity , string price , string totalamount , DateTimePicker date_added)
            {
            try
                {
                SqlCommand cmd = new SqlCommand();
            con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Item" , name);
                cmd.Parameters.AddWithValue("@Quantity" , quantity);
                cmd.Parameters.AddWithValue("@Selling_Price" , price);
                cmd.Parameters.AddWithValue("@total_Amount" , totalamount);
                cmd.Parameters.AddWithValue("@Date_Updated" , date_added.Value.ToString("MM/dd/yyy"));

                cmd.CommandText = "UPDATE SetSales SET Item=@Item,Quantity=@Quantity,Selling_Price=@Selling_Price,total_Amount=@total_Amount,Date_Updated=@Date_Updated WHERE Item_Id="+id+";"+
                    "INSERT INTO SalesStock(Item,Quantity,Selling_Price,Total_Amount,Date_Added) VALUES(@Item,@Quantity,@Selling_Price,@Total_Amount,@Date_Updated)";
                cmd.ExecuteNonQuery();
                con.Close(); 
                dataAccess.Description = "Updated " + name;
                dataAccess.Activities();
            }
            catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Could not record item" , ex);
        }

    }
        public  void Delete(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE SalesStock WHERE Item IN (SELECT Item FROM SetSales WHERE Item_Id =@id);DELETE Sales WHERE Item_Id =@id ;DELETE SetSales WHERE Item_Id =@id;", con);
                 
                cmd.Parameters.Add(new SqlParameter("@id" , SqlDbType.VarChar));
                cmd.Parameters["@id"].Value = id;
                cmd.ExecuteNonQuery(); 
                con.Close(); 
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Item could not be Deleted\nTry Again ",Ex);
            }
        }
      
        //GET THE QUATITY OF A PARTICULAR STOCK
        public static void StockInfor(string searchText,Label totalQty, Label qtySold,Label qtyAvail)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
               // get total quatity
               
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT Quantity FROM SetSales WHERE Item=@search";
                cmd.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmd.Parameters["@search"].Value = searchText;
                SqlDataReader reader = cmd.ExecuteReader();
                int total = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    { 
                      total= int.Parse( reader["Quantity"].ToString());
                        
                    }
                }
                reader.Close(); 

                //get the quantity sold 
                SqlCommand cmd2 = new SqlCommand(); 
                
               var query=" SELECT SUM(Qty_Sold) FROM Sales_Report WHERE Names_of_Items=@search";
               SqlDataAdapter da = new SqlDataAdapter(query, con);
               da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = searchText; ;
               
                DataTable dt = new DataTable();
               da.Fill(dt);
               long sold = 0;
               int x = dt.Rows.Count;
               if (x > 0)
               {
                   foreach (DataRow dr in dt.Rows)
                   {

                       sold =string.IsNullOrEmpty(dr[0].ToString())? 0: Int32.Parse( dr[0].ToString());
                       
                   }

               } 
                con.Close();

                totalQty.Text = total.ToString();
                qtySold.Text = sold.ToString();
                var avail = total - sold;
                qtyAvail.Text = avail.ToString();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("There was error in the search", ex);
            }
        }
     
    }
}
