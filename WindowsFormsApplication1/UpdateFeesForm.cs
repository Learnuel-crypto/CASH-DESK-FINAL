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
    public partial class UpdateFeesForm : Form
    {

        string feeid; string sessionid; string feename;
        public UpdateFeesForm()
        {
            InitializeComponent();
            UpdateFee.viewFees(dataGridSession);
        }
       
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void dataGridSession_Click(object sender, EventArgs e)
        {
            try
            {
                feeid = dataGridSession.SelectedRows[0].Cells[0].Value.ToString();
                sessionid = dataGridSession.SelectedRows[0].Cells[1].Value.ToString();
                txtSection.Text = dataGridSession.SelectedRows[0].Cells[2].Value.ToString();
                feename = dataGridSession.SelectedRows[0].Cells[3].Value.ToString();
                txtFeename.Text = dataGridSession.SelectedRows[0].Cells[3].Value.ToString();
                txtAmount.Text = dataGridSession.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception) { }
        }
        void Clear()
        {
            feeid = "";
            txtAmount.Clear();
            txtFeename.Clear();
            txtSection.Clear();
            feename = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(feeid)){
                    throw new Exception("Select a record to perform operation");
                }
                if (UpdateFee.isUpdate(sessionid, feename))
                {
                    var fees = new Fees();
                    fees.setSection(txtSection.Text);
                    fees.setFeeName(txtFeename.Text);
                    fees.setAmount(double.Parse(txtAmount.Text));
                    UpdateFee.updateFee(feeid, fees.getSection(), fees.getFeeName(), fees.getAmount().ToString());
                    MessageBox.Show("Update Successful", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    throw new Exception("Fee CANNOT be updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(feeid))
                {
                    throw new Exception("Select a record to perform operation");
                }

                if (UpdateFee.isUpdate(sessionid,feename))
                {
                    UpdateFee.DeletFee(feeid);
                    MessageBox.Show("Delete Successful", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    throw new Exception("Fee CANNOT be updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
