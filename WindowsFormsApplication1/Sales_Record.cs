using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Sales_Record : Form
        {
        bool dateSelect = false;
        int SalesID = 0;
        public Sales_Record()
            {
            InitializeComponent();
            ItemSales.AllSales(dataGridSalesRecord,txtItemSearch.Text);
            ItemSales.ItemNames(combItemName);
            
            }

        private void timer1_Tick(object sender , EventArgs e)
            {
            
            if (ItemSales.isSaleMade()==true)
                {
                //TODO
                ///REFRESH THE SALES RECOD
                ItemSales.AllSales(dataGridSalesRecord, "");
                timer1.Stop();
                }
            else
                {
                timer1.Stop();
                }

            if (ItemSales.isSaleDeleted() == true)
                {
                ItemSales.AllSales(dataGridSalesRecord , "");
                timer1.Stop();
                }
            else
                {
                timer1.Stop();
                }
            }

        private void btnMakeSale_Click(object sender , EventArgs e)
            {
            try { 
            var makeSales = new Make_Sale();
            makeSales.ShowDialog();
            timer1.Start();//start the time when sales form pops up.
            ItemSales.ItemNames(combItemName);
            }
            catch (Exception)
                {
                MessageBox.Show("Something went wrong, Try again." , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
    }

        private void btnAddItem_Click(object sender , EventArgs e)
            {
            try { 
            var addItem = new Add_Items();
            addItem.ShowDialog();
            ItemSales.ItemNames(combItemName);
                }
            catch (Exception)
                {
                MessageBox.Show("Something went wrong, Try again." , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnDelete_Click(object sender , EventArgs e)
            {
            try{
            if (dateSelect == true)
                {
                if (MessageBox.Show("All records will be Deleted for Selected Date\nContinue ?" , "Confirm Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                    { 
                        ItemSales.DeleteSale(dateTimeFrom);
                        dataAccess.Description = "Deleted all Sales record for "+ dateTimeFrom.Value.ToString("MM/dd/yyyy");
                        dataAccess.Activities();
                        ItemSales.AllSales(dataGridSalesRecord , "");
                    dateSelect = false;
                    }
                }
            else
                {
                if (MessageBox.Show("Confirm Delete of Selected Record" , "Confirm Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                    { 
                    if (SalesID <= 0)
                        {
                        throw new Exception("Select a record to Delete");
                        }
                    else
                        {
                        ItemSales.DeleteSale(SalesID);
                        dataAccess.Description = "Deleted an item from Sales record";
                        dataAccess.Activities();
                        ItemSales.AllSales(dataGridSalesRecord , "");
                        SalesID = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void btnTodaySales_Click(object sender , EventArgs e)
            {
            try
                {
                var todaysale = new Today_Sales_Record();
                todaysale.ShowDialog();
            }catch(Exception)
                {
                MessageBox.Show("Something went wrong, Try again." , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
    }

        private void btnPrintSaleRecord_Click(object sender , EventArgs e)
            {
                var printDialoge = new PrintDialog();
                printDialoge.ShowDialog();
                if (MyPrinter.Print)
                { 
                    MyPrinter.PrintRecords(dataGridSalesRecord, MyPrinter.GetPrintTile());
                }
            
            }
         
        private void txtPrintTitle_Click(object sender , EventArgs e)
            {
           
            }

       
        private void dateTimeTo_ValueChanged(object sender , EventArgs e)
            {
            dateSelect = false;
            ItemSales.AllSalesBetweenDate(dataGridSalesRecord , dateTimeFrom , dateTimeTo);
            lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
            }

        private void combItemName_SelectedIndexChanged(object sender , EventArgs e)
            {
            if (dateSelect == true)
                {
                ItemSales.AllSalesBetweenDate(dataGridSalesRecord , dateTimeFrom , combItemName.Text); 
                }
            else
                {
                ItemSales.AllSalesBetweenDate(dataGridSalesRecord , dateTimeFrom , dateTimeTo , combItemName.Text);
                } 
            lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
            }

        private void dateTimeFrom_ValueChanged(object sender , EventArgs e)
            {
            dateSelect = true;
            ItemSales.AllSalesBetweenDate(dataGridSalesRecord , dateTimeFrom);
            lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
           
            }

        private void checkTotal_Click(object sender , EventArgs e)
            {
            if (checkTotal.Checked == true)
                {
                lblTotal.Text =string.Format("{0:00.#0}", ItemSales.TodayTotal);
                lblTotal.Visible = true;
                }
            else
                {
                lblTotal.Visible = false;
                }
            }

        private void btnRefresh_Click(object sender , EventArgs e)
            {
            dateSelect = false;
            ItemSales.AllSales(dataGridSalesRecord, "");
            }

        private void btnWhatisReport_Click(object sender , EventArgs e)
            {
            what_Is_Report1.Visible = true;
            }

        private void btnInstruction_Click(object sender , EventArgs e)
            {
            report_From_SalesForm1.Visible = true;
            }

        private void txtItemSearch_TextChanged(object sender , EventArgs e)
            {
            try
                {
                if (!string.IsNullOrEmpty(txtItemSearch.Text))
                    {
                     
                    ItemSales.AllSales(dataGridSalesRecord , txtItemSearch.Text);
                    lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
                    }
                else
                    {
                    ItemSales.AllSales(dataGridSalesRecord , "");
                    lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
                    }
                
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void dataGridSalesRecord_Click(object sender , EventArgs e)
            {
            try
                {
                SalesID = Int32.Parse(dataGridSalesRecord.SelectedRows[0].Cells[8].Value.ToString());
                dateSelect = false;
                }catch(Exception) { }
            }

        private void btnCreditSales_Click(object sender , EventArgs e)
            {
            try { 
            var creditsales = new Credit_Sales_Record();
            creditsales.ShowDialog();
            timer1.Start();
            ItemSales.ItemNames(combItemName);
            }catch(Exception)
                {
                MessageBox.Show("Something went wrong, Try again." , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
    }

        private void btnAllSalesInfor_Click(object sender , EventArgs e)
            {
            try { 
            var namesSales = new Sales_With_Student_Names();
            namesSales.ShowDialog();
                }
            catch (Exception)
                {
                MessageBox.Show("Something went wrong, Try again." , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnReportSales_Click(object sender , EventArgs e)
            {
            try
                {
                AllSalesReport.CheckItemReport(combItemName.Text , dateTimeFrom.Value);
                AllSalesReport.InsertReport(combItemName.Text , dateTimeFrom.Value);
                MessageBox.Show("Report completed Successfully" , "Sales Report" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Report Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnSalesReport_Click(object sender , EventArgs e)
            {
            try
                {
                var dailyReport = new Daily_Sales_Report();
            dailyReport.Show();
                }
            catch (Exception)
                {
                MessageBox.Show("Something went wrong, Try again." , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnStock_Click(object sender , EventArgs e)
            {
                try
                {
                    var stock = new SalesStock();
                    stock.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong try again", "Cashdesk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
