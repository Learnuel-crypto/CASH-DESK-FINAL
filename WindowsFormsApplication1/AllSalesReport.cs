using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class AllSalesReport
        {

        private static string Qty_Sold;
        private static long  Amount;
        public static long Total;
        
        public static int CheckItemReport(string item,DateTime repDate)
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Sold_Date FROM Sales WHERE Sold_Date IN(SELECT Date_Sold FROM All_Sales_Report WHERE All_Sales_Report.Item=@item AND All_Sales_Report.Date_Sold =@date) " , con);
            da.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
            da.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = repDate.ToString("MM/dd/yyyy");
            DataTable dt = new DataTable();
            da.Fill(dt);
            int x = dt.Rows.Count;
            if (x <= 0)
                {
                SqlDataAdapter dat = new SqlDataAdapter("SELECT SUM(Qty_Sold),SUM(Amount) FROM Sales_Report WHERE Names_of_Items=@item AND Sold_Date=@date" , con);
                dat.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
                dat.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = repDate.ToString("MM/dd/yyyy");
                DataTable dtable = new DataTable();
                dat.Fill(dtable);
                int y = dtable.Rows.Count;
                if (y > 0)
                    {
                    foreach (DataRow drw in dtable.Rows)
                        {
                        Qty_Sold = drw[0].ToString();
                        Amount =Convert.ToInt32( drw[1]);
                        }
                    }
                }
            else
                {
                    con.Close();
                throw new Exception("Selected Item Alredy exist in report for selected Date");
                }
            return x;
            }
        public static void InsertReport(string item,DateTime sold_Date)
            {
            SqlConnection con = new DBConnection().getConnection();
            try
                {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Item" , item);
                cmd.Parameters.AddWithValue("@Qty_Sold" , Qty_Sold);
                cmd.Parameters.AddWithValue("@Amount" , Amount);
                cmd.Parameters.AddWithValue("@Date_Sold" , sold_Date.ToString("MM/dd/yyy"));
                cmd.Parameters.AddWithValue("@Report_Date" , DateTime.Today.ToString("MM/dd/yyy"));
                cmd.CommandText = "INSERT INTO All_Sales_Report(Item,Qty_Sold,Amount,Date_Sold,Report_Date) VALUES(@Item,@Qty_Sold,@Amount,@Date_Sold,@Report_Date)";
                cmd.ExecuteNonQuery();
                con.Close();
                }
            catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Item report was not succesful" , ex);
                }
            }
         
        public static void DisplayReport(DataGridView view)
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                { 
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM All_Sales_Report ORDER BY Report_Date,Item DESC" , con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    int today = Convert.ToInt32(dr[3]);
                    Total = Total + today;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                    view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                    }
                }catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Sales report failed to Load\nTry again" , ex);
                }
            }
        public static void DisplayReport(DataGridView view,string search)
            {
                SqlConnection con = new DBConnection().getConnection();
            try { 
            if (string.IsNullOrEmpty(search)) {
               var query = "SELECT *FROM All_Sales_Report ORDER BY Report_Date,Item DESC";

                SqlDataAdapter da = new SqlDataAdapter(query , con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    int today = Convert.ToInt32(dr[3]);
                    Total = Total + today;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                    view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                }
                    }
            else
                {
               var query = "SELECT *FROM All_Sales_Report WHERE Item LIKE'%'+ @search+ '%' OR Qty_Sold LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%' ORDER BY Report_Date,Item DESC";

                SqlDataAdapter da = new SqlDataAdapter(query , con);
                da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = search;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    int today = Convert.ToInt32(dr[3]);
                    Total = Total + today;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                    view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                }
                    }
           
                }
            catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Sales report failed to Load\nTry again" , ex);
                }
            }
        public static void DisplaySelectedReport(DataGridView view , string search)
            {
                SqlConnection con = new DBConnection().getConnection();
            try { 
             
            string query = "SELECT *FROM All_Sales_Report WHERE Item =@search ORDER BY Item,Report_Date DESC";
                
            SqlDataAdapter da = new SqlDataAdapter(query , con);
            da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = search;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Total = 0;
            view.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                int today = Convert.ToInt32(dr[3]);
                Total = Total + today;
                view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                }
                }
            catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Sales report failed to Load\nTry again" , ex);
                }
            }
        public static void AllReportBetweenDate(DataGridView view , DateTimePicker Ddate , string item)
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                { 
                con.Open();
                string search;
                if (string.IsNullOrEmpty(item))
                    {
                    search = "SELECT *FROM All_Sales_Report WHERE  Report_Date=@reportdate ORDER BY Report_Date,Item DESC";
                    SqlDataAdapter Tda = new SqlDataAdapter(search , con);

                    DataTable dt = new DataTable();
                    Tda.SelectCommand.Parameters.AddWithValue("@reportdate" , SqlDbType.VarChar).Value = Ddate.Value.ToString("MM/dd/yyyy");
                    Tda.Fill(dt);
                    Total = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        int today = Convert.ToInt32(dr[3]);
                        Total = Total + today;
                        view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                        view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                    }
                    }
                else
                    {
                    search = "SELECT *FROM All_Sales_Report WHERE  Report_Date=@reportdate AND Item=@search ORDER BY Report_Date,Item DESC";
                    SqlDataAdapter Tda = new SqlDataAdapter(search , con);

                    DataTable dt = new DataTable();
                    Tda.SelectCommand.Parameters.AddWithValue("@reportdate" , SqlDbType.VarChar).Value = Ddate.Value.ToString("MM/dd/yyyy");
                    Tda.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = item;
                    Tda.Fill(dt);
                    Total = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        int today = Convert.ToInt32(dr[3]);
                        Total = Total + today;
                        view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                        view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                    }

                    }
                
                }
            catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Sales report failed to Load\nTry again" , ex);
                }
            }
        public static void AllReportBetweenDate(DataGridView view , DateTimePicker from , DateTimePicker to)
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                { 
             
            SqlDataAdapter Tda = new SqlDataAdapter("SELECT *FROM All_Sales_Report WHERE  Date_Sold BETWEEN @datefrom AND  @dateto ORDER BY Report_Date,Item DESC" , con);
            Tda.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value =
                from.Value.ToString("MM/dd/yyyy");
            Tda.SelectCommand.Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value =
                to.Value.ToString("MM/dd/yyyy");
            DataTable dt = new DataTable();
            Tda.Fill(dt);
            Total = 0;
            view.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                int today = Convert.ToInt32(dr[3]);
                Total = Total + today;
                view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}" , dr[3]);
                view.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);
                view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyyy}" , dr[5]);
                }
                }
            catch (Exception ex)
                {
                    con.Close();
                throw new ExceptionHandling("Sales report failed to Load\nTry again" , ex);
                }
            }
        public static void DeleteReport(int reportid)
        {

            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
                cmd.Parameters["@id"].Value = reportid;
                cmd.CommandText = "DELETE  All_Sales_Report WHERE  Report_Id=@id";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("Delete Error", ex);
            }
        }
        public static void DeleteReport(DateTimePicker deletedate)
            {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.VarChar));
                cmd.Parameters["@date"].Value = deletedate.Value.ToString("MM/dd/yyyy");
                cmd.CommandText = "DELETE All_Sales_Report WHERE  Report_Date=@date";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("Delete Error", ex);
            }
            }
        }
    }
