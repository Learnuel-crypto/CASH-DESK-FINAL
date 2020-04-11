using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class PaymentRecordSearch
    {
        public static long total = 0;
        public static  void PaymentSearch(DataGridView search, TextBox searchText)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                total = 0;
             
                con.Open();
                
                var query = "SELECT *FROM Cash WHERE Names like '%' +@search +'%' " +
                            " OR Class LIKE '%' + @search +'%'  OR Amount LIKE '%' + @search +'%'" +
                            " OR Fee_Name LIKE '%' + @search + '%' OR  Term LIKE '%' + @search + '%'" +
                            " OR Fee_Type LIKE '%' + @search + '%'  ";
                SqlDataAdapter danow = new SqlDataAdapter(query, con);
               danow.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = searchText.Text;
                
                DataTable dtnow = new DataTable();
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
                    search.Rows[n].Cells[6].Value =string.Format("{0:MM/dd/yyyy}",  drnow[6] );
                    search.Rows[n].Cells[7].Value = drnow[7].ToString();
                    search.Rows[n].Cells[8].Value = drnow[8].ToString();
                    search.Rows[n].Cells[9].Value =string.Format("{0:MM/dd/yyyy}",  drnow[9] );
                    search.Rows[n].Cells[10].Value = drnow[10].ToString();

                }

                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("search error", Ex);

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
                    new SqlDataAdapter("SELECT *FROM Cash WHERE Pay_Date = @paydate", con);
                
                daToday.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = dataAccess.Sdate;
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
                    today.Rows[n].Cells[6].Value =string.Format("{0:MM/dd/yyyy}",  drToday[6] );
                    today.Rows[n].Cells[7].Value = drToday[7].ToString();
                    today.Rows[n].Cells[8].Value = drToday[8].ToString();
                    today.Rows[n].Cells[9].Value =string.Format("{0:MM/dd/yyyy}",  drToday[9] );
                    today.Rows[n].Cells[10].Value = drToday[10];

                }

                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("today record search error" , Ex);
            }
        }
        public static void PaymentSearch(DataGridView search,DateTimePicker date1,string term,ComboBox feeBox)
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                {
                total = 0; 
                if (string.IsNullOrEmpty(term))
                {
                    con.Open();
                    DataTable dtnow = new DataTable();
                    SqlDataAdapter danow = new SqlDataAdapter(
                        "SELECT *FROM Cash WHERE Fee_Name = @feename AND Year LIKE  @payYear + '____%'" +
                        " ORDER BY ID DESC", con);
                    danow.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feeBox.Text;
                    danow.SelectCommand.Parameters.AddWithValue("@payYear", SqlDbType.VarChar).Value =
                        date1.Value.Year.ToString();
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
                        search.Rows[n].Cells[7].Value = drnow[7].ToString();
                        search.Rows[n].Cells[8].Value = drnow[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drnow[9]);
                        search.Rows[n].Cells[10].Value = drnow[10].ToString();

                    }

                    con.Close();
                }
                else
                {
                    con.Open();
                    DataTable dtnow = new DataTable();
                    SqlDataAdapter danow = new SqlDataAdapter("SELECT *FROM Cash WHERE Fee_Name = @feename AND  Term=@term AND Year LIKE  @payYear + '____%'" +
                                                              " ORDER BY ID DESC" , con);
                    danow.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feeBox.Text;
                    danow.SelectCommand.Parameters.AddWithValue("@payYear" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                    danow.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;
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
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drnow[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drnow[6]);
                        search.Rows[n].Cells[7].Value = drnow[7].ToString();
                        search.Rows[n].Cells[8].Value = drnow[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drnow[9]);
                        search.Rows[n].Cells[10].Value = drnow[10].ToString();

                    }

                    con.Close();
                    }
                }
            catch (Exception Ex)
                {
                    con.Close();
                throw new ExceptionHandling("search error" , Ex);

                }
            }
        public static void PaymentSearch(DataGridView search , DateTimePicker date1, DateTimePicker date2 , ComboBox feeBox)
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                {
                total = 0; 
                con.Open();
                DataTable dtnow = new DataTable();
                SqlDataAdapter danow = new SqlDataAdapter("SELECT *FROM Cash WHERE Fee_Name = @feename AND Pay_Date BETWEEN @datefrom AND @dateto" +
                                                          " ORDER BY ID DESC" , con);
                danow.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feeBox.Text;
                danow.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date1.Value.ToString("d");
                danow.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString("d");
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
                    search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drnow[5]);
                    search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drnow[6]);
                    search.Rows[n].Cells[7].Value = drnow[7].ToString();
                    search.Rows[n].Cells[8].Value = drnow[8].ToString();
                    search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drnow[9]);
                    search.Rows[n].Cells[10].Value = drnow[10].ToString();

                    }

                con.Close();
                }
            catch (Exception Ex)
                {
                    con.Close();
                throw new ExceptionHandling("search error" , Ex);

                }
            }

        public static void PaymentSearch(DataGridView view)
            {
            total = 0;
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Cash ORDER BY ID desc", con);
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
                
                view.Rows[n].Cells[7].Value = drRec[7].ToString();
                view.Rows[n].Cells[8].Value = drRec[8].ToString();
                view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drRec[9]);
                view.Rows[n].Cells[10].Value = drRec[10];
                     
            }

            con.Close();
            }
        public static void Report(DataGridView view,TextBox feename,DateTimePicker datepick)
        {

            total = 0;
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cash WHERE Fee_Name=@feename AND Pay_Date=@paydate", con);
                da.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feename.Text;
                da.SelectCommand.Parameters.AddWithValue("@paydate", SqlDbType.VarChar).Value = datepick.Value;
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

                    view.Rows[n].Cells[7].Value = drRec[7].ToString();
                    view.Rows[n].Cells[8].Value = drRec[8].ToString();
                    view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drRec[9]);
                    view.Rows[n].Cells[10].Value = drRec[10];

                }

                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("search error", Ex);

            }
        }
        //NAME TEXTFIELD CHANGED QUERY
        public static void PaymentSearch(DataGridView search, DateTimePicker pick1, DateTimePicker pick2, TextBox name, string term,ComboBox feeBox)
            {
 
                SqlConnection con = new DBConnection().getConnection();   
            try
                {  
            total = 0; 
                    con.Open();
                if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(feeBox.Text))
                {
              var  query = "SELECT *FROM Cash WHERE Pay_Date BETWEEN @datefrom AND @dateto  AND Class =@namesearch OR Names LIKE '%'+ @namesearch +'%'";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                    
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                else if (string.IsNullOrEmpty(feeBox.Text))
                {
              var  query = "SELECT *FROM Cash WHERE Term =@termsearch AND Pay_Date BETWEEN @datefrom AND @dateto" +
                        "  AND Class =@namesearch OR Names = @namesearch ";
                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);

                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                    da.SelectCommand.Parameters.AddWithValue("@termsearch" , SqlDbType.VarChar).Value = term;
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                else if (string.IsNullOrEmpty(term))
                {
             var   query = "SELECT *FROM Cash WHERE Fee_Name =@feename AND Pay_Date BETWEEN @datefrom AND @dateto" +
                            "  AND Class =@namesearch OR Names =@namesearch ";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text; 
                    da.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feeBox.Text;
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                else
                {
               var query = "SELECT *FROM Cash WHERE Fee_Name =@feename AND Term =@termsearch AND Pay_Date BETWEEN @datefrom AND @dateto" +
                            " AND  Class =@namesearch OR Names =@namesearch ";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@termsearch" , SqlDbType.VarChar).Value = term;
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                    da.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feeBox.Text;
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                 
               

                }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("search error", Ex);

            }
            }
        public static void PaymentSearch(DataGridView search, DateTimePicker pick1, DateTimePicker pick2)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            { 
                total = 0; 
                con.Open();
                 
                 var  query = "SELECT *FROM Cash WHERE Pay_Date BETWEEN @datefrom AND @dateto " ; 
                
                DataTable dtS = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query,con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                da.Fill(dtS);
                search.Rows.Clear();
                foreach (DataRow drS in dtS.Rows)
                {
                    int n = search.Rows.Add();
                    search.Rows[n].Cells[0].Value = drS[0].ToString();
                    search.Rows[n].Cells[1].Value = drS[1].ToString();
                    search.Rows[n].Cells[2].Value = drS[2].ToString();
                    search.Rows[n].Cells[3].Value = drS[3].ToString();
                    search.Rows[n].Cells[4].Value = drS[4].ToString();
                    long amount = Convert.ToInt64(drS[5]);
                    total = total + amount;
                    search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", drS[5]);
                    search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}", drS[6]);
                    search.Rows[n].Cells[7].Value = drS[7].ToString();
                    search.Rows[n].Cells[8].Value = drS[8].ToString();
                    search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}", drS[9]);
                    search.Rows[n].Cells[10].Value = drS[10].ToString();

                }

                con.Close();

            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("search error", Ex);
            }
        }
        //SEARCH BUTTON QUERY
        public static void PaymentSearchButton(DataGridView search, DateTimePicker pick1, DateTimePicker pick2, TextBox name, string term, ComboBox feeBox)
            {
            try
                { 
                total = 0;
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(feeBox.Text))
                    {
                   var query = "SELECT *FROM Cash WHERE Pay_Date BETWEEN @datefrom AND @dateto " +
                            " AND Names =@namesearch OR Class =@namesearch";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                     
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                else if (string.IsNullOrEmpty(feeBox.Text))
                    {
                   var query = "SELECT *FROM Cash WHERE Term =@termsearch AND Pay_Date BETWEEN @datefrom AND @dateto" +
                            "  AND Names =namesearch";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);

                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                    da.SelectCommand.Parameters.AddWithValue("@termsearch" , SqlDbType.VarChar).Value = term;
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                else if (string.IsNullOrEmpty(term))
                    {
                   var query = "SELECT *FROM Cash WHERE Fee_Name =@feename AND Pay_Date BETWEEN @datefrom AND @dateto" +
                                "  AND Names =@namesearch";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                    da.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feeBox.Text;
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                else
                    {
                  var  query = "SELECT *FROM Cash WHERE Term = @termsearch AND Pay_Date BETWEEN @datefrom AND @dateto" +
                                " AND Names =@namesearch AND Fee_Name=@feename";

                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@namesearch" , SqlDbType.VarChar).Value = name.Text;
                    da.SelectCommand.Parameters.AddWithValue("@termsearch" , SqlDbType.VarChar).Value = term;
                    da.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feeBox.Text;
                    da.Fill(dtS);
                    search.Rows.Clear();
                    foreach (DataRow drS in dtS.Rows)
                        {
                        int n = search.Rows.Add();
                        search.Rows[n].Cells[0].Value = drS[0].ToString();
                        search.Rows[n].Cells[1].Value = drS[1].ToString();
                        search.Rows[n].Cells[2].Value = drS[2].ToString();
                        search.Rows[n].Cells[3].Value = drS[3].ToString();
                        search.Rows[n].Cells[4].Value = drS[4].ToString();
                        long amount = Convert.ToInt64(drS[5]);
                        total = total + amount;
                        search.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , drS[5]);
                        search.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}" , drS[6]);
                        search.Rows[n].Cells[7].Value = drS[7].ToString();
                        search.Rows[n].Cells[8].Value = drS[8].ToString();
                        search.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , drS[9]);
                        search.Rows[n].Cells[10].Value = drS[10].ToString();

                        }

                    con.Close();
                    }
                
                }
            catch (Exception Ex)
                {
                throw new ExceptionHandling("Search error" , Ex);

                }
            }
    }
    }
