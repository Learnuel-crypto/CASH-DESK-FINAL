using System;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication1
{
    public partial class RegistrationForm : Form
    {
        int clicked = 0;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public RegistrationForm(string user)
            {
            InitializeComponent();
            txtusername.Text = user;
            this.ActiveControl = txtpass;
            }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtusername.Text))
                {
                    throw new Exception("Enter Username");
                }

                else if (string.IsNullOrEmpty(txtpass.Text))
                {
                     throw new Exception("Enter Password");
                }

                else if (string.IsNullOrEmpty(txtConpass.Text))
                {
                    throw new Exception("Confrim Password");
                }
                else if (txtpass.Text == txtConpass.Text)
                {
                        //call the insert class
                    AdminLog.CreateAdmin(txtusername.Text,txtpass.Text);
                    MessageBox.Show("Admin Created Succesfully\n\nPlease Set security questions after you\n" +
                                    "must have log in, to help Reset\n" +
                                    " your password if forgotten, thanks." , "Create Admin", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    var admin = new LoginForm();
                    this.Close();
                    admin.Show();
                }
                else
                {
                    throw new Exception("Password Mismatch");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Create Admin", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            var admin =new LoginForm();
            this.Close();
            admin.Show();
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Cash Desk", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                var admin = new LoginForm();
                this.Close();
                admin.Show();
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                this.ActiveControl = txtpass;
             

            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                this.ActiveControl = txtConpass;


            }
        }

        private void txtConpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtusername.Text))
                    {
                        throw new Exception("Enter Username");
                    }

                    else if (string.IsNullOrEmpty(txtpass.Text))
                    {
                        throw new Exception("Enter Password");
                    }

                    else if (string.IsNullOrEmpty(txtConpass.Text))
                    {
                        throw new Exception("Confrim Password");
                    }
                    else if (txtpass.Text == txtConpass.Text)
                    {
                        //call the insert class
                        AdminLog.CreateAdmin(txtusername.Text, txtpass.Text);
                        MessageBox.Show("Admin Created Succesfully\n\nPlease Set security questions after you\n" +
                                    "must have log in, to help Reset\n" +
                                    " your password if forgotten, thanks.", "Create Admin", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        var admin = new LoginForm();
                        this.Close();
                        admin.Show();
                    }
                    else
                    {
                        throw new Exception("Password Mismatch");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Create Admin", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (clicked == 1)
                {
                    btnViewPass.Image = Image.FromFile(@"cashdesk icon\Visible_30px.png");
                    txtpass.UseSystemPasswordChar = true;
                    txtConpass.UseSystemPasswordChar = true;
                    clicked = 0;
                }
                else
                {
                    btnViewPass.Image = Image.FromFile(@"cashdesk icon\Invisible_30px.png");
                    txtpass.UseSystemPasswordChar = false;
                    txtConpass.UseSystemPasswordChar = false;
                    clicked = 1;
                }
            }
            catch (Exception) { }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void txtConpass_TextChanged(object sender, EventArgs e)
        {
            txtConpass.UseSystemPasswordChar = true;
        }
    }
    }
