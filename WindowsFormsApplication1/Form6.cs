using System;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace WindowsFormsApplication1
{
    public partial class ReportForm : Form
    {
        private string term=null ;
        EvenPayList eventlist = new EvenPayList();
        RegularPay regularPay=new RegularPay();
      private  bool searchYear = false;
      bool pastYear = false;
        public ReportForm()
        {
            InitializeComponent();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        } 
        private void btnlog_Click(object sender, EventArgs e)
        { 
            ActivityForm af = new ActivityForm();
            af.ShowDialog();
        }

        private void btnviewstudents_Click(object sender, EventArgs e)
        {
            var view = new Form8();
            view.ShowDialog();
            view.ShowInTaskbar = false;
        }

        private void btnpayRec_Click(object sender, EventArgs e)
        {
            var payRec = new PayRecordsForm();
            payRec.ShowDialog();
            
        }

        private void btnDailyIncome_Click(object sender, EventArgs e)
        {
            var TDI = new TotalDailyIncome();
            TDI.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
            {
                AllExpenses alp = new AllExpenses();
                alp.ShowDialog();
            }

        private void radioFirst_Click(object sender, EventArgs e)
        {
             term = radioFirst.Text;
            if (checkEvent.Checked == true)
                {
                eventlist.SearchEventList(dataGridEventList , term);
                if (string.IsNullOrEmpty(txtFeeName.Text)) { 
                    eventlist.SearchEventList(dataGridEventList , term);
                }
            }
            else
            {
                regularPay.SearchRegularPay(dataGridRegularPay, term);
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            regularPay.DisplayRegularPay(dataGridRegularPay);
            eventlist.DisplayEventList(dataGridEventList);
            dataGridRegularPay.Visible = true;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void radioSecond_Click(object sender, EventArgs e)
        {
              term = radioSecond.Text;
            if (checkEvent.Checked == true)
            {
                eventlist.SearchEventList(dataGridEventList, term);
            }
            else
            {
                regularPay.SearchRegularPay(dataGridRegularPay, term);
            }
        }

        private void radioThird_Click(object sender, EventArgs e)
            {
                  term = radioThird.Text;
                if (checkEvent.Checked == true)
                {
                    eventlist.SearchEventList(dataGridEventList,term);
                }
                else
                {
                    regularPay.SearchRegularPay(dataGridRegularPay, term);
                }
            }

        private void btnClose_Click(object sender, EventArgs e)
            { 
            this.Close();  
            }

        private void btnDebtorsListGenerate_Click(object sender, EventArgs e)
        {
            var debtorsList = new DebtorsList();
            debtorsList.Show();
        }

        private void btnCleared_Click(object sender, EventArgs e)
            {
            var fulPayment = new ClearedPayments();
                fulPayment.Show();
            }

        private void btnEventCleared_Click(object sender, EventArgs e)
            {
            var cleared = new EventPayRecord();
                cleared.Show();
            }

        private void btnNotCleared_Click(object sender, EventArgs e)
            {
            var notCleared = new EventDebtRecord();
                notCleared.Show();
            }

        private void btnEventCleared_Click_1(object sender, EventArgs e)
        {
            var cleared = new EventPayRecord();
            cleared.Show();
        }

        private void dataGridRegularPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void btnPdf_Click(object sender, EventArgs e)
            {
            
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridRegularPay, "Regular Fees Record", "Regular Fees Record");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void btnEventPdf_Click(object sender, EventArgs e)
            {
            ConvertFormat.convertToPDF(dataGridEventList,"Event Fees Record");
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridEventList, "Event Fees Record", "Event Fees Record");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            } 

        private void btnNotCleared_Click_1(object sender, EventArgs e)
        {
            var evenDebt = new EventDebtRecord();
            evenDebt.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
            {
                timer1.Start();
                regularPay.DisplayRegularPay(dataGridRegularPay);
                radioFirst.Checked = false;
                radioSecond.Checked = false;
                radioThird.Checked = false;
                term =" ";
            searchYear = false;
                txtFeeName.Clear();
                txtStudnetName.Clear();
                dateTimeYear.Value = DateTime.Now.Date;

            }
 
        private void btnSearch_Click(object sender, EventArgs e)
            {
                if (checkEvent.Checked == true)
                {
                    eventlist.SearchEventList(dataGridEventList,dateTimeYear,term,txtFeeName,txtStudnetName);
                }
                else
                {
                    regularPay.SearchRegularPay(dataGridRegularPay,dateTimeYear, term, txtFeeName,txtStudnetName);
                }
            }

        private void checkEvent_Click(object sender, EventArgs e)
            {
                if (checkEvent.Checked == false)
                {
                    dataGridEventList.Visible = false;
                    panelEvents.Visible = false;
                    groupRegular.Text = "Regular Fees";
                    dataGridRegularPay.Visible = true; 
                    radioFirst.Checked = false;
                    radioSecond.Checked = false;
                    radioThird.Checked = false;
                    term ="";
                searchYear = false;
                    regularPay.DisplayRegularPay(dataGridRegularPay);
                }
                if (checkEvent.Checked == true)
                {
                    radioFirst.Checked = false;
                    radioSecond.Checked = false;
                    radioThird.Checked = false;
                    term = "";
                searchYear = false;
                   dataGridEventList.Visible = true;
                    panelEvents.Visible = true;
                    groupRegular.Text = "Event Fees";
                    eventlist.DisplayEventList(dataGridEventList);
                dataGridRegularPay.Visible = false; 
                }
            }

        
        private void timer1_Tick(object sender, EventArgs e)
            { 
            if (Cash.isPaid() == true)
                {
                regularPay.DisplayRegularPay(dataGridRegularPay);
                eventlist.DisplayEventList(dataGridEventList);
                Cash.paid = false;
                }
            }

        private void radioThird_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void btnPrintRegularFees_Click(object sender, EventArgs e)
            {

            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
                {
                MyPrinter.PrintRecords(dataGridRegularPay , MyPrinter.GetPrintTile());
                } 
            }

        private void btnPrintEvents_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
                {
                MyPrinter.PrintRecords(dataGridEventList , MyPrinter.GetPrintTile());
                }
            }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
            {
            searchYear = true;
                if (checkEvent.Checked == true)
                {
                    eventlist.SearchEventList(dataGridEventList,dateTimeFrom,dateTimeTo,term);
                }
                else
                {
                    regularPay.SearchRegularPay(dataGridRegularPay, dateTimeFrom, dateTimeTo, term);
                }
            }

        private void txtStudnetName_TextChanged(object sender, EventArgs e)
            { 
                if (checkEvent.Checked == true)
                {
                    eventlist.SearchEventList(dataGridEventList, term, txtFeeName, txtStudnetName);
                }
                else
                {
                regularPay.SearchRegularPay(dataGridRegularPay, term, txtFeeName, txtStudnetName);
                }
            }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            reportSearchInfor2.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            {
                if (radioFirst.Checked == true)
                {
                    regularPay.SearchRegularPay(dataGridRegularPay, term);
                    
                }
                else if (radioSecond.Checked == true)
                {
                    regularPay.SearchRegularPay(dataGridRegularPay, term);
                    
                }
                else if (radioThird.Checked == true)
                {
                    regularPay.SearchRegularPay(dataGridRegularPay, term);
                    
                }
                else
                    {
                    regularPay.DisplayRegularPay(dataGridRegularPay);
                    eventlist.DisplayEventList(dataGridEventList);
                    
                }

                term = "";
            searchYear = false;
            }

        private void btnView_Click(object sender, EventArgs e)
            {
            var views = new Form9();
            views.ShowDialog();
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioFirst.Checked == true)
            {
                regularPay.SearchRegularPay(dataGridRegularPay, term);
                
            }
            else if (radioSecond.Checked == true)
            {
                regularPay.SearchRegularPay(dataGridRegularPay, term);
                
            }
            else if (radioThird.Checked == true)
            {
                regularPay.SearchRegularPay(dataGridRegularPay, term);
                
            }
            else
            {
                regularPay.DisplayRegularPay(dataGridRegularPay);
                eventlist.DisplayEventList(dataGridEventList);
                
            }
        }

        private void txtFeeName_TextChanged_1(object sender , EventArgs e)
            {
                try
                {
                    if (checkEvent.Checked == true)
                    {

                        if (searchYear == true)
                        {
                            if (string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                eventlist.DisplayEventList(dataGridEventList);
                            }
                            else
                            {
                                eventlist.SearchEventListWithDate(dataGridEventList, dateTimeFrom, dateTimeTo, term, txtFeeName.Text);
                            }
                        }
                        else if (pastYear == true)
                        {

                            if (string.IsNullOrEmpty(term))
                            {
                                throw new Exception("Select Term or click Reset");
                            }
                            else if (string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                eventlist.DisplayEventList(dataGridEventList);
                            }
                            else
                            {
                                eventlist.PastYearEventList(dataGridEventList, dateTimeYear, term, txtFeeName.Text);
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                eventlist.DisplayEventList(dataGridEventList);

                            }
                            else if (string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                eventlist.SearchAllEventList(dataGridEventList, txtFeeName.Text);
                            }
                            else if (string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                eventlist.SearchEventList(dataGridEventList, term);
                            }
                            else
                            {
                                eventlist.SearchEventList(dataGridEventList, term, txtFeeName);
                            }
                        }
                    }
                    else
                    {

                        if (searchYear == true)
                        {
                            if (string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                regularPay.DisplayRegularPay(dataGridRegularPay);
                            }
                            else
                            {
                                regularPay.SearchRegularPayWithDate(dataGridRegularPay, dateTimeFrom, dateTimeTo, term, txtFeeName.Text);
                            }
                        } 
                        else if (pastYear == true)
                        {

                            if (string.IsNullOrEmpty(term))
                            {
                                throw new Exception("Select Term or click Reset");
                            }
                            else if (string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                regularPay.DisplayRegularPay(dataGridRegularPay);
                            }
                            else
                            {
                                regularPay.PastYearRegularPay(dataGridRegularPay, dateTimeYear, term, txtFeeName.Text);
                            }
                        }

                        else
                        {
                            if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                regularPay.DisplayRegularPay(dataGridRegularPay);
                            }
                            else if (string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                regularPay.SearchAllRegularPay(dataGridRegularPay, txtFeeName.Text);
                            }
                            else if (string.IsNullOrEmpty(txtFeeName.Text))
                            {
                                regularPay.SearchRegularPay(dataGridRegularPay, term);
                            }
                            else
                            {
                                regularPay.SearchRegularPay(dataGridRegularPay, term, txtFeeName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void dateTimeFrom_ValueChanged_1(object sender , EventArgs e)
            {

            }

        private void dateTimeYear_ValueChanged(object sender , EventArgs e)
            {
                pastYear = true;
            if (checkEvent.Checked == true)
                {
                eventlist.SearchEventList(dataGridEventList , dateTimeYear , term);
                }

            else
                {
                regularPay.SearchRegularPay(dataGridRegularPay , dateTimeYear , term);
                }
            }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pastYear = false;
            searchYear = false;
            radioFirst.Checked = false;
            radioSecond.Checked = false;
            radioThird.Checked = false;
            term = "";
        }
        }
}
