using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AesEncrypt;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.IO.IsolatedStorage;

namespace WindowsFormsApplication1
    {
    public partial class AdminForm : Form
    { 
        SqlCommand cmd = new SqlCommand();
        SqlParameter Logo;
        SqlConnection con = new DBConnection().getConnection();
        private string  destination_File = null;
        public AdminForm()
            {
            InitializeComponent();
            }

        private void btnclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnAddStudents_Click(object sender, EventArgs e)
            {
                AddStudentsForm adds = new AddStudentsForm(); 
                adds.ShowDialog();
            }

        private void btnCreateEvent_Click(object sender, EventArgs e)
            {  
                EventsForm evef = new EventsForm(); 
                evef.ShowDialog();
            }

        private void btnSetSession_Click(object sender, EventArgs e)
            {
                SetSessionForm set = new SetSessionForm(); 
                set.ShowDialog();
            }

        private void btnSetFees_Click(object sender, EventArgs e)
            {
                setFeesForm stf = new setFeesForm();
                stf.ShowDialog();
            }

        private void btnViewActivity_Click(object sender, EventArgs e)
            {
                ActivityForm act = new ActivityForm();
                act.ShowDialog();
            }

        private void btnEventFee_Click(object sender, EventArgs e)
            {
                EventPayForm eveform = new EventPayForm();
                eveform.Show();
            }

        private  void brnSet_Click(object sender, EventArgs e)
            {
                try
                { 
                    if (pictureBoxLogo.Image == null)
                    {
                        if (MessageBox.Show("School Logo is Not Selected\nDo You want to Proceed?", "School Receipt",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            con.Open();
                            SqlCommand cmdDel = new SqlCommand("Delete ReceiptName", con);//DELETE THE INITIAL RECORDS IN TE TABLE
                            cmdDel.ExecuteNonQuery();
                            cmd.Connection = con;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@School_Name" , txtName.Text);
                        cmd.Parameters.AddWithValue("@Address" , txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Motto" , txtMotto.Text);
                            cmd.CommandText = "INSERT INTO ReceiptName(School_Name,Address,Motto) VALUES(@School_Name,@Address,@Motto)";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show( "Receipt Details Set", "Receipt Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        saveLogo();
                    }
                   
                }
                catch (Exception Ex)
                {
                    con.Close();
                    MessageBox.Show(Ex.Message+"\nCould Not Set Receipt Details\nTry Again","Receipt Setting",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        private void btnIncome_Click(object sender, EventArgs e)
            {
                TotalDailyIncome income = new TotalDailyIncome();
                income.ShowDialog();
            }

        private void btnViewSetFees_Click(object sender, EventArgs e)
            {
            var feeSet = new Fees_Set();
                feeSet.ShowDialog();
            }

            private void getSchoolLogo()
            {
                try
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    
                    fileDialog.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|PNG|*.png";
                    fileDialog.FilterIndex = 2;
                    fileDialog.Title = "Select School Logo";
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxLogo.Image= Image.FromFile(fileDialog.FileName);
                        
                        lblPictureName.Text = fileDialog.FileName;
                        
                    }
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Either image format is incorrect \nor the size is too large","Image Error");
                }
            }

            private void saveLogo()
            {
                try
                { 
                    con.Open();
                    SqlCommand cmdDel = new SqlCommand("Delete ReceiptName",con);
                    cmdDel.ExecuteNonQuery();
                    con.Close();
                    if (pictureBoxLogo.Image != null)
                    {
                        //SET THE SCHOOL LOGO AND NAME
                        MemoryStream ms = new MemoryStream();
                        pictureBoxLogo.Image.Save(ms, pictureBoxLogo.Image.RawFormat);
                        byte[] a = ms.GetBuffer();
                        ms.Close();
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@School_Name" , txtName.Text);
                    cmd.Parameters.AddWithValue("@Address" , txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Motto" , txtMotto.Text);
                    cmd.Parameters.AddWithValue("@Logo", a);
                        cmd.CommandText = "INSERT INTO ReceiptName(School_Name,Address,Motto,Logo) VALUES(@School_Name,@Address,@Motto,@Logo)";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Receipt Details Set", "Receipt Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    con.Close();
                    MessageBox.Show("Error occurred, Receipt was not set","Receipt Error");
                }
            }

            private void btnloadImage_Click(object sender, EventArgs e)
                {

                getSchoolLogo(); 
                }

            private void btnSet_Click(object sender, EventArgs e)
                {
            //change username button
                    try
                    {
                if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                    throw new Exception("Enter current username");
                    }
                if (txtUsername.Text != AdminLog.Admin)
                    {
                    throw new Exception("Current username is not same as the current user");
                    }
                
                 if (string.IsNullOrEmpty(txtNewUser.Text))
                        {
                            throw new Exception("Enter New username");
                        }
                if (string.IsNullOrEmpty(txtCurrentPass.Text))
                    {
                    throw new Exception("Enter admin password");
                    }

                if (PasswordEncryptor.Encrypt(txtCurrentPass.Text) != AdminLog.AdminPass)
                    {
                    throw new Exception("Current user password is incorrect");
                    }

                    AdminLog.UpdateAdminUsername(txtUsername.Text, txtNewUser.Text);
                        MessageBox.Show("Update Successful", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCurrentPass.Text=""; 
                        txtUsername.Text="";
                        txtNewUser.Text = "";
                var newLogin = new AdminLogOut();
                newLogin.ShowDialog();
                }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            private void tabControl1_Click(object sender, EventArgs e)
                {
                //con.Open();
                }

            private void btnReports_Click(object sender, EventArgs e)
            {
                var report = new ReportForm();
                report.Show(); 
            }

            private void btnLogs_Click(object sender, EventArgs e)
                {
                var log = new AdminLogs();
                    log.ShowDialog();
                }

            private void bnDelete_Click(object sender, EventArgs e)
                {
                    try
                    {
                if (string.IsNullOrEmpty(txtUser.Text))
                    {
                    throw new Exception("Enter Username");
                    }
                if (string.IsNullOrEmpty(txtAdminpass.Text))
                    {
                    throw new Exception("Enter Admin Password");
                    }
                 if (txtUser.Text == AdminLog.Admin)
                          {
                     throw new Exception("You CANNOT Delete the Currently Logged User");
                          }
               if (PasswordEncryptor.Encrypt( txtAdminpass.Text) == AdminLog.AdminPass)
                        {
                    if (MessageBox.Show("Do you want to delete this User ?" , "Confirm Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                        AdminLog.DeleteAdmin(txtUser);
                        txtUser.Text = "";
                        txtAdminpass.Text = "";
                        }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect admin Password", "Cash Desk", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "Cash Desk", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
                }

            private void btnViewUser_Click(object sender, EventArgs e)
                {
                var view = new ViewUser();
                view.Show();
                }

            private void panHead_Paint(object sender, PaintEventArgs e)
            {

            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                try
                {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        throw new Exception("Enter Username");
                    }

                    else if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        throw new Exception("Enter Password");
                    }

                    else if (string.IsNullOrEmpty(textBox3.Text))
                    {
                        throw new Exception("Confrim Password");
                    }
                    else if (textBox2.Text == textBox3.Text)
                    {
                        if (PasswordEncryptor.Encrypt(txtcreateUserAdmin.Text) == AdminLog.AdminPass)
                        {
                            //call the insert class
                            AdminLog.CreateAdmin(textBox1.Text, textBox2.Text);
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            txtcreateUserAdmin.Text = "";
                            MessageBox.Show("Admin Created Succesfully\n\nPlease set security questions\n" +
                                            "after now, to enable password reset\n" +
                                            "in case password is forgotten", "Create Admin", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            dataAccess.Description = "Added a new user";
                            dataAccess.Activities();
                        }
                        else
                        {
                            throw new Exception("Enter Currently Logged in admin Password");
                        }
                    }
                    else
                    {
                        throw new Exception("Password Mismatch");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Cash Desk", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            private void bnClear_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                txtcreateUserAdmin.Clear();
            }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            txtCurrentPass.UseSystemPasswordChar = true;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            txtConPass.UseSystemPasswordChar = true;
        }

        private void txtAdminpass_TextChanged(object sender, EventArgs e)
        {
            txtAdminpass.UseSystemPasswordChar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        private void txtcreateUserAdmin_TextChanged(object sender, EventArgs e)
        {
            txtcreateUserAdmin.UseSystemPasswordChar = true;
        }
        void Check(string check)
            {
             
            try
                {

                if (check.Length > 30)
                    {
                    throw new Exception(" length of characters is exceeded, reduce.");
                    } 
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Input Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        private void textBox1_TextChanged(object sender , EventArgs e)
            {
            if (!string.IsNullOrEmpty(textBox1.Text))
                {
                Check(textBox1.Text);
                }
            }

        private void txtUsername_TextChanged(object sender , EventArgs e)
            {
            if (!string.IsNullOrEmpty(txtUsername.Text))
                {
                Check(txtUsername.Text);
                }
            }

        private void txtNewUser_TextChanged(object sender , EventArgs e)
            {
            if (!string.IsNullOrEmpty(txtNewUser.Text))
                {
                Check(txtNewUser.Text);
                }
            }

        private void btnChangePassword_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtCurrentPassword.Text))
                    {
                    throw new Exception("Enter current password");
                    }
                if (string.IsNullOrEmpty(txtNewPass.Text))
                    {
                    throw new Exception("Enter new password");
                    }
                if (string.IsNullOrEmpty(txtConPass.Text))
                    {
                    throw new Exception("confirm new password");
                    }
                if(PasswordEncryptor.Encrypt(txtCurrentPassword.Text) != AdminLog.AdminPass)
                    {
                    throw new Exception("Incorrect current password");
                    }
                if(PasswordEncryptor.Encrypt(txtNewPass.Text) != PasswordEncryptor.Encrypt(txtConPass.Text))
                    {
                    throw new Exception("new password mismatched");
                    }
                else
                    {
                    //call update method
                    
                    AdminLog.UpdateAdminPass (txtConPass.Text);
                    MessageBox.Show("Update Successful" , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    txtCurrentPassword.Text = "";
                    txtNewPass.Text = "";
                    txtConPass.Text = "";
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Input Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void txtCurrentPassword_TextChanged(object sender , EventArgs e)
            {
            txtCurrentPassword.UseSystemPasswordChar = true;
            }

        private void btnSales_Click(object sender , EventArgs e)
            {
            var SalesRecord = new Sales_Record();
            SalesRecord.Show();
            }

        void Clear()
            {
            txQuest1.Clear();
            txtAnswer1.Clear();
            txtQuest2.Clear();
            txtAnswer2.Clear();
            }
        private void btnSubmit_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txQuest1.Text))
                    {
                    throw new Exception("Question 1 is empty");
                    }
                if (string.IsNullOrEmpty(txtAnswer1.Text))
                    {
                    throw new Exception("Answer for question 1 is empty");
                    }
                if (string.IsNullOrEmpty(txtQuest2.Text))
                    {
                    throw new Exception("Question 2 is empty");
                    }
                if (string.IsNullOrEmpty(txtAnswer2.Text))
                    {
                    throw new Exception("Answer for question 2 is empty");
                    }
                UserResetPassword.CreateSecurityTable();
                var Questionchecked= UserResetPassword.CheckSecurityQuestions();
                if (Questionchecked == 0)
                    {
                    //inset these questions
                    UserResetPassword.SetSecurityQuestions(txQuest1.Text , txtAnswer1.Text , txtQuest2.Text , txtAnswer2.Text);
                    MessageBox.Show("Question Set Successfully" , "Security Questions" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    Clear();
                    }
                else
                    {
                    //update the questions
                    UserResetPassword.UpdateSecurityQuestions(txQuest1.Text , txtAnswer1.Text , txtQuest2.Text , txtAnswer2.Text);
                    MessageBox.Show("Question Updated Successfully" , "Security Questions" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    Clear();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Set Question Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnDeleteLogs_Click(object sender , EventArgs e)
            {
            var DeleteAdminLogs = new AdminLogs();
            DeleteAdminLogs.ShowDialog();
            }

        private void btnDbBackup_Click(object sender, EventArgs e)
        {
            try
            {

                ProcessStartInfo info = new ProcessStartInfo("BackFile.exe");
                info.UseShellExecute = true;
                info.Verb = "runas";
                Process.Start(info);
                new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, "Logout"); }).Start();
                Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Export Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
       
        private void btnImportdata_Click(object sender, EventArgs e)
        {

            try
            {
                string path = Application.StartupPath;
                string filename = "\\DataPath.txt";
                var newpath = path.Substring(0, path.IndexOf("\\"));
                destination_File = newpath + filename;
                if (!File.Exists(destination_File))
                {
                    File.WriteAllText(destination_File, path);
                    File.SetAttributes(destination_File, FileAttributes.Hidden);
                    }
               
                MessageBox.Show("Execute CashImport from your Desktop\nto import data", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, "Logout"); }).Start();
                Application.ExitThread();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("File not found", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied" , "Data Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            catch (System.IO.IOException) {
                MessageBox.Show("File not Found" , "Data Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Data Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                File.Delete(destination_File);
            }
            
        }
        }
    }
