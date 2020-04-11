using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class SecurityQuestions : Form
        {
        public SecurityQuestions()
            {
            InitializeComponent();
            UserResetPassword.ShowSecurityQuestions();
            txQuest1.Text = UserResetPassword.Question1;
            txtQuest2.Text = UserResetPassword.Question2;
            this.ActiveControl = txtAnswer1;
            }

        private void SecurityQuestions_Load(object sender , EventArgs e)
            {
            if (string.IsNullOrEmpty(UserResetPassword.Question1))
                {
                MessageBox.Show("No security question has been set by this user" , "Reset Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }

            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            if (MessageBox.Show("Are you sure you want to exit ?" , "Confirm " , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                {
                Application.Exit();
                }
            }

        private void btnSubmit_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtAnswer1.Text))
                    {
                    throw new Exception("Enter Question1 answer");
                    }
                if (string.IsNullOrEmpty(txtAnswer1.Text))
                    {
                    throw new Exception("Enter Question2 answer");
                    }
                if (txtAnswer1.Text.ToLower() == UserResetPassword.Answer1.ToLower() && txtAnswer2.Text.ToLower() == UserResetPassword.Answer2.ToLower())
                    {
                    //TODO
                    var reset = new RestPassword();
                    this.Hide();
                    reset.Show();
                    }
                else
                    {
                    throw new Exception("Answer(s) were incorrect\nTry again");
                    }
                }
            catch (Exception ex)
                {

                MessageBox.Show(ex.Message, "Password Rest" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        }
    }
