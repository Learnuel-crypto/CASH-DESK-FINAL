using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class CreditSales
        {
        private  static string creditorFirstname;
        private static string creditorLastname;
        private static string creditorContact;
        public static float TodayCredit = 0.00f;
        SqlConnection con = new DBConnection().getConnection();

        /// <summary>
        /// Member methods
        /// </summary>
        /// <param name="fname"></param>
        #region
        public void SetFirstname(string fname)
            {
           
            try
                {
                if (string.IsNullOrEmpty(fname))
                    {
                    throw new Exception("Creditor first is empty");
                    }
                 
                else
                    {
                    creditorFirstname = fname;
                    } 
                }
            catch(Exception ex)
                {
                throw new ExceptionHandling("First name cannot be empty" , ex);
                }
            }
        public void SetLasttname(string lname)
            {
            
            try
                {
                if (string.IsNullOrEmpty(lname))
                    {
                    throw new Exception("Creditor Last name is empty");
                    }
                 
                else
                    {
                    creditorLastname = lname;
                    }
                }
            catch (Exception ex)
                {
                throw new ExceptionHandling("Last name cannot be empty" , ex);
                }
            }
        public void SetContact(string contact)
            { 
            try
                { 
                    creditorContact = contact;
                    
                }
            catch (Exception ex)
                {
                throw new ExceptionHandling("First name Contains invalide alphabet" , ex);
                }
            }
        public  string GetCreditorFirstname()
            {
            return creditorFirstname;
            }
        public string GetCreditorLastname()
            {
            return creditorLastname;
            }
        public string GetCreditorContact()
            {
            return creditorContact;
            }
        public static void RecordCreditor(int saleID , string fname , string lname , string contact)
            {
           
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Firstname" , fname);
                cmd.Parameters.AddWithValue("@Lastname" , lname);
                cmd.Parameters.AddWithValue("@Contact" , contact);
                cmd.Parameters.AddWithValue("@Sales_Id" , saleID);
                cmd.CommandText = "INSERT INTO Credit_Sales(Firstname,Lastname,Contact,Sales_Id) VALUES(@Firstname,@Lastname,@Contact,@Sales_Id)";
                cmd.ExecuteNonQuery();
                con.Close();
                }
            catch (Exception ex)
                {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("DELETE * FROM Sales WHERE Sales_Id =@saleid" , con);
                da.SelectCommand.Parameters.AddWithValue("@saleid" , SqlDbType.VarChar).Value = saleID;
                con.Close();
                throw new ExceptionHandling("An Error occured Credit sale was not completed" , ex);
                }
            }
        #endregion
        //QUERIES
        #region
        public static void AllCreditSales(DataGridView view , string search)
            {
               
              try
              {
                  if (string.IsNullOrEmpty(search))
                  {
                      var query = "SELECT *FROM View_Credit_Sales ORDER BY Sold_Date,Firstname,Item";
                      SqlConnection con = new DBConnection().getConnection();
                      SqlDataAdapter da = new SqlDataAdapter(query, con);
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      TodayCredit = 0;
                      view.Rows.Clear();
                      foreach (DataRow dr in dt.Rows)
                      {
                          int n = view.Rows.Add();
                          view.Rows[n].Cells[0].Value = dr[0].ToString();
                          view.Rows[n].Cells[1].Value = dr[1].ToString();
                          view.Rows[n].Cells[2].Value = dr[2].ToString();
                          view.Rows[n].Cells[3].Value = dr[3].ToString();
                          view.Rows[n].Cells[4].Value = dr[4].ToString();
                          view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                          view.Rows[n].Cells[6].Value = dr[6].ToString();
                          int credit = Convert.ToInt32(dr[7]);
                          TodayCredit = TodayCredit + credit;
                          view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                          view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                          view.Rows[n].Cells[9].Value = dr[9].ToString();
                      }
                  }
                  else
                  {
                      var query = "SELECT *FROM View_Credit_Sales WHERE Firstname LIKE'%' + @search + '%'  OR Lastname LIKE'%' + @search + '%' OR Item LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%' ORDER BY Sold_Date,Firstname,Item";

                      SqlConnection con = new DBConnection().getConnection();
                      SqlDataAdapter da = new SqlDataAdapter(query, con);
                      da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = search;
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      TodayCredit = 0;
                      view.Rows.Clear();
                      foreach (DataRow dr in dt.Rows)
                      {
                          int n = view.Rows.Add();
                          view.Rows[n].Cells[0].Value = dr[0].ToString();
                          view.Rows[n].Cells[1].Value = dr[1].ToString();
                          view.Rows[n].Cells[2].Value = dr[2].ToString();
                          view.Rows[n].Cells[3].Value = dr[3].ToString();
                          view.Rows[n].Cells[4].Value = dr[4].ToString();
                          view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                          view.Rows[n].Cells[6].Value = dr[6].ToString();
                          int credit = Convert.ToInt32(dr[7]);
                          TodayCredit = TodayCredit + credit;
                          view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                          view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                          view.Rows[n].Cells[9].Value = dr[9].ToString();
                      }
                  }
              }
              catch (Exception ex)
              {
                  throw new ExceptionHandling("there was error in the search", ex);
              }
            

            }
        public static void CreditSalesItem(DataGridView view , string search)
            {
                try
                {
                    if (string.IsNullOrEmpty(search))
                    {
                        var query = "SELECT *FROM View_Credit_Sales ORDER BY Sold_Date,Firstname,Item";
                        SqlConnection con = new DBConnection().getConnection();
                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        TodayCredit = 0;
                        view.Rows.Clear();
                        foreach (DataRow dr in dt.Rows)
                        {
                            int n = view.Rows.Add();
                            view.Rows[n].Cells[0].Value = dr[0].ToString();
                            view.Rows[n].Cells[1].Value = dr[1].ToString();
                            view.Rows[n].Cells[2].Value = dr[2].ToString();
                            view.Rows[n].Cells[3].Value = dr[3].ToString();
                            view.Rows[n].Cells[4].Value = dr[4].ToString();
                            view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                            view.Rows[n].Cells[6].Value = dr[6].ToString();
                            int credit = Convert.ToInt32(dr[7]);
                            TodayCredit = TodayCredit + credit;
                            view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                            view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                            view.Rows[n].Cells[9].Value = dr[9].ToString();
                        }
                    }
                    else
                    {
                        var query = "SELECT *FROM View_Credit_Sales WHERE Item =@search  ORDER BY Sold_Date,Firstname,Item";
                        SqlConnection con = new DBConnection().getConnection();
                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = search;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        TodayCredit = 0;
                        view.Rows.Clear();
                        foreach (DataRow dr in dt.Rows)
                        {
                            int n = view.Rows.Add();
                            view.Rows[n].Cells[0].Value = dr[0].ToString();
                            view.Rows[n].Cells[1].Value = dr[1].ToString();
                            view.Rows[n].Cells[2].Value = dr[2].ToString();
                            view.Rows[n].Cells[3].Value = dr[3].ToString();
                            view.Rows[n].Cells[4].Value = dr[4].ToString();
                            view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                            view.Rows[n].Cells[6].Value = dr[6].ToString();
                            int credit = Convert.ToInt32(dr[7]);
                            TodayCredit = TodayCredit + credit;
                            view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                            view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                            view.Rows[n].Cells[9].Value = dr[9].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ExceptionHandling("there was error in the search", ex);
                }

            }
        public static void AllCreditBetweenDate(DataGridView view , DateTimePicker from , DateTimePicker To)
            {
                SqlConnection con = new DBConnection().getConnection();  
            try
                {
                    string query = "SELECT *FROM View_Credit_Sales WHERE Sold_Date BETWEEN @datefrom AND @dateto ORDER BY Sold_Date,Firstname,Item";

                    
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                    da.SelectCommand.Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = To.Value.ToString("MM/dd/yyyy");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TodayCredit = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        int credit = Convert.ToInt32(dr[7]);
                        TodayCredit = TodayCredit + credit;
                        view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                        view.Rows[n].Cells[9].Value = dr[9].ToString();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw new ExceptionHandling("there was error in the search", ex);
                }

            }
        public static void AllCreditBetweenDate(DataGridView view , DateTimePicker from )
            {
                try
                {
                    string query = "SELECT *FROM View_Credit_Sales WHERE Sold_Date = @datefrom  ORDER BY Sold_Date,Firstname,Item";

                    SqlConnection con = new DBConnection().getConnection();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TodayCredit = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        int credit = Convert.ToInt32(dr[7]);
                        TodayCredit = TodayCredit + credit;
                        view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                        view.Rows[n].Cells[9].Value = dr[9].ToString();
                    }
                }catch (Exception ex)
                { 
                    throw new ExceptionHandling("there was error in the search", ex);
                }
            }
        public static void AllCreditBetweenDate(DataGridView view , DateTimePicker from , DateTimePicker To, string item)
            {
             SqlConnection con = new DBConnection().getConnection();    
            try
                {
                    string query = "SELECT *FROM View_Credit_Sales WHERE Sold_Date BETWEEN @datefrom AND @dateto AND Item =@item ORDER BY Sold_Date,Firstname,Item";
                   
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                    da.SelectCommand.Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = To.Value.ToString("MM/dd/yyyy");
                    da.SelectCommand.Parameters.AddWithValue("@item", SqlDbType.VarChar).Value = item;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TodayCredit = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dr[5]);
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        int credit = Convert.ToInt32(dr[7]);
                        TodayCredit = TodayCredit + credit;
                        view.Rows[n].Cells[7].Value = string.Format("{0:00.#0}", dr[7]);
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dr[8]);
                        view.Rows[n].Cells[9].Value = dr[9].ToString();
                    }
                }catch (Exception ex)
                {
                    con.Close();
                    throw new ExceptionHandling("there was error in the search", ex);
                }
            }
        #endregion
        }
    }
