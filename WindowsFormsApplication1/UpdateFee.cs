using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace WindowsFormsApplication1
    {
    public class UpdateFee
        {
        SqlConnection con = new DBConnection().getConnection();
        private static bool update = true;
        public UpdateFee()
            {

            }
        public static bool isUpdate(string sessionid, string feename)
        {
            SqlConnection con = new DBConnection().getConnection();
            var first = "SELECT Session_Id FROM FirstTerm  WHERE  Fee_Name =@feename AND Session_Id =@sesid";
            SqlDataAdapter da = new SqlDataAdapter(first,con);
            da.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarChar).Value = sessionid;
            da.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feename;
            DataTable dtfirst = new DataTable();
            da.Fill(dtfirst);
            int x = dtfirst.Rows.Count;
            if (x > 0)
            {
              return  update = false;
            }
            var Second = "SELECT Session_Id FROM SecondTerm  WHERE   Fee_Name =@feename AND Session_Id =@sesid";
            SqlDataAdapter da2 = new SqlDataAdapter(Second,con);
            da2.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarChar).Value = sessionid;
            da2.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feename;
            DataTable dtsecond = new DataTable();
            da2.Fill(dtsecond);
            int y = dtsecond.Rows.Count;
            if (y > 0)
            {
                return update = false;
            }

            var third = "SELECT Session_Id FROM ThirdTerm  WHERE   Fee_Name =@feename AND Session_Id =@sesid";
            SqlDataAdapter da3 = new SqlDataAdapter(third,con);
            da3.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarChar).Value = sessionid;
            da3.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = feename;
            DataTable dtthird = new DataTable();
            da3.Fill(dtthird);
            int b = dtthird.Rows.Count;
            if (b > 0)
            {
                return update = false;
            }
            return update;
        }

        public static void viewFees(DataGridView view){

            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SetFees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int x = dt.Rows.Count;
            if (x > 0)
            {
                view.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dr[0].ToString();
                    view.Rows[n].Cells[1].Value = dr[1].ToString();
                    view.Rows[n].Cells[2].Value = dr[2].ToString();
                    view.Rows[n].Cells[3].Value = dr[3].ToString();
                    view.Rows[n].Cells[4].Value =string.Format("{0:00.#0}", dr[4]);
                    view.Rows[n].Cells[5].Value = dr[5].ToString();
                    view.Rows[n].Cells[6].Value =string.Format("{0:MM/dd/yyyy}", dr[6]);

                }

            }
        }
        
        public static void updateFee(string feeid,string section, string feename, string amount)
        {
            SqlConnection con = new DBConnection().getConnection();
            try{
                con.Open();
                
                SqlCommand cmd = new SqlCommand(); 
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@section", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@amount", SqlDbType.VarChar));
                cmd.Parameters["@id"].Value = feeid;
                cmd.Parameters["@section"].Value = section;
                cmd.Parameters["@feename"].Value = feename;
                cmd.Parameters["@amount"].Value = amount; 
                cmd.CommandText = "UPDATE SetFees SET Section=@section , Fee_Name=@feename , Amount=@amount  WHERE Set_Id =@id ";
                cmd.ExecuteNonQuery();
                con.Close(); 
                dataAccess.Description = "Updated a Fee Successfully";
                dataAccess.Activities();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Fee could not be update", Ex);
            }
        }
        public static void DeletFee(string feeid)
        {
            SqlConnection con = new DBConnection().getConnection();
            try{
                con.Open();
                
                SqlCommand cmd = new SqlCommand("DELETE FROM SetFees WHERE Set_Id ='"+feeid+"'");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Fee could not be update", Ex);
            }
        }
        }
    }
