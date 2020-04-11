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
    public partial class Payfees : UserControl
    {
        public Payfees()
        {
            InitializeComponent();
        }

        private void radioDebt_CheckedChanged(object sender, EventArgs e)
        {
            panyear.Visible = true;
        }

        private void radioCurrent_CheckedChanged(object sender, EventArgs e)
        {
            panyear.Visible = false;
            txtdebtyear.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

         

        

         
    }
}
