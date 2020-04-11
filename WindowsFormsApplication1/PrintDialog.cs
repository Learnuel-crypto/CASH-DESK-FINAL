using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class PrintDialog : Form
        {
        public PrintDialog()
            {
            InitializeComponent();
            }

        private void btnCancel_Click(object sender , EventArgs e)
            {
            if(MessageBox.Show("Your about to Cancel Print","Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                {
                MyPrinter.Print = false;
                this.Close();
                }
            }

        private void btnOk_Click(object sender , EventArgs e)
            {
            if (string.IsNullOrEmpty(txtPrintTitle.Text))
                {
                if(MessageBox.Show("No Page Title provided\nContinue ?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                    MyPrinter.SetPrintTitle(txtPrintTitle.Text);
                    MyPrinter.Print = true;
                    this.Close();
                    }
                }
            else
                {
                MyPrinter.SetPrintTitle(txtPrintTitle.Text);
                MyPrinter.Print = true;
                this.Close();
                }
            }
 
        private void txtPrintTitle_KeyDown(object sender , KeyEventArgs e)
            {
            if(e.KeyValue == (char)Keys.Enter)
                {
                btnOk.PerformClick();
                
                }
            }
        }
    }
