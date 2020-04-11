using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
    {
    class Session
    {
        private string startYear;
        private string endYear;
        private string endMonth;
        private string dateSet;

        //CONSTUCTOR
        public Session()
        {
            
        }
        //GETTERS
        public string getStartYear() {return this.startYear; }
        public string getendYear() { return this.endYear; }
        public string getendMonth() { return this.endMonth; }
        public string getdateSet() { return this.dateSet; }

        //SETTERS
        public void setStartyear(string startyear)
        {
        try
            {
            if (string.IsNullOrEmpty(startyear))
                {
                throw new Exception("Begin Year of Session Can't be Empty");

                }
            else
                {
                this.startYear = startyear;
                }
            }
            catch(Exception Ex){
            throw new ExceptionHandling("The Start Year was Null", Ex);
                }
        }
        public void setEndYear(string endyear)
        {try{
            if (string.IsNullOrEmpty(endyear))
            {
            throw new Exception("End Year of Session Can't be Empty");
            }
            else { this.endYear = endyear; }
            }
            catch(Exception Ex){
            throw new ExceptionHandling("The End Year was Null", Ex);
                }
        }
        public void setEndMonth(string endmonth)
        {
            if (string.IsNullOrEmpty(endmonth))
            {
                this.endMonth = null;
            }
            else { this.endMonth = endmonth; }
        }
        public void setDateSet(string setdate) {  this.dateSet = setdate;}

        public void setSession(string startyear, string endyear, string endmonth, string dateset)
            {
            SqlConnection con = new DBConnection().getConnection();
            try
                {
                
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Start_Year,End_year FROM Session WHERE Start_Year =@startyear AND End_Year = @endyear", con);
                da.SelectCommand.Parameters.AddWithValue("@staryear", SqlDbType.VarChar).Value = startyear;
                da.SelectCommand.Parameters.AddWithValue("@endyear" , SqlDbType.VarChar).Value = endyear;
                DataTable dt = new DataTable();
                da.Fill(dt);
                int a = dt.Rows.Count;
                if (a > 0)
                    {
                        con.Close();
                    throw new Exception("Session already Exist");
                   
                    }
                else
                    {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Session VALUES('" + startyear + "', '" + endyear + "','" + endmonth + "','" + dateset + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session Set successfully", "Session");
                    dataAccess.Description = "Set Session";
                    dataAccess.Activities();
                    con.Close();
                    }
                }
            catch (Exception Ex)
                {
                con.Close();
                throw new ExceptionHandling("Session Already Exist", Ex);

                }
             
        }
        public void setNewSession(DateTimePicker startyear, DateTimePicker endyear, DateTimePicker setDate)
        {
            SqlConnection con = new DBConnection().getConnection(); 
            try
            {
               con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Start_Year,End_year FROM Session WHERE Start_Year = @startyear", con);
                da.SelectCommand.Parameters.AddWithValue("@startyear", SqlDbType.VarChar).Value = startyear.Value.ToString();
                DataTable dt = new DataTable();
                da.Fill(dt);
                int a = dt.Rows.Count;
                if (a > 0)
                {
                    throw new Exception("Session already Exist");
                     
                }
                else
                {
                    SqlCommand cmd =
                        new SqlCommand();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Start_Year", startyear.Value);
                    cmd.Parameters.AddWithValue("@End_Year", endyear.Value);
                    cmd.Parameters.AddWithValue("@Set_Date", setDate.Value.ToString());
                    cmd.CommandText = "INSERT INTO Session VALUES(@Start_Year,@End_Year,@Set_Date)";
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session Set successfully", "Session");
                    dataAccess.Description = "Created New Session";
                    dataAccess.Activities();
                    con.Close();
                }
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Session Already Exist or Date format is invalid",Ex);

            }

        }
    }
    
    }

