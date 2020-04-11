using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class SetSessionForm : Form
    {

        public SetSessionForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            try
            {

                if (dateTimeStartYear.Value.ToString() == dateTimeEndYear.Value.ToString())
                    throw new Exception("The Start and End Year Can't be Same Year");
            Session ses = new Session(); 
                //INSERT INTO DATABASE
                ses.setNewSession(dateTimeStartYear, dateTimeEndYear,dateTimeSetDate);
                this.Close();
                }
                catch(Exception Ex){
                    MessageBox.Show(Ex.Message +"\nSession Creation Failed","Session Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
            }
         
        
    }
}
