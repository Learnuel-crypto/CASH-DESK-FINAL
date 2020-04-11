using System;
using System.Windows.Forms;
using ShowTallerImage;

namespace WindowsFormsApplication1
    {
    public partial class TodayPayRecords : Form
        {
        ConvertFormat cf = new ConvertFormat();
        DisplayTaller display = new DisplayTaller();
        private string StudNames;
        private string PAmount;
        private string dDate;
        private string FeeName;
        public TodayPayRecords()
            {
            InitializeComponent();
            RecordAccess.getTodayfeeNames (combFeeName);
            } 

            private void TodayPayRecords_Load(object sender, EventArgs e)
            {
                 RecordAccess.todayRecords(dataGridRecords);
            }

            private void dataGridRecords_Click(object sender, EventArgs e)
                {
            try
                {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
                dataAccess.DcashId = Convert.ToInt32(dataGridRecords.SelectedRows[0].Cells[0].Value.ToString());
                display.CheckTallerID(dataAccess.DcashId , btnViewTaller);//check if the payment was made with taller
                StudNames = dataGridRecords.SelectedRows[0].Cells[1].Value.ToString();
                FeeName = dataGridRecords.SelectedRows[0].Cells[3].Value.ToString();
                PAmount = dataGridRecords.SelectedRows[0].Cells[5].Value.ToString();
                dDate = dataGridRecords.SelectedRows[0].Cells[6].Value.ToString();
                }catch (Exception) { }
                } 
            private void btnReceipt_Click(object sender, EventArgs e)
                {
                    try
                    {
                        lblTotal.Visible = false;
                        checkTotal.Checked = false;
                        if (dataAccess.DcashId == 0)
                        {
                            throw new Exception("Click on a Record to Select ");
                        }
                        else
                        {
                            ReceiptView rv = new ReceiptView();
                            rv.ShowDialog();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message+"\nReceipt Preview Failed", "Make a Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
            RecordAccess.todaySeacrchRecords(dataGridRecords, txtSearch);
            if (string.IsNullOrEmpty(txtSearch.Text))
                {
                RecordAccess.todayRecords(dataGridRecords);
                }
            }

        private void btnSearch_Click(object sender, EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    {
                    throw new Exception("Enter the Fee Name");
                    }
                 
                    RecordAccess.todayRecords(dataGridRecords);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void checkTotal_Click(object sender, EventArgs e)
            {
                if (checkTotal.Checked == true)
                {
                    lblTotal.Text = string.Format("{0:00.#0}", RecordAccess.total);
                    lblTotal.Visible = true;
                }
                else
                {
                    lblTotal.Visible = false;
                }
            }

        

        private void txtName_TextChanged(object sender, EventArgs e)
            {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
            }

        private void btnViewTodayAll_Click(object sender, EventArgs e)
            {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
                RecordAccess.todayRecords(dataGridRecords);
            }

        private void btnPDF_Click(object sender, EventArgs e)
        {  
                try
                {
                    ConvertFormat.ExportDataTableToPdf(dataGridRecords, "Daily pay Record", "Daily pay Record");
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
            if (MyPrinter.Print == true)
            {
                MyPrinter.PrintRecords(dataGridRecords, MyPrinter.GetPrintTile());
            }
        }

        private void dataGridRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void btnReport_Click(object sender, EventArgs e)
            {
                try
                {
                    var feeDate = dataGridRecords.Rows[0].Cells[6].Value.ToString();
                    DailyReports.GetlastReport(combFeeName.Text, feeDate);
                    DailyReports.InsertDailyReport(combFeeName.Text, RecordAccess.total, RecordAccess.RecordDate.ToString());

                }
                catch (IndexOutOfRangeException Ex)
                {
                    throw new Exception("No Records Found"); 
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message+ " \nReport Not Successful", "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void btnViewTaller_Click(object sender, EventArgs e)
        { 
            var viewTaller = new ViewTallerForm(StudNames,FeeName,PAmount,dDate);
            viewTaller.ShowDialog();
        }

        private void btnAllTallerPayments_Click(object sender, EventArgs e)
        { 
            var viewTallers = new AllTallerPaymentForm();
            viewTallers.Show();
        }

        private void combFeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RecordAccess.todaySeacrchRecordsByFeename(dataGridRecords, combFeeName.Text);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message , "search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
        }
