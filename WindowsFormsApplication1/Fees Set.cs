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
    public partial class Fees_Set : Form
        {
        public Fees_Set()
            {
            InitializeComponent();
            }

        private void Fees_Set_Load(object sender, EventArgs e)
            {
            var viewSetFee = new ViewSetFees();
                viewSetFee.DisplaySetFees(dataGridViewFees);
            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnpdf_Click(object sender, EventArgs e)
            { 
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridViewFees, "Set Fees Record", "Set Fees Record");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
        }
    }
