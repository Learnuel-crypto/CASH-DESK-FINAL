using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class EventPayment
    {
        public static int EventId;
        public static string EventName;

        public EventPayment()
        {

        }

        public static void setEventName(ComboBox Fee )
        {
            //GET THE FEE NAME FROM THE DATABASE
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Events";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Fee.Items.Add(dr["Name"].ToString());
            }

            con.Close();
        }
            public static void setEventFeeName(ComboBox Name,TextBox fee)
            {
                //GET THE FEE NAME FROM THE DATABASE
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Events WHERE Name=@name";
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar));
                cmd.Parameters["@name"].Value = Name.SelectedItem;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                EventName = Name.SelectedItem.ToString();
                foreach (DataRow dr in dt.Rows)
                {
                    fee.Text=(dr["Fee_Name"].ToString());
                    EventId = Convert.ToInt32(dr["Event_Id"]);
                    //MessageBox.Show(EventId.ToString(), "event Id");
                }
                con.Close();
        }
        public static void setEventClassName(ListBox text, TextBox Com)
        {
            SqlConnection con = new DBConnection().getConnection();
            text.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM EventClass WHERE EventClass.Event_Id in(SELECT Event_Id FROM Events WHERE Fee_Name =@feename)";
            cmd.Parameters.Add(new SqlParameter("@feename" , SqlDbType.VarChar));
            cmd.Parameters["@feename"].Value =Com.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)

            {
                
                text.Items.Add((dr["Class"].ToString()));
            }
            con.Close();
        }

        public static void DisplayEventPayments(DataGridView view)
        {
            SqlConnection con = new DBConnection().getConnection();
            SqlCommand query = new SqlCommand("SELECT Fee_Name,Term, Class,Amount,Status,EventPay.Date,Student_Id," +
                                              " Event_Id FROM EventPay JOIN  EventClass ON EventClass.Id=EventPay.Id ORDER" +
                                              " BY Pay_Id DESC;", con);
            SqlDataAdapter display = new SqlDataAdapter(query);
            DataTable data = new DataTable();
            display.Fill(data);
            view.Rows.Clear();
            foreach (DataRow dat in data.Rows)
            {
                int n = view.Rows.Add();
                view.Rows[n].Cells[0].Value = dat[0].ToString();
                view.Rows[n].Cells[1].Value = dat[1].ToString();
                view.Rows[n].Cells[2].Value = dat[2].ToString();
                view.Rows[n].Cells[3].Value = string.Format("{0:00.#0}",dat[3] );
                view.Rows[n].Cells[4].Value =  dat[4].ToString();
                view.Rows[n].Cells[5].Value =  dat[5].ToString();
                 
                 

            }
        }
    }
}
