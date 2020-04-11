using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class RestPassword : Form
        {
        public RestPassword()
            {
            InitializeComponent();
            }

        private void txtpass_TextChanged(object sender , EventArgs e)
            {
            txtpass.UseSystemPasswordChar = true;
            }

        private void txtConpass_TextChanged(object sender , EventArgs e)
            {
            txtConpass.UseSystemPasswordChar = true;
            }

        private void btnReset_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtusername.Text))
                    {
                    throw new Exception("Enter New username");
                    }
                if (string.IsNullOrEmpty(txtpass.Text))
                    {
                    throw new Exception("Enter new Password");
                    }
                if (string.IsNullOrEmpty(txtConpass.Text))
                    {
                    throw new Exception("confirm password");
                    }
                if(txtpass.Text != txtConpass.Text)
                    {
                    throw new Exception("Provided password mismatch");
                    }
                else
                    {
                    UserResetPassword.UpdateAdminUsername(txtusername.Text , txtConpass.Text);
                    MessageBox.Show( "Password reset successful", "Password Reset" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    var login = new LoginForm();
                    this.Hide();
                    login.Show();
                    }
                }
            catch (Exception ex)
                { 
                MessageBox.Show(ex.Message , "Password Reset" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                } 
            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            if(MessageBox.Show("Are you sure you want to exit ?","Confirm " , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                {
                Application.Exit();
                }
            }

        private void txtConpass_KeyDown(object sender , KeyEventArgs e)
            {
            if (e.KeyValue == (char)Keys.Enter)
                {
                btnReset.PerformClick();
                }
            }

        private void txtpass_KeyDown(object sender , KeyEventArgs e)
            {
            if (e.KeyValue == (char)Keys.Enter)
                {
                btnReset.PerformClick();
                }
            }
        }
    }
