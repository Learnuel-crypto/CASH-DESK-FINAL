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
    public partial class What_Is_Report : UserControl
        {
        public What_Is_Report()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            this.Visible = false;
            }
        }
    }
