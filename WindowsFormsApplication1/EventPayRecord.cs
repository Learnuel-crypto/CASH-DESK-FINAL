using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class EventPayRecord : Form
        {
            EvenPayList enEvenPayList = new EvenPayList();
        public EventPayRecord()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void EventPayRecord_Load(object sender, EventArgs e)
            {
            enEvenPayList.ClearedEventList(dataGridPayment);
            }

        private void dateTimeDate_ValueChanged(object sender, EventArgs e)
            {
             
            }

        private void txtsearch_TextChanged(object sender, EventArgs e)
            {
            
            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                enEvenPayList.ClearedEventList(dataGridPayment);
                }
            else
            {
                enEvenPayList.ClearedEventList(dataGridPayment , txtsearch);
                }
            }

        private void btnSearch_Click(object sender, EventArgs e)
            { 
                    enEvenPayList.ClearedEventList(dataGridPayment,dateTimeDate,dateTimePicker1,txtsearch); 
            }

        private void btnAll_Click(object sender, EventArgs e)
            {
            enEvenPayList.ClearedEventList(dataGridPayment);
            }

        private void btnPrintEventscleared_Click(object sender, EventArgs e)
        {

            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecords(dataGridPayment, MyPrinter.GetPrintTile());
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            infor2.Visible = true;  
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
           //export to pdf
            try
            { 
                ConvertFormat.ExportDataTableToPdf(dataGridPayment, "Other Completed Fees List", "Other Completed Fees List");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender , EventArgs e)
            {
                enEvenPayList.ClearedEventList(dataGridPayment , dateTimeDate , dateTimePicker1);
            }
        }
    }
