using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class RecordAccess
    {
        /// <summary>
        /// <public variables>
        /// </summary>
        public static long total=0;
        public static string RecordDate;
        public  static string Feename;

        public static void todaySeacrchRecords(DataGridView search, TextBox searchtext)
                {
                    SqlConnection con = new DBConnection().getConnection();
                try
                    {
                        total = 0;
                  
                    con.Open();
                    DataTable dtnow = new DataTable();
                    SqlDataAdapter danow = new SqlDataAdapter("SELECT *FROM Cash WHERE  Pay_Date IN(SELECT Pay_Date FROM Cash WHERE Pay_Date=@today) AND Names LIKE '%' + @search +'%' " +
                       " OR Fee_Name LIKE '%' + @search + '%' OR Class=@search ", con);
                danow.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.Text).Value =searchtext.Text ;
                danow.SelectCommand.Parameters.AddWithValue("@today" , SqlDbType.VarChar).Value =dataAccess.Sdate.ToString();
                 
                danow.Fill(dtnow);
                    search.Rows.Clear();
                    foreach (DataRow drnow in dtnow.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drnow[0].ToString();
                        search.Rows[n].Cells[1].Value = drnow[1].ToString();
                        search.Rows[n].Cells[2].Value = drnow[2].ToString();
                        search.Rows[n].Cells[3].Value = drnow[3].ToString();
                        search.Rows[n].Cells[4].Value = drnow[4].ToString();
                            long amount = Convert.ToInt64(drnow[5]);
                            total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drnow[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}",drnow[6]);
                            //GET THE DATE OF THE RECORDS
                           RecordDate=drnow[6].ToString();
                        search.Rows[n].Cells[7].Value = drnow[7].ToString();
                        search.Rows[n].Cells[8].Value = drnow[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drnow[9]);
                        search.Rows[n].Cells[10].Value = drnow[10].ToString();
                        
                        }

                    con.Close();

                    }
                catch (Exception)
                    {
                        con.Close();
                        MessageBox.Show("There was error in the search");
                    }
                }
        public static void todaySeacrchRecordsByFeename(DataGridView search, string searchtext)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                total = 0; 
                con.Open();
                DataTable dtnow = new DataTable();
                SqlDataAdapter danow = new SqlDataAdapter("SELECT *FROM Cash WHERE  Pay_Date IN(SELECT Pay_Date FROM Cash WHERE Pay_Date=@today) AND Fee_Name=@search ", con);
                danow.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.Text).Value = searchtext;
                danow.SelectCommand.Parameters.AddWithValue("@today", SqlDbType.VarChar).Value = dataAccess.Sdate.ToString();

                danow.Fill(dtnow);
                search.Rows.Clear();
                foreach (DataRow drnow in dtnow.Rows)
                {
                    int n = search.Rows.Add();
                    search.Rows[n].Cells[0].Value = drnow[0].ToString();
                    search.Rows[n].Cells[1].Value = drnow[1].ToString();
                    search.Rows[n].Cells[2].Value = drnow[2].ToString();
                    search.Rows[n].Cells[3].Value = drnow[3].ToString();
                    search.Rows[n].Cells[4].Value = drnow[4].ToString();
                    long amount = Convert.ToInt64(drnow[5]);
                    total = total + amount;
                    search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drnow[5]);
                    search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}", drnow[6]);
                    //GET THE DATE OF THE RECORDS
                    RecordDate = drnow[6].ToString();
                    search.Rows[n].Cells[7].Value = drnow[7].ToString();
                    search.Rows[n].Cells[8].Value = drnow[8].ToString();
                    search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drnow[9]);
                    search.Rows[n].Cells[10].Value = drnow[10].ToString();

                }

                con.Close();

            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("There was error in the search");
            }
        }
        public static void getTodayfeeNames(ComboBox feeName)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Fee_Name FROM Cash WHERE Pay_Date=@today ", con);
            da.SelectCommand.Parameters.AddWithValue("@today", SqlDbType.VarChar).Value = dataAccess.Sdate.ToString();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                feeName.Items.Add(dr["Fee_Name"]);
            }
        }
            public static void todayRecords(DataGridView today)
            {
                SqlConnection con = new DBConnection().getConnection();
                try
                    {
                        total = 0;
                  
                    con.Open();
                    DataTable dtToday = new DataTable();
                    SqlDataAdapter daToday =
                        new SqlDataAdapter("SELECT *FROM Cash WHERE Pay_Date = @today", con);
                daToday.SelectCommand.Parameters.AddWithValue("@today" , SqlDbType.VarChar).Value = dataAccess.Sdate;
                
                daToday.Fill(dtToday);
                    today.Rows.Clear();
                    foreach (DataRow drToday in dtToday.Rows)
                    {
                    int n = today.Rows.Add();
                        today.Rows[n].Cells[0].Value = drToday[0].ToString();
                        today.Rows[n].Cells[1].Value = drToday[1].ToString();
                        today.Rows[n].Cells[2].Value = drToday[2].ToString();
                        today.Rows[n].Cells[3].Value = drToday[3].ToString();
                        today.Rows[n].Cells[4].Value = drToday[4].ToString();
                        long amount = Convert.ToInt64(drToday[5]);
                        total = total + amount;
                        today.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drToday[5]);
                        today.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}", drToday[6]);
                        RecordDate = drToday[6].ToString();
                        today.Rows[n].Cells[7].Value = drToday[7].ToString();
                        today.Rows[n].Cells[8].Value = drToday[8].ToString();
                        today.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drToday[9]);
                        today.Rows[n].Cells[10].Value = drToday[10];
                         
                    }

                    con.Close();
                }
                catch (Exception Ex)
                {
                    con.Close();
                throw new ExceptionHandling("today search error" , Ex);
                }
            }
        public static void Report(DataGridView view, string feename, DateTimePicker datepick)
        {
              SqlConnection con = new DBConnection().getConnection();
              try
              {
                  total = 0;

                  con.Open();
                  DataTable dts = new DataTable();
                  SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cash WHERE Fee_Name=@feename and Pay_Date=@paydate", con);
                  da.SelectCommand.Parameters.AddWithValue("@paydate", SqlDbType.VarChar).Value = datepick.Value.ToString("MM/dd/yyyy");
                  da.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feename;
                  da.Fill(dts);
                  view.Rows.Clear();
                  foreach (DataRow drRec in dts.Rows)
                  {
                      //DISPLAY THE RECORDS IN THE GRID VIEW C 
                      int n = view.Rows.Add();
                      view.Rows[n].Cells[0].Value = drRec[0].ToString();
                      view.Rows[n].Cells[1].Value = drRec[1].ToString();
                      view.Rows[n].Cells[2].Value = drRec[2].ToString();
                      view.Rows[n].Cells[3].Value = drRec[3].ToString();
                      view.Rows[n].Cells[4].Value = drRec[4].ToString();
                      long amount = Convert.ToInt64(drRec[5]);
                      total = total + amount;
                      view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drRec[5]);
                      view.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}", drRec[6]);
                      RecordDate = drRec[6].ToString();
                      view.Rows[n].Cells[7].Value = drRec[7].ToString();
                      view.Rows[n].Cells[8].Value = drRec[8].ToString();
                      view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drRec[9]);
                      view.Rows[n].Cells[10].Value = drRec[10];
                      PaymentRecordSearch.total = total;
                  }

                  con.Close();
              }
              catch (Exception ex)
              {
                  con.Close();
                  throw new ExceptionHandling("there was error in the search ", ex);

              }
        }
        public static void todayRecords(DataGridView today,TextBox fee,TextBox name)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                total = 0;
               
                con.Open();
                DataTable dtToday = new DataTable();
                SqlDataAdapter daToday =
                    new SqlDataAdapter("SELECT *FROM Cash WHERE Pay_Date = @paydate AND Fee_Name like'%' + @fee + '%'" +
                                       " AND Names LIKE'%' +@ names +'%' ", con);
                daToday.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = dataAccess.Sdate;
                daToday.SelectCommand.Parameters.AddWithValue("@names" , SqlDbType.VarChar).Value = name.Text;
                daToday.SelectCommand.Parameters.AddWithValue("@fee" , SqlDbType.VarChar).Value = fee.Text;
                daToday.Fill(dtToday);
                today.Rows.Clear();
                foreach (DataRow drToday in dtToday.Rows)
                {
                    int n = today.Rows.Add();
                    today.Rows[n].Cells[0].Value = drToday[0].ToString();
                    today.Rows[n].Cells[1].Value = drToday[1].ToString();
                    today.Rows[n].Cells[2].Value = drToday[2].ToString();
                    today.Rows[n].Cells[3].Value = drToday[3].ToString();
                    today.Rows[n].Cells[4].Value = drToday[4].ToString();
                    long amount = Convert.ToInt64(drToday[5]);
                    total = total + amount;
                    today.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drToday[5]);
                    today.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}",drToday[6]);
                    RecordDate =drToday[6].ToString();
                    today.Rows[n].Cells[7].Value = drToday[7].ToString();
                    today.Rows[n].Cells[8].Value = drToday[8].ToString();
                    today.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drToday[9]);
                    today.Rows[n].Cells[10].Value = drToday[10].ToString();
                    

                }

                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("today search error" , Ex);
                }

        }
        public static void TodayReport(DataGridView today, TextBox fee)
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                {
                total = 0;
               
                con.Open();
                DataTable dtToday = new DataTable();
                SqlDataAdapter daToday =
                    new SqlDataAdapter("SELECT *FROM Cash WHERE Pay_Date =@paydate AND Fee_Name =@fee", con);
                daToday.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = RecordDate;
               
                daToday.SelectCommand.Parameters.AddWithValue("@fee" , SqlDbType.VarChar).Value = fee.Text;
                daToday.Fill(dtToday);
                today.Rows.Clear();
                foreach (DataRow drToday in dtToday.Rows)
                    {
                    int n = today.Rows.Add();
                    today.Rows[n].Cells[0].Value = drToday[0].ToString();
                    today.Rows[n].Cells[1].Value = drToday[1].ToString();
                    today.Rows[n].Cells[2].Value = drToday[2].ToString();
                    today.Rows[n].Cells[3].Value = drToday[3].ToString();
                        //GET THE FEE NAME
                    Feename = drToday[3].ToString();
                    today.Rows[n].Cells[4].Value = drToday[4].ToString();
                    long amount = Convert.ToInt64(drToday[5]);
                    total = total + amount;
                    today.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drToday[5]);
                    today.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}", drToday[6]);
                        RecordDate = drToday[6].ToString();
                    today.Rows[n].Cells[7].Value = drToday[7].ToString();
                    today.Rows[n].Cells[8].Value = drToday[8].ToString();
                    today.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drToday[9]);
                    today.Rows[n].Cells[10].Value = drToday[10].ToString();

                    }

                con.Close();
                }
            catch (Exception Ex)
                {
                    con.Close();
                throw new ExceptionHandling("today search error" , Ex);
                }

            }
        }
    }
