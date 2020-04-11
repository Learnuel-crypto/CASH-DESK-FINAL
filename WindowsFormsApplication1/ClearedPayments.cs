using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class ClearedPayments : Form
        {
            GroundworkerFulPay fullPay = new GroundworkerFulPay();
        public ClearedPayments()
            {
            InitializeComponent();
            }

        private void ClearedPayments_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            fullPay.DisplayPayments(dataGridPayment);
            fullPay.inProcess(lblNotice);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
            {
                fullPay.PaymentSearch(dataGridPayment, txtsearch);
                if (string.IsNullOrEmpty(txtsearch.Text))
                    fullPay.DisplayPayments(dataGridPayment); 
            }

        private void btnAll_Click(object sender, EventArgs e)
            {
                fullPay.DisplayPayments(dataGridPayment);
            }

        private void btnSearch_Click(object sender, EventArgs e)
            { 
                    fullPay.PaymentSearchMore(dataGridPayment, dateTimeDate, dateTimePicker1,txtsearch);
            }

        private void btnpdf_Click(object sender, EventArgs e)
            {
                try
                {
                    ConvertFormat.ExportDataTableToPdf(dataGridPayment, "List of Cleared Payment", "List of Cleared Payment");
                    this.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void timer1_Tick(object sender, EventArgs e)
            {
            fullPay.inProcess(lblNotice);
            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnPrintCleared_Click(object sender, EventArgs e)
        {
            ///var myPrintTitle = "Completed Payment List";
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecordsPortrate(dataGridPayment, MyPrinter.GetPrintTile());
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            infor1.Visible = true;
        }
        }
    }
