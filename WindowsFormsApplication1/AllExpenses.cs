using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class AllExpenses : Form
    {
        private Expenses expense = new Expenses();
        public AllExpenses()
            {
            InitializeComponent();
            }

        private void btnclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void AllExpenses_Load(object sender, EventArgs e)
            {
            expense.DisplayAll(dataGridExpense);
            }

        private void btnUpdate_Click(object sender, EventArgs e)
            {
                expense.Update(lblID, txtDes, txtAmount, dateTimeDate);
                expense.DisplayAll(dataGridExpense);
                txtAmount.Text = "";
                txtDes.Text = "";
                lblID.Text = "";
                dateTimeDate.Value = dataAccess.Sdate;
                dataAccess.Description = "Updated An Expense";
                dataAccess.Activities();
                expense.DisplayAll(dataGridExpense);
            }

        private void btnAddnew_Click(object sender, EventArgs e)
            {
                txtAmount.Text = "";
                txtDes.Text = "";
                lblID.Text = "";
                dateTimeDate.Value = dataAccess.Sdate;
            }

        private void btnDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    expense.delete(lblID);
                    expense.DisplayAll(dataGridExpense);
                    txtAmount.Text = "";
                    txtDes.Text = "";
                    lblID.Text = "";
                    dateTimeDate.Value = dataAccess.Sdate;
                    dataAccess.Description = "Deleted An Expense";
                    dataAccess.Activities();
                    
                }
                catch (Exception Ex)
                {

                }
            }

        private void btnSave_Click(object sender, EventArgs e)
            {
                try
                {
                if (string.IsNullOrEmpty(txtDes.Text))
                    {
                    throw new Exception("Enter Description");
                    }
                    if (string.IsNullOrEmpty(txtAmount.Text)) { 
                        throw new Exception("Enter Amount");
                        
                        }
                    expense.insert(txtDes, txtAmount, dateTimeDate);
                    expense.DisplayAll(dataGridExpense);
                    txtAmount.Text = "";
                    txtDes.Text = "";
                    lblID.Text = "";
                    dateTimeDate.Value = dataAccess.Sdate;
                    dataAccess.Description = "Made An Expense";
                    dataAccess.Activities();
                     
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "Operation Failed", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void checkTotal_Click(object sender, EventArgs e)
            {
                if (checkTotal.Checked == true)
                {
                    lblTotal.Visible = true;
                    lblTotal.Text = string.Format("{0:00.#0}", Expenses.Total.ToString());
                }
                else
                {

                    lblTotal.Visible = false;
                }
            }

        private void dataGridExpense_Click(object sender, EventArgs e)
            {
                try
                {
                    lblID.Text = dataGridExpense.SelectedRows[0].Cells[0].Value.ToString();
                    txtDes.Text = dataGridExpense.SelectedRows[0].Cells[1].Value.ToString();
                    txtAmount.Text = string.Format("{0:00.#0}", dataGridExpense.SelectedRows[0].Cells[2].Value.ToString());
                    dateTimeDate.Text = dataGridExpense.SelectedRows[0].Cells[3].Value.ToString();
                }
                catch (Exception Ex)
                {

                }
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
            expense.seachAll(dataGridExpense,txtSearch);
                if (string.IsNullOrEmpty(txtSearch.Text))
                    expense.DisplayAll(dataGridExpense);
            }

        private void btnSearch_Click(object sender, EventArgs e)
            {
                expense.seachAll(dataGridExpense, txtSearch);
            }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridExpense, "Expenses", "Expenses");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "Operation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
    }
