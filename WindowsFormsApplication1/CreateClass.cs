using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class CreateClass : Form
    {
        private int studId = 0;
        private int sesId=0;
        SqlConnection con = new DBConnection().getConnection();
        public CreateClass()
        {
            InitializeComponent();

        }

        private void CreateClass_Load(object sender, EventArgs e)
        {
              
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM Class WHERE Class.Student_Id IN(SELECT Student_Id FROM Students WHERE Students.Name_Id='" +
                dataAccess.nameId + "');"; 
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                studId = Convert.ToInt32(dr["Student_Id"]); 
                listClass.Items.Add(dr["ClassName"].ToString().ToUpper());
                sesId = Convert.ToInt32(dr["Session_Id"]); 

            }
            con.Close();
             
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void listClass_Click(object sender, EventArgs e)
            {
            try
                {
                txtClass.Text = listClass.SelectedItem.ToString();
                lblclass.Text = listClass.SelectedItem.ToString();
                }catch(NullReferenceException ex){

                
                    }
            catch(Exception Ex){
             
                }
            }

        private void btnPromote_Click(object sender, EventArgs e)
            {
            try
                { 
                ///<summary>
                ///<promote selected class to new class>
                ///<summar>
                DataTable dtS2 = new DataTable();
                SqlDataAdapter daS2 = new SqlDataAdapter("SELECT ClassName FROM Class WHERE Student_Id=@studid AND Session_Id=@sesid", con);
                daS2.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value = studId;
                daS2.SelectCommand.Parameters.AddWithValue("@sesid" , SqlDbType.VarChar).Value = dataAccess.GetSesseionID();
                DataSet dsCheck = new DataSet();
                    daS2.Fill(dtS2);
                    daS2.Fill(dsCheck);
                var x = dsCheck.Tables[0].Rows.Count;
                   
                    if (x > 0)
                        throw new Exception("Student Class is current Session\nYou have to Create new Session");
                con.Open();
                if (string.IsNullOrEmpty(txtNewclass.Text))
                    {
                    throw new Exception("New class Name Can't be Empty'");
                    }
                else
                    {
                    //promote the student
                    string promote = "INSET INTO Class VALUES('" + studId + "','" + dataAccess.GetSesseionID() + "','" + txtNewclass.Text.ToUpper() + "','" + DateTime.Now.Year + "')";
                    SqlCommand sqlpromote = new SqlCommand(promote, con);
                    SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Class WHERE Student_Id=@studid  AND ClassName =@newclass AND Session_Id =@sesid", con);
                    da.SelectCommand.Parameters.AddWithValue("@studid" , SqlDbType.VarChar).Value = studId;
                    da.SelectCommand.Parameters.AddWithValue("@sesid" , SqlDbType.VarChar).Value =sesId;
                    da.SelectCommand.Parameters.AddWithValue("@newclass" , SqlDbType.VarChar).Value = txtNewclass.Text;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                        {
                        throw new Exception("Student Class Already Exist" );

                        }
                    else
                        {
                            if (MessageBox.Show("Make sure its a new Academic Session And\nYou must have created a new Session\n Before Promotng Students",
                                    "Student Promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                                DialogResult.Yes)
                            {
                               //ADD CODE TO CREATE NEW SESSION HERE IN THE FUTURE VERSION
                                sqlpromote.ExecuteNonQuery();
                                this.listClass.Items.Add(txtNewclass.Text.ToUpper());
                                MessageBox.Show("Promotion Successful", "Promotion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.Close();
                            }
                            con.Close();
                        }
                    }
                }
            catch(NullReferenceException Ex){
            con.Close();
            MessageBox.Show("Please Select A Class Name", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            catch(Exception Ex){
            con.Close();
            
            MessageBox.Show(Ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
            {
            try
                {
                //update the student class
                this.listClass.Items.Insert(listClass.SelectedIndex, txtClass.Text.ToUpper());
                this.listClass.Items.Remove(listClass.SelectedItem);
                con.Open();
                string sql = "UPDATE Class SET ClassName=@newclass WHERE ClassName=@classname AND Student_Id=@studentid";

                SqlCommand sqlupdate = new SqlCommand();
                sqlupdate.Connection = con;
                sqlupdate.CommandType = CommandType.Text;
                sqlupdate.Parameters.Clear();
                sqlupdate.Parameters.Add(new SqlParameter("@newclass", SqlDbType.VarChar));
                sqlupdate.Parameters.Add(new SqlParameter("@classname" , SqlDbType.VarChar));
                sqlupdate.Parameters.Add(new SqlParameter("@studentid" , SqlDbType.VarChar));
                sqlupdate.Parameters["@newclass"].Value = txtClass.Text;
                sqlupdate.Parameters["@classname"].Value = lblclass.Text;
                sqlupdate.Parameters["@studentid"].Value = studId;
                sqlupdate.CommandText = sql;
                sqlupdate.ExecuteNonQuery();
                    dataAccess.Description = "Updated Student Class";
                    dataAccess.Activities();
                MessageBox.Show("Update Successful");
                con.Close();
                
                }
            catch(NullReferenceException Ex){
            MessageBox.Show("Please Select a Class to Update", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            catch(Exception Ex){
 
               MessageBox.Show("Please Select a Class to Update", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                    }

            }
    }
}