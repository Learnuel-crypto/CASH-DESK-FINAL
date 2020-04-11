using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class Reports
    {
        public static long Total = 0;
            public Reports()
            {

            }

            public   void dailyReportInsert(TextBox income, TextBox expense, TextBox balance, string cash)
            {
                try
                {
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    //INSERT EXPENSE VALUES  

                    SqlCommand cmd = new SqlCommand("INSERT INTO DailyReport VALUES(@income, @expense,@bal,@cash,@date)", con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@income" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@expense" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@bal" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@cash" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmd.Parameters["@income"].Value = income.Text;
                cmd.Parameters["@expense"].Value = expense.Text;
                cmd.Parameters["@bal"].Value = balance.Text;
                cmd.Parameters["@cash"].Value = cash;
                cmd.Parameters["@date"].Value = dataAccess.Sdate;
                cmd.ExecuteNonQuery();
                    con.Close();
                    dataAccess.Description = "Recorded Income Report";
                    dataAccess.Activities();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nCould not Save", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        public void ReportInsert(TextBox income, TextBox expense, TextBox cash,DateTimePicker date)
        {
            try
            {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                //INSERT EXPENSE VALUES  
                long inc = Convert.ToInt32(income.Text);
                long exp = Convert.ToInt32(expense.Text);
                long balance = inc - exp;
                SqlCommand cmd = new SqlCommand("INSERT INOT DailyReport VALUES(@income, @expense,@bal,@cash,@date)", con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@income" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@expense" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@bal" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@cash" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmd.Parameters["@income"].Value = income.Text;
                cmd.Parameters["@expense"].Value = expense.Text;
                cmd.Parameters["@bal"].Value = balance;
                cmd.Parameters["@cash"].Value = cash.Text;
                cmd.Parameters["@date"].Value = date.Value;
                cmd.ExecuteNonQuery();
                con.Close();
                dataAccess.Description = "Recorded Income Report";
                dataAccess.Activities();
            }
            catch (Exception Ex)
            {
                throw new Exception ( "Error At ReportInsert Class Level ",Ex);
            }
        }
            public void dailyReportUpdate(Label id, TextBox income, TextBox expense,TextBox cash,DateTimePicker pick)
            {
                try
                { 
                    long inc = Convert.ToInt32(income.Text);
                    long exp = Convert.ToInt32(expense.Text);
                   long bal = inc - exp;
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    //UPDATE REPORT 
                    SqlCommand cmd = new SqlCommand("UPDATE DailyReport SET Total_Income=@income,Total_Expense=@expense" +
                       " Balance=@bal, Cash_Type=@cash ,Date=@date WHERE Report_Id= @id", con);

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@income" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@expense" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@bal" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@cash" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@id" , SqlDbType.VarChar));
                cmd.Parameters["@income"].Value = income.Text;
                cmd.Parameters["@expense"].Value = expense.Text;
                cmd.Parameters["@bal"].Value = bal;
                cmd.Parameters["@cash"].Value = cash.Text;
                cmd.Parameters["@date"].Value = pick.Value;
                cmd.Parameters["@id"].Value =id.Text;
                cmd.ExecuteNonQuery();
                    con.Close();
                    dataAccess.Description = "Updated Income Report";
                    dataAccess.Activities();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nCould not Update", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            public static void displayReport(DataGridView view)
            {
            try
            {
                Total = 0;//clear the initial Total amount
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT  *FROM DailyReport ORDER BY Report_Id DESC", con);
                da.Fill(dts);
                view.Rows.Clear();
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drRec[0].ToString();
                    view.Rows[n].Cells[1].Value = string.Format("{0:00}", drRec[1]);
                    view.Rows[n].Cells[2].Value = string.Format("{0:00}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[3]);
                    Total = Total + amount;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00}", drRec[3]);
                    view.Rows[n].Cells[4].Value = drRec[4].ToString();
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyy}", drRec[5]);
                }
            }
            catch(Exception Ex)
            {

            }
            }
        public static void ReportSearch(DataGridView view,TextBox seach)
        {
            try
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT  *FROM DailyReport WHERE Total_Income LIKE'% + @search + '%' or Total_Expense like'%" + seach.Text + "%'" +
                                       "OR Balance like'%'+ @search + '%'OR Cash_Type like'%' + search + '%' " +
                                       "OR Date like'%' + search + '%'", con);
                da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = seach.Text;
                da.Fill(dts);
                view.Rows.Clear(); 
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drRec[0].ToString();
                    view.Rows[n].Cells[1].Value =string.Format("{0:00}", drRec[1]);
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[3]);
                    Total = Total + amount;
                    view.Rows[n].Cells[3].Value =string.Format("{0:00}", drRec[3]);
                    view.Rows[n].Cells[4].Value =   drRec[4];
                    view.Rows[n].Cells[5].Value =string.Format("{0:MM/dd/yyy}", drRec[5]);

                }
            }
            catch (Exception Ex)
            {

            }
        }
        public static void ReportSearch(DataGridView view, DateTimePicker date1,DateTimePicker date2)
        {
            try
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT  *FROM DailyReport WHERE Date BETWEEN @datefrom AND  @dateto", con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value;
                da.Fill(dts);
                view.Rows.Clear(); 
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drRec[0].ToString();
                    view.Rows[n].Cells[1].Value = string.Format("{0:00}", drRec[1]);
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[3]);
                    Total = Total + amount;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00}", drRec[3]);
                    view.Rows[n].Cells[4].Value = drRec[4];
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyy}", drRec[5]);

                }
            }
            catch (Exception Ex)
            {

            }
        }
        public static void ReportSearch(DataGridView view, DateTimePicker date1, DateTimePicker date2,TextBox search)
        {
            try
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT  *FROM DailyReport WHERE Date BETWEEN @datefrom AND  @dateto "+
                        "AND Total_Income like'%'+ @search +'%'", con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value;
                da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
                da.Fill(dts);
                view.Rows.Clear(); 
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drRec[0].ToString();
                    view.Rows[n].Cells[1].Value = string.Format("{0:00}", drRec[1]);
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[3]);
                    Total = Total + amount;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00}", drRec[3]);
                    view.Rows[n].Cells[4].Value = drRec[4];
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyy}", drRec[5]);

                }
            }
            catch (Exception Ex)
            {

            }
        }
        public static void ReportSearch(DataGridView view, DateTimePicker date1)
        {
            try
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT  *FROM DailyReport WHERE Date LIKE'%' + @datefrom + '____%'", con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                da.Fill(dts);
                view.Rows.Clear(); 
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drRec[0].ToString();
                    view.Rows[n].Cells[1].Value = string.Format("{0:00}", drRec[1]);
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[3]);
                    Total = Total + amount;
                    view.Rows[n].Cells[3].Value = string.Format("{0:00}", drRec[3]);
                    view.Rows[n].Cells[4].Value = drRec[4];
                    view.Rows[n].Cells[5].Value = string.Format("{0:MM/dd/yyy}", drRec[5]);

                }
            }
            catch (Exception Ex)
            {

            }
        }
        public void deleteReport(Label id)
        { 
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE DailyReport WHERE Report_Id='" + id.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataAccess.Description = "Deleted Income Report";
                dataAccess.Activities(); 
        }
        }
        }
