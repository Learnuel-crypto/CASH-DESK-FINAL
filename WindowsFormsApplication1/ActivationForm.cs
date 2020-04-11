using System;
using System.Windows.Forms;
using CashDeskActivation;
using Secure;
using Activation;
using System.IO.IsolatedStorage;

namespace WindowsFormsApplication1
{
    public partial class ActivationForm : Form
    {
        string ProID;
        public ActivationForm()
        {
            InitializeComponent();
            ProID = HardWareID.GET_HardWareID;
            txtProID.Text = ProID.Substring(0 , ProID.Length - 3).ToUpper();
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {

            try
            {
                var ID = ProID.Substring(0, ProID.Length - 3);
                if (string.IsNullOrEmpty(txtProID.Text))
                    {
                    throw new Exception("Enter Product ID");
                    }
                if (txtProID.Text != ID.ToUpper())
                    {
                    throw new Exception("Invalid Product ID");
                    }
                if (string.IsNullOrEmpty(txtActivation.Text))
                    {
                    throw new Exception("Enter Activation Key");
                    }
                var key = SecuredPass.Encrypt(txtProID.Text.TrimEnd());
                if (txtActivation.Text == key.Substring(0,24).ToUpper().TrimEnd())
                { 
                  AppActivation.activate(txtActivation.Text);
                    //MessageBox.Show("Activation Successful", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }else
                {
                    MessageBox.Show("Invalid Activation Key", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nActivation Failed", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActivationForm_Load(object sender, EventArgs e)
        {
            using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("apps.txt", System.IO.FileMode.Open, isolatedStorageFile))
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(isolatedStorageFileStream))
                        {
                            var activation = sr.ReadLine();
                             
                            //if the there is an activation Key check if it is valid
                            if (AppActivation.isActivated() == activation)
                            {
                                MessageBox.Show("Software is already Activated", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                }
                        }
                    }
                }
                catch (Exception) {
                    
                }
            }
        }
    }
    }

