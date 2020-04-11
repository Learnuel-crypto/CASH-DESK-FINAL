using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class SalesWithNames
        {
        public static float Total = 0.00f;
        public static void AllNamesSales(DataGridView view , string search)
            {
            try
                {
                string query;
                SqlConnection con = new DBConnection().getConnection();
                if (string.IsNullOrEmpty(search))
                    {
                    query = "SELECT *FROM Student_Sales_View ORDER BY Sold_Date,First_Name,Item";

                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Total = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                        view.Rows[n].Cells[7].Value = dr[7].ToString();
                        int credit = Convert.ToInt32(dr[8]);
                        Total = Total + credit;
                        view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                        view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , dr[9]);
                        }
                    }
                else
                    {
                    query = "SELECT *FROM Student_Sales_View WHERE First_Name LIKE'%' + @search + '%'  OR Last_Name LIKE'%' + @search + '%' OR Item LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%' ORDER BY Sold_Date,First_Name,Item";
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Total = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                        view.Rows[n].Cells[7].Value = dr[7].ToString();
                        int credit = Convert.ToInt32(dr[8]);
                        Total = Total + credit;
                        view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                        view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , dr[9]);
                        }

                    }
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Sales search error" , ex);
                }
            }
        public static void NameSalesItem(DataGridView view , string search)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                string query;
                if (string.IsNullOrEmpty(search))
                    {
                    query = "SELECT *FROM Student_Sales_View ORDER BY Sold_Date,First_Name,Item";
                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Total = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                        view.Rows[n].Cells[7].Value = dr[7].ToString();
                        int credit = Convert.ToInt32(dr[8]);
                        Total = Total + credit;
                        view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                        view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyy}" , dr[9]);
                        }
                    }
                else
                    {
                    query = "SELECT *FROM Student_Sales_View WHERE Item = @search  ORDER BY Sold_Date,First_Name,Item";

                    SqlDataAdapter da = new SqlDataAdapter(query , con);
                    da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Total = 0;
                    view.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dr[0].ToString();
                        view.Rows[n].Cells[1].Value = dr[1].ToString();
                        view.Rows[n].Cells[2].Value = dr[2].ToString();
                        view.Rows[n].Cells[3].Value = dr[3].ToString();
                        view.Rows[n].Cells[4].Value = dr[4].ToString();
                        view.Rows[n].Cells[5].Value = dr[5].ToString();
                        view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                        view.Rows[n].Cells[7].Value = dr[7].ToString();
                        int credit = Convert.ToInt32(dr[8]);
                        Total = Total + credit;
                        view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                        view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyy}" , dr[9]);
                        }
                    }

                }catch (Exception ex)
                {
                throw new ExceptionHandling("Sales search error" , ex);
                }
            }
        public static void AllNamesBetweenDate(DataGridView view , DateTimePicker from , DateTimePicker To)
            {
            try
                {
                string query = "SELECT *FROM Student_Sales_View WHERE Sold_Date BETWEEN @datefrom AND @dateto ORDER BY Sold_Date,First_Name,Item";

                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query , con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = To.Value.ToString("MM/dd/yyyy");
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = dr[4].ToString();
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                    view.Rows[n].Cells[7].Value = dr[7].ToString();
                    int credit = Convert.ToInt32(dr[8]);
                    Total = Total + credit;
                    view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                    view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , dr[9]);
                    }
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Sales search error" , ex);
                }
            }
        public static void AllNamesBetweenDate(DataGridView view , DateTimePicker from ,string item)
            {
            try
                {
                string query = "SELECT *FROM Student_Sales_View WHERE Sold_Date = @datafrom AND Item = @item ORDER BY Sold_Date,First_Name,Item";

                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query , con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                da.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = dr[4].ToString();
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                    view.Rows[n].Cells[7].Value = dr[7].ToString();
                    int credit = Convert.ToInt32(dr[8]);
                    Total = Total + credit;
                    view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                    view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , dr[9]);
                    }
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Sales search error" , ex);
                }
            }
        public static void AllNamesBetweenDate(DataGridView view , DateTimePicker from)
            {
            try
                {
                string query = "SELECT *FROM Student_Sales_View WHERE Sold_Date =@datefrom  ORDER BY Sold_Date,First_Name,Item";

                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query , con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = dr[4].ToString();
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                    view.Rows[n].Cells[7].Value = dr[7].ToString();
                    int credit = Convert.ToInt32(dr[8]);
                    Total = Total + credit;
                    view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                    view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , dr[9]);
                    }
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Sales search error" , ex);
                }
            }
        public static void AllNamesBetweenDate(DataGridView view , DateTimePicker from , DateTimePicker To , string item)
            {
            try
                {
                string query = "SELECT *FROM Student_Sales_View WHERE Sold_Date BETWEEN @datefrom AND @dateto AND Item =@item  ORDER BY Sold_Date,First_Name,Item";

                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query , con);
                da.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = from.Value.ToString("MM/dd/yyyy");
                da.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = To.Value.ToString("MM/dd/yyyy");
                da.SelectCommand.Parameters.AddWithValue("@item" , SqlDbType.VarChar).Value = item;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Total = 0;
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = dr[4].ToString();
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value = string.Format("{0:00.#0}" , dr[6].ToString());
                    view.Rows[n].Cells[7].Value = dr[7].ToString();
                    int credit = Convert.ToInt32(dr[8]);
                    Total = Total + credit;
                    view.Rows[n].Cells[8].Value = string.Format("{0:00.#0}" , dr[8]);
                    view.Rows[n].Cells[9].Value = string.Format("{0:MM/dd/yyyy}" , dr[9]);
                    }
                }catch(Exception ex)
                {
                throw new ExceptionHandling("Sales search error" , ex);
                }
            }
        }
    }
