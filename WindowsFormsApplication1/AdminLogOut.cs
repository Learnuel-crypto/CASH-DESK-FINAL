using System;
using AesEncrypt;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminLogOut : Form
        {
        public AdminLogOut()
            {
            InitializeComponent();
            }

        private void btnLogin_Click(object sender, EventArgs e)
            {
                try
                { 
                    if (txtUsername.Text == AdminLog.Admin && PasswordEncryptor.Encrypt( txtPassword.Text) == AdminLog.AdminPass)
                    { 
                        //USE ASYNC HERE
                        new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, btnLogin.Text); }).Start();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Incorrect Username or Password");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Admin Login error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                try
                { 
                    if (txtUsername.Text == AdminLog.Admin &&PasswordEncryptor.Encrypt (txtPassword.Text) == AdminLog.AdminPass)
                    {
                        //USE ASYNC HERE
                        new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, btnLogin.Text); }).Start();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Incorrect Username or Password");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Admin Login error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                try
                {
                    AdminLog.LogIn(txtUsername.Text, txtPassword.Text);
                    if (txtUsername.Text == AdminLog.Admin && PasswordEncryptor.Encrypt( txtPassword.Text) == AdminLog.AdminPass)
                    {
                        //USE ASYNC HERE
                        new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, btnLogin.Text); }).Start();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Incorrect Username or Password");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Admin Login error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;  
        }
    }
    }
