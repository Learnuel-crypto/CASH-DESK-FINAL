using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SalesStock : Form
    {
        bool dateSearch = false;
        string stockID;
        public SalesStock()
        {
            InitializeComponent();
            setSales.DisplayStock(dataGridItmes);
            ItemSales.StockNames(combStockName);
        }

        private void btnPrintStock_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecordsPortrate(dataGridItmes, MyPrinter.GetPrintTile());
            }
        }

        private void combStockName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateSearch == true)
                {
                    setSales.DisplayStockThroughDate(dataGridItmes, dateTimeFrom, dateTimeTo, combStockName.Text);
                }
                else
                {
                    setSales.SearchStock(dataGridItmes, combStockName.Text);

                }
                dateSearch = false;
                setSales.StockInfor(combStockName.Text, lblTotal, lblSold, lblAvailable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            setSales.SearchStockAll(dataGridItmes, txtSearch.Text);
            lblAvailable.Text = "0";
            lblSold.Text = "0";
            lblTotal.Text = "0";
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                setSales.DisplayStockThroughDate(dataGridItmes, dateTimeFrom, dateTimeTo, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalesStock_Load(object sender, EventArgs e)
        {

        }

        private void dataGridItmes_Click(object sender, EventArgs e)
        {
            try
            {
                stockID = dataGridItmes.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(stockID))
                {
                    throw new Exception("Select a record to perfrom operation");
                }
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    setSales.DeleteStock(stockID);
                    setSales.DisplayStock(dataGridItmes);
                    ItemSales.StockNames(combStockName);
                    stockID = "";
                    MessageBox.Show("Delete Successful", "Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
