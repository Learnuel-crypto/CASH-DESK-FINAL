using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Report_From_SalesForm : UserControl
        {
        public Report_From_SalesForm()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            this.Visible = false;
            }
        }
    }
