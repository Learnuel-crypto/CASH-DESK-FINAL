using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
    {
    public partial class Update_Students : Form
        {
        SqlConnection con = new DBConnection().getConnection();
        DataTable dt = new DataTable();
        Student st = new Student();
        public Update_Students()
            {
            InitializeComponent();
            //FILL THE GRIEW VIEW ON LOAD UP OF FORM
            displays();
            }

        private void Update_Students_Load(object sender, EventArgs e)
            {


            }

        void displays()
            {
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_display_students" , con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dts);
            dataGridDisplayStudent.Rows.Clear();
            foreach (DataRow dr in dts.Rows)
                {
                //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                int n = dataGridDisplayStudent.Rows.Add();
                dataGridDisplayStudent.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridDisplayStudent.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridDisplayStudent.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridDisplayStudent.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridDisplayStudent.Rows[n].Cells[4].Value = dr[4].ToString();

                }
            con.Close();

            }

        private void btnupdate_Click(object sender, EventArgs e)
            {
            try
                {
                //UPDATE THE RECORD IN THE DATABASE
                int id = int.Parse(txtID.Text);
                Student st = new Student();
                st.setFName(txtFirstName.Text);
                st.setMName(txtMiddleName.Text);
                st.setLName(txtLastName.Text);
                if (string.IsNullOrEmpty(txtSex.Text))
                    {
                    throw new Exception("Enter Gender");
                    }
                else if (txtSex.Text.Trim().Length == 1 && txtSex.Text.ToLower().Trim() == "m" || txtSex.Text.ToLower().Trim() == "f")
                    {
                        st.setGender(txtSex.Text.Trim());
                    
                    }
                else
                    {
                        throw new Exception("Gender format is invalid");
                    }
                st.updateStudent(st.getFName(), st.getMName(), st.getLName(), st.getGender(), id);
                lblClass.Visible = false;
                txtClass.Visible = false;
                displays();
                    dataAccess.Description = "Updated Student Record Successfully";
                    dataAccess.Activities();
                MessageBox.Show("Details Updated Successfully", "Student Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            catch (Exception Ex)
                {
                MessageBox.Show("Error: " + Ex.Message.ToString(), "Student Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void btnclose_Click_1(object sender, EventArgs e)
            {
            this.Close();
            }

        private void dataGridDisplayStudent_Click(object sender, EventArgs e)
            {
                try
                {
                    lblClass.Visible = false;
                    txtClass.Visible = false;
                    btnClassView.Visible = true;
                    //DISPLAY THE GRID VIEW ROW SELECTED IN THE TEXBOXES
                    txtID.Text = dataGridDisplayStudent.SelectedRows[0].Cells[0].Value.ToString();
                    txtFirstName.Text = dataGridDisplayStudent.SelectedRows[0].Cells[1].Value.ToString();
                    txtMiddleName.Text = dataGridDisplayStudent.SelectedRows[0].Cells[2].Value.ToString();
                    txtLastName.Text = dataGridDisplayStudent.SelectedRows[0].Cells[3].Value.ToString();
                  txtSex.Text   = dataGridDisplayStudent.SelectedRows[0].Cells[4].Value.ToString();
                 
                    showStudentClass(txtID.Text);
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        void showStudentClass(string id)
            {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ClassName FROM Class WHERE Class.Student_Id in(SELECT Student_Id FROM Students WHERE Students.Name_Id='" +
                id + "');";
             
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listViewClass.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                {
                listViewClass.Items.Add(dr[0].ToString());
                }
            con.Close();
            }
        private void btnClassView_Click(object sender, EventArgs e)
            {
            dataAccess.nameId = int.Parse(txtID.Text);
            CreateClass CC = new CreateClass();
            CC.ShowDialog();
            }

        private void btnaddnew_Click(object sender, EventArgs e)
            {
            Clear();
            listViewClass.Items.Clear();
            lblClass.Visible = true;
            txtClass.Visible = true;
            btnClassView.Visible = false;

            }

        private void btnsave_Click(object sender, EventArgs e)
            { 
            try
                {
                // GET THE INFORMATIONS FROM THE FORM FOR STUDENT
                st.setFName(txtFirstName.Text);
                st.setMName(txtMiddleName.Text);
                st.setLName(txtLastName.Text);
                if (string.IsNullOrEmpty(txtSex.Text))
                    {
                    throw new Exception("Enter Gender");
                    }
                else if (txtSex.Text.Length ==1 && txtSex.Text.ToLower().Trim() == "m" || txtSex.Text.ToLower().Trim() == "f")
                    {
                        st.setGender(txtSex.Text.Trim());
                  
                    }
                else
                    {
                        throw new Exception("Gender format is invalid");
                    }
                st.setClass(txtClass.Text.Trim());

                //SEND THE RECORD FOR INSERTION
                st.insertStudent(st.getFName(), st.getMName(), st.getLName(), st.getGender(), st.getpClass());
                         
                   btnClassView.Visible = false;
                       
                        con.Close();
                        Clear();
                        displays(); 
                }
            catch (Exception Ex)
                {
                MessageBox.Show("Error :" + Ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }


            }

        void Clear()
            {
            txtFirstName.Clear(); txtMiddleName.Clear(); txtLastName.Clear();txtID.Clear() ;
            txtClass.Clear();
            txtSex.Clear();
            }
        private void btnSearch_Click(object sender, EventArgs e)
            {
                try
                {

                Clear(); 
                    btnClassView.Visible = false;

                    st.searchStudentName(dataGridDisplayStudent, txtSearch.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message , "Error Occured" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    {
                    Clear();//CLEAR THE TEXTBOXES 
                    btnClassView.Visible = false;
                    displays();
                    listViewClass.Items.Clear();
                    }
                else
                    {
                    Clear();
                    btnClassView.Visible = false; 
                    st.searchStudents(dataGridDisplayStudent,txtSearch.Text);
                    }
                }catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        private void btndel_Click(object sender, EventArgs e)
            {
                try
                {
                if (string.IsNullOrEmpty(txtID.Text))
                    {
                    throw new Exception("Select Record To Delete");
                    }
            
            if (MessageBox.Show("Continue With Delete Operation", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
              st.deleteStudent(txtID.Text);
                displays();
                MessageBox.Show("Student Deleted Succesfully", "Student Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            else
                {
                //DO NOTHING
                con.Close();
                }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message+"\nStudent Delete Failed", "Student Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
         
        private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

        private void btnpromoteClass_Click(object sender, EventArgs e)
            {
                PromoteStudents PS = new PromoteStudents();
                PS.ShowDialog();
            }

        private void dataGridDisplayStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void btnPrintNames_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecords(dataGridDisplayStudent, MyPrinter.GetPrintTile());
            }
        }

        private void listViewClass_SelectedIndexChanged(object sender , EventArgs e)
            {
            try { }catch(Exception) { }
            }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {
           txtSex.Text= txtSex.Text.ToUpper();
        }
        }
    }