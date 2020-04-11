using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class dataAccess
    {
        public static int move = 0;
        public static int nameId;
        public static int eventId;
        public static int DcashId;
        public static string Description;  
        public static DateTime Sdate =DateTime.Today.Date.Date;
        //CONSTUCTOR
        public dataAccess()
        {
             
            
        }

        //GETTERS
        public static void setNames(ComboBox comb)
        {

            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Names";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comb.Items.Add(dr["First_Name"].ToString() + "  " + dr["Middle_Name"].ToString() + "  " + dr["Last_Name"].ToString());
            }
        }
        public static void setSessionYear(ListBox text)
            {
            //SET THE YEAR OF THE SCHOOL SESSION THE LIST BOX CONTROL
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Session.Start_Year FROM Session";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                {
                text.Items.Add(string.Format("{0:MM/dd/yyy}",dr["Start_Year"]));
                }
            }
        public static void setClassName(ListBox text)
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
                text.Items.Add((dr["ClassName"].ToString()));
                }
            }
        public static void setClassName(ComboBox text)
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
                text.Items.Add((dr["ClassName"].ToString()));
            }
        }
        public static void setFeeName(ComboBox Fee)
        {
            //GET THE FEE NAME FROM THE DATABASE
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT  Fee_Name FROM SetFees";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Fee.Items.Add(dr["Fee_Name"].ToString());
            }
        }
        public static void clearNames(TextBox c1, TextBox c2 , TextBox c3 , TextBox c4)
        {
            c1.Clear(); c2.Clear(); c3.Clear(); c4.Clear();
        }
        public static void Activities(){
        //TRACK THE ACTIVITIES OF THE USER
        //
        SqlConnection con = new DBConnection().getConnection();
        try
        {
            con.Open();
                SqlCommand cmdActivity = new SqlCommand();
                cmdActivity.Connection = con;
                cmdActivity.Parameters.Clear();
                cmdActivity.Parameters.AddWithValue("@Description" , Description);
                cmdActivity.Parameters.AddWithValue("@Time" , Form1.Dtime);
                cmdActivity.Parameters.AddWithValue("@Date" , Sdate);
             cmdActivity.CommandText= "INSERT INTO Activity(Description,Time,Date)  VALUES(@Description,@Time,@Date)";
            cmdActivity.ExecuteNonQuery();
            con.Close();
            }
        catch(Exception Ex){
            con.Close();
            MessageBox.Show(Ex.Message, "Activity Error");
             
                }
            }
         
        public static void displaysActivity(DataGridView Activity)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Activity ORDER BY Date,Description DESC", con);
            da.Fill(dts);
            Activity.Rows.Clear();
            foreach (DataRow dr in dts.Rows)
            {
                //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                int n = Activity.Rows.Add();
                Activity.Rows[n].Cells[0].Value = dr[0].ToString();
                Activity.Rows[n].Cells[1].Value = dr[1].ToString();
                Activity.Rows[n].Cells[2].Value = dr[2].ToString();
                Activity.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyyy}",dr[3]);
                 
            }
            con.Close();

        }
        public static int insertEvent(string eventName, string feeName, string amount, string setDate){
         
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
                //INSERT EVENT NAMES INTO EVENT TABLE 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@eventname", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@amount", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.VarChar));
                cmd.Parameters["@eventname"].Value = eventName;
                cmd.Parameters["@feename"].Value = feeName;
                cmd.Parameters["@amount"].Value = amount;
                cmd.Parameters["@date"].Value = setDate;
                cmd.CommandText = "INSERT INTO Events VALUES(@eventname, @feename,@amount,@date )";
                cmd.ExecuteNonQuery();
                dataAccess.Description = "Created Event \"" + eventName + "\"";
                dataAccess.Activities();
                MessageBox.Show("Event Create Successfully", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //GET THE JUST EVENT ID
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT max(Event_Id) FROM Events", con);
                da.Fill(dt);
                var pos = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    pos = Convert.ToInt32(dr[0]);
                    //MessageBox.Show(pos.ToString());
                    eventId = pos;
                }
                con.Close();
                return eventId;
            
            }
        public static int GetSesseionID()
        {
            SqlConnection con = new DBConnection().getConnection();
            try
                {
                DataTable dtS = new DataTable();
                SqlDataAdapter daS = new SqlDataAdapter("SELECT max(Session_Id) FROM Session", con);
                daS.Fill(dtS);
                int sesId = dtS.Rows.Count;
                if (sesId <= 0)
                    {
                    throw new Exception("No Session Has Been Created");
                   
                     
                    }else{
                 foreach(DataRow dr in dtS.Rows){
                 sesId =Convert.ToInt32(dr[0]);
                     }
                     
                    }
                    return sesId;
                     
                }
            catch(Exception Ex){
            throw new ExceptionHandling("You Need To Create School Session First", Ex);
                }
        }

        public static void Students()
        {
            SqlConnection con = new DBConnection().getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }
        public static void displays(TextBox fn, TextBox mn, TextBox ln, TextBox gen)
        {
            //DISPLAY THE NAME IN THEIR TEXT BOXES
            SqlConnection con = new DBConnection().getConnection();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Names", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fn.Text = dt.Rows[move][0].ToString();
            mn.Text = dt.Rows[move][1].ToString();
            ln.Text = dt.Rows[move][2].ToString();
            gen.Text = dt.Rows[move][3].ToString();
             
        }
    }
}
