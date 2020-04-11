using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
    {
    public class Fees
    {
     
       private string Section;
       private string FeeName;
       private double Amount;
       private int Installment;
       private string DateSet;
       //GETTES
      
       public string getSection() { return this.Section; }
       public string getFeeName() { return this.FeeName; }
       public double getAmount() { return this.Amount; }
       public int getInstallment() { return this.Installment; }
       public string getDateSet() { return this.DateSet; }
        
       //CONSTRUCTORE
       public Fees()
       {
        
       }
      
       public void setAmount(double  amount)
       {
        
           if ( amount<=0)
           {
               throw new Exception("Enter Fee Amount");
                
           }
           else { this.Amount = amount; }
       }

       public void setFeeName(string feename)
       {
           if (string.IsNullOrEmpty(feename) )
           {
               throw new Exception("Fee Name Cannot be empty");
                
           }
           else { this.FeeName = feename; }
       }

       public void setSection(string section)
       {
           if (string.IsNullOrEmpty(section) )
           {
               throw new Exception("Please enter Section");
                
           }
           else { this.Section = section; }
       }
       public void setInstallment(int instal) {this.Installment = instal; }
       public void setDateSet(string da) { this.DateSet = da; }

       public void setFees(string section,string feename, string amount, int install, string dateset)
       {
           SqlConnection con = new DBConnection().getConnection();
           try
               {
               con.Open();
               //GET THE SESSION ID FROM SESSION TABLE
               
                SqlCommand cmd = new SqlCommand();//"INSERT INTO SetFees VALUES('" + id + "','" + section + "', '" + feename + "','" + amount + "','" + install + "','" + dateset + "' )", con);
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@section" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@feename" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@amount" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@install" , SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@dateset" , SqlDbType.VarChar));
                cmd.Parameters["@id"].Value = dataAccess.GetSesseionID();
                cmd.Parameters["@section"].Value = section;
                cmd.Parameters["@feename"].Value = feename;
                cmd.Parameters["@amount"].Value = amount;
                cmd.Parameters["@install"].Value = install;
                cmd.Parameters["@dateset"].Value = dateset;
                cmd.CommandText = "INSERT INTO SetFees VALUES(@id , @section  , @feename , @amount , @install , @dateset )";
                cmd.ExecuteNonQuery();
               con.Close();
               MessageBox.Show("Fee Set Successful", "Fee Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
               dataAccess.Description = "Set Fees Successfully";
               dataAccess.Activities();
               }
           catch(Exception Ex){
           con.Close();
           throw new ExceptionHandling("Create Academic Session First", Ex);
               }
           
       }
        
        public static void DisplayFeeName(ComboBox feename)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Fee_Name FROM SetFees WHERE Fee_Name IS NOT null" , con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                feename.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                    {
                    feename.Items.Add(dr["Fee_Name"].ToString());
                    }
                }catch (Exception)
                {

                }
            }
        public static void CheckFeeStatus(string sessionid, string feename){
             SqlConnection con = new DBConnection().getConnection();
            try
            {
               //CHECK IF THE FEE CAN BE UPDATED OR NOT
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Session_id FROM FirstTerm WHERE Session_id=@sesid AND Fee_Name =@feename", con);
                da.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarBinary).Value = sessionid;
                da.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarBinary).Value = feename;
                DataTable dt = new DataTable();
                da.Fill(dt);
                int x = dt.Rows.Count;
                if (x > 0)
                {
                    throw new Exception("This fee has record in other tables");
                }

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT Session_id FROM SecondTerm WHERE Session_id=@sesid AND Fee_Name =@feename", con);
                da2.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarBinary).Value = sessionid;
                da2.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarBinary).Value = feename;
                DataTable dt2 = new DataTable();
                da2.Fill(dt);
                int y = dt.Rows.Count;
                if (y > 0)
                {
                    throw new Exception("This fee has record in other tables");
                }
                SqlDataAdapter da3 = new SqlDataAdapter("SELECT Session_id FROM ThirdTerm WHERE Session_id=@sesid AND Fee_Name =@feename", con);
                da3.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarBinary).Value = sessionid;
                da3.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarBinary).Value = feename;
                DataTable dt3 = new DataTable();
                da3.Fill(dt);
                int b = dt.Rows.Count;
                if (b > 0)
                {
                    throw new Exception("This fee has record in other tables");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("This fee cannot be edited", ex);
            }
    }
    }
}
