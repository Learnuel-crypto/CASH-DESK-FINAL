using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ShowTallerImage;

namespace WindowsFormsApplication1
    {
    public partial class PayRecordsForm : Form
        {
            SqlConnection con = new DBConnection().getConnection();
            ConvertFormat cf = new ConvertFormat();
        DisplayTaller display = new DisplayTaller();
            private string term = "";
            private  string myPrintTitle="";
        private string StudNames;
            private string PAmount;
            private string Pdate;
        private string FeeName;
        private bool feeDate = false;
        public PayRecordsForm()
            {
            InitializeComponent();
            }

        private void PayRecordsForm_Load(object sender, EventArgs e)
        {
            PaymentRecordSearch.PaymentSearch(dataGridViewRecords);
            feeNames(combFeeName);
            

        }

            void feeNames(ComboBox feeName)
            {
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Fee_Name FROM Cash ", con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    feeName.Items.Add(dr["Fee_Name"]);
                }
            }
            private void btnclose_Click(object sender, EventArgs e)
                {
                this.Close();
                }

            private void dataGridRecords_Click(object sender, EventArgs e)
            {
            try
                {

                dataAccess.DcashId = Convert.ToInt32(dataGridViewRecords.SelectedRows[0].Cells[0].Value.ToString());
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
                        MessageBox.Show(Ex.Message+"\nReceipt Preview Failed", "make a Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            private void txtSearch_TextChanged(object sender, EventArgs e)
                {
                    try
                    {
                        feeDate = false;
                        PaymentRecordSearch.PaymentSearch(dataGridViewRecords, txtSearch);
                if (string.IsNullOrEmpty(txtSearch.Text))
                    {
                        PaymentRecordSearch.PaymentSearch(dataGridViewRecords);
                    }
                        
                    }
                    catch (Exception Ex)
                    {
                MessageBox.Show(Ex.Message + " \nsearch was Not Successful" , "Seach error" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);

                }
                }

            private void btnTodayPayment_Click(object sender, EventArgs e)
                {
                    try
                    {
                    lblTotal.Visible = false;
                        checkTotal.Checked = false;
                radioFirst.Checked = false;
                radioSecond.Checked = false;
                radioThird.Checked = false;
                feeDate = false;
                term = "";
                PaymentRecordSearch.todayRecords(dataGridViewRecords);
                         
                    }
                    catch (Exception)
                    {

                    }
                     
                }

            private void btnAll_Click(object sender, EventArgs e)
                {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
            radioFirst.Checked = false;
            radioSecond.Checked = false;
            radioThird.Checked = false;
            feeDate = false;
            term = "";
            PaymentRecordSearch.PaymentSearch(dataGridViewRecords);
                    
                }

            private void btnSearch_Click(object sender, EventArgs e)
            {
            try
                {
                    PaymentRecordSearch.PaymentSearchButton(dataGridViewRecords, dateTimeFrom, dateTimeTo, txtName, term, combFeeName);
                
                }catch (Exception ex)
                {
                MessageBox.Show(ex.Message + "\nsearch Not Successful" , "Error" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
                }

            private void checkTotal_CheckedChanged(object sender, EventArgs e)
            {
              
            }

            private void checkTotal_Click(object sender, EventArgs e)
                {
                    if (checkTotal.Checked == true)
                    {
                    lblTotal.Text = string.Format("{0:00.#0}", PaymentRecordSearch.total);
                        lblTotal.Visible = true;
                    }
                    else
                    {
                        lblTotal.Visible = false;
                    }
                }

        private void btnPrint_Click(object sender , EventArgs e)
            { 
            try {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
                var printDialog = new PrintDialog();
                printDialog.ShowDialog();
                if (MyPrinter.Print)
                    {
                    MyPrinter.PrintRecords(dataGridViewRecords , MyPrinter.GetPrintTile());
                    }
                }catch (Exception)
                {
                MessageBox.Show("something went wrong, please try again" , "Cash Desk" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
                }
            private void combFeeName_SelectedIndexChanged(object sender, EventArgs e)
                {
                    
                lblTotal.Visible = false;
                checkTotal.Checked = false;
                if (feeDate == true)
                {

                    PaymentRecordSearch.PaymentSearch(dataGridViewRecords, dateTimeFrom, dateTimeTo, combFeeName);
                }
                else
                {

                    PaymentRecordSearch.PaymentSearch(dataGridViewRecords, dateTimeFrom, term, combFeeName);
                }
                     
                }

            private void dataGridRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }

            private void btnPDF_Click(object sender, EventArgs e)
            {
                try
                {
                    schoolInfor sch = new schoolInfor();
                    ConvertFormat.ExportDataTableToPdf(dataGridViewRecords, "Daily pay Record", "Daily pay Record");
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

             
            private void radioThird_Click(object sender, EventArgs e)
            {
                term = radioThird.Text;
            }

            private void radioFirst_Click(object sender, EventArgs e)
            {
                term = radioFirst.Text;
            }

            private void radioSecond_Click(object sender, EventArgs e)
            {
                term = radioSecond.Text;
            }

            private void txtName_TextChanged(object sender, EventArgs e)
                {
                    try
                    {
                        PaymentRecordSearch.PaymentSearch(dataGridViewRecords, dateTimeFrom, dateTimeTo, txtName, term,
                            combFeeName);
                if (string.IsNullOrEmpty(txtName.Text))
                    {
                        PaymentRecordSearch.PaymentSearch(dataGridViewRecords);
                    }
                             
                    }
                    catch (NullReferenceException)
                    {

                    }
                    catch (Exception Ex)
                    {
                MessageBox.Show(Ex.Message + " \nsearch was Not Successful" , "Error" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
                }

            private void btnInstruction_Click(object sender, EventArgs e)
            {
                dailyPaySearchInfor1.Visible = true;
            }

            private void btnReport_Click(object sender, EventArgs e)
                {
                    try
                    {
                if (string.IsNullOrEmpty(combFeeName.Text))
                    {
                    throw new Exception("Select a fee to report");
                    }
                        DailyReports.GetlastReport(combFeeName.Text, dateTimeReport.Value.ToString("MM/dd/yyyy"));
                        DailyReports.InsertDailyReport(combFeeName.Text, RecordAccess.total, RecordAccess.RecordDate);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + " \nReport Not Successful", "Cash Desk", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    }
                }

            private void dateTimeReport_ValueChanged(object sender, EventArgs e)
            {
            try
                {
                if(string.IsNullOrEmpty(combFeeName.Text))
                    {
                    throw new Exception("Select a fee to search");
                    }
                RecordAccess.Report(dataGridViewRecords, combFeeName.Text, dateTimeReport);
                }catch (Exception ex)
                {
                MessageBox.Show(ex.Message + " \nOperation failed" , "Error" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
            }

            

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        { 
            try
            {
                feeDate = true;
                PaymentRecordSearch.PaymentSearch(dataGridViewRecords, dateTimeFrom, dateTimeTo);
                
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + " \noperation Not Successful" , "Error" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
        }

        private void btnViewTaller_Click(object sender, EventArgs e)
        {
            try
                {

                var viewTaller = new ViewTallerForm(StudNames , FeeName , PAmount , Pdate);
                viewTaller.ShowDialog();
                }catch (Exception)
                {
                MessageBox.Show(  "something went wrong, try again" , "Cash Desk" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
        }
        /// <summary>
        /// see all the payments made with taller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllTallerPayments_Click(object sender, EventArgs e)
        {
            try
                {
                var viewTallers = new AllTallerPaymentForm();
                viewTallers.Show();
                }catch (Exception)
                {
                MessageBox.Show( " something went wrong, try again" , "Cash Desk" , MessageBoxButtons.OK ,
                   MessageBoxIcon.Information);
                }
        }

        private void dataGridViewRecords_Click(object sender, EventArgs e)
        {
            try
            {
                lblTotal.Visible = false;
                checkTotal.Checked = false;
                dataAccess.DcashId = Convert.ToInt32(dataGridViewRecords.SelectedRows[0].Cells[0].Value.ToString());
                display.CheckTallerID(dataAccess.DcashId, btnViewTaller);//check if the payment was made with taller
                StudNames = dataGridViewRecords.SelectedRows[0].Cells[1].Value.ToString();
                FeeName = dataGridViewRecords.SelectedRows[0].Cells[3].Value.ToString();
                PAmount = dataGridViewRecords.SelectedRows[0].Cells[5].Value.ToString();
                Pdate = dataGridViewRecords.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
    }
