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
    public partial class InforDebt : UserControl
        {
        public InforDebt()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        }
    }
