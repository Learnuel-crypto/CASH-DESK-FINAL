using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class PromoteStudents : Form
        {
            SqlConnection con = new DBConnection().getConnection();
        public PromoteStudents()
            {
            InitializeComponent();
                
            }

        private void btnclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void PromoteStudents_Load(object sender, EventArgs e)
            {
                StudentPromotion sp = new StudentPromotion();
                dataAccess.setClassName(listClass);
                
            }

        private void listClass_Click(object sender, EventArgs e)
            {
                
            }

        private void btnPromote_Click(object sender, EventArgs e)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtPresentClass.Text))
                        throw new Exception("No Class is selected, Select a Class");
                    if(string.IsNullOrEmpty(txtNewclass.Text))
                        throw new Exception("Enter New Class Name");
                     
                    var pSesid = dataAccess.GetSesseionID();
                    pSesid -= 1;
                     
                    con.Open();
                    DataTable dts = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(
                        " select Student_Id from Class where Class.Session_Id =@sessid AND Class.ClassName =@pclass ", con);
                da.SelectCommand.Parameters.AddWithValue("@sesid" , SqlDbType.VarChar).Value = pSesid;
                da.SelectCommand.Parameters.AddWithValue("@pclass" , SqlDbType.VarChar).Value = txtPresentClass.Text;
                DataSet ds = new DataSet();
                    da.Fill(dts);
                    da.Fill(ds);
                    int x = ds.Tables[0].Rows.Count;
                    if (x > 0)
                    {
                        if (MessageBox.Show("Confirm Class Promotion", "Student Promotion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //PROMOTE STUDENTS 
                            
                            foreach (DataRow dr in dts.Rows)
                            {
                                var id =dr[0];
                            //INSERT EACH OF THE RECORDS FOUND FROM THE SEARCH
                            SqlCommand cmd =
                                new SqlCommand();
                                       
                            cmd.Connection = con;
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new SqlParameter("@id" , SqlDbType.VarChar));
                            cmd.Parameters.Add(new SqlParameter("@sesid" , SqlDbType.VarChar));
                            cmd.Parameters.Add(new SqlParameter("@newclass" , SqlDbType.VarChar));
                            cmd.Parameters.Add(new SqlParameter("@year" , SqlDbType.VarChar));
                            cmd.Parameters["@id"].Value = id;
                            cmd.Parameters["@sesid"].Value = dataAccess.GetSesseionID();
                            cmd.Parameters["@newclass"].Value = txtNewclass.Text.ToUpper();
                            cmd.Parameters["@year"].Value = DateTime.Now.Year;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "INSERT INTO Class VALUES(@id,@sesid,@newclass,@year)";
                            cmd.ExecuteNonQuery();

                            }
                            
                            con.Close();
                            dataAccess.Description = "Promoted " + txtPresentClass.Text + " Class";
                            dataAccess.Activities();
                            MessageBox.Show("Operation Successful", "Student Promotion", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            txtNewclass.Clear();
                            txtPresentClass.Clear();
                           
                        }
                        
                    }
                    else
                    {
                    con.Close();
                        throw  new Exception("Class Cannot Be promoted Because \nnew Session Has Not Been Created");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nOperation Failed Try Again", "Student Promotion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
        try
        {
            txtPresentClass.Text = listClass.SelectedItem.ToString();
        }
        catch (Exception )
        {

        }
            
        }
        }
    }
