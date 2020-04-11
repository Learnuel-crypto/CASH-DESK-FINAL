using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class TodayExpenses : Form
    {
        Expenses expense = new Expenses();

        public TodayExpenses()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TodayExpenses_Load(object sender, EventArgs e)
        {

            expense.Display(dataGridExpense);
        }

        private void checkTotal_Click(object sender, EventArgs e)
        {
            if (checkTotal.Checked == true)
            {
                lblTotal.Visible = true;
                lblTotal.Text = Expenses.Total.ToString();
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
            catch (Exception )
            {

            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtDes.Text = "";
            lblID.Text = "";
            dateTimeDate.Value = dataAccess.Sdate;
        }

        private void btnSave_Click(object sender, EventArgs e)
            {
                try
                {
                if (string.IsNullOrEmpty(txtDes.Text))
                    {
                    throw new Exception("Enter Description");
                    }
                if (string.IsNullOrEmpty(txtAmount.Text))
                    {
                    throw new Exception("Enter Amount");
                    }
                    expense.insert(txtDes, txtAmount, dateTimeDate);
                    expense.Display(dataGridExpense);
                    Clear(); 
                    dateTimeDate.Value = dataAccess.Sdate;
                    dataAccess.Description = "Made an Expense";
                    dataAccess.Activities();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message+ "Operation Failed", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        void Clear()
            {
            txtAmount.Clear();
            txtDes.Clear(); ;
            lblID.Text = "";
            }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
                {

                expense.Update(lblID , txtDes , txtAmount , dateTimeDate);
                expense.Display(dataGridExpense);
                Clear();
                dateTimeDate.Value = dataAccess.Sdate;
                dataAccess.Description = "Updated An Expense";
                dataAccess.Activities();
                }catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Error");
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    expense.delete(lblID);
                    expense.Display(dataGridExpense);
                Clear();
                    dateTimeDate.Value = dataAccess.Sdate;
                    dataAccess.Description = "Deleted An Expense";
                    dataAccess.Activities();
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Error");
                }
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
            expense.todaySearch(dataGridExpense,txtSearch);
            if (string.IsNullOrEmpty(txtSearch.Text))
                {
                expense.Display(dataGridExpense);
                }
            }

        private void btnSearch_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {

                }
                else
                {
                    expense.todaySearch(dataGridExpense, txtSearch);
                }
            }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridExpense, "Expenses", "Expenses");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
