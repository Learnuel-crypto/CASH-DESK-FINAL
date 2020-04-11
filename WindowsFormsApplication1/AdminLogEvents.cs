using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class AdminLogEvents
    {

        public static void AdminLogs(DataGridView Activity)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM AdminLog ORDER BY ID DESC", con);
            da.Fill(dts);
            Activity.Rows.Clear();
            foreach (DataRow dr in dts.Rows)
            {
                //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                int n = Activity.Rows.Add();
                Activity.Rows[n].Cells[0].Value = dr[0].ToString();
                Activity.Rows[n].Cells[1].Value = dr[1].ToString();
                Activity.Rows[n].Cells[2].Value = dr[2].ToString();
                Activity.Rows[n].Cells[3].Value = dr[3];
                Activity.Rows[n].Cells[4].Value =string.Format("{0:MM/dd/yyyy}", dr[4]);

            }

            con.Close();
        }

        public static void AdminlogsToday(DataGridView log)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            { 
                con.Open();
                DataTable dtToday = new DataTable();
                SqlDataAdapter daToday =
                    new SqlDataAdapter(
                        "SELECT  *from AdminLog WHERE Date =@date", con);
                daToday.SelectCommand.Parameters.AddWithValue("@date" , SqlDbType.VarChar).Value = dataAccess.Sdate;
                daToday.Fill(dtToday);
                log.Rows.Clear();
                foreach (DataRow drToday in dtToday.Rows)
                {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = log.Rows.Add();
                    log.Rows[n].Cells[0].Value = drToday[0].ToString();
                    log.Rows[n].Cells[1].Value = drToday[1].ToString();
                    log.Rows[n].Cells[2].Value = drToday[2].ToString();
                    log.Rows[n].Cells[3].Value = drToday[3];
                    log.Rows[n].Cells[4].Value =string.Format("{0:MM/dd/yyyy}", drToday[4]);
                }
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message +"\nLog Event Error", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void DeleleAdminLogs()
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete AdminLog", con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataAccess.Description = "Deleted Admin Logs";
                dataAccess.Activities();
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message + "\nLog Event Error", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
