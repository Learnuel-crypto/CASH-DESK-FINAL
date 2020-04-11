using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class TermReport
    {
        public TermReport()
        {

        }

        public void displayFirstTerm(DataGridView view)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT Session_Id, Fee_Name,Amount,Status,PayDate,Fees.Class_Id,Fees.Student_Id FROM FirstTerm " +
                    "JOIN Fees ON Fees.Fee_Id =FirstTerm.Fee_Id AND Session_Id IS NOT NULL ORDER BY PayDate DESC", con);
            da.Fill(dts);
            view.Rows.Clear();
            foreach (DataRow drRec in dts.Rows)
            { 
                //DISPLAY THE RECORDS IN THE GRID VIEW C 
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = drRec[0].ToString();
                view.Rows[n].Cells[1].Value = drRec[1].ToString();
                view.Rows[n].Cells[2].Value =string.Format("{0:00.#0}" ,drRec[2]);
                view.Rows[n].Cells[3].Value = drRec[3].ToString();
                view.Rows[n].Cells[4].Value = drRec[4].ToString();
                view.Rows[n].Cells[5].Value = drRec[5].ToString();
               view.Rows[n].Cells[6].Value = drRec[6].ToString();

            }
        }

        public void displaySecondTerm(DataGridView view)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dtsec = new DataTable(); 
                SqlDataAdapter das =
                new SqlDataAdapter(
                    "SELECT Session_Id, Fee_Name,Amount,Status,PayDate,Fees.Class_Id,Fees.Student_Id FROM SecondTerm " +
                    "JOIN Fees ON Fees.Fee_Id =SecondTerm.Fee_Id AND Session_Id IS NOT NULL ORDER BY PayDate DESC", con);
            das.Fill(dtsec);
            view.Rows.Clear();
            foreach (DataRow drRec in dtsec.Rows)
            { 
                //DISPLAY THE RECORDS IN THE GRID VIEW C 
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = drRec[0].ToString();
                view.Rows[n].Cells[1].Value = drRec[1].ToString();
                view.Rows[n].Cells[2].Value =string.Format("{0:00.#0}" ,drRec[2]);
                view.Rows[n].Cells[3].Value = drRec[3].ToString();
                view.Rows[n].Cells[4].Value = drRec[4].ToString();
                view.Rows[n].Cells[5].Value = drRec[5].ToString();
                view.Rows[n].Cells[6].Value = drRec[6].ToString();

            }
        }
        public void displayThirdTerm(DataGridView view)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dtThird = new DataTable(); 
                SqlDataAdapter dat=
                new SqlDataAdapter(
                    "SELECT Session_Id, Fee_Name,Amount,Status,PayDate,Fees.Class_Id,Fees.Student_Id FROM ThirdTerm " +
                    "JOIN Fees ON Fees.Fee_Id =ThirdTerm.Fee_Id AND Session_Id IS NOT NULL ORDER BY PayDate DESC", con);
            dat.Fill(dtThird);
            view.Rows.Clear();
            foreach (DataRow drRec in dtThird.Rows)
            { 
                //DISPLAY THE RECORDS IN THE GRID VIEW 
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = drRec[0].ToString();
                view.Rows[n].Cells[1].Value = drRec[1].ToString();
                view.Rows[n].Cells[2].Value =string.Format("{0:00.#0}" ,drRec[2]);
                view.Rows[n].Cells[3].Value = drRec[3].ToString();
                view.Rows[n].Cells[4].Value = drRec[4].ToString();
                view.Rows[n].Cells[5].Value = drRec[5].ToString();
                view.Rows[n].Cells[6].Value = drRec[6].ToString();

            }
        }

        public void displayName(DataGridView view,TextBox name, int classid,int studid)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dtName = new DataTable();
            SqlDataAdapter daName = new SqlDataAdapter( "SELECT Names.First_Name,Names.Last_Name,Names.Sex FROM Names WHERE Name_Id IN  (SELECT Name_Id FROM Students WHERE Student_Id =@studid );", con);
            daName.SelectCommand.Parameters.AddWithValue("@studid" , SqlDbType.VarChar).Value = studid;
            daName.Fill(dtName);
            view.Rows.Clear();
            foreach (DataRow drRec in dtName.Rows)
            {
                //DISPLAY THE RECORDS IN THE GRID VIEW 
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = drRec["First_Name"].ToString();
                view.Rows[n].Cells[1].Value = drRec["last_Name"].ToString();
                view.Rows[n].Cells[2].Value = drRec["Sex"].ToString();
            }
            displayClass(name,classid);
        }

        private void displayClass(TextBox name, int classid)
            {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dtsec = new DataTable();
                SqlDataAdapter das =
                    new SqlDataAdapter(
                        "SELECT Class.ClassName FROM Class WHERE Class_Id=@classid", con);
            das.SelectCommand.Parameters.AddWithValue("@classid" , SqlDbType.VarChar).Value = classid;
            das.Fill(dtsec);
                 
                foreach (DataRow drRec in dtsec.Rows)
                {
                    //DISPLAY THE CLASS IN THE TEXTBOX 
                    name.Text = drRec["ClassName"].ToString();
                    
                }
        }
    }
}
