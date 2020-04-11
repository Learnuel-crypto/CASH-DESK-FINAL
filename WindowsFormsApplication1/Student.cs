using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{

   public class Student
    {
       private string FName;
       private string MName;
       private string LName;
       private string Gender;
       private string pClass;
       private int pos = 0;
       private int clasid = 0; 
       SqlConnection con = new DBConnection().getConnection();

       //CONSTRUCTOR
       public Student()
       {
           
        }
       //GETTERS
       public string getFName() { return this.FName; }
       public string getMName() { return this.MName; }
       public string getLName() { return this.LName; }
       public string getpClass() { return this.pClass; }
       public string getGender() { return this.Gender; }

       //SETTERS
       public void setFName(string fname)
       {
           try
           {
               if (string.IsNullOrEmpty(fname))
               {
                   throw new Exception("First Name can't be empty"); 
               }
               else
               {
                   this.FName = fname;
               }
           }
           catch (Exception Ex)
           {
               throw new Exception(Ex.Message);
           }

       }
       public void setMName(string mname)
       {
           //VALIDATE MIDDLE NAME
           if (string.IsNullOrEmpty(mname)) {  this.MName = null;}
           else { this.MName = mname; }
       }
       
       public void setLName(string lname) {
           try
           {
               //VALIDATE LAST NAME
               if (string.IsNullOrEmpty(lname))
               {
                   throw new Exception("Last Name can't be empty");

               }
               else
               {
                   this.LName = lname;
               }
           }
           catch (Exception Ex)
           {
               throw new Exception(Ex.Message);
           }
       }

       public void setGender(string gender)
       {
           try
           {
               if (string.IsNullOrEmpty(gender))
               {
                   throw new Exception("Sex can't be empty");

               }
               else
               {
                   this.Gender = gender;
               }
           }
           catch (Exception Ex)
           {
               throw new Exception(Ex.Message);
           }
       }

        public void setClass(string Pclass)
        {
            try
            {
                if (Pclass.Contains(" "))
                    {
                    Pclass.Trim();
                    }
                if (string.IsNullOrEmpty(Pclass))
                {
                    throw new Exception("Class can't be empty");
                }
                else
                { 
                       this.pClass = Pclass;
                }

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        

        public string studenDetails()
       {
           return  "First Name:   "+this.FName + "\n" + "Middle Name:   "+
               this.MName + "\n" + "Last Name:   " + this.LName + "\n" + "Class:   " + this.pClass + "\n" + "Sex:   " + this.Gender ;

       }
       
       //INSERT NAME INTO THE NAMES TABLE
       public  void insertStudent(string firstName, string midName, string lastName, string pgender, string pclass)
       {
            try
                {
                con.Open();
                //GET SESSION ID FROM THE TABLE
                DataTable dtS = new DataTable();
                SqlDataAdapter daS = new SqlDataAdapter("SELECT *FROM Session" , con);
                daS.Fill(dtS);
                int sesId = dtS.Rows.Count;
                if (sesId <= 0)
                    {
                    throw new Exception("You need to First Create An Academic Session");
                    }
                else
                    {
                    DataTable dtS2 = new DataTable();
                    SqlDataAdapter daS2 = new SqlDataAdapter("SELECT MAX(Session_Id) FROM Session" , con);
                    daS2.Fill(dtS2);
                    foreach (DataRow dr1 in dtS2.Rows)
                        {
                        sesId = Convert.ToInt32(dr1[0]);

                        }

                    }
                if (string.IsNullOrEmpty(midName))
                    {
                    midName = "";
                    }
                //INSERT STUDENT NAMES INTO NAMES TABLE
                SqlCommand cmd = new SqlCommand();
                 cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@First_Name" , firstName);
                cmd.Parameters.AddWithValue("@Middle_Name" , midName);
                cmd.Parameters.AddWithValue("@Last_Name" , lastName);
                cmd.Parameters.AddWithValue("@Sex" , pgender.ToUpper());
                cmd.CommandText = "INSERT INTO Names(First_Name,Middle_Name,Last_Name,Sex) VALUES(@First_Name,@Middle_Name,@Last_Name,@Sex )";
                cmd.ExecuteNonQuery();
               //GET THE JUST ADDed STUDENT NAME ID
               DataTable dt = new DataTable();
               SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Name_Id) FROM Names", con);
               da.Fill(dt);
               //var pos=0 ;
               foreach (DataRow dr in dt.Rows)
               {
                   pos =Convert.ToInt32( dr[0] );
                 // MessageBox.Show(pos.ToString(),"Name Id");
               }
               //INSERT THE STUDENT NAME ID INTO THE STUDENT TABLE
               SqlCommand cmdNameId = new SqlCommand("INSERT INTO Students(Name_Id) VALUES('" + pos + "')", con);
               cmdNameId.ExecuteNonQuery();
             
               //GET THE JUST ADDed STUDENT ID
               DataTable dtStud = new DataTable();
               SqlDataAdapter daStud = new SqlDataAdapter("SELECT MAX(Student_Id) FROM Students", con);
               daStud.Fill(dtStud);
               var stud = 0;
               foreach (DataRow drS in dtStud.Rows)
                   {
                   stud = Convert.ToInt32(drS[0]); 
                   }

                //INSERT THE STUDENT ID  ND CLASS INTO THE CLASSTABLE
                SqlCommand cmdC = new SqlCommand();
                    
                cmdC.Connection = con;
                cmdC.Parameters.Clear();
                cmdC.Parameters.AddWithValue("@Student_id",stud);
                cmdC.Parameters.AddWithValue("@Session_id" , sesId);
                cmdC.Parameters.AddWithValue("@ClassName" , pclass.ToUpper());
                cmdC.Parameters.AddWithValue("@Year" , DateTime.Now.Year.ToString());
                cmdC.CommandText = "INSERT INTO Class(Student_id,Session_id,ClassName,Year)  VALUES(@Student_id,@Session_id,@ClassName,@Year)";
                cmdC.ExecuteNonQuery();
                
               //GET THE JUST INSERTED CLASS ID OF THE STUDENT
               DataTable dtc = new DataTable();
               SqlCommand cmd2 = new SqlCommand("SELECT  MAX(Class_Id) FROM Class ", con);
               SqlDataAdapter dacid = new SqlDataAdapter(cmd2);
               dacid.Fill(dtc);
               var clasid = 0;
               foreach (DataRow drc in dtc.Rows)
               {
                   clasid = Convert.ToInt32(drc[0]);
                    }
                //INSERT THE STUDENT NAME ID INTO THE NAME ID OF THE STUDENT TABLE
                SqlCommand cmdsUpdate = new SqlCommand();
                cmdsUpdate.Connection = con;
                cmdsUpdate.Parameters.Clear();
                cmdsUpdate.Parameters.AddWithValue("@Class_id" , clasid);
                cmdsUpdate.Parameters.AddWithValue("@Student_id" , stud);
                cmdsUpdate.CommandText=  "UPDATE Students SET Class_Id=@Class_id WHERE Student_Id=@Student_id";
               cmdsUpdate.ExecuteNonQuery(); 
               con.Close();
               dataAccess.Description = "Registered Student Successfully";
               dataAccess.Activities();
                
           }
           catch (Exception Ex)
           {
           SqlCommand del = new SqlCommand("DELETE FROM Names WHERE Name_Id='" + pos +"'; DELETE FROM Class WHERE Class_Id='" + clasid + "'", con);
           del.ExecuteNonQuery();
           con.Close();
           dataAccess.Description = "Register Student but failed";
           dataAccess.Activities();
           MessageBox.Show(Ex.Message+"\nStudent Registration Failed", "Student Registation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }

       public void updateStudent(string firstName, string midName, string lastName, string pgender, int id)
       {
           try
           {
                //UPDATE NAMES IN THE NAMES TABLE
                if (string.IsNullOrEmpty(midName))
                    {
                    midName = "";
                    }
               con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@First_Name" , firstName);
                cmd.Parameters.AddWithValue("@Middle_Name" , midName);
                cmd.Parameters.AddWithValue("@Last_Name" , lastName);
                cmd.Parameters.AddWithValue("@Sex" , pgender.ToUpper()); 
                cmd.CommandText = "UPDATE Names SET First_Name =@First_Name,Middle_Name=@Middle_Name,Last_Name=@Last_Name,Sex=@Sex  WHERE Name_Id='" + id + "'";
                cmd.ExecuteNonQuery();
               con.Close();
               dataAccess.Description = "Updated Student Record Successfully";
               dataAccess.Activities(); 
           }
           catch (Exception Ex)
           {
                MessageBox.Show("Unknown Error, Check string put" , "Update Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
       }
        public void DisplayClass(ComboBox clas)
            {
            SqlCommand cmd2 = new SqlCommand("SELECT DISTINCT ClassName FROM Class " , con);
            DataTable dtc = new DataTable();
            SqlDataAdapter dacid = new SqlDataAdapter(cmd2);
            dacid.Fill(dtc);
            int x = dtc.Rows.Count;
            clas.Items.Clear();
            if (x > 0)
                {
                foreach (DataRow drc in dtc.Rows)
                    {
                    clas.Items.Add(drc["ClassName"]);
                    }
                }
            }
        public void searchStudents(DataGridView view , string searchText)
        {
            try
            {
                con.Open();
                DataTable dtsseach = new DataTable();
                SqlDataAdapter daSeach = new SqlDataAdapter("SELECT  *FROM Names WHERE First_Name LIKE '%' + @search + '%' OR Middle_Name LIKE '%' + @search + '%' OR Last_Name LIKE '%' + @search + '%'", con);
                daSeach.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = searchText;
                daSeach.Fill(dtsseach);
                view.Rows.Clear();
                foreach (DataRow drt in dtsseach.Rows)
                {
                    //DISPLAY FOUND RECORDS INTO TE GRID VIEW CONTROL
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drt[0].ToString();
                    view.Rows[n].Cells[1].Value = drt[1].ToString();
                    view.Rows[n].Cells[2].Value = drt[2].ToString();
                    view.Rows[n].Cells[3].Value = drt[3].ToString();
                    view.Rows[n].Cells[4].Value = drt[4].ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
            }
        public void searchStudentName(DataGridView view , string searchText)
        {
            try
            {
                con.Open();
                DataTable dtsseach = new DataTable();
                SqlDataAdapter daSeach = new SqlDataAdapter("SELECT  *FROM Names WHERE First_Name =@search OR Middle_Name = @search OR Last_Name =@search ", con);
                daSeach.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = searchText;
                daSeach.Fill(dtsseach);
                view.Rows.Clear();
                foreach (DataRow drt in dtsseach.Rows)
                {
                    //DISPLAY FOUND RECORDS INTO TE GRID VIEW CONTROL
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = drt[0].ToString();
                    view.Rows[n].Cells[1].Value = drt[1].ToString();
                    view.Rows[n].Cells[2].Value = drt[2].ToString();
                    view.Rows[n].Cells[3].Value = drt[3].ToString();
                    view.Rows[n].Cells[4].Value = drt[4].ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public void deleteStudent(string studentid)
       {
           try
           {
               con.Open();
               SqlDataAdapter da= new SqlDataAdapter("SELECT Name_Id FROM Students WHERE Student_Id='" + studentid + "'",con);
               DataTable dt = new DataTable();
               da.Fill(dt);
               string nameid="";
               foreach (DataRow dr in dt.Rows)
               {
                   nameid = dr["Name_Id"].ToString();
               }
               SqlCommand del = new SqlCommand("UPDATE Students SET Class_Id=NULL WHERE Student_Id='" + studentid + "';UPDATE   Fees SET Class_Id=NULL,Student_Id=NULL WHERE Student_Id='" + studentid + "';"+
                   "DELETE FROM Class WHERE Class.Student_Id= '" + studentid + "';DELETE FROM Students WHERE Student_Id='" + studentid + "';" +
                   "DELETE FROM Names WHERE Name_Id='"+ nameid +"'", con);

               del.ExecuteNonQuery();
               con.Close();
               dataAccess.Description = "Deleted Student Records";
               dataAccess.Activities();
           }
           catch (Exception ex)
           {
               con.Close();
               throw new ExceptionHandling("There was error in the process, try again", ex);
           }
            }
    }
}
