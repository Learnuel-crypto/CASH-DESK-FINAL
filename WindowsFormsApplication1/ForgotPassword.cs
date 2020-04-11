using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class ForgotPassword : Form
        {
        public ForgotPassword()
            {
            InitializeComponent();
            this.ActiveControl = txtUsername;
            }

        private void btnBack_Click(object sender , EventArgs e)
            {
            txtUsername.Clear();
            var Login = new LoginForm();
            this.Hide();
            Login.Show();
            }

        private void btnNext_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                    throw new Exception("Enter Username");
                    } 
                UserResetPassword.ResetUserPassword(txtUsername.Text);
                var securityquestions = new SecurityQuestions();
                this.Hide();
                securityquestions.Show();
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Result" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void txtUsername_KeyDown(object sender , KeyEventArgs e)
            {
            if (e.KeyValue == (char)Keys.Enter)
                {
                btnNext.PerformClick();
                }
            }
        }
    }
