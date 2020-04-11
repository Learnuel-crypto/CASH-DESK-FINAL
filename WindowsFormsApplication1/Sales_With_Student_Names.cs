using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Sales_With_Student_Names : Form
        {

        bool dateSelect = false;
        int RecordID = 0;
        public Sales_With_Student_Names()
            {
            InitializeComponent();
            SalesWithNames.AllNamesSales(dataGridNamesSalesRecord , "");
            ItemSales.ItemNames(combItemName);
            }

        private void combItemName_SelectedIndexChanged(object sender , EventArgs e)
            {
            try{
            if (dateSelect == true)
                {
                SalesWithNames.AllNamesBetweenDate (dataGridNamesSalesRecord , dateTimeFrom , combItemName.Text);
                } 
            else
                {
                SalesWithNames.AllNamesBetweenDate(dataGridNamesSalesRecord , dateTimeFrom , dateTimeTo , combItemName.Text);
                }
            lblTotal.Text = string.Format("{0:00.#0}" , SalesWithNames.Total);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        

        private void dateTimeFrom_ValueChanged(object sender , EventArgs e)
            {
            dateSelect = true;
            SalesWithNames.AllNamesBetweenDate(dataGridNamesSalesRecord , dateTimeFrom);
            lblTotal.Text = string.Format("{0:00.#0}" , SalesWithNames.Total);
            }

        private void dateTimeTo_ValueChanged(object sender , EventArgs e)
            {
            dateSelect = false;
            SalesWithNames.AllNamesBetweenDate(dataGridNamesSalesRecord , dateTimeFrom , dateTimeTo);
            lblTotal.Text = string.Format("{0:00.#0}" , SalesWithNames.Total);
            }

        private void btnRefresh_Click(object sender , EventArgs e)
            {
            dateSelect = false;
            SalesWithNames.AllNamesSales (dataGridNamesSalesRecord , "");
            }

        private void btnPrintSaleRecord_Click(object sender , EventArgs e)
            {

                var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if(MyPrinter.Print){

                 MyPrinter.PrintRecords(dataGridNamesSalesRecord ,MyPrinter.GetPrintTile());
            }
            
            }

       
        private void btnDelete_Click(object sender , EventArgs e)
            {
            try{
                if (dateSelect == true)
                {
                    if (MessageBox.Show("All records will be Deleted for Selected Date\nContinue ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ItemSales.DeleteSale(dateTimeFrom);
                        dataAccess.Description = "Deleted all Sales record for " + dateTimeFrom.Value.ToString("MM/dd/yyyy");
                        dataAccess.Activities();
                        SalesWithNames.AllNamesSales(dataGridNamesSalesRecord, "");
                        dateSelect = false;
                    }
                }
                else
                {
                    if (MessageBox.Show("Confirm Delete of Selected Record", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //CARRY OUT DELETE
                        if (RecordID <= 0)
                        {
                            throw new Exception("Select a record to Delete");
                        }
                        else
                        {
                            ItemSales.DeleteSale(RecordID);
                            dataAccess.Description = "Deleted an item from Sales record";
                            dataAccess.Activities();
                            SalesWithNames.AllNamesSales(dataGridNamesSalesRecord, "");
                            RecordID = 0;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }

        private void checkTotal_Click(object sender , EventArgs e)
            {
            if (checkTotal.Checked == true)
                {
                lblTotal.Text = string.Format("{0:00.#0}" , SalesWithNames.Total);
                lblTotal.Visible = true;
                }
            else
                {
                lblTotal.Visible = false;
                }
            }

        private void txtItemSearch_TextChanged(object sender , EventArgs e)
            {
            try
                {
                if (!string.IsNullOrEmpty(txtItemSearch.Text))
                    {
                    string pattern = @"(^[a-zA-Z0-9 ]+)$";
                    Match match = Regex.Match(txtItemSearch.Text , pattern);
                    if (!match.Success)
                        {
                        throw new Exception("Search contains invalid character");
                        }
                    SalesWithNames.AllNamesSales(dataGridNamesSalesRecord , txtItemSearch.Text);
                    lblTotal.Text = string.Format("{0:00.#0}" , SalesWithNames.Total);
                    }
                else
                    {
                    SalesWithNames.AllNamesSales(dataGridNamesSalesRecord , "");
                    lblTotal.Text = string.Format("{0:00.#0}" , SalesWithNames.Total);
                    }

                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void dataGridNamesSalesRecord_Click(object sender , EventArgs e)
            {
            try
                {
                RecordID = Int32.Parse(dataGridNamesSalesRecord.SelectedRows[0].Cells[0].Value.ToString());
                }
            catch (Exception) { }
            }

        
        }
    }
