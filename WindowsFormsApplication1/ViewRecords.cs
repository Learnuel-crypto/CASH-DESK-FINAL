using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
    {
    class ViewRecords
        {
        public static void FirstTerm(DataGridView view)
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM View_First_Term_Fees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dr[0].ToString();
                view.Rows[n].Cells[1].Value = dr[1].ToString();
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = dr[4].ToString();
                view.Rows[n].Cells[5].Value =string.Format("{0:00.#0}", dr[5]);
                view.Rows[n].Cells[6].Value = dr[6].ToString();
                view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}",dr[7]);
                 

                }
            }
        public static void SecondTerm(DataGridView view)
            { 
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM View_Second_Term_Fees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
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
                    view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}", dr[7]);

                }
            }
        public static void ThirdTerm(DataGridView view)
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM View_third_Term_Fees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
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
                    view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}", dr[7]);

                }
            }
        public static void SessionSet(DataGridView view)
            {
            //VIEW THE SESSION AND THE SET FEES
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM View_Session_Fees_Set", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                int n = view.Rows.Add(); 
                view.Rows[n].Cells[0].Value =string.Format("{0:MM/dd/yyyy}", dr[0] );
                view.Rows[n].Cells[1].Value =string.Format("{0:MM/dd/yyyy}", dr[1] );
                view.Rows[n].Cells[2].Value = dr[2].ToString();
                view.Rows[n].Cells[3].Value = dr[3].ToString();
                view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}",dr[4]);
                view.Rows[n].Cells[5].Value = dr[5].ToString();
                view.Rows[n].Cells[6].Value = string.Format("{0:MM/dd/yyyy}", dr[6]);
                }
            }
        public static void Students(DataGridView view)
            {
            //VIEW STUDENTS AND THEIRE CLASS
           SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM View_Students_Class", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            view.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value = dr[4].ToString();
                     
                }
            }
        public static void Events(DataGridView view)
            {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM View_Event_Fees_Paid", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
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
                    view.Rows[n].Cells[7].Value = string.Format("{0:MM/dd/yyyy}", dr[7]);

                }
            }
        }
    }
