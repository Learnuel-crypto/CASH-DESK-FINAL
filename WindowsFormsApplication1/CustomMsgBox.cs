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
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }
        static CustomMsgBox MsgBox; static DialogResult result = DialogResult.OK;
        public static DialogResult Show(string text, string Caption, string btnYes, string btnNo)
        {
            MsgBox = new CustomMsgBox();
            MsgBox.label1.Text = text;
            MsgBox.Text = Caption;
            MsgBox.button1.Text = btnYes;
            MsgBox.button2.Text = btnNo;
            MsgBox.ShowDialog();
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; MsgBox.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }

        private void CustomMsgBox_Load(object sender, EventArgs e)
        {

        }
    }
}
