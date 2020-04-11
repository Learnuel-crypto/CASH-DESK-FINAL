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
    public partial class EditStudents : UserControl
    {
        
         
       public EditStudents()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
          
        }

        private void EditStudents_Load(object sender, EventArgs e)
        {
            
        }

        public  void displays(int index )
        {
            //DISPLAY THE NAMES OF STUDENT 
           
             
        }

        private void btnupdate_Click(object sender, EventArgs e)
        { 
            try
            {
                int id = int.Parse(txtID.Text);
                Student st = new Student();
                st.setFName(txtFirstName.Text);
                st.setMName(txtMiddleName.Text);
                st.setLName(txtLastName.Text);
                st.setClass(txtClass.Text.ToUpper());
                st.setGender(txtsex.Text.ToUpper());
                st.updateStudent(st.getFName(), st.getMName(), st.getLName() , st.getGender(),  id);
               
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message.ToString(),"Student Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
             
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            
        }

        private void EditStudents_VisibleChanged(object sender, EventArgs e)
        {
             
        }

        

         
    }
}
