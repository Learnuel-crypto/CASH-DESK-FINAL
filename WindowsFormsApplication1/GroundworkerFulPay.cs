using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class GroundworkerFulPay
    {
        private SqlConnection con = new DBConnection().getConnection();
        private string Names;
        private string FeeName;
        private string Status;
        private string Pclass;
        private long paidAmount = 0;
        private long feeAmount = 0;
        private int studid = 0;
        private int feeid = 0;
        private int sessionid = 0;
        private int classid = 0;
        private long bal = 0;
        private string date;
        private string Term;
        private string section;
        private string Sex;
        private bool done = false;
        private string Search = "Cleared";

        GroundWorker groundWorker = new GroundWorker();
        public GroundworkerFulPay()
        {

        }

        public void OnAppStarted(object source, EventArgs args)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE FullPayment", con);
            cmd.ExecuteNonQuery();
            con.Close();
            FirstTermDebtAsync();
            SecondTermDebtAsync();
            ThirdTermDebtAsync();
            done = true;
        }

        public void start()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE FullPayment", con);
            cmd.ExecuteNonQuery();
            con.Close();
            FirstTermDebtAsync();
            SecondTermDebtAsync();
            ThirdTermDebtAsync();
            done = true;
        }
        private void FirstTermDebtAsync()
        {
            try
            {
                con.Open();
                DataTable dtfirst = new DataTable();
                DataSet dsfirst = new DataSet();
                SqlDataAdapter dafirst = new SqlDataAdapter(
                    "SELECT Session_Id, Fee_Name,Amount,Status,PayDate, Fees.Class_Id, Fees.Student_Id " +
                    "FROM FirstTerm  JOIN Fees ON Fees.Fee_Id =FirstTerm.Fee_Id and FirstTerm.Status=@search AND Session_Id IS NOT " +
                    "NULL ORDER BY PayDate DESC;", con);
                dafirst.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = Search;
                dafirst.Fill(dtfirst);
                dafirst.Fill(dsfirst);
                int y = dsfirst.Tables.Count;
                if (y <= 0)
                {
                    con.Close();
                    SecondTermDebtAsync();
                }
                else
                {
                    foreach (DataRow dr in dtfirst.Rows)
                    {

                        sessionid = Convert.ToInt32(dr["Session_Id"]);
                        FeeName = dr["Fee_Name"].ToString();
                        paidAmount = Convert.ToInt32(dr["Amount"]);
                        Status = dr["Status"].ToString();
                        date = dr["PayDate"].ToString();//UNBOXE THIS CODE
                        classid = Convert.ToInt32(dr["Class_Id"]);
                        studid = Convert.ToInt32(dr["Student_Id"]);
                        Term = "First";
                        setClassName(classid, studid); //GET THE CLASS NAME 
                        studentName(studid); //GET THE STUDENT NAMES 
                        con.Open();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("Unknown error", ex);
            }
        }
            
        

        private void SecondTermDebtAsync()
        {
           try{
            con.Open();
            DataTable dtSec = new DataTable();
            DataSet dsSec = new DataSet();
            SqlDataAdapter daSec = new SqlDataAdapter(
                "select Session_Id, Fee_Name,Amount,Status,PayDate, Fees.Class_Id, Fees.Student_Id " +
            "from SecondTerm  join Fees on Fees.Fee_Id =SecondTerm.Fee_Id and SecondTerm.Status=@search  " +
                "and Session_Id IS NOT NULL order by PayDate DESC;", con);
            daSec.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = Search; 
            daSec.Fill(dsSec);
            int y = dsSec.Tables.Count;
            if (y <= 0)
            {
                con.Close();
                ThirdTermDebtAsync();
            }
            else
            {
                foreach (DataRow dr in dtSec.Rows)
                {

                    sessionid = Convert.ToInt32(dr["Session_Id"]);
                    FeeName = dr["Fee_Name"].ToString();
                    paidAmount = Convert.ToInt32(dr["Amount"]);
                    Status = dr["Status"].ToString();
                    date = dr["PayDate"].ToString();
                    classid = Convert.ToInt32(dr["Class_Id"]);
                    studid = Convert.ToInt32(dr["Student_Id"]);
                    Term = "Second";
                    setClassName(classid, studid); //GET THE CLASS NAME 
                    studentName(studid); //GET THE STUDENT NAMES 
                    con.Open();
                }
                con.Close();
            }
           }
           catch (Exception ex)
           {
               con.Close();
               throw new ExceptionHandling("Unknown error", ex);
           }
        }

        private void ThirdTermDebtAsync()
        {
            
            try{
                con.Open();
            DataTable dtT = new DataTable();
            DataSet dsT = new DataSet();
            SqlDataAdapter daT = new SqlDataAdapter(
                "SELECT Session_Id, Fee_Name,Amount,Status,PayDate, Fees.Class_Id, Fees.Student_Id " +
                "FROM ThirdTerm  JOIN Fees ON Fees.Fee_Id =ThirdTerm.Fee_Id AND ThirdTerm.Status=@search" +
                " AND Session_Id IS NOT NULL ORDER BY PayDate DESC;", con);
            daT.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = Search;
            daT.Fill(dtT);
            daT.Fill(dsT);
            int y = dsT.Tables.Count;
            if (y <= 0)
            {
                con.Close();
            }
            else
            {
                foreach (DataRow dr in dtT.Rows)
                {

                    sessionid = Convert.ToInt32(dr["Session_Id"]);
                    FeeName = dr["Fee_Name"].ToString();
                    paidAmount = Convert.ToInt32(dr["Amount"]);
                    Status = dr["Status"].ToString();
                    date =  dr["PayDate"].ToString();
                    classid = Convert.ToInt32(dr["Class_Id"]);
                    studid = Convert.ToInt32(dr["Student_Id"]);
                    Term = "Third";
                    bal = 0;
                    setClassName(classid, studid); //GET THE CLASS NAME 
                    studentName(studid); //GET THE STUDENT NAMES 
                    con.Open();
                }
                con.Close();
            }
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("Unknown error", ex);
            }
        }

        private void setClassName(int classid, int stud)
        {
            try{
            DataTable dtclas = new DataTable();
            SqlDataAdapter daclas = new SqlDataAdapter("SELECT ClassName FROM Class WHERE Class_Id =@classid AND  Student_Id =@stud ", con);
            daclas.SelectCommand.Parameters.AddWithValue("@classid" , SqlDbType.VarChar).Value = classid;
            daclas.SelectCommand.Parameters.AddWithValue("@stud" , SqlDbType.VarChar).Value = stud;
            daclas.Fill(dtclas);
            foreach (DataRow drclass in dtclas.Rows)
            {
                Pclass = drclass["ClassName"].ToString();
            }
            con.Close();
            
         section= groundWorker.ClassName(Pclass);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Unknown error", "Cashdesk");
            }
           
        }
 
        private void studentName(int id)
        {
            try{
            con.Open();
            DataTable dtNameS = new DataTable();
            SqlDataAdapter daNameS = new SqlDataAdapter(
                "select Names.First_Name,Names.Last_Name,Names.Sex from Names where Name_Id IN " +
                " (select Name_Id from Students where Student_Id =@studid);", con);
            daNameS.SelectCommand.Parameters.AddWithValue("@studid" , SqlDbType.VarChar).Value = studid;
            daNameS.Fill(dtNameS);
            foreach (DataRow drRec in dtNameS.Rows)
            {
                var firstname = drRec["First_Name"].ToString();
                var lastname = drRec["last_Name"].ToString();
                var sex = drRec["Sex"].ToString();
                Names = firstname + " " + lastname;
                Sex = sex;
            }

            con.Close();
            insertDebtRecord(); //INSERT THE RECORDS
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error", "Cashdesk");
            }
        }

        private void insertDebtRecord()
        {
            try
            {
                con.Open();
               SqlCommand cmdFulPay = new SqlCommand(); 
                 
                cmdFulPay.Connection = con;
                cmdFulPay.Parameters.Clear();
                cmdFulPay.CommandType = CommandType.Text;
                cmdFulPay.Parameters.AddWithValue("@Names" , Names);
                cmdFulPay.Parameters.AddWithValue("@Sex" , Sex);
                cmdFulPay.Parameters.AddWithValue("@Class" , Pclass);
                cmdFulPay.Parameters.AddWithValue("@Fee_Name" , FeeName);
                cmdFulPay.Parameters.AddWithValue("@Paid_Amount" , paidAmount);
                cmdFulPay.Parameters.AddWithValue("@Balance" , bal);
                cmdFulPay.Parameters.AddWithValue("@Term" , Term);
                cmdFulPay.Parameters.AddWithValue("@Status" , Status);
                cmdFulPay.Parameters.AddWithValue("@Date" , date);
                cmdFulPay.CommandText = "INSERT INTO FullPayment VALUES(@Names,@Sex,@Class,@Fee_Name," +
                 "@Paid_Amount,@Balance,@Term,@Status, @Date);INSERT INTO RegularPayment VALUES(@Names,@Sex,@Class,@Fee_Name," +
                 "@Paid_Amount,@Balance,@Term,@Status, @Date)";
                cmdFulPay.ExecuteNonQuery(); 
                con.Close();
                 
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Application Error Occurred",Ex );
            }
        }

        public void DisplayPayments(DataGridView view)
        {
            try
            {
                con.Open();
                SqlCommand query = new SqlCommand("SELECT *FROM FullPayment", con);
                SqlDataAdapter display = new SqlDataAdapter(query);
                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}", dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dat[9]);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the search", ex);
            }
        }

        public void inProcess(Label view)
        {
            if (!done)
            {
                view.Text = "Done..";
                view.Visible = false;

            }
            else
            {
                view.Visible = true;
                view.Text = "Please Wait...";
            }
        }
         
        public void PaymentSearch(DataGridView view, TextBox search)
        {
            try{
            con.Open();
            string query = "SELECT *FROM FullPayment WHERE Fee_Name LIKE'%' + @search + '%'" +
                                              "OR Term LIKE'%' + @search + '%' OR Names LIKE'%' + @search +'%'" +
                                              "OR Class =@search";
           
            SqlDataAdapter display = new SqlDataAdapter(query,con);
            display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
            DataTable data = new DataTable();
            display.Fill(data);
            view.Rows.Clear();
            foreach (DataRow dat in data.Rows)
            {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dat[1].ToString();
                view.Rows[n].Cells[1].Value = dat[2].ToString();
                view.Rows[n].Cells[2].Value = dat[3].ToString();
                view.Rows[n].Cells[3].Value = dat[4].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}", dat[5]);
                view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dat[6]);
                view.Rows[n].Cells[6].Value = dat[7].ToString();
                view.Rows[n].Cells[7].Value = dat[8].ToString();
                view.Rows[n].Cells[8].Value =string.Format("{0:MM/dd/yyyy}", dat[9]);

            }
            con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("There was error in the search", ex);
            }
        }

        public void PaymentSearchMore(DataGridView view, DateTimePicker date1, DateTimePicker date2, TextBox search)
        {
            try
            {
                con.Open();
                if (string.IsNullOrEmpty(search.Text))
                {
                    var query = "SELECT *FROM FullPayment WHERE Status='Cleared' AND Date BETWEEN @datefrom AND @dateto";

                    SqlDataAdapter display = new SqlDataAdapter(query, con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value;
                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}", dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dat[9]);

                    }

                    con.Close();
                }
                else
                {
                    var query = "SELECT *FROM FullPayment WHERE Status='Cleared' AND Date BETWEEN @datefrom AND @dateto AND Class=@search OR Fee_Name =@search";

                    SqlDataAdapter display = new SqlDataAdapter(query, con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value;
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value;
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
                  
                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}", dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dat[9]);

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("Search error",ex);
            }
        }
        
    }
}