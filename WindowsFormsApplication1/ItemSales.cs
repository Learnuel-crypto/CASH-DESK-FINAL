using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public class ItemSales : setSales
        {
        public static float TotalSale = 0.00f;
        public static float Amount = 0.00f;
        public static float TodayTotal = 0.00f;
        public static string ItemName;
        private static bool SaleMade = false;
        private static bool SaleDeleted = false;
        CreditSales creditsales = new CreditSales();
        CreditSales creditsale = new CreditSales();
        public static bool isSaleMade()
            {
            return SaleMade;
            }
        public static bool isSaleDeleted()
            {
            return SaleDeleted;
            }
        public static void getItemName(ComboBox itemname)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Item_Id, Item FROM SetSales" , con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int x = dt.Rows.Count;
                itemname.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    itemname.Items.Add(dr["Item_Id"].ToString());
                    }
                }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("Operation failed" , Ex);
                }
            }
        //TO MAKE SURE QUANT AVAILABLE EQUAL QUATITY SOLD
        public static int checkItemQuantity(int itemid)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Quantity FROM SetSales WHERE SetSales.Item_Id=@itemid " , con);
                da.SelectCommand.Parameters.AddWithValue("@itemid" , SqlDbType.VarChar).Value = itemid;
                DataTable dt = new DataTable();
                da.Fill(dt);
                var availableQuantity = 0;
                foreach (DataRow dr in dt.Rows)
                    {
                    availableQuantity = Convert.ToInt32((dr["Quantity"].ToString()));
                    }
                return availableQuantity;
                }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("Operation could not complete" , Ex);
                }
            }
        
            public static int checkItemQuantitySold(int itemid)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Qty  FROM Sales WHERE Item_Id=@itemid" , con);
                da.SelectCommand.Parameters.AddWithValue("@itemid" , SqlDbType.VarChar).Value = itemid;
                DataTable dt = new DataTable();
                da.Fill(dt);
                var QuantitySold = 0;
                foreach (DataRow dr in dt.Rows)
                    {
                    QuantitySold += Convert.ToInt32((dr["Qty"].ToString()));
                    }
                return QuantitySold;
                }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("Operation could not complete" , Ex);
                }
            }
        public static int setSellinPrice(int itemid)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Selling_Price FROM SetSales WHERE Item_Id=@itemid" , con);
                da.SelectCommand.Parameters.AddWithValue("@itemid" , SqlDbType.VarChar).Value = itemid;
                DataTable dt = new DataTable();
                da.Fill(dt);
                var sellingPrice = 0;
                foreach (DataRow dr in dt.Rows)
                    {
                    sellingPrice = Convert.ToInt32(dr["Selling_Price"]);
                    }
                return sellingPrice;
                }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("An Error Occurred" , Ex);
                }
            }
        public static void DispayItems(DataGridView view,string item)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                string Query;
                if (string.IsNullOrEmpty(item))
                    {
                    Query = Query = "SELECT Item_Id,Item FROM SetSales";
                    SqlDataAdapter da = new SqlDataAdapter(Query , con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();

                        }
                    con.Close();
                    }
                else
                    {
                    Query = "SELECT Item_Id,Item FROM SetSales WHERE Item LIKE'%' + @item + '%'";

                    SqlDataAdapter da = new SqlDataAdapter(Query , con);
                    da.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();

                        }
                    con.Close();
                    
                    }
               
                }
            catch(Exception ex)
                {

                }
            }
        public static void makeSale(int itemid ,int qty_Avail, string Quantity , string cost , string total , DateTimePicker dDate , string discount , int credit = 0, string nameid=null)
            {
            SqlConnection con = new DBConnection().getConnection();
            try
                { 
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Item_Id" , itemid);
                cmd.Parameters.AddWithValue("@UserName" , AdminLog.Admin);
                cmd.Parameters.AddWithValue("@Qty" , Quantity);
                cmd.Parameters.AddWithValue("@Cost" , cost);
                cmd.Parameters.AddWithValue("@Discount" , discount);
                cmd.Parameters.AddWithValue("@Amount" , total);
                cmd.Parameters.AddWithValue("@Sold_Date" , dDate.Value.ToString("MM/dd/yyy"));
                cmd.Parameters.AddWithValue("@Qty_Avail" , qty_Avail); 
                if (nameid == null)
                {
                cmd.CommandText = "INSERT INTO Sales(Item_Id,UserName,Qty,Cost,Discount,Amount,Sold_Date,Qty_Avail) VALUES(@Item_Id,@UserName,@Qty,@Cost,@Discount,@Amount,@Sold_Date,@Qty_Avail)";

                }
            else
                {
                cmd.Parameters.AddWithValue("@Name_id" , nameid);
                cmd.CommandText = "INSERT INTO Sales(Item_Id,UserName,Qty,Cost,Discount,Amount,Sold_Date,Name_id,Qty_Avail) VALUES(@Item_Id,@UserName,@Qty,@Cost,@Discount,@Amount,@Sold_Date,@Name_id,@Qty_Avail)";
                }
                cmd.ExecuteNonQuery();

                if (credit != 0)
                    { 
                SqlDataAdapter da = new SqlDataAdapter("SELECT Max(Sales_Id) FROM  Sales  " , con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                var saleId = 0;
                foreach (DataRow dr in dt.Rows)
                    { 
                       saleId = Int32.Parse(dr[0].ToString());
                     } 
                CreditSales creditsale = new CreditSales();
                CreditSales.RecordCreditor(saleId , creditsale.GetCreditorFirstname() , creditsale.GetCreditorLastname() , creditsale.GetCreditorContact());
                     
                    }
                SaleMade = true;
            con.Close();
            }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("An Error Occurred",Ex);
        }
    }

        public static void TodaySales(DataGridView view)
            {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Sales_Report WHERE  Sold_Date=@date" , con);
            da.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = DateTime.Now.Date;
            DataTable dt = new DataTable();
            da.Fill(dt);
            TodayTotal = 0;
            view.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , dr[2]);
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dr[4]);
                view.Rows[n].Cells[5].Value = dr[5].ToString();
                int today = Convert.ToInt32(dr[6]);
                TodayTotal = TodayTotal + today;
                view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6]); 
                view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);
                view.Rows[n].Cells[8].Value = dr[8].ToString();
                  
                }
            }
        public static void AllSales(DataGridView view, string search)
            {
            string query;
            if (string.IsNullOrEmpty(search))
                {
                query = "SELECT *FROM Sales_Report ORDER BY Sold_Date,Names_of_Items";
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query , con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TodayTotal = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , dr[2]);
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dr[4]);
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6]);
                    int today = Convert.ToInt32(dr[6]);
                    TodayTotal = TodayTotal + today;
                    view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);
                    view.Rows[n].Cells[8].Value = dr[8].ToString();
                    view.Rows[n].Cells[9].Value = dr[9].ToString();
                    }
                }
            else
                {
                query = "SELECT *FROM Sales_Report WHERE Names_of_Items LIKE'%' + @search + '%'  OR Qty_Sold LIKE'%' + @search + '%' OR Cost LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%' ORDER BY Sold_Date,Names_of_Items,Amount";

                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query , con);
                da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
                DataTable dt = new DataTable();
                da.Fill(dt);
                TodayTotal = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , dr[2]);
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dr[4]);
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6]);
                    int today = Convert.ToInt32(dr[6]);
                    TodayTotal = TodayTotal + today;
                    view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);
                    view.Rows[n].Cells[8].Value = dr[8].ToString();
                    view.Rows[n].Cells[9].Value = dr[9].ToString();
                    }
                }
            

            }
        public static void AllSalesBetweenDate(DataGridView view,DateTimePicker from,DateTimePicker To)
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Sales_Report WHERE Sold_Date BETWEEN @datefrom AND @dateto ORDER BY Sold_Date,Names_of_Items" , con);
            da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
            da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = To.Value.ToString("MM/dd/yyyy");
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            TodayTotal = 0;
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , dr[2]);
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dr[4]);
                view.Rows[n].Cells[5].Value = dr[5].ToString();
                view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6]);
                int today = Convert.ToInt32(dr[6]);
                TodayTotal = TodayTotal + today;
                view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);
                view.Rows[n].Cells[8].Value = dr[8].ToString();
                view.Rows[n].Cells[9].Value = dr[9].ToString();
                }

            }
        public static void AllSalesBetweenDate(DataGridView view , DateTimePicker from , DateTimePicker To,string item)
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Sales_Report WHERE Sold_Date BETWEEN @datefrom AND @dateto AND Names_of_Items=@item ORDER BY Sold_Date,Names_of_Items" , con);
            da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
            da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = To.Value.ToString("MM/dd/yyyy");
            da.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            TodayTotal = 0;
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , dr[2]);
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dr[4]);
                view.Rows[n].Cells[5].Value = dr[5].ToString();
                view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6]);
                int today = Convert.ToInt32(dr[6]);
                TodayTotal = TodayTotal + today;
                view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);
                view.Rows[n].Cells[8].Value = dr[8].ToString();
                view.Rows[n].Cells[9].Value = dr[9].ToString();
                }

            }

        public static void AllSalesBetweenDate(DataGridView view , DateTimePicker from )
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Sales_Report WHERE Sold_Date=@datefrom ORDER BY Names_of_Items" , con);
            da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            TodayTotal = 0;
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , dr[2]);
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dr[4]);
                view.Rows[n].Cells[5].Value = dr[5].ToString();
                view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6]);
                int today = Convert.ToInt32(dr[6]);
                TodayTotal = TodayTotal + today;
                view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);
                view.Rows[n].Cells[8].Value = dr[8].ToString();
                 
                }

            }
        public static void DispayStudentNames(DataGridView view , string name)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                string Query;
                if (string.IsNullOrEmpty(name))
                    {
                    Query = Query = "SELECT Name_id,First_Name,Last_Name FROM Names";
                    SqlDataAdapter da = new SqlDataAdapter(Query , con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        }
                    con.Close();
                    }
                else
                    {
                    Query = "SELECT Name_id,First_Name,Last_Name  FROM Names WHERE First_Name LIKE'%' + @name + '%' OR Last_Name LIKE'%' + @name + '%' ORDER BY First_Name ";
                    SqlDataAdapter da = new SqlDataAdapter(Query , con);
                    da.SelectCommand.Parameters.AddWithValue("@name" , SqlDbType.VarChar).Value = name;
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        }
                    con.Close();
                    }
                
                }
            catch (Exception)
                {

                }
            }
        public static void ItemNames(ComboBox item)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Item FROM SetSales WHERE Item_id IN (SELECT Item_id FROM Sales)" , con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                item.Items.Clear(); 
                foreach (DataRow dr in dt.Rows)
                    {
                    item.Items.Add( dr["Item"].ToString());
                    }

                }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("Operation could not complete" , Ex);
                }
            }
        public static void StockNames(ComboBox item)
        {
            try
            {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Item FROM SalesStock", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                item.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    item.Items.Add(dr["Item"].ToString());
                }

            }
            catch (Exception Ex)
            {
                throw new ExceptionHandling("Operation could not complete", Ex);
            }
        }
        public static void TodaySalesItems(DataGridView today,string item)
            {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlDataAdapter Tda = new SqlDataAdapter("SELECT *FROM Sales_Report WHERE  Sold_Date=@date AND Names_of_Items=@item ORDER BY Names_of_Items" , con);
            Tda.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = DateTime.Now.Date.ToString("MM/dd/yyyy");
            Tda.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
            DataTable dt = new DataTable();
            Tda.Fill(dt);
            today.Rows.Clear();
            TodayTotal = 0;
            foreach (DataRow Tdr in dt.Rows)
                {
                int n = today.Rows.Add();
                today.Rows[n].Cells[0].Value = Tdr[0].ToString();
                today.Rows[n].Cells[1].Value = Tdr[1].ToString();
                today.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , Tdr[2]);
                today.Rows[n].Cells[3].Value = Tdr[3].ToString();
                today.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , Tdr[4]);
                today.Rows[n].Cells[5].Value = Tdr[5].ToString();
                today.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , Tdr[6]);
                int tday = Convert.ToInt32(Tdr[6]);
                TodayTotal = TodayTotal + tday;
                today.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , Tdr[7]);
                today.Rows[n].Cells[8].Value = Tdr[8].ToString();
                 
                }

            }
        public static void AllSalesBetweenDate(DataGridView today , DateTimePicker Ddate , string item)
            {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlDataAdapter Tda = new SqlDataAdapter("SELECT *FROM Sales_Report WHERE  Sold_Date=@date AND Names_of_Items=@item ORDER BY Names_of_Items" , con);
            Tda.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = Ddate.Value.ToString("MM/dd/yyyy");
            Tda.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
            DataTable dt = new DataTable();
            Tda.Fill(dt);
            today.Rows.Clear();
            TodayTotal = 0;
            foreach (DataRow Tdr in dt.Rows)
                {
                int n = today.Rows.Add();
                today.Rows[n].Cells[0].Value = Tdr[0].ToString();
                today.Rows[n].Cells[1].Value = Tdr[1].ToString();
                today.Rows[n].Cells[2].Value = string.Format("{0:00.#0}" , Tdr[2]);
                today.Rows[n].Cells[3].Value = Tdr[3].ToString();
                today.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , Tdr[4]);
                today.Rows[n].Cells[5].Value = Tdr[5].ToString();
                today.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , Tdr[6]);
                int tday = Convert.ToInt32(Tdr[6]);
                TodayTotal = TodayTotal + tday;
                today.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , Tdr[7]);
                today.Rows[n].Cells[8].Value = Tdr[8].ToString();
                 
                }
            }
      public static void DeleteSale(int itemid)
            {
           try{
                
                SqlConnection con = new DBConnection().getConnection();
            con.Open();
                SqlCommand cmd = new SqlCommand("DELETE  Sales WHERE Sales_Id ="+itemid+"" , con);
            cmd.ExecuteNonQuery();
            con.Close();
                SaleDeleted = true;
                }
        catch (Exception ex)
                {
                throw new ExceptionHandling("Record could not be deleted" , ex);
                }
            }
        public static void DeleteSale(DateTimePicker dateDel)
            {
            try
                {

                SqlConnection con = new DBConnection().getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@delDate" , SqlDbType.VarChar));
                cmd.Parameters["@delDate"].Value = dateDel.Value.ToString("MM/dd/yyyy");
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  Sales WHERE Sold_Date =@delDate";
                cmd.ExecuteNonQuery();
                con.Close();
                SaleDeleted = true;
                }
            catch (Exception ex)
                {
                throw new ExceptionHandling("Records could not be deleted" , ex);
                }
            }
        }
    }
