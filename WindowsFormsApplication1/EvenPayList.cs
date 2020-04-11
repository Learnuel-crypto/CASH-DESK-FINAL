using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class EvenPayList
    {
        private string Names;
        private string Pclass;
        private string Sex;
        private string FeeName;
        private string Term;
        private long Amount = 0;
        private long bal = 0;
        private string Status;
        private DateTime date;
        private int StudentId = 0;
        private int EventId = 0;
        private bool done = false;
        private long FeeAmount = 0;
        private string mySearch;

       SqlConnection con = new DBConnection().getConnection();
            public void OnAppStarted(object source, EventArgs args)
            {
                try
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE EventList" , con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetEventPayments();
                    done = true;
                }
                catch (Exception Ex)
                {
                    con.Close();
                    MessageBox.Show(Ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private  void GetEventPayments()
            {
                con.Open();
                SqlCommand query = new SqlCommand("sp_get_event_payments" , con);
                SqlDataAdapter display = new SqlDataAdapter(query);
                display.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable data = new DataTable();
                display.Fill(data);
                foreach (DataRow dat in data.Rows)
                {
                     
                    FeeName = dat[0].ToString();
                    Term = dat[1].ToString();
                    Pclass = dat[2].ToString();
                    Amount= Convert.ToInt32( dat[3]);
                    Status = dat[4].ToString();
                    date =(DateTime) dat[5];
                    StudentId =Convert.ToInt32( dat[6]);
                    EventId=Convert.ToInt32( dat[7]);
                     EventFeeAmount(EventId);
                    studentName(StudentId);
                    con.Open();
                }
            }
         

        private void EventFeeAmount(int evenid)
        {
            DataTable dtfee = new DataTable();
            SqlDataAdapter dafee = new SqlDataAdapter("SELECT Amount FROM Events WHERE Event_Id =@eventid AND " +
                                                      " Fee_Name =@feename", con);
            dafee.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = FeeName;
            dafee.SelectCommand.Parameters.AddWithValue("@eventid",SqlDbType.VarChar).Value= evenid;
            dafee.Fill(dtfee);
            foreach (DataRow drfee in dtfee.Rows)
            {
                FeeAmount = Convert.ToInt32(drfee["Amount"]);
            }

            bal = FeeAmount - Amount;
        }
        private void studentName(int studid)
        {
            DataTable dtName = new DataTable();
            SqlDataAdapter daName = new SqlDataAdapter("sp_event_student_name", con);
            daName.SelectCommand.CommandType = CommandType.StoredProcedure;
            daName.SelectCommand.Parameters.Add(new SqlParameter("@studentid", SqlDbType.Int));
            daName.SelectCommand.Parameters["@studentid"].Value = studid;
            daName.Fill(dtName);
            foreach (DataRow drRec in dtName.Rows)
            {
                var firstname = drRec["First_Name"].ToString();
                var lastname = drRec["last_Name"].ToString();
                var sex = drRec["Sex"].ToString();
                Names = firstname + " " + lastname;
                Sex = sex;
            }
            insertEventList(); //INSERT THE RECORDS
        }
        /// <summary>
        /// prepare the event payment list
        /// </summary>
        private void insertEventList()
        {
            try
            { 
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Names" , Names);
                cmd.Parameters.AddWithValue("@Sex" , Sex);
                cmd.Parameters.AddWithValue("@Class" , Pclass);
                cmd.Parameters.AddWithValue("@Fee_Name" , FeeName);
                cmd.Parameters.AddWithValue("@Paid_Amount" , Amount);
                cmd.Parameters.AddWithValue("@Balance" , bal);
                cmd.Parameters.AddWithValue("@Term" , Term);
                cmd.Parameters.AddWithValue("@Status" , Status);
                cmd.Parameters.AddWithValue("@Date" , date);
                cmd.CommandText= "INSERT INTO EventList(Names,Sex, Class,Fee_Name,Paid_Amount,Balance,Term,Status,Date) VALUES(@Names,@Sex, @Class,@Fee_Name,@Paid_Amount,@Balance,@Term,@Status,@Date)";
                cmd.ExecuteNonQuery();
                con.Close(); 
            }
            catch (Exception Ex)
            {
                con.Close();
               throw new ExceptionHandling ("Event List insertion error",Ex);
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

        public void DisplayEventList(DataGridView view)
        { 
            SqlCommand query = new SqlCommand("sp_event_list_all" , con);
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

        }
        public void NotClearedEventList(DataGridView view)
        { 
            SqlCommand query = new SqlCommand("SELECT *FROM view_uncleared_event_pay" , con);
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
                view.Rows[n].Cells[8].Value =string.Format("{0:MM/dd/yyyy}", dat[9]);

            }

        }
        public void NotClearedEventList(DataGridView view,TextBox text)
        { 
             
        var query =
            "SELECT * FROM view_uncleared_event_pay WHERE Status ='Not Cleared' AND Term =@search OR Fee_Name LIKE '%'+ @search +'%' OR" +
            " Names LIKE '%' + @search + '%' OR Class LIKE '%' + @search + '%'";
        SqlDataAdapter display = new SqlDataAdapter(query,con); 
            display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = text.Text;
             
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

        }

        public void NotClearedEventList(DataGridView view , DateTimePicker date1 , DateTimePicker date2 , TextBox text)
            {
                try
                {
                    mySearch = text.Text;
                    SqlDataAdapter display = new SqlDataAdapter("sp_uncleared_events", con);
                    display.SelectCommand.CommandType = CommandType.StoredProcedure;
                    display.SelectCommand.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.Date));
                    display.SelectCommand.Parameters.Add(new SqlParameter("@dateto", SqlDbType.Date));
                    display.SelectCommand.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                    display.SelectCommand.Parameters["@datefrom"].Value = date1.Value.Date;
                    display.SelectCommand.Parameters["@dateto"].Value = date2.Value.Date;
                    display.SelectCommand.Parameters["@search"].Value = mySearch;
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
                }
                catch (Exception)
                {
                    con.Close();
                    MessageBox.Show("there was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }
        public void NotClearedEventList(DataGridView view , DateTimePicker date1 , DateTimePicker date2 )
            {
                try
                {
                    SqlDataAdapter display = new SqlDataAdapter("sp_uncleared_events_date_search", con);
                    display.SelectCommand.CommandType = CommandType.StoredProcedure;
                    display.SelectCommand.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.Date));
                    display.SelectCommand.Parameters.Add(new SqlParameter("@dateto", SqlDbType.Date));

                    display.SelectCommand.Parameters["@datefrom"].Value = date1.Value.Date;
                    display.SelectCommand.Parameters["@dateto"].Value = date2.Value.Date;

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
                }
                catch (Exception)
                {
                    con.Close();
                    MessageBox.Show("there was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        public void ClearedEventList(DataGridView view, DateTimePicker date1,DateTimePicker date2, TextBox text)
        {
            try
            {
                mySearch = text.Text;
                SqlDataAdapter display = new SqlDataAdapter("sp_cleared_events", con);
                display.SelectCommand.CommandType = CommandType.StoredProcedure;
                display.SelectCommand.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.Date));
                display.SelectCommand.Parameters.Add(new SqlParameter("@dateto", SqlDbType.Date));
                display.SelectCommand.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                display.SelectCommand.Parameters["@datefrom"].Value = date1.Value.Date;
                display.SelectCommand.Parameters["@dateto"].Value = date2.Value.Date;
                display.SelectCommand.Parameters["@search"].Value = mySearch;

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
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("there was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void ClearedEventList(DataGridView view , DateTimePicker date1 , DateTimePicker date2)
        {
            try
            {
                SqlDataAdapter display = new SqlDataAdapter("sp_cleared_event_date_search" , con);
                display.SelectCommand.CommandType = CommandType.StoredProcedure;
                display.SelectCommand.Parameters.Add(new SqlParameter("@datefrom", SqlDbType.Date));
                display.SelectCommand.Parameters.Add(new SqlParameter("@dateto", SqlDbType.Date));

                display.SelectCommand.Parameters["@datefrom"].Value = date1.Value.Date;
                display.SelectCommand.Parameters["@dateto"].Value = date2.Value.Date;

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
                }
            catch (Exception ) {
                con.Close();
                MessageBox.Show("there was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void ClearedEventList(DataGridView view, TextBox text)
        {
            try
            {
                mySearch = string.IsNullOrEmpty(text.Text) ? "" : text.Text; 
                string query = "SELECT * FROM view_cleared_event_pay WHERE Status ='Cleared' AND Term =@search OR Fee_Name LIKE '%'+ @search +'%' OR Names LIKE '%' + @search + '%' OR Class LIKE '%' + @search + '%'";
                SqlDataAdapter display = new SqlDataAdapter(query, con);
                display.SelectCommand.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                display.SelectCommand.Parameters["@search"].Value = mySearch;

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
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("there was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void ClearedEventList(DataGridView view)
        {  
            SqlDataAdapter display = new SqlDataAdapter("SELECT *FROM view_cleared_event_pay" , con); 
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

        }
        public void SearchEventList(DataGridView view, string searchtext)
            {
            try
            { 
                con.Open(); 
                var query = "SELECT * FROM view_event_list WHERE Term =@Search";
                SqlDataAdapter display = new SqlDataAdapter(query,con); 
                display.SelectCommand.Parameters.AddWithValue( "@Search", SqlDbType.VarChar).Value = searchtext;
                
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
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                con.Close();
                }catch (Exception)
                {
                MessageBox.Show("Search input error" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        public void SearchAllEventList(DataGridView view, string searchtext)
        {
            try
            {
                con.Open();
                var query =
                    "SELECT * FROM view_event_list WHERE Names LIKE '%'+@Search +'%'  OR Fee_Name LIKE '%'+ @Search +'%' OR Class LIKE '%'+ @Search +'%' OR Paid_Amount LIKE '%'+ @Search +'%' OR Term LIKE '%'+ @Search +'%'";
                SqlDataAdapter display = new SqlDataAdapter(query, con);
                display.SelectCommand.Parameters.AddWithValue("@Search", SqlDbType.VarChar).Value = searchtext;

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
            catch (Exception)
            {
                MessageBox.Show("\nSearch input error", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void SearchEventList(DataGridView view, DateTimePicker date1, string text)
            {
            try
                {
                mySearch = string.IsNullOrEmpty(text) ? "" : text;
                con.Open();
                if (string.IsNullOrEmpty(text))
                    {
                    var query = "SELECT *FROM EventList WHERE Date LIKE @paydate + '____%'";

                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();

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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                    con.Close();
                    }
                else
                    {
                    var query = "SELECT *FROM EventList WHERE Date LIKE @paydate + '____%' and Term=@search";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = date1.Value.Year; ;
                    display.SelectCommand.Parameters.Add("@search" , SqlDbType.VarChar).Value = mySearch;

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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                    con.Close();

                    }
                }catch (Exception)
                {
                    con.Close();
                    MessageBox.Show("Search contain error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        public void SearchEventList(DataGridView view, string termSearch, TextBox feename)
            {
            try
            {
              
                if ( string.IsNullOrEmpty(termSearch) )
                { 
                    var query =
                        " SELECT *FROM view_event_list WHERE Fee_Name LIKE'%' + @feename + '%' OR Class=@feename";
                      SqlDataAdapter display = new SqlDataAdapter(query ,con); 
                      display.SelectCommand.Parameters.AddWithValue( "@feename" , SqlDbType.VarChar).Value = feename.Text;
                    
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
                          view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                          view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                          view.Rows[n].Cells[6].Value = dat[7].ToString();
                          view.Rows[n].Cells[7].Value = dat[8].ToString();
                          view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                      }
                      con.Close();
                    }
                  else
                  { 
                    var query = "  SELECT *FROM view_event_list WHERE Term =@search AND Class =@feename" +
                                " OR Fee_Name = @feename";
                    SqlDataAdapter display = new SqlDataAdapter(query,con); 
                    display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = termSearch;
                     
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                  
                
                }catch (Exception)
                {
                    con.Close();
                MessageBox.Show("Search input error" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        public void SearchEventList(DataGridView view, DateTimePicker date1, string searchText, TextBox feename, TextBox name)
            {
            try
                { 
                
                con.Open(); 
                #region  
                if (string.IsNullOrEmpty(searchText) && string.IsNullOrEmpty(feename.Text))
                    {
                   var query = "SELECT *FROM EventList WHERE Names =@feename ";
                    SqlDataAdapter display = new SqlDataAdapter(query,con);
                    display.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feename.Text;
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else if (string.IsNullOrEmpty(searchText))
                    {
                  var  query = "SELECT *FROM EventList WHERE Fee_Name = @feename  AND Names = @feename  ";
  
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else if (string.IsNullOrEmpty(name.Text))
                    {
                  var  query = "SELECT *FROM EventList WHERE Term =@search AND Date LIKE @date + '____%' " +
                            "AND Class =@feename OR  Fee_Name =@feename";
                     
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value =searchText;
                    display.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else if (string.IsNullOrEmpty(feename.Text))
                    {
                   var query = "SELECT *FROM EventList WHERE Term =@search AND Date LIKE @date+ '____%' " +
                            "AND Names =@names ";

                    SqlDataAdapter display = new SqlDataAdapter(query , con); 
                    display.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@names" , SqlDbType.VarChar).Value = name.Text;
                    display.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = searchText;
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else
                    {
                        var query = "SELECT *FROM EventList WHERE  Date LIKE @date + '____%' AND Term =@search AND  " +
                            " Names =@names AND Class=@feename   ";

                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = searchText;
                    display.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
                    display.SelectCommand.Parameters.AddWithValue("@names" , SqlDbType.VarChar).Value = name.Text;
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
#endregion
                 
                }catch (Exception)
                {
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        public void SearchEventList(DataGridView view, string search, TextBox feename, TextBox name)
            {
            try
                {
               
                
                #region 
                if (string.IsNullOrEmpty(search) && string.IsNullOrEmpty(feename.Text))
                    {
                  var   query = "SELECT *FROM view_event_list WHERE Names LIKE'%' + @names + '%'";
                  SqlDataAdapter display = new SqlDataAdapter(query , con); 
                  display.SelectCommand.Parameters.AddWithValue("@names" , SqlDbType.VarChar).Value = name.Text;
                   
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
                      view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                      view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                      view.Rows[n].Cells[6].Value = dat[7].ToString();
                      view.Rows[n].Cells[7].Value = dat[8].ToString();
                      view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                  }

                  con.Close();
                    }
                else if (string.IsNullOrEmpty(search))
                    {
                  var   query = "SELECT *FROM view_event_list WHERE Fee_Name LIKE'%' + @feename + '%' AND Names LIKE'%' +@names + '%'";
                  SqlDataAdapter display = new SqlDataAdapter(query , con); 
                  display.SelectCommand.Parameters.AddWithValue("@names" , SqlDbType.VarChar).Value = name.Text;
                  display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
                   
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
                      view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                      view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                      view.Rows[n].Cells[6].Value = dat[7].ToString();
                      view.Rows[n].Cells[7].Value = dat[8].ToString();
                      view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                  }

                  con.Close();
                    }
                else
                {
                  var  query =
                        " SELECT *FROM view_event_list WHERE Fee_Name LIKE'%' +@feename + '%' AND Term =@search AND Names LIKE'%' + @names + '%'";
                  SqlDataAdapter display = new SqlDataAdapter(query , con); 
                  display.SelectCommand.Parameters.AddWithValue("@names" , SqlDbType.VarChar).Value = name.Text;
                  display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
                  display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;

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
                      view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                      view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                      view.Rows[n].Cells[6].Value = dat[7].ToString();
                      view.Rows[n].Cells[7].Value = dat[8].ToString();
                      view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                  }

                  con.Close();
                    }
                #endregion
              
               
                }
            catch (Exception Ex)
                {
                MessageBox.Show(Ex.Message+"\nThere was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        public void SearchEventList(DataGridView view, DateTimePicker date1, DateTimePicker date2, string term)
        {
            try
                { 
                con.Open();
                if (string.IsNullOrEmpty(term))
                    {
                  var  query = "SELECT *FROM view_event_list WHERE Date BETWEEN @datefrom AND @dateto";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                     
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else
                    {
                   var query = "SELECT *FROM view_event_list WHERE Date BETWEEN @datefrom AND @dateto AND Term=@term";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;

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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    } 
            
                }catch (Exception ex)
            {
                throw new ExceptionHandling("There was an error", ex);
            }
        }
        public void SearchEventListWithDate(DataGridView view , DateTimePicker date1 , DateTimePicker date2 , string term,string search)
            {
            try
                {
                con.Open();
                if (string.IsNullOrEmpty(term))
                    {
                    var query = "SELECT *FROM view_event_list WHERE Date BETWEEN @datefrom AND @dateto AND Names LIKE '%'+ @search +'%' "+
                        " OR Fee_Name LIKE '%'+ @search +'%' OR Class LIKE '$%'+ @search +'%'";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                    con.Close();
                    }
                else
                    {
                    var query = "SELECT *FROM view_event_list WHERE Date BETWEEN @datefrom AND @dateto AND Term=@term AND Names LIKE '%'+ @search +'%' " +
                         " OR Fee_Name LIKE '%'+ @search +'%' OR Class LIKE '$%'+ @search +'%'";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
                    display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;

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
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                    con.Close();
                    }

                }
            catch (Exception ex)
                {
                throw new ExceptionHandling("There was an error" , ex);
                }
            }
        public void PastYearEventList(DataGridView view, DateTimePicker dateYear, string term, string classname)
        {
            try
            {
                con.Open();
                var query = "SELECT *FROM EventList WHERE Date LIKE @dateyear +'____%'  AND Term=@term AND Class LIKE '%'+ @classname +'%' ";
                SqlDataAdapter display = new SqlDataAdapter(query, con);
                display.SelectCommand.Parameters.AddWithValue("@dateyear", SqlDbType.VarChar).Value = dateYear.Value.Year.ToString();
                display.SelectCommand.Parameters.AddWithValue("@classname", SqlDbType.VarChar).Value = classname;
                display.SelectCommand.Parameters.AddWithValue("@term", SqlDbType.VarChar).Value = term;
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
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("There was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
    }
