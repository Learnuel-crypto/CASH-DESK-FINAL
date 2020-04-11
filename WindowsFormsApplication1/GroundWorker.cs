using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    class GroundWorker
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
        private string Search="Not Cleared";

        public GroundWorker()
        {
             
        }
         
        public   void OnAppStarted(object source, EventArgs args)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_clear_debtors_and_regularpayments" , con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                new Thread(() =>
                {
                     
                    var ground = new GroundworkerFulPay();
                    ground.start();
                }).Start();
                
                FirstTermDebtAsync();
                SecondTermDebtAsync();
                ThirdTermDebtAsync();
                done = true;
                
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new Exception(Ex.Message + "\nApplication Error Occurred");
            }
        }
         
        private  void FirstTermDebtAsync()
        { 
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Session_Id, Fee_Name,Amount,Status,PayDate, Fees.Class_Id, Fees.Student_Id " +
                "FROM FirstTerm  JOIN Fees ON Fees.Fee_Id =FirstTerm.Fee_Id AND FirstTerm.Status=@search AND Session_Id IS NOT " +
                 "NULL AND Fees.Student_Id IS NOT NULL ORDER BY PayDate DESC;", con);
            da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = Search;
            da.Fill(dt);
            da.Fill(ds);
            int x = ds.Tables.Count;
            if (x <= 0)
            {
                
                SecondTermDebtAsync();
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {

                    sessionid = Convert.ToInt32(dr["Session_Id"]);
                    FeeName = dr["Fee_Name"].ToString();
                    paidAmount = Convert.ToInt32(dr["Amount"]);
                    Status = dr["Status"].ToString();
                    date =  dr["PayDate"].ToString();
                    classid = Convert.ToInt32(dr["Class_Id"]);
                    studid = Convert.ToInt32(dr["Student_Id"]);
                    Term = "First";
                    setClassName(classid, studid); //GET THE CLASS NAME
                    setFeeAmount(sessionid); //GET THE FEE AMOUNT SET
                    studentName(studid); //GET THE STUDENT NAMES 
                    //con.Open();
                }
                 
            }

        }
        private void SecondTermDebtAsync()
        { 
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Session_Id, Fee_Name,Amount,Status,PayDate, Fees.Class_Id, Fees.Student_Id " +
             "FROM SecondTerm  JOIN Fees ON Fees.Fee_Id =SecondTerm.Fee_Id AND SecondTerm.Status=@search " +
             "AND Session_Id IS NOT NULL AND Fees.Student_Id IS NOT NULL ORDER BY PayDate DESC;", con);
            da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = Search;
            da.Fill(dt);
            da.Fill(ds);
            int x = ds.Tables.Count;
            if (x <= 0)
            {
                 
                ThirdTermDebtAsync();
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
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
                    setFeeAmount(sessionid); //GET THE FEE AMOUNT SET
                    studentName(studid); //GET THE STUDENT NAMES 
                     
                }
                
            }

        }
        private void ThirdTermDebtAsync()
        { 
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Session_Id, Fee_Name,Amount,Status,PayDate, Fees.Class_Id, Fees.Student_Id " +
                 "FROM ThirdTerm  JOIN Fees ON Fees.Fee_Id =ThirdTerm.Fee_Id AND ThirdTerm.Status=@search "+
                 " AND Session_Id IS NOT NULL AND Fees.Student_Id IS NOT NULL ORDER BY PayDate DESC;", con);
            da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = Search;
            da.Fill(dt);
            da.Fill(ds);
            int x = ds.Tables.Count;
            if (x <= 0)
            {
                 
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {

                    sessionid = Convert.ToInt32(dr["Session_Id"]);
                    FeeName = dr["Fee_Name"].ToString();
                    paidAmount = Convert.ToInt32(dr["Amount"]);
                    Status = dr["Status"].ToString();
                    date = dr["PayDate"].ToString();
                    classid = Convert.ToInt32(dr["Class_Id"]);
                    studid = Convert.ToInt32(dr["Student_Id"]);
                    Term = "Third";
                    setClassName(classid, studid); //GET THE CLASS NAME
                    setFeeAmount(sessionid); //GET THE FEE AMOUNT SET
                    studentName(studid); //GET THE STUDENT NAMES 
                     
                }
               
            }
        }
        private void setFeeAmount(int sesid)
        { 
            DataTable dtfee = new DataTable();
            SqlDataAdapter dafee = new SqlDataAdapter("SELECT Amount FROM SetFees WHERE Session_Id =@sesid AND " +
                                                      " Fee_Name =@feeName AND Section =@section",con);
            dafee.SelectCommand.Parameters.AddWithValue("@sesid" , SqlDbType.VarChar).Value = sesid;
            dafee.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = FeeName;
            dafee.SelectCommand.Parameters.AddWithValue("@section" , SqlDbType.VarChar).Value = section;
            dafee.Fill(dtfee);
            foreach (DataRow drfee in dtfee.Rows)
            {
                feeAmount = Convert.ToInt32(drfee["Amount"]);
            }

            while (feeAmount <= 0)
            {
                sesid -= 1;
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT Amount FROM SetFees WHERE Session_Id =@sesid AND " +
                                                        " Fee_Name =@feeName AND Section =@section ", con);
                da2.SelectCommand.Parameters.AddWithValue("@sesid" , SqlDbType.VarChar).Value = sesid;
                da2.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = FeeName;
                da2.SelectCommand.Parameters.AddWithValue("@section" , SqlDbType.VarChar).Value = section;
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    feeAmount = Convert.ToInt32(dr2["Amount"]);
                }
            }

            if (paidAmount == feeAmount)
            {
                Status = "Cleared";
                bal = 0;
            }
            else
            {
                Status = "Not Cleared";
                bal = feeAmount - paidAmount;
            } 
        }

        private void setClassName(int classid, int stud)
        {
            DataTable dtclas = new DataTable();
            SqlDataAdapter daclas = new SqlDataAdapter("SELECT ClassName FROM Class WHERE Class_Id =@classid "+
                                                       " AND  Student_Id =@stud ", con);
            daclas.SelectCommand.Parameters.AddWithValue("@classid", SqlDbType.VarChar).Value = classid;
            daclas.SelectCommand.Parameters.AddWithValue("@stud" , SqlDbType.VarChar).Value = stud;
            daclas.Fill(dtclas);
            foreach (DataRow drclass in dtclas.Rows)
            {
                Pclass = drclass["ClassName"].ToString();
            } 
            ClassName(Pclass);
        }

        public  string ClassName(string name)
        {
            //GET THE CLASS NAME ENTERED AND RETURN THE SECTION IT BELONGS
            if (string.IsNullOrEmpty(name))
            {

                throw new Exception("Class not found");
            }

            else
            { 
               var subName = name.Substring(0, 3).ToLower().TrimStart();
               if (subName.StartsWith("jss") || subName.StartsWith("js"))
                {
                    section = "Junior"; 
                }
               else if (subName.StartsWith("bas") || subName.StartsWith("bs"))
                {
                    section = "Basic"; 
                }

                else if (subName.StartsWith("ss") || subName.StartsWith("sss"))
                {
                    section = "Senior"; 
                }
               else if (subName.StartsWith("pri") || subName.StartsWith("pr"))
                {
                    section = "Primary"; 
                }
               else if (subName.StartsWith("nur") || subName.StartsWith("nu"))
                {
                    section = "Nursery"; 
                }
                else if (subName.StartsWith("pre") ||subName.StartsWith("prenu"))
                {
                    section = "Prenursery"; 
                }
               else if (subName.StartsWith("cre") || subName.StartsWith("che"))
                {
                    section = "Creche";
                }
               else if (subName.StartsWith("da") || subName.StartsWith("day") || subName.StartsWith("dayc"))
               {
                   section = "Daycare";
               }
               else if (subName.StartsWith("kin") || subName.StartsWith("kg") || subName.StartsWith("kindergarten") || subName.StartsWith("king"))
               {
                   section = "Kindergarten";
               }
               else
               {
                   throw new Exception("Class not found");
               }
        }
             
            return section;
        }

        private void studentName(int id)
        {
            //con.Open();
            DataTable dtName = new DataTable();
            SqlDataAdapter daName = new SqlDataAdapter("select Names.First_Name,Names.Last_Name,Names.Sex from Names where Name_Id IN " +
                " (select Name_Id from Students where Student_Id =@studid);", con);
            daName.SelectCommand.Parameters.AddWithValue("@studid" , SqlDbType.Int).Value = studid;
            daName.Fill(dtName);
            foreach (DataRow drRec in dtName.Rows)
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

        private void insertDebtRecord()
        {
            try
            {
                //modify the code
               con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Names" ,Names);
                cmd.Parameters.AddWithValue("@Sex" ,Sex);
                cmd.Parameters.AddWithValue("@Class" ,Pclass);
                cmd.Parameters.AddWithValue("@Fee_Name" ,FeeName);
                cmd.Parameters.AddWithValue("@Paid_Amount" ,paidAmount);
                cmd.Parameters.AddWithValue("@Balance" ,bal);
                cmd.Parameters.AddWithValue("@Term" ,Term);
                cmd.Parameters.AddWithValue("@Status" ,Status);
                cmd.Parameters.AddWithValue("@Date" ,date);
                cmd.CommandText= "INSERT INTO Debtors(Names,Sex,Class,Fee_Name,Paid_Amount,Balance, Term,Status,Date) VALUES(@Names,@Sex,@Class,@Fee_Name,@Paid_Amount,@Balance, @Term,@Status,@Date);INSERT INTO RegularPayment(Names,Sex,Class,Fee_Name,Paid_Amount,Balance, Term,Status,Date) VALUES( @Names,@Sex,@Class,@Fee_Name,@Paid_Amount,@Balance, @Term,@Status,@Date)";
                 
                cmd.ExecuteNonQuery();
                
                con.Close(); 
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Application Error Occurred",Ex);
            }
        }

        public  void DisplayDebtor(DataGridView view)
        {
            try
            {
                con.Open();
                SqlDataAdapter display = new SqlDataAdapter("sp_debtors_list", con);
                display.SelectCommand.CommandType = CommandType.StoredProcedure;
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
                throw new ExceptionHandling("A file is missing", ex);
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
                view.Text = " Please Wait...";
            }
        }

        public void DebtorsSearch(DataGridView view, DateTimePicker date1,DateTimePicker date2, TextBox search)
        {
            try{
            con.Open();
            
            //if (string.IsNullOrEmpty(search.Text))
            //{
            //    query = "select *from Debtors where Status='Not Cleared' and Date between '" + date1.Value + "'" +
            //            " and '" + date2.Value + "'";
            //}
            //else
            //{
            //    query = "select *from Debtors where Status='Not Cleared' and Date between '" + date1.Value + "'" +
            //            " and '" + date2.Value + "' and Class='" + search.Text + "' or Fee_Name ='" + search.Text + "' ";
            //}

            var searchText = string.IsNullOrEmpty(search.Text) ? " " : search.Text;
            SqlCommand cmdCommand = new SqlCommand("sp_debtors_list_search_withdate" , con);
            SqlDataAdapter display = new SqlDataAdapter(cmdCommand);
            display.SelectCommand.CommandType = CommandType.StoredProcedure;
            display.SelectCommand.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.VarChar));
            display.SelectCommand.Parameters.Add(new SqlParameter("@dateto" , SqlDbType.VarChar));
            display.SelectCommand.Parameters.Add(new SqlParameter("@search" , SqlDbType.VarChar));
            display.SelectCommand.Parameters["@datefrom"].Value = date1.Value;
            display.SelectCommand.Parameters["@dateto"].Value = date2.Value;
            display.SelectCommand.Parameters["@search"].Value = searchText;
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

        public void DebtorsDateSearch(DataGridView view, DateTimePicker date1, DateTimePicker date2)
        {
            try
            {
                con.Open();
                var query = "SELECT *FROM Debtors WHERE Status='Not Cleared' AND Date BETWEEN @datefrom AND  @dateto";

                SqlDataAdapter display = new SqlDataAdapter(query, con);
                display.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = date1.Value.ToString();
                display.SelectCommand.Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = date2.Value.ToString();

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
                throw new ExceptionHandling("There is error in the search", ex);
            }
        }

        public void DebtorsSearch(DataGridView view,  TextBox search)
        {
            try{
            con.Open();
            var searchText = string.IsNullOrEmpty((search.Text)) ?  " " : search.Text;
            SqlCommand query = new SqlCommand("sp_debtors_list_search", con);
            SqlDataAdapter display = new SqlDataAdapter(query);
            display.SelectCommand.CommandType = CommandType.StoredProcedure;
            display.SelectCommand.Parameters.Add((new SqlParameter("@search", SqlDbType.VarChar)));
            display.SelectCommand.Parameters["@search"].Value = searchText;
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
    }
}
