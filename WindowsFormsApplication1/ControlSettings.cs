using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class ControlSettings : UserControl
        {
        public ControlSettings()
            {
            InitializeComponent();
            }

        private void btnAdminLogout_Click(object sender, EventArgs e)
            {
                AdminLog.AdminLogs(AdminLog.Admin, btnAdminLogout.Text);
                var Logout = new AdminLogOut();
                this.Visible = false;
                Logout.ShowDialog();

               
            }

        private void ControlSettings_MouseLeave(object sender, EventArgs e)
            {
             
            }

        private void btnAdminLogout_MouseEnter(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void btnAdminLogout_MouseHover(object sender, EventArgs e)
            {
                this.Visible = true;
            }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            this.Visible = false;
               var logs=new AdminLogs();
                logs.Show();
            }
        }
    }
