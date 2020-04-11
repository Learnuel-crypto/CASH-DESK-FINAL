using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DailyReports
    {
        public static string addedFeename = "";
        public static DateTime lastAddedDate;
        private static int Id;
        public static long Total = 0;
        public void DisplayReports(DataGridView reports)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            { 
                con.Open();
                DataTable dtReport = new DataTable();
                SqlDataAdapter daReport =
                    new SqlDataAdapter("SELECT * FROM DailyFeesPayReport ORDER BY ID DESC", con);
                daReport.Fill(dtReport);
                reports.Rows.Clear();
                Total = 0;
                foreach (DataRow dr in dtReport.Rows)
                {
                    int n = reports.Rows.Add();
                    reports.Rows[n].Cells[0].Value = dr[0].ToString();
                    reports.Rows[n].Cells[1].Value = dr[1].ToString();
                    reports.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", dr[2]);
                    var total = Convert.ToInt32(dr[2]);
                    Total = Total + total;
                    reports.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}", dr[3]);
                }

                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message + "\nOperation Not Successful", "Cash Desk", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public static void DeleteDailyReport(string id)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                SqlCommand cmdCommand = new SqlCommand("DELETE DailyFeesPayReport WHERE ID='" + id + "'", con);
                cmdCommand.ExecuteNonQuery();
                con.Close(); 
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message + "\nOperation Not Successful", "Cash Desk", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }
        public static void UpdateDailyReport(string id, TextBox fee, TextBox total, DateTimePicker date1)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                SqlCommand cmdCommand = new SqlCommand();
                cmdCommand.Connection = con;
                cmdCommand.Parameters.Clear();
                cmdCommand.CommandType = CommandType.Text;
                cmdCommand.Parameters.Add(new SqlParameter("@fee" , SqlDbType.VarChar));
                cmdCommand.Parameters.Add(new SqlParameter("@total" , SqlDbType.VarChar));
                cmdCommand.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmdCommand.Parameters["@fee"].Value = fee.Text;
                cmdCommand.Parameters["@total"].Value = total.Text;
                cmdCommand.Parameters["@date"].Value = date1.Value.ToString("MM/dd/yyyy");
                cmdCommand.CommandText = "UPDATE DailyFeesPayReport SET Fee_Name =@fee,Total=@total,Date=@date";
                cmdCommand.ExecuteNonQuery();
                con.Close(); 
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message + "\nOperation Not Successful", "Cash Desk", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }
        public static string InsertDailyReport(string Fname, long amount, string date)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                //check if there is actually any file in the db before insertion 
                if (string.IsNullOrEmpty(Fname))
                    {
                    throw new Exception("No record Found");
                    }
                con.Open();
                SqlCommand cmdCommand = new SqlCommand();// "INSERT INTO DailyFeesPayReport VALUES('" + Fname + "','" + amount + "','" + string.Format("{0:MM/dd/yyyy}", date )+ "')", con);
                cmdCommand.Connection = con;
                cmdCommand.Parameters.Clear();
                cmdCommand.CommandType = CommandType.Text;
                cmdCommand.Parameters.Add(new SqlParameter("@fname" , SqlDbType.VarChar));
                cmdCommand.Parameters.Add(new SqlParameter("@amount" , SqlDbType.VarChar));
                cmdCommand.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmdCommand.Parameters["@fname"].Value = Fname;
                cmdCommand.Parameters["@amount"].Value = amount;
                cmdCommand.Parameters["@date"].Value = string.Format("{0:MM/dd/yyyy}" , date);
                cmdCommand.CommandText = "INSERT INTO DailyFeesPayReport VALUES(@fname,@amount,@date)";
                cmdCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Fname + " Reported Successfully", "Cash Desk", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message + "\nOperation Not Successful", "Cash Desk", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return addedFeename = Fname;
        }

        private static void lastReport()
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dtToday = new DataTable();
            SqlDataAdapter daToday =
                new SqlDataAdapter("SELECT Max(ID)As Id FROM DailyFeesPayReport ", con);
            daToday.Fill(dtToday);
            foreach (DataRow drToday in dtToday.Rows)
            {
                Id = Int32.Parse(drToday["Id"].ToString());
            }
            con.Close();
        }

        public static void GetlastReport(string feename, string date)
        {
            try
            {
                SqlConnection con = new DBConnection().getConnection();
                if (string.IsNullOrEmpty(feename))
                    {
                    throw new Exception("Select a Feename");
                    }
                if (string.IsNullOrEmpty(feename))
                    {
                    throw new Exception("There is no such Fee for today");
                    }
              
                con.Open();
                DataTable dtToday = new DataTable();
                SqlDataAdapter daToday =
                    new SqlDataAdapter(
                        "SELECT Fee_Name,Date FROM DailyFeesPayReport WHERE Fee_Name=@feename AND Date=@date", con);
                daToday.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename;
                daToday.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = date;
                daToday.Fill(dtToday);
                int x = dtToday.Rows.Count;
                if (x > 0)
                {
                    con.Close();
                    throw new Exception(feename + " Has been already Reported");
                }
                
                con.Close();
            }
            catch (Exception Ex)
            { 
                throw new Exception(Ex.Message);
            }
        }
        public static void SearchDailyReport(DataGridView reports, DateTimePicker date1, DateTimePicker date2)
        { 
            SqlConnection con = new DBConnection().getConnection();
            try
            { 
                con.Open();
                DataTable dtReport = new DataTable();
                SqlDataAdapter daReport =
                    new SqlDataAdapter("SELECT * FROM DailyFeesPayReport WHERE Date BETWEEN @datefrom AND @dateto " +
                        " ORDER BY ID DESC", con);
                daReport.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                daReport.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value;
                daReport.Fill(dtReport);
                reports.Rows.Clear();
                Total = 0;
                foreach (DataRow dr in dtReport.Rows)
                {
                    int n = reports.Rows.Add();
                    reports.Rows[n].Cells[0].Value = dr[0].ToString();
                    reports.Rows[n].Cells[1].Value = dr[1].ToString();
                    reports.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", dr[2]);
                    var total = Convert.ToInt32(dr[2]);
                    Total = Total + total;
                    reports.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}", dr[3]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void SearchDailyReport(DataGridView reports, TextBox search)
        {
            //CODE LATER
            SqlConnection con = new DBConnection().getConnection();
            try
            { 
                con.Open();
                DataTable dtReport = new DataTable();
                SqlDataAdapter daReport =
                    new SqlDataAdapter("SELECT * FROM DailyFeesPayReport WHERE Fee_Name LIKE'%' + @search + '%' OR Total LIKE'%' + @search + '%' " +
                        " OR Date LIKE'%' + @search + '%'ORDER BY ID DESC", con);
                daReport.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
             
                daReport.Fill(dtReport);
                reports.Rows.Clear();
                Total = 0;
                foreach (DataRow dr in dtReport.Rows)
                {
                    int n = reports.Rows.Add();
                    reports.Rows[n].Cells[0].Value = dr[0].ToString();
                    reports.Rows[n].Cells[1].Value = dr[1].ToString();
                    reports.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", dr[2]);
                    var total = Convert.ToInt32(dr[2]);
                    Total = Total + total;
                    reports.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}", dr[3]);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void SearchDailyReport(DataGridView reports, DateTimePicker date1, DateTimePicker date2, TextBox search)
        {
            //CODE LATER
            SqlConnection con = new DBConnection().getConnection();
            try
            {

                con.Open();
                DataTable dtReport = new DataTable();
                SqlDataAdapter daReport =
                    new SqlDataAdapter("SELECT * FROM DailyFeesPayReport WHERE Date BETWEEN @datefrom AND @dateto " +
                        "AND Fee_Name =@search ORDER BY ID DESC", con);
                daReport.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                daReport.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value;
                daReport.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
                daReport.Fill(dtReport);
                reports.Rows.Clear();
                Total = 0;
                foreach (DataRow dr in dtReport.Rows)
                {
                    int n = reports.Rows.Add();
                    reports.Rows[n].Cells[0].Value = dr[0].ToString();
                    reports.Rows[n].Cells[1].Value = dr[1].ToString();
                    reports.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", dr[2]);
                    var total = Convert.ToInt32(dr[2]);
                    Total = Total + total;
                    reports.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}", dr[3]);
                }

                con.Close();
            }
            catch (Exception)
            {
                con.Close();

            }
        }
        public static void SearchDailyReport(DataGridView reports, DateTimePicker date1)
        {
            //CODE LATER
            SqlConnection con = new DBConnection().getConnection();
            try
            { 
                con.Open();
                DataTable dtReport = new DataTable();
                SqlDataAdapter daReport =
                    new SqlDataAdapter("SELECT * FROM DailyFeesPayReport WHERE Date LIKE @dateyear + '____%' ORDER BY ID DESC", con);
                daReport.SelectCommand.Parameters.AddWithValue("@dateyear" , SqlDbType.VarChar).Value = date1.Value;
                daReport.Fill(dtReport);
                reports.Rows.Clear();
                Total = 0;
                foreach (DataRow dr in dtReport.Rows)
                {
                    int n = reports.Rows.Add();
                    reports.Rows[n].Cells[0].Value = dr[0].ToString();
                    reports.Rows[n].Cells[1].Value = dr[1].ToString();
                    reports.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", dr[2]);
                    var total = Convert.ToInt32(dr[2]);
                    Total = Total + total;
                    reports.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}", dr[3]);
                }

                con.Close();
            }
            catch (Exception)
            {
                con.Close();

            }
        }
    }
}