using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class DebtorsList : Form
        {
            GroundWorker groundWorker = new GroundWorker();
        public DebtorsList()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void DebtorsList_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
                groundWorker.DisplayDebtor(dataGridDebtors);
            groundWorker.inProcess(lblNotice);
        }

        private void btnpdf_Click(object sender, EventArgs e)
            { 
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridDebtors, "DEBTORS LIST", "DEBTORS LIST");
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
            groundWorker.inProcess(lblNotice);
        }

        private void btnSearch_Click(object sender, EventArgs e)
            { 
                    groundWorker.DebtorsSearch(dataGridDebtors, dateTimeDate,dateTimePicker1,txtsearch);
                   
            }

        private void btnAll_Click(object sender, EventArgs e)
            {
            groundWorker.DisplayDebtor(dataGridDebtors);
            }

        private void txtsearch_TextChanged(object sender, EventArgs e)
            {
            groundWorker.DebtorsSearch(dataGridDebtors,txtsearch);
                if(string.IsNullOrEmpty(txtsearch.Text))
                    groundWorker.DisplayDebtor(dataGridDebtors);
            }

        private void btnPrintDebtors_Click(object sender, EventArgs e)
        { 
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecords(dataGridDebtors, MyPrinter.GetPrintTile());
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            inforDebt1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                groundWorker.DebtorsDateSearch(dataGridDebtors, dateTimeDate, dateTimePicker1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
    }
