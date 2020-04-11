using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Daily_Sales_Report : Form
        {
        int ReportID = 0;
        bool dateSelected = false;
        public Daily_Sales_Report()
            {
            InitializeComponent();
            AllSalesReport.DisplayReport(dataGridDailyReport);
            ItemSales.ItemNames(combItemName);
            }

        private void checkTotal_Click(object sender , EventArgs e)
            {
            if (checkTotal.Checked == true)
                {
                lblTotal.Text =string.Format("{0:00.#0}", AllSalesReport.Total);
                lblTotal.Visible = true;
                }
            else
                {
                lblTotal.Visible = false;
                }
            }

        private void btnRefresh_Click(object sender , EventArgs e)
            {
            dateSelected = false;
            AllSalesReport.DisplayReport(dataGridDailyReport);
            }

        private void btnPrintSaleRecord_Click(object sender , EventArgs e)
            {
                var printDialog = new PrintDialog();
                printDialog.ShowDialog();
                if (MyPrinter.Print)
                {
                    MyPrinter.PrintRecords(dataGridDailyReport, MyPrinter.GetPrintTile());
                }
            }
         

        private void combItemName_SelectedIndexChanged(object sender , EventArgs e)
            {
            if (dateSelected == true)
                {
                AllSalesReport.AllReportBetweenDate(dataGridDailyReport , dateTimeFrom , combItemName.Text);
                }
            else
                {
                AllSalesReport.DisplaySelectedReport(dataGridDailyReport , combItemName.Text);
                } 
            lblTotal.Text = string.Format("{0:00.#0}" , AllSalesReport.Total);
            }

        private void txtItemSearch_TextChanged(object sender , EventArgs e)
            {
            try
                {
                if (!string.IsNullOrEmpty(txtItemSearch.Text))
                    {
                    
                    AllSalesReport.DisplayReport(dataGridDailyReport , txtItemSearch.Text); 
                    }
                else
                    {
                    AllSalesReport.DisplayReport(dataGridDailyReport , ""); 
                    }
                lblTotal.Text = string.Format("{0:00.#0}" , AllSalesReport.Total);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void dataGridDailyReport_Click(object sender , EventArgs e)
            {
            try
                {
                dateSelected = false;
                ReportID = Int32.Parse(dataGridDailyReport.SelectedRows[0].Cells[0].Value.ToString());
                }
            catch (Exception)
                {

                }
            }

        

        private void dateTimeFrom_ValueChanged(object sender , EventArgs e)
            {
            dateSelected = true;
            AllSalesReport.AllReportBetweenDate(dataGridDailyReport , dateTimeFrom , "");
            }

        private void dateTimeTo_ValueChanged(object sender , EventArgs e)
            {
            dateSelected = false;
            AllSalesReport.AllReportBetweenDate(dataGridDailyReport , dateTimeFrom ,dateTimeTo);
            }

        private void btnDelete_Click(object sender , EventArgs e)
            {
            try
                {
                if (dateSelected == true) 
                    {
                    if (MessageBox.Show("Do you want to delete record(s) for the selected Date ?" , "Multiple Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                        AllSalesReport.DeleteReport(dateTimeFrom);
                        dataAccess.Description = "Deleted Report record(s) for " + dateTimeFrom.Value.ToString("MM/dd/yyyy");
                        dataAccess.Activities();
                        MessageBox.Show("Delete Successful" , "Delete Completed" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        AllSalesReport.DisplayReport(dataGridDailyReport);
                        }
                    }
              else  if (ReportID == 0)
                    {
                    throw new Exception("No record is selected, Selete a record to Delete");
                    }
                else
                    {
                    if (MessageBox.Show("Do you want to delete Selected record ?" , "Confirm Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                        AllSalesReport.DeleteReport(ReportID);
                        dataAccess.Description = "Deleted a Report record ";
                        dataAccess.Activities();
                        MessageBox.Show("Delete Successful" , "Delete Completed" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        AllSalesReport.DisplayReport(dataGridDailyReport);
                        }
                    }
               
                }
            catch (Exception ex)
                {
                throw new  ExceptionHandling( "Delete Error" ,ex );

                }
             
            }
        }
    }
