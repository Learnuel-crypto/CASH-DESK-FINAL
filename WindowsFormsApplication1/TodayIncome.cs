using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class TodayIncome : Form
    {
        private string cash="Unknown";
        public TodayIncome()
            {
            InitializeComponent();
            }

        private void TodayIncome_Load(object sender, EventArgs e)
        { 
            txtIncome.Text =  Expenses.Income.ToString();
            txtExpense.Text =  Expenses.Expense.ToString();
            txtBalance.Text = Expenses.Bal.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioAtHand.Checked == true)
                    {
                    cash = radioAtHand.Text;
                    }
                if (radioBank.Checked == true)
                    {
                    cash = radioBank.Text;
                    }
                if(radioAtHand.Checked==false && radioBank.Checked == false)
                    {
                    throw new Exception("No Cash statement is selected");
                    }
                if(txtIncome.Text=="0" && txtExpense.Text == "0")
                    {
                    throw new Exception("There is nothing to report");
                    }
                Reports rep = new Reports();
                rep.dailyReportInsert(txtIncome, txtExpense, txtBalance, cash);
                dataAccess.Description = "Made a Report";
                dataAccess.Activities();
                MessageBox.Show( "Save Successful", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIncome.Text = "";
                txtExpense.Text = "";
                txtBalance.Text = "";
                radioAtHand.Checked = false;
                radioBank.Checked = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Report" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
        }
        }
    }
