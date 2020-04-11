using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class AddStudentsForm : Form
    {
        Student st = new Student();
        int count = 0;
        public AddStudentsForm()
        {
            InitializeComponent();
            st.DisplayClass(comClass);
            }

        private void button4_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            try
            {
                // GET THE INFORMATIONS FROM THE FORM FOR STUDENT
                st.setFName(txtFname.Text);
                st.setLName(txtLname.Text);
                st.setMName(txtMname.Text);
                st.setClass(comClass.Text);

                if ((radioFemale.Checked == false) && (radioMale.Checked == false))
                    {
                    throw new Exception("Sex Can't Be Empty");
                    }
                st.insertStudent(st.getFName(), st.getMName(), st.getLName(), st.getGender(), st.getpClass());//SEND THE RECORD FOR INSERTION
                count = 15;
                timer1.Enabled = true;
                timer1.Start();
                dataAccess.clearNames(txtFname, txtMname, txtLname, txtClass);//CLEAR THE TEXT BOXEX
                comClass.Text = "";
                radioMale.Checked = false;
                radioFemale.Checked = false;
                st.DisplayClass(comClass);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message+"\nStudent was not Added","Add Student Error",MessageBoxButtons.OK,MessageBoxIcon.Information );
                
            }
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            st.setGender(radioMale.Text);
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            st.setGender(radioFemale.Text); 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            }

        private void bnclear_Click(object sender, EventArgs e)
        {
            dataAccess.clearNames(txtFname, txtMname, txtLname, txtClass);
            comClass.Text = "";
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            Update_Students us = new Update_Students();
            us.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count -= 1;
            if (count > 0)
            {
                lblinfor.Visible = true;
            }
            if (count == 0)
            {
                timer1.Stop();
                lblinfor.Visible = false;
            }
        }
    }
}
