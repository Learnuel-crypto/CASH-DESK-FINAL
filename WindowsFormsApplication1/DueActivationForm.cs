using Activation;
using AesEncrypt;
using CashDeskActivation;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class DueActivationForm : Form
    {
        private string ProID;
        public DueActivationForm()
        {
            InitializeComponent();
            ProID =HardWareID.GET_HardWareID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DueActivationForm_Load(object sender, EventArgs e)
        {
            
                txtProID.Text = ProID.Substring(0, ProID.Length - 3);
             
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtActivation.Text))
                    throw new Exception("Enter Activation Key");
                var key = PasswordEncryptor.Encrypt(txtProID.Text.TrimEnd());
                if (txtActivation.Text == key.Substring(0, 24).ToUpper().TrimEnd())
                { 
                    AppActivation.activate(txtActivation.Text); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Activation Key", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nActivation Failed", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            var about = new AboutUsForm();
            about.Show();
        }
    }
}
