using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Today_Sales_Record : Form
        {
        public Today_Sales_Record()
            {
            InitializeComponent();
            ItemSales.TodaySales(dataGridTodaySalesRecord);
            ItemSales.ItemNames(combItemName);
            }

        private void btnRefresh_Click(object sender , EventArgs e)
            {
            ItemSales.TodaySales(dataGridTodaySalesRecord);
            }

        private void combItemName_SelectedIndexChanged(object sender , EventArgs e)
            {
            if (string.IsNullOrEmpty(combItemName.Text))
                {
                ItemSales.TodaySales(dataGridTodaySalesRecord);
                }
            else
                { 
                ItemSales.TodaySalesItems(dataGridTodaySalesRecord , combItemName.Text);
                }
            }

        private void checkTotalAmount_Click(object sender , EventArgs e)
            {
            if (checkTotalAmount.Checked == true)
                {
                lblTotal.Text =string.Format("{0:00.#0}", ItemSales.TodayTotal);
                lblTotal.Visible = true;
                }
            else
                {
                lblTotal.Visible = false;
                }

            }

        private void btnPrintSaleRecord_Click(object sender , EventArgs e)
            {
                var printDialog = new PrintDialog();
                printDialog.ShowDialog();
                if (MyPrinter.Print)
                {

                    MyPrinter.PrintRecords(dataGridTodaySalesRecord, MyPrinter.GetPrintTile());
                }
            }

        private void btnHowToReport_Click(object sender , EventArgs e)
            {
            how_to_Report_Daily_Sales1.Visible = true;
            }

        private void btnReportSales_Click(object sender , EventArgs e)
            {
            try
                {
                if (!string.IsNullOrEmpty(combItemName.Text))
                    {
                    AllSalesReport.CheckItemReport(combItemName.Text , DateTime.Today);
                    AllSalesReport.InsertReport(combItemName.Text , DateTime.Today);
                    MessageBox.Show("Report completed Successfully" , "Sales Report" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                else
                    {
                    throw new Exception("No Item is selected for report");
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Report Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
         
        }
    }
