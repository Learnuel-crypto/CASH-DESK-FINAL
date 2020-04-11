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
    public partial class ActivationPanel : UserControl
    {
        public ActivationPanel()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var generate = new GenerateForm();
            generate.ShowDialog();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            var activate = new ActivationForm();
            activate.ShowDialog();
                }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            var aboutus = new AboutUsForm();
            aboutus.ShowDialog();
        }
    }
}
