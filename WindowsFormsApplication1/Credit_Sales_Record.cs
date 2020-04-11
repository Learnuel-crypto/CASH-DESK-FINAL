using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Credit_Sales_Record : Form
        {
        bool DateSelect = false;
        int SalesID = 0;
        public Credit_Sales_Record()
            {
            InitializeComponent();
            CreditSales.AllCreditSales(dataGridCreditSalesRecord , txtItemSearch.Text);
            lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
            ItemSales.ItemNames(combItemName);
            }

        private void btnRefresh_Click(object sender , EventArgs e)
            {
                try
                {
                    DateSelect = false;
                    CreditSales.AllCreditSales(dataGridCreditSalesRecord, txtItemSearch.Text);
                    lblTotal.Text = string.Format("{0:00.#0}", ItemSales.TodayTotal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void dateTimeFrom_ValueChanged(object sender , EventArgs e)
            {
                try
                {
                    DateSelect = true;
                    CreditSales.AllCreditBetweenDate(dataGridCreditSalesRecord, dateTimeFrom);
                    lblTotal.Text = string.Format("{0:00.#0}", ItemSales.TodayTotal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void dateTimeTo_ValueChanged(object sender , EventArgs e)
            {
                try
                {
                    DateSelect = false;
                    CreditSales.AllCreditBetweenDate(dataGridCreditSalesRecord, dateTimeFrom, dateTimeTo);
                    lblTotal.Text = string.Format("{0:00.#0}", ItemSales.TodayTotal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void combItemName_SelectedIndexChanged(object sender , EventArgs e)
            {
                try
                {
                    CreditSales.AllCreditBetweenDate(dataGridCreditSalesRecord, dateTimeFrom, dateTimeTo, combItemName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void txtItemSearch_TextChanged(object sender , EventArgs e)
            {
            try
                { 
                    CreditSales.AllCreditSales(dataGridCreditSalesRecord , txtItemSearch.Text);
                    lblTotal.Text = string.Format("{0:00.#0}" , ItemSales.TodayTotal);
                     
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
           
            }

        private void btnPrintSaleRecord_Click(object sender , EventArgs e)
            {

                var printDialog = new PrintDialog();
                printDialog.ShowDialog();
                if (MyPrinter.Print)
                {
                    MyPrinter.PrintRecords(dataGridCreditSalesRecord, MyPrinter.GetPrintTile());
                }
             
            }

        

        private void checkTotal_Click(object sender , EventArgs e)
            {
            if (checkTotal.Checked == true)
                {
                lblTotal.Text = string.Format("{0:00.#0}" , CreditSales.TodayCredit.ToString());
                lblTotal.Visible = true;
                }
            else
                {
                lblTotal.Visible = false;
                }
            }

        private void btnDelete_Click(object sender , EventArgs e)
            {

            //DELETE CODE MOT WORKING FINE 
            if (DateSelect == true)
                {
                if (MessageBox.Show("All records will be Deleted for Selected Date\nContinue ?" , "Confirm Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                    ItemSales.DeleteSale(dateTimeFrom);
                    dataAccess.Description = "Deleted all credit Sales record for " + dateTimeFrom.Value.ToString("MM/dd/yyyy");
                    dataAccess.Activities();
                    CreditSales.AllCreditSales(dataGridCreditSalesRecord ,"");
                    DateSelect = false;
                    }
                }
            else
                {
                if (MessageBox.Show("Confirm Delete of Selected Record" , "Confirm Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                    //CARRY OUT DELETE
                    if (SalesID <= 0)
                        {
                        throw new Exception("Select a record to Delete");
                        }
                    else
                        {
                        ItemSales.DeleteSale(SalesID);
                        dataAccess.Description = "Deleted a Credit Sales record";
                        dataAccess.Activities();
                        CreditSales.AllCreditSales(dataGridCreditSalesRecord , "");
                        SalesID = 0;
                        }
                    }
                }
            
            }

        private void dataGridCreditSalesRecord_Click(object sender , EventArgs e)
            {
            try
                {
                SalesID = Int32.Parse(dataGridCreditSalesRecord.SelectedRows[0].Cells[9].Value.ToString());
                }catch (Exception)
                {

                }
            }
        }
    }
