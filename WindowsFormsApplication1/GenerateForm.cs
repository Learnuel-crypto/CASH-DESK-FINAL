using System;
using System.Windows.Forms;
using CashDeskActivation;

namespace WindowsFormsApplication1
    {
    public partial class GenerateForm : Form
    {
        string hwid;
        public GenerateForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            hwid =   HardWareID.GET_HardWareID; 
            txtProID.Text = hwid.Substring(0,hwid.Length-3).ToUpper();
        }

        private void GenerateForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
