using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TallerInfor
{

    class Taller
    {
        public static string TallerID;
        public static bool TallerError = false;
        public  Image TallerPic;
       
        SqlConnection con = new DBConnection().getConnection();

         

        /// <summary>
        /// VALIDATE THE TALLER NUMBER
        /// </summary>
        /// <param name="tallerid"></param>
        public  void   setTallerId(string tallerid,PictureBox image, Label path)
        { 
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Taller_Id FROM Taller WHERE Taller_Id =@tellerid", con);
                da.SelectCommand.Parameters.AddWithValue("@tellerid", SqlDbType.VarChar).Value = tallerid;
                da.Fill(ds);
                da.Fill(dt);
                int x = dt.Rows.Count;
                if (x > 0)
                {
                    throw new Exception("Teller Number Already Exist For A student");
                }
                TallerID = tallerid; 
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Teller Has Been Used",Ex);
                
            }
            
        }
         
        public  void UpdateTaller(int cash_id)
        {
            try
            {
                //update the taller tracking id to the payment id made
                var TrackingID = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@cashid", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@trackid" , SqlDbType.VarChar));
                cmd.Parameters["@cashid"].Value = cash_id;
                cmd.Parameters["@trackid"].Value = TrackingID;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Taller SET ID=@cashid WHERE ID=@trackid";
                cmd.ExecuteNonQuery(); 
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message+ "\nTeller Operation Failed","Teller Update");
            }
        }
        /// <summary>
        /// DISPLAY DETAILS OF PAYMENT MADE WITH TALLER
        /// </summary>
        /// <param name="view"></param>
        #region
        public static void TallerPayments(DataGridView view)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Cash.ID, Cash.Names, Cash.Class, Cash.Fee_Name,Cash.Amount, "+
                    "Cash.Term,Cash.Fee_Type,Cash.Pay_Date FROM Cash WHERE Cash.ID IN (SELECT Taller.ID FROM Taller)", con);
                da.Fill(ds);
                da.Fill(dt); 
                view.Rows.Clear(); 
                   foreach(DataRow dr in dt.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value =string.Format("{0:00.00#}", dr[4]);
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        view.Rows[n].Cells[7].Value =string.Format("{0:MM/dd/yyyy}", dr[7]); 
                }

            }
            catch (Exception)
            {
                con.Close();

            }
        }
        public   void TallerDateSearch(DataGridView view, DateTimePicker pick1, DateTimePicker pick2, string searchtext, string term)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {  
                if(string.IsNullOrEmpty(searchtext) && string.IsNullOrEmpty(term))
                {
                    //SEARCH WITH TWO PARAMETERS
                var    query = "SELECT Cash.ID, Cash.Names, Cash.Class, Cash.Fee_Name,Cash.Amount, " +
                   "Cash.Term,Cash.Fee_Type,Cash.Pay_Date FROM Cash WHERE Cash.ID IN (SELECT Taller.ID FROM Taller) " +
                   "AND Pay_Date BETWEEN @datafrom AND @dateto";

                    con.Open(); 
                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query ,con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto",SqlDbType.VarChar).Value = pick2.Value;
                    da.Fill(dtS);
                    view.Rows.Clear();
                    foreach (DataRow dr in dtS.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.00#}" , dr[4]);
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);

                    }

                    con.Close();
                    }
                else if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(searchtext) == false)
                {
                    //SEARCH WITH THREE PARAMETERS
                   var query = "SELECT Cash.ID, Cash.Names, Cash.Class, Cash.Fee_Name,Cash.Amount, " +
                       "Cash.Term,Cash.Fee_Type,Cash.Pay_Date FROM Cash WHERE Cash.ID IN (SELECT Taller.ID FROM Taller) AND Pay_Date BETWEEN @datefrom AND  @dateto" +
                       " AND Class LIKE '%' + @search + '%' OR Names LIKE '%' + @search + '%' OR Fee_Name LIKE '%' + @search + '%' OR Amount LIKE '%' + @search + '%'";
                    con.Open(); 
                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query,con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value =searchtext;
                     
                    da.Fill(dtS);
                    view.Rows.Clear();
                    foreach (DataRow dr in dtS.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.00#}" , dr[4]);
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);

                    }

                    con.Close();
                    }
                else
                {
                    //SEARCH WITH FOUR PARAMETERS
                  var  query = "SELECT Cash.ID, Cash.Names, Cash.Class, Cash.Fee_Name,Cash.Amount, " +
                       "Cash.Term,Cash.Fee_Type,Cash.Pay_Date FROM Cash WHERE Cash.ID IN (SELECT Taller.ID FROM Taller) AND Pay_Date BETWEEN @datefrom AND @dateto " +
                       " AND Term =@term AND Class=@search OR Names=@search OR Fee_Name=@search";

                    con.Open(); 
                    DataTable dtS = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query ,con);
                    da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = pick1.Value;
                    da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = pick2.Value;
                    da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = searchtext;
                    da.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;
                    da.Fill(dtS);
                    view.Rows.Clear();
                    foreach (DataRow dr in dtS.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.00#}" , dr[4]);
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = dr[6].ToString();
                        view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}" , dr[7]);

                    }

                    con.Close();
                    }
                    

            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("Search Error",ex);

            }
        }
        public void TallerTermSearch(DataGridView view, string searchtext)
        {
            //SEARCH ONLY THE TERM
            con.Open();
             
          var  query = "SELECT Cash.ID, Cash.Names, Cash.Class, Cash.Fee_Name,Cash.Amount, " +
                    "Cash.Term,Cash.Fee_Type,Cash.Pay_Date from Cash WHERE Cash.ID IN (SELECT Taller.ID FROM Taller) " +
                    " AND Term=@search"; 

            SqlDataAdapter display = new SqlDataAdapter(query,con);
            display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = searchtext;
          
            DataTable data = new DataTable();
            display.Fill(data);
            view.Rows.Clear();
            foreach (DataRow dat2 in data.Rows)
            {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dat2[0].ToString();
                view.Rows[n].Cells[1].Value = dat2[1].ToString();
                view.Rows[n].Cells[2].Value = dat2[2].ToString();
                view.Rows[n].Cells[3].Value = dat2[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.00#}", dat2[4]);
                view.Rows[n].Cells[5].Value = dat2[5].ToString();
                view.Rows[n].Cells[6].Value = dat2[6].ToString();
                view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}", dat2[7]);
            }
            con.Close();
        }
        public  void TallerSearchAll(DataGridView view, string searchtext)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {  
                con.Open();
                DataTable dtnow = new DataTable();
             var query="SELECT Cash.ID, Cash.Names, Cash.Class, Cash.Fee_Name,Cash.Amount, " +
                    "Cash.Term, Cash.Fee_Type, Cash.Pay_Date FROM Cash WHERE Cash.ID IN (SELECT Taller.ID FROM Taller) "+
                    " AND Class LIKE '%' + @search + '%' OR Names LIKE '%' + @search + '%' OR Fee_Name LIKE '%' + @search + '%' OR Amount LIKE '%' + @search + '%'";
          
            SqlDataAdapter danow = new SqlDataAdapter(query ,con);
            danow.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = searchtext;
                danow.Fill(dtnow);
                view.Rows.Clear();
                foreach (DataRow dat in dtnow.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[0].ToString();
                    view.Rows[n].Cells[1].Value = dat[1].ToString();
                    view.Rows[n].Cells[2].Value = dat[2].ToString();
                    view.Rows[n].Cells[3].Value = dat[3].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.00#}", dat[4]);
                    view.Rows[n].Cells[5].Value = dat[5].ToString();
                    view.Rows[n].Cells[6].Value = dat[6].ToString();
                    view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}", dat[7]);
                }

                con.Close();
        }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Search error",Ex);
            }
}
        #endregion
    }
}
