using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ShowTallerImage
{
    class DisplayTaller
    {
        public static string tallerID; 
        SqlConnection con = new DBConnection().getConnection();
        private void setTallerId(string id)
        {
            tallerID = id;
        }
        
        public void CheckTallerID(int Id, Button TallerButton)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Taller where ID =@id",con);
                da.SelectCommand.Parameters.AddWithValue("@id" , SqlDbType.VarChar).Value = Id;
                DataTable dt = new DataTable();
                da.Fill(dt);
                int x = dt.Rows.Count;
                if (x > 0)
                {
                    TallerButton.Visible = true;
                    foreach (DataRow Rec in dt.Rows)
                    {
                        var id = Rec[1].ToString();
                        tallerID = id;
                    }
                    
                }
                else
                {
                    TallerButton.Visible = false;
                    tallerID = null;
                    
                }  
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
        }
         
    } 
}
