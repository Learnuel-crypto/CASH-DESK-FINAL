using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Secure;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
    {
    public partial class LoginForm : Form
    {
        SqlConnection con = new DBConnection().getConnection();
        
        int error = 0;
        public LoginForm()
        {
            InitializeComponent();
            
            }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
                {
                con.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Admin" , con);
                da.Fill(ds);
                da.Fill(dt);
                int x = dt.Rows.Count;
                if (x <= 0)
                    {

                    }
                else
                    {
                    btnCreateAdmin.Visible = false;
                    btnResetPass.Visible = false;
                    btnImportDb.Visible = false;
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message +"\nApplication was unable to start correctly, Restart application" , "Cash Desk Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                Application.Exit();
                }
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            var register = new RegistrationForm();
            this.Hide();
            register.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Exit Application", "Cash Desk", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                { 
                    Application.Exit();
                }
            }
            catch (Exception)
            {

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //THE HOLE TO CREATE ANOTHER USER FROM OUTSIDE OF THE APPLICATION
                if (SecuredPass.Encrypt(txtUsername.Text) == SecuredPass.Username() && SecuredPass.Encrypt(txtPassword.Text) == SecuredPass.Password())
                { 
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT UserName,Password FROM Admin ORDER BY ID  ASC " , con);
                        da.Fill(dt);
                        int x = dt.Rows.Count; 
                        if (x > 0)
                            {
                            foreach (DataRow dr in dt.Rows)
                                {
                                AdminLog.Admin = dr["UserName"].ToString();
                            AdminLog.AdminPass = dr["Password"].ToString();
                            break;
                                } 
                            }
                    AdminLog.ForgottenPassword = true; 
                    btnCreateAdmin.Visible = true;
                    txtUsername.Text = "";
                } 
                AdminLog.LogIn(txtUsername.Text, txtPassword.Text);
               
                if (txtUsername.Text == AdminLog.Admin && SecuredPass.Encrypt( txtPassword.Text) == AdminLog.AdminPass)
                {
                    var mainApp = new Form1();
                    this.Hide();
                    //USE ASYNC HERE
                    new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, btnLogin.Text); }).Start();
                    mainApp.Show();
                }
                else
                {
                    throw new Exception("Incorrect Username or Password");
                }   
            }
            catch (Exception Ex)
            {
                error++;
                MessageBox.Show(Ex.Message, "Admin Login error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (error == 3)
                    {
                    btnResetPass.Visible = true;
                    error = 0;
                    }
                } 
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgetpass = new ForgotPassword();
            UserResetPassword.CreateSecurityTable("create");
            this.Hide();
            forgetpass.Show(); 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnImportDb_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                string filename = "\\DataPath.txt";
                var newpath = path.Substring(0, path.IndexOf("\\"));
                var destination_File = newpath + filename;
                if (!File.Exists(destination_File))
                {
                    File.WriteAllText(destination_File, path);
                    File.SetAttributes(destination_File, FileAttributes.Hidden);
                }
               
                MessageBox.Show("Execute CashImport from your Desktop\nto import Data","Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Application.ExitThread();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("File not found", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
                {
                MessageBox.Show("Access denied" , "Import Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
