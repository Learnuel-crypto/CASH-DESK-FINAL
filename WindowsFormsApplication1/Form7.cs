using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class setFeesForm : Form
    {
        public setFeesForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 

        private void Form7_Load(object sender, EventArgs e)
        {
            Fees.DisplayFeeName(comFeeName);
            }

         
        private void btnset_Click(object sender, EventArgs e)
        {
            try{
            Fees fset = new Fees();
                if(comFeeName.Text=="e.g School Fee")
                    {
                    throw new Exception("Enter or Select a fee name");
                    }
            fset.setFeeName(comFeeName.Text);
            fset.setAmount(Convert.ToInt32(txtAmount.Text));
            fset.setSection(combSection.Text);
            if (string.IsNullOrEmpty(txtinstall.Text))
                {
                fset.setInstallment(1);
                }
            else
                { 
                fset.setInstallment(int.Parse(txtinstall.Text));
                }
            fset.setDateSet(dateTimePicker1.Value.ToString());
              
                fset.setFees(fset.getSection(), fset.getFeeName(), fset.getAmount().ToString(), fset.getInstallment(), fset.getDateSet());
                txtAmount.Clear(); 
                txtinstall.Clear();
                combSection.Text = "";
              Fees.DisplayFeeName(comFeeName);
                }
           catch (ExceptionHandling Ex){
                MessageBox.Show(Ex.Message + "\nSet Fee Could be Not Completed", "Set Fee Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message+"\nSet Fee Could be Not Completed","Set Fee Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
            {
            if(char.IsNumber(e.KeyChar)){
                
                }
            else{
            e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void txtinstall_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {

                }
            else
                {
                e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void button1_Click(object sender, EventArgs e)
            {
            EventsForm events = new EventsForm();
            events.ShowDialog();

            }

        private void btnClear_Click(object sender, EventArgs e)
            {
            //CLEAR THE ENTERED DATA
            txtAmount.Clear(); 
            txtinstall.Clear();
            combSection.Text="";
            dateTimePicker1.Text = DateTime.Today.ToString("MM/dd/yyyy");
            }

        private void btnedit_Click(object sender, EventArgs e)
        {

            var updateFee = new UpdateFeesForm(); 
            updateFee.Show();
            //CREATE A FORM FOR EDITING FEES
           // MessageBox.Show("Regular Fees CANNOT be Edited once Set", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
