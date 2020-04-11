using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrecordExpense_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtexpensename.Text))
                {
                    throw new Exception("Enter Name for the Expense ");
                }
                else if (string.IsNullOrEmpty(txtcost.Text))
                {
                    throw new Exception("Enter Amount for Expense ");
                }
                Expenses expense = new Expenses();
                expense.insert(txtexpensename, txtcost, dateTimeDate);
                dataAccess.Description = "Made an Expense";
                dataAccess.Activities();
                MessageBox.Show("Expense Recorded", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcost.Text = "";
                txtexpensename.Text = "";
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message+"\nExpense Record Failed", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
            {
            if(char.IsNumber(e.KeyChar)){
                }
            else{
            e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void ExpenseForm_Load(object sender, EventArgs e)
            {

            }

        private void txtcost_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter){

                try
                {
                    if (string.IsNullOrEmpty(txtexpensename.Text))
                    {
                        throw new Exception("Enter Name for the Expense ");
                    }
                    else if (string.IsNullOrEmpty(txtcost.Text))
                    {
                        throw new Exception("Enter Amount for Expense ");
                    }
                    Expenses expense = new Expenses();
                    expense.insert(txtexpensename, txtcost, dateTimeDate);
                    dataAccess.Description = "Made an Expense";
                    dataAccess.Activities();
                    MessageBox.Show("Expense Recorded", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcost.Text = "";
                    txtexpensename.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nExpense Record Failed", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }  
    }
}
