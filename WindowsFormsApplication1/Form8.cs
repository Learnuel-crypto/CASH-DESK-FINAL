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
    public partial class Form8 : Form
    {
        DailyReports report = new DailyReports();
        public Form8()
        {
            InitializeComponent();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            report.DisplayReports (dataGridRecordsReport);
        }

        private void btnPrintDailyReports_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecordsPortrate(dataGridRecordsReport, MyPrinter.GetPrintTile());
            }
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            checkTotal.Checked = false;
            lblTotal.Visible = false;
            DailyReports.SearchDailyReport(dataGridRecordsReport, txtsearch);
            if(string.IsNullOrEmpty(txtsearch.Text))
                report.DisplayReports(dataGridRecordsReport);
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DailyReports.SearchDailyReport(dataGridRecordsReport, dateTimeFrom, dateTimeTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkTotal.Checked = false;
            lblTotal.Visible = false;
            DailyReports.SearchDailyReport(dataGridRecordsReport, dateTimeFrom, dateTimeTo, txtsearch);
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            checkTotal.Checked = false;
            lblTotal.Visible = false;
            DailyReports.SearchDailyReport(dataGridRecordsReport, dateTimeFrom);
        }

        private void checkTotal_Click(object sender, EventArgs e)
        {
            if (checkTotal.Checked == true)
            {
                lblTotal.Text =string.Format("{0:00.#0}", DailyReports.Total.ToString());
                lblTotal.Visible = true;
            }
            else
            {
                lblTotal.Visible = false;
            }
        }
    }
}
