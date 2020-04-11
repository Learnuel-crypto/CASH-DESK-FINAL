using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class EventDebtRecord : Form
        {
            EvenPayList evebPayList = new EvenPayList();
        public EventDebtRecord()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void EventDebtRecord_Load(object sender, EventArgs e)
            {
            evebPayList.NotClearedEventList(dataGridEventPayment);
            }

        private void dateTimeDate_ValueChanged(object sender, EventArgs e)
            {
             
            }

        private void txtsearch_TextChanged(object sender, EventArgs e)
            {
            evebPayList.NotClearedEventList(dataGridEventPayment,txtsearch);
                if(string.IsNullOrEmpty(txtsearch.Text))
                    evebPayList.NotClearedEventList(dataGridEventPayment);
            }

        private void btnSearch_Click(object sender, EventArgs e)
            { 
             evebPayList.NotClearedEventList(dataGridEventPayment, dateTimeDate,dateTimePicker1, txtsearch);
            }

        private void btnAll_Click(object sender, EventArgs e)
            {
            evebPayList.NotClearedEventList(dataGridEventPayment);
            }

        private void btnPrintEventDebtors_Click(object sender, EventArgs e)
        { 
           // var myPrintTitle = "Other Fees Debtors List";
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecords(dataGridEventPayment, MyPrinter.GetPrintTile());
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            inforDebt1.Visible = true;
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            //export the records
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridEventPayment, "Other Fees Debtors List", "Other Fees Debtors List");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void dateTimePicker1_ValueChanged(object sender , EventArgs e)
            {
                evebPayList.NotClearedEventList(dataGridEventPayment , dateTimeDate , dateTimePicker1);
            }
        }
    }
