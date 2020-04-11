using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class AddStudentcs : UserControl
    {
        //Student st = new Student();
        public AddStudentcs()
        {
            InitializeComponent();
            //Student st = new Student();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void AddStudentcs_Load(object sender, EventArgs e)
        {
             
        }

        private void btnaddstudnets_Click(object sender, EventArgs e)
        {
            try
            {
                Student st = new Student();
                st.setFName(txtfname.Text);
                st.setLName(txtlname.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex.Message);
            }
        }

        private void radiomale_CheckedChanged(object sender, EventArgs e)
        {
             //sex = radiomale.Text;

        }

        private void radiofemale_CheckedChanged(object sender, EventArgs e)
        {
            //sex = radiomale.Text;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Update_Students us = new Update_Students();
            this.Visible = false;
            us.ShowDialog();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dataAccess.clearNames(txtfname, txtmname, txtlname, txtclass);
        }

         
    }
}
