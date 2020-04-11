using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public class Cash
    {
        SqlConnection con = new DBConnection().getConnection();

        public static bool paid = false;
        public Cash()
        {
             
        }
        public static bool isPaid()
            {
            return paid;
            }
      public void insertCastPay(TextBox name, TextBox clas, ComboBox fee,ComboBox term, TextBox amount, DateTimePicker date,ComboBox instal, string feetype, string year)
        {
            try
            { 
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Names" , name.Text);
                cmd.Parameters.AddWithValue("@Class" ,clas.Text );
                cmd.Parameters.AddWithValue("@Fee_Name" , fee.SelectedItem);
                cmd.Parameters.AddWithValue("@Term" , term.SelectedItem);
                cmd.Parameters.AddWithValue("@Amount" , amount.Text);
                cmd.Parameters.AddWithValue("@Pay_Date" , date.Value.Date);
                cmd.Parameters.AddWithValue("@Installment" , instal.SelectedItem);
                cmd.Parameters.AddWithValue("@Fee_Type" , feetype);
                cmd.Parameters.AddWithValue("@Year" , year);
                cmd.Parameters.AddWithValue("@Time" , Form1.Dtime);
                cmd.CommandText= "INSERT INTO Cash(Names,Class,Fee_Name,Term,Amount,Pay_Date,Installment,Fee_Type,Year,Time) VALUES(@Names,@Class,@Fee_Name,@Term,@Amount,@Pay_Date,@Installment,@Fee_Type,@Year,@Time )";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            MessageBox.Show(Ex.Message + "\nCash insertion Failed","Cash Error");
            }
            
        }
        public void insertEventPay(TextBox name, TextBox clas, TextBox fee, ComboBox term, TextBox amount, DateTimePicker date, ComboBox instal, string feetype )
        {
            try
            {  
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Names" , name.Text);
                cmd.Parameters.AddWithValue("@Class" , clas.Text);
                cmd.Parameters.AddWithValue("@Fee_Name" , fee.Text);
                cmd.Parameters.AddWithValue("@Term" , term.SelectedItem);
                cmd.Parameters.AddWithValue("@Amount" , amount.Text);
                cmd.Parameters.AddWithValue("@Pay_Date" , date.Value.Date);
                cmd.Parameters.AddWithValue("@Installment" , instal.SelectedItem);
                cmd.Parameters.AddWithValue("@Fee_Type" , feetype);
                cmd.Parameters.AddWithValue("@Year" , DateTime.Now.Year.ToString());
                cmd.Parameters.AddWithValue("@Time" , Form1.Dtime);
                cmd.CommandText = "INSERT INTO Cash(Names,Class,Fee_Name,Term,Amount,Pay_Date,Installment,Fee_Type,Year,Time) VALUES(@Names,@Class,@Fee_Name,@Term,@Amount,@Pay_Date,@Installment,@Fee_Type,@Year,@Time )";
                cmd.ExecuteNonQuery();
                con.Close(); 
                 
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message + "\nCash insertion Failed", "Cash Error");
            }

        }

    }
}
