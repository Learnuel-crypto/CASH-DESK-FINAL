using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class StudentPromotion
    {

        public int StudentId { get; set; }

        public StudentPromotion()
        {

        }

        public void setStudentId(int id)
        {
            this.StudentId = id;
        }

        public void promoteClass(ListBox text)
        {
            //SET THE YEAR OF THE SCHOOL SESSION THE LIST BOX CONTROL

            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT ClassName FROM Class";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var id = Convert.ToInt32(dr["Student_Id"]);
                setStudentId(id);
                text.Items.Add((dr["ClassName"].ToString()));
            }
        }
    }
}
