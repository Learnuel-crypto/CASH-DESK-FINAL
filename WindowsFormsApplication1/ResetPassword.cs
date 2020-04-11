using System;
using System.Data.SqlClient;
using AesEncrypt;

namespace WindowsFormsApplication1
    {
    class UserResetPassword
        {
        public static string Question1;
        public static string Answer1;
        public static string Question2;
        public static string Answer2;
        public static int Resetuserid = 0;
        private static int userid = 0;
        private static int QuestionID = 0;
        public static void ResetUserPassword(string username)
            {
            SqlConnection con = new DBConnection().getConnection();
            try
                { 
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UserName" , username); 
                cmd.CommandText = "SELECT * FROM Admin WHERE UserName =@UserName  ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        Resetuserid = Int32.Parse(reader["ID"].ToString());
                        AdminLog.Admin = reader["UserName"].ToString();
                        AdminLog.AdminPass = reader["Password"].ToString();
                        }
                    }
                else
                    {
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@Password" ,PasswordEncryptor.Encrypt( username));
                    cmd2.CommandText = "SELECT * FROM Admin WHERE Password=@Password  ";
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.HasRows)
                        {
                        while (reader2.Read())
                            {
                            Resetuserid = Int32.Parse(reader2["ID"].ToString());
                            AdminLog.Admin = reader2["UserName"].ToString();
                            AdminLog.AdminPass = reader2["Password"].ToString();
                            }
                        }
                    else
                        {
                        reader2.Close();
                        throw new Exception("Username NOT found");
                        }
                    reader2.Close();
                    }
                reader.Close();
                con.Close();

                }
            catch (Exception Ex)
                {
                con.Close();
                throw new Exception(Ex.Message);
                }
            }
        public static int GetAdminID()
            {

            SqlConnection con = new DBConnection().getConnection();
            try
                {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UserName" , AdminLog.Admin);
                cmd.CommandText = "SELECT * FROM Admin WHERE UserName =@UserName  ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        userid = Int32.Parse(reader["ID"].ToString());
                        AdminLog.Admin = reader["UserName"].ToString();
                        AdminLog.AdminPass = reader["Password"].ToString();
                        }
                    }
                return userid;
                }
            catch(Exception ex)
                {
                throw new Exception(ex.Message );
                } 
            }
        public static int CheckSecurityQuestions()
            {
            try
                { 
                SqlConnection con = new DBConnection().getConnection();
               //GET THE QUESTION ID
                con.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@AdminID" , GetAdminID());
                cmd2.CommandText = "SELECT SecurityID FROM UserSecurity WHERE AdminID=@AdminID";// get the admin id form the security table
                SqlDataReader reader = cmd2.ExecuteReader();
                int id = 0;
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        id = Int32.Parse(reader["SecurityID"].ToString());
                        }
                    }
                reader.Close(); 
                return QuestionID = id;
                }
            catch (Exception ex)
                { 
                throw new Exception(ex.Message+"\nCheck questions error");
                }
            }
        public static void CreateSecurityTable()
            { 
            SqlConnection con = new DBConnection().getConnection();
            //GET THE ADMIN ID
            con.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = " IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'UserSecurity')  CREATE TABLE UserSecurity(SecurityID int NOT NULL identity(1 , 1) ,AdminID int NULL ," +
                   "Question1 varchar(MAX) NOT NULL ,Answer1 varchar(MAX) NOT NULL ,Question2 varchar(MAX) NOT NULL ,Answer2 varchar(MAX) NOT NULL ,CONSTRAINT PK_SecurityID primary key CLUSTERED(SecurityID))";
           // drop table UserSecurity
            cmd2.ExecuteNonQuery();
            CheckSecurityQuestions();
            }
        public static void CreateSecurityTable(string createTable)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = " IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'UserSecurity')  CREATE TABLE UserSecurity(SecurityID int NOT NULL identity(1 , 1) ,AdminID int NULL ," +
                               "Question1 varchar(MAX) NOT NULL ,Answer1 varchar(max) NOT NULL ,Question2 varchar(MAX) NOT NULL ,Answer2 varchar(max) NOT NULL ,CONSTRAINT PK_SecurityID primary key CLUSTERED(SecurityID))";
            cmd2.ExecuteNonQuery();
            
        }
        public static void SetSecurityQuestions(string question1, string answer1, string question2, string answer2)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                //SET SECURITY QUESTIONS
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AdminID" , GetAdminID());
                cmd.Parameters.AddWithValue("@Question1" , question1);
                cmd.Parameters.AddWithValue("@Answer1" , answer1);
                cmd.Parameters.AddWithValue("@Question2" , question2);
                cmd.Parameters.AddWithValue("@Answer2" , answer2);
                cmd.CommandText = "INSERT INTO UserSecurity(AdminID,Question1,Answer1,Question2,Answer2) VALUES(@AdminID,@Question1,@Answer1,@Question2,@Answer2)  ";
                cmd.ExecuteNonQuery(); 
               
                }
            catch (Exception ex)
                {
                throw new Exception(ex.Message +"\nSet Security");
                }
                }
        public static void UpdateSecurityQuestions(string question1 , string answer1 , string question2 , string answer2)
            {
            try
                {
                SqlConnection con = new DBConnection().getConnection();
                //SET SECURITY QUESTIONS
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@SecurityID" , QuestionID);
                cmd.Parameters.AddWithValue("@Question1" , question1);
                cmd.Parameters.AddWithValue("@Answer1" , answer1);
                cmd.Parameters.AddWithValue("@Question2" , question2);
                cmd.Parameters.AddWithValue("@Answer2" , answer2);
                cmd.CommandText = "UPDATE UserSecurity SET Question1=@Question1,Answer1=@Answer1,Question2=@Question2,Answer2=@Answer2 WHERE SecurityID=@SecurityID ";
                cmd.ExecuteNonQuery();
                }
            catch (Exception ex)
                {
                throw new Exception(ex.Message+"\nUpdate error");
                }
            }
        public static void ShowSecurityQuestions()
            {
            SqlConnection con = new DBConnection().getConnection();
            try
                {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AdminID" , Resetuserid);
                cmd.CommandText = "SELECT *FROM UserSecurity WHERE AdminID =@AdminID";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        {
                        Question1 = reader["Question1"].ToString();
                        Answer1 = reader["Answer1"].ToString();
                        Question2 = reader["Question2"].ToString();
                        Answer2 = reader["Answer2"].ToString();
                        }
                    }
                reader.Close();
                con.Close();
                }
            catch (Exception ex)
                {

                throw new Exception(ex.Message+"\nshow questions error");
                }
            }
        public static void UpdateAdminUsername(string newuser , string password)
            {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            try
                {
                //check if user  already exist 
                AdminLog.CheckUserName(newuser);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@UserName" , newuser);
                    cmd.Parameters.AddWithValue("@Password" , PasswordEncryptor.Encrypt(password));
                    cmd.Parameters.AddWithValue("@ID" , Resetuserid);
                    cmd.CommandText = "UPDATE Admin SET UserName =@UserName, Password=@Password WHERE ID=@ID";
                    cmd.ExecuteNonQuery(); 
                con.Close();
                AdminLog.Admin = newuser;
                AdminLog.AdminPass = PasswordEncryptor.Encrypt(password);
                }
            catch (Exception Ex)
                {
                con.Close();
                throw new Exception(Ex.Message + "\nUpdate Not Successful");
                }

            }
        public static void DeleteSecurityQuestion(string username)
            {
            //PASS IN THE USER NAME  
            try
                {
                ResetUserPassword(username);
                SqlConnection con = new DBConnection().getConnection();
                con.Open();
                SqlCommand cmCommand = new SqlCommand();
                cmCommand.Connection = con;
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@AdminID" , Resetuserid);
                cmCommand.CommandText = "DELETE UserSecurity WHERE AdminID =@AdminID";
                cmCommand.ExecuteNonQuery();
                con.Close(); 
                 
                }
            catch (Exception Ex)
                {
                throw new Exception(Ex.Message + "\nDelete Not Successful");
                }

            }

        }
    }
