using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class TotalDailyIncome : Form
    {
        Reports rp = new Reports();

        public TotalDailyIncome()
        {
            InitializeComponent();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalDailyIncome_Load(object sender, EventArgs e)
        {

            Reports.displayReport(dataGridExpense);
             
        }

        private void dataGridExpense_Click(object sender, EventArgs e)
        {
            try
            {
                lblID.Text = dataGridExpense.SelectedRows[0].Cells[0].Value.ToString();
                txtIncome.Text = dataGridExpense.SelectedRows[0].Cells[1].Value.ToString();
                txtExpense.Text = dataGridExpense.SelectedRows[0].Cells[2].Value.ToString();
                txtcash.Text =   dataGridExpense.SelectedRows[0].Cells[4].Value.ToString();
                dateTimeDate.Text = dataGridExpense.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch(Exception Ex){}
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            Clear();
            dateTimeDate.Value = dataAccess.Sdate;
            txtIncome.Focus();
            checkTotal.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "ID")
                    {
                    throw new Exception("Select record to delete");
                    }
                rp.deleteReport(lblID);
                Reports.displayReport(dataGridExpense);
                Clear();
                dateTimeDate.Value = dataAccess.Sdate;
                txtIncome.Focus();
                checkTotal.Checked = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nCould not Delete", "Report", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIncome.Text))
                    {
                    throw new Exception("Income Field cannot be Empty'");
                    }
                if (string.IsNullOrEmpty(txtExpense.Text))
                    {
                    throw new Exception("Expense Field cannot be Empty'");
                    }
                if (string.IsNullOrEmpty(txtcash.Text))
                    {
                    throw new Exception("Cash Field Empty'");
                    }
                if (txtcash.TextLength >= 20)
                    {
                    throw new Exception("Enter At Hand or Bank in the Cash Field'");
                    }
                rp.dailyReportUpdate(lblID, txtIncome, txtExpense, txtcash, dateTimeDate);
                Reports.displayReport(dataGridExpense);
                Clear();
                dateTimeDate.Value = dataAccess.Sdate;
                checkTotal.Checked = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nCould not Save", "Report", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIncome.Text))
                    {
                    throw new Exception("Income Field cannot be Empty'");
                    }
                if (string.IsNullOrEmpty(txtExpense.Text))
                    {
                    throw new Exception("Expense Field cannot be Empty'");
                    }
                if (string.IsNullOrEmpty(txtcash.Text))
                    {
                    throw new Exception("Cash Field Empty'");
                    }
                if (txtcash.TextLength >= 20)
                    {
                    throw new Exception("Enter At Hand or Bank in the Cash Field'");
                    }
                rp.ReportInsert(txtIncome, txtExpense, txtcash, dateTimeDate);
                Reports.displayReport(dataGridExpense);
                checkTotal.Checked = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nCould not Save", "Report", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        void Clear()
        {
            lblID.Text = "";
            txtIncome.Clear();
            txtExpense.Clear();
            txtcash.Clear();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    Clear();
                    dateTimeDate.Value = dataAccess.Sdate;
                Reports.ReportSearch(dataGridExpense, txtSearch);
                    if (string.IsNullOrEmpty(txtSearch.Text))
                    {
                    Reports.displayReport(dataGridExpense);
                    }
                  

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nCould not Find", "Report", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        private void btnSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    Clear();
                //dateTimeDate.Value = dataAccess.Sdate;
                Reports.ReportSearch(dataGridExpense,dateTimeFrom,dateTimeTo, txtSearch);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nCould not Find", "Report", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        private void dataGridExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        { 
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridExpense, "Daily Income Report", "Daily Income Report");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecordsPortrate(dataGridExpense, MyPrinter.GetPrintTile());
            }
        }
 
        private void checkTotal_Click(object sender, EventArgs e)
        {
            if (checkTotal.Checked == true)
            { 
                lblTotal.Text = string.Format("{0:00.#0}", Reports.Total.ToString());
                lblTotal.Visible = true;
            }
            else
            {
                lblTotal.Visible = false;
            }
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            checkTotal.Checked = false;
            lblTotal.Visible=false;
            Reports.ReportSearch(dataGridExpense, dateTimeFrom);
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            checkTotal.Checked = false;
            lblTotal.Visible = false;
            Reports.ReportSearch(dataGridExpense, dateTimeFrom,dateTimeTo);
        }

        private void checkTotal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
