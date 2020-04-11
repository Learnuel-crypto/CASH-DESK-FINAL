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
    public partial class AdminLogs : Form
        {
        public AdminLogs()
            {
            InitializeComponent();
            }

        private void btnTodayActivity_Click(object sender, EventArgs e)
            {
            AdminLogEvents.AdminlogsToday(dataGridActivity);
            }

        private void btnViewAll_Click(object sender, EventArgs e)
            {
            AdminLogEvents.AdminLogs(dataGridActivity);
            }

        private void AdminLogs_Load(object sender, EventArgs e)
            {
            AdminLogEvents.AdminLogs(dataGridActivity);
            }

        private void btnDeleteActivities_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Are you sure you want to Delete ?", "Cash Desk", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    AdminLogEvents.DeleleAdminLogs();
                    AdminLogEvents.AdminLogs(dataGridActivity);
                    MessageBox.Show("Records Deleted Successfully", "Cash Desk", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                    var logout =new AdminLogOut();
                    logout.ShowDialog();
                }
            }

        private void btnclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnExport_Click(object sender, EventArgs e)
        { 
           try{
               ConvertFormat.ExportDataTableToPdf(dataGridActivity,"Admin Log Records","Admin Log Records");
           }
            catch(Exception Ex){
                MessageBox.Show(Ex.Message+"\nOperation Failed", "Export Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
        }
    }
