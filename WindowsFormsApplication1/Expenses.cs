using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class Expenses
        {
            public static long Total = 0;
            public static long Income = 0;
            public static long Expense = 0;
            public static long Bal = 0;

            public Expenses()
            {

            }

            public void Display(DataGridView grid)
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense WHERE Date = @sdate", con);
            da.SelectCommand.Parameters.AddWithValue("@sdate" , SqlDbType.VarChar).Value = dataAccess.Sdate;
                da.Fill(dts);
                grid.Rows.Clear();
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = grid.Rows.Add();
                    grid.Rows[n].Cells[0].Value = drRec[0].ToString();
                    grid.Rows[n].Cells[1].Value = drRec[1].ToString();
                    grid.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[2]);
                    Total = Total + amount;
                    grid.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}",drRec[3]);
                }

                con.Close(); 
            }
            public void todaySearch(DataGridView grid,TextBox text)
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense WHERE Description LIKE'%' +@search + '%' OR Amount LIKE'%' + @search + '%'" +
                                                       "AND  Date = @sdate", con);
            da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = text.Text;
            da.SelectCommand.Parameters.AddWithValue("@sdate" , SqlDbType.VarChar).Value = dataAccess.Sdate;
            da.Fill(dts);
                grid.Rows.Clear();
                foreach (DataRow drRec in dts.Rows)
                { 
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = grid.Rows.Add();
                    grid.Rows[n].Cells[0].Value = drRec[0].ToString();
                    grid.Rows[n].Cells[1].Value = drRec[1].ToString();
                    grid.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[2]);
                    Total = Total + amount;
                    grid.Rows[n].Cells[3].Value =string.Format("{0:MM/dd/yyyy}", drRec[3]);
                }

                con.Close();
            }
            public void DisplayAll(DataGridView grid)
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense ORDER BY ID desc", con);
                da.Fill(dts);
                grid.Rows.Clear();
                foreach (DataRow drRec in dts.Rows)
                {

                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = grid.Rows.Add();
                    grid.Rows[n].Cells[0].Value = drRec[0].ToString();
                    grid.Rows[n].Cells[1].Value = drRec[1].ToString();
                    grid.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[2]);
                    Total = Total + amount;
                    grid.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}",drRec[3]);
                }

                con.Close();
            }
            public void seachAll(DataGridView grid,TextBox text)
            {
                Total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense WHERE Description LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%'" +
                                                       "OR Date like'%' + @search + '%' ", con);
            da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = text.Text;
            da.Fill(dts);
                grid.Rows.Clear();
                foreach (DataRow drRec in dts.Rows)
                {

                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = grid.Rows.Add();
                    grid.Rows[n].Cells[0].Value = drRec[0].ToString();
                    grid.Rows[n].Cells[1].Value = drRec[1].ToString();
                    grid.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[2]);
                    Total = Total + amount;
                    grid.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}",drRec[3]);
                }

                con.Close();
            }
            public void getExpense( )
            {
                Expense = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Amount FROM Expense WHERE Date = @sdate", con);
            da.SelectCommand.Parameters.AddWithValue("@sdate" , SqlDbType.VarChar).Value = dataAccess.Sdate;
            da.Fill(dts);
                 
                foreach (DataRow drRec in dts.Rows)
                {
                    // GET THE TOTAL INCOME
                long amount = Convert.ToInt64(drRec["Amount"]);
                    Expense = Expense + amount;
                   
                     
                }
                con.Close();
                getIncome();

            }
            public void getIncome()
            {
                Income = 0;
                Bal = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  Amount FROM Cash WHERE Pay_Date =@sdate", con);
            da.SelectCommand.Parameters.AddWithValue("@sdate" , SqlDbType.VarChar).Value = dataAccess.Sdate;
            da.Fill(dts); 
                foreach (DataRow drRec in dts.Rows)
                {
                    // GET THE TOTAL EXPENSES
                    long amount = Convert.ToInt64(drRec["Amount"]);
                    Income = Income + amount;
                } 
                con.Close();
                Bal =Income - Expense;
            }
            public void Display(DataGridView grid, DateTime date)
            {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT  *FROM Expense WHERE Date =@sdate", con);
            da.SelectCommand.Parameters.AddWithValue("@sdate" , SqlDbType.VarChar).Value = date.Date;
            da.Fill(dts);
                grid.Rows.Clear();
                foreach (DataRow drRec in dts.Rows)
                {
                    Total = 0;
                    //DISPLAY THE RECORDS IN THE GRID VIEW C 
                    int n = grid.Rows.Add();
                    grid.Rows[n].Cells[0].Value = drRec[0].ToString();
                    grid.Rows[n].Cells[1].Value = drRec[1].ToString();
                    grid.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", drRec[2]);
                    long amount = Convert.ToInt64(drRec[2]);
                    Total = Total + amount;
                    grid.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}",drRec[3]);

                }
            }
             
            public void insert(TextBox Des, TextBox Cost, DateTimePicker pick)
            {
                try
                {
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    //INSERT EXPENSE VALUES  

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Description", Des.Text);
                    cmd.Parameters.AddWithValue("@Amount", Cost.Text);
                    cmd.Parameters.AddWithValue("@Date", pick.Value);
                    cmd.CommandText = "INSERT INTO Expense VALUES(@Description, @Amount,@Date)";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                throw new ExceptionHandling("Record was not saved" , ex);
                    
                }
            }
            public void delete(Label id)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                //DELETE RECORD 
                SqlCommand cmd = new SqlCommand("DELETE  Expense WHERE ID='" + id.Text + "'" , con);
                cmd.ExecuteNonQuery();
                con.Close();
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Record could not be deleted" , ex);
                }
            }
            public void Update(Label Id, TextBox Des, TextBox Cost, DateTimePicker pick)
            {
                try
                {
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    // UPDATE THE RECORD ENTERED BEFORE
                    SqlCommand cmd =
                        new SqlCommand();
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@amount" , SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@id" , SqlDbType.VarChar));
                cmd.Parameters["@description"].Value = Des.Text;
                    cmd.Parameters["@amount"].Value = Cost.Text;
                    cmd.Parameters["@date"].Value = pick.Value;
                    cmd.Parameters["@id"].Value = Id.Text;
                    cmd.CommandText = "UPDATE Expense set Description =@description, Amount =@amount, Date =@date where ID= @id";
                cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                throw new ExceptionHandling("Record could not be updated" , ex);
                }
            }
            
        }
    }
