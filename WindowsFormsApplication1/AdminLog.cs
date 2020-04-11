using System;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncrypt;


namespace WindowsFormsApplication1
{
    class AdminLog
    {
        public static string AdminPass;
        public static string Admin;
        public static bool ForgottenPassword=false;
        public static bool ResetPassword = false;
        public static void LogIn(string admin, string pass)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                if (string.IsNullOrEmpty(admin))
                {
                    throw new Exception("Enter Username");
                }
                else if (string.IsNullOrEmpty(pass))
                {
                    throw new Exception("Enter Password");
                }
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UserName" , admin);
                cmd.Parameters.AddWithValue("@Password" , PasswordEncryptor.Encrypt(pass)); 
                cmd.CommandText= "SELECT *FROM Admin WHERE UserName =@UserName AND Password=@Password ";
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                        {
                        Admin = reader.GetString(1);
                        AdminPass = reader.GetString(2);
                        }
                }
                reader.Close();
                con.Close();
                
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new ExceptionHandling("Username or Password was not provided\n Login Not Successful"  , Ex);
            }

        }

        public static  void CreateAdmin(string user, string pass)
        { 
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                if (ForgottenPassword == true)
                    {
                    UpdateAdminUsername(Admin , user);
                    UpdateAdminPass(pass);
                    ForgottenPassword = false;
                    }else if (ResetPassword == true)
                    {
                    UpdateAdminPass(pass);
                    ResetPassword = false;
                    }
                else
                    {
                    CheckPrvilege();
                    CheckUserName(user);
                    con.Open();
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    SqlCommand cmdcreateCommand = new SqlCommand();
                    cmdcreateCommand.Connection = con;
                    cmdcreateCommand.Parameters.Clear();
                    cmdcreateCommand.Parameters.AddWithValue("@UserName" , user);
                    cmdcreateCommand.Parameters.AddWithValue("@Password" , PasswordEncryptor.Encrypt(pass));
                    cmdcreateCommand.CommandText = "INSERT INTO Admin(UserName,Password) VALUES(@UserName,@Password)";

                    cmdcreateCommand.ExecuteNonQuery();
                    con.Close();
                    }
            }
            catch (Exception Ex)
            {
                con.Close();
                throw new Exception(Ex.Message+"\nAdmin Not Created");
            }

        }
        /// <summary>
        /// /update the Admins
        /// </summary>
        /// <param name="pass"></param>
        /// <param name="passNew"></param>
        /// <param name="user"></param>
        /// <param name="newuser"></param>
        public static void UpdateAdminUsername( string user, string newuser)
        {
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            try
            {
                //check if user  already exist
                if(user != AdminLog.Admin)
                    {
                    throw new Exception("User is not currently logged in\nLogin user and try again");
                    }
                else
                    {
                    CheckUserName(newuser);
                    UserResetPassword.ResetUserPassword(user);
                    SqlCommand cmd = new SqlCommand(); 
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@UserName" , newuser);
                    cmd.Parameters.AddWithValue("@Password" , AdminLog.AdminPass);
                    cmd.Parameters.AddWithValue("@ID" , UserResetPassword.Resetuserid);
                    cmd.CommandText = "UPDATE Admin SET UserName =@UserName WHERE ID=@ID";
                    cmd.ExecuteNonQuery();
                    } 
                con.Close(); 
                dataAccess.Description = Admin + " Updated username to " + newuser;
                dataAccess.Activities(); 
                 Admin = newuser;
                
                }
            catch (Exception Ex)
            {
               
                throw new Exception(Ex.Message + "\nUpdate Not Successful");
            }

        }
        /// <summary>
        /// check if the username is already in use
        /// </summary>
        /// <param name="newuser"></param>
        public static void CheckUserName(string newuser)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
               
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UserName" , newuser);
                cmd.CommandText = "SELECT UserName FROM Admin WHERE UserName=@UserName"; 
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    {
                    while (reader.Read())
                        { 
                        if (newuser.ToLower() == reader["UserName"].ToString().ToLower())
                            {
                            reader.Close();
                            throw new Exception("Username NOT allowed, Choose another");
                            }
                        }
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
        public static void UpdateAdminPass(string password)
        {
            try
                {
                //PASS IN THE USER NAME AND THE NEW PASSWORD
                UserResetPassword.ResetUserPassword(AdminLog.Admin);
            SqlConnection con = new DBConnection().getConnection(); 
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID" ,UserResetPassword.Resetuserid);
               
                    cmd.Parameters.AddWithValue("@Password" ,PasswordEncryptor.Encrypt( password)); 
                    cmd.CommandText= "UPDATE Admin SET Password =@Password WHERE ID= @ID " ;
                    cmd.ExecuteNonQuery();
                    con.Close();
                dataAccess.Description = Admin + " updated password";
                dataAccess.Activities();
                AdminPass = PasswordEncryptor.Encrypt(password);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message + "\nUpdate Not Successful");
            }

        }
        public static void DeleteAdmin(TextBox username)
        {
            //PASS IN THE USER NAME AND THE NEW PASSWORD 
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                if (string.IsNullOrEmpty(username.Text))
                    {
                    throw new Exception("Enter Username to Delete");
                    } 
                CheckPrvilege();
                UserResetPassword.DeleteSecurityQuestion(username.Text);
              
                con.Open();
                SqlCommand cmCommand = new SqlCommand();
                cmCommand.Connection = con;
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@UserName" , username.Text);
                cmCommand.CommandText = "DELETE Admin WHERE UserName =@UserName";
                cmCommand.ExecuteNonQuery();
                con.Close(); 
                dataAccess.Description = "Deleted an Admin";
                dataAccess.Activities();
                MessageBox.Show("User Deleted", "Cash Desk", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

            }
            catch (Exception Ex)
            {
                con.Close();
                throw new Exception(Ex.Message + "\nDelete Not Successful");
            }

        }
        public static Task  AdminLogsUpdate( string newuser)
        { 
            SqlConnection con = new DBConnection().getConnection();
           try
            {
            con.Open();
            return Task.Factory.StartNew(() =>
                {
                 SqlCommand cmCommand = new SqlCommand();
                cmCommand.Connection = con;
                cmCommand.Parameters.Clear();
                cmCommand.Parameters.AddWithValue("@UserName", newuser); 
                cmCommand.CommandText= "UPDATE AdminLog SET UserName= @UserName WHERE UserName =NULL";
                cmCommand.ExecuteNonQuery();
                    con.Close();
                  });
                }
            catch (Exception Ex)
            {
                con.Close();
            throw new Exception(Ex.Message + "\nLog Details Not Successful");
            }
        } 
        public static Task AdminLogs(string user , string log)
            { 
            SqlConnection con = new DBConnection().getConnection();
            try
                {
                con.Open();
                return Task.Factory.StartNew(() =>
                {
                    SqlCommand cmCommand = new SqlCommand();
                    cmCommand.Connection = con;
                    cmCommand.Parameters.Clear();
                    cmCommand.Parameters.AddWithValue("@UserName" , user);
                    cmCommand.Parameters.AddWithValue("@Logs" , log);
                    cmCommand.Parameters.AddWithValue("@Time" , DateTime.Now.ToShortTimeString());
                    cmCommand.Parameters.AddWithValue("@Date" , DateTime.Now.Date.ToString("MM/dd/yyyy"));
                    cmCommand.CommandText = "INSERT INTO AdminLog(UserName,Logs,Time,Date) VALUES(@UserName,@Logs, @Time, @Date)";
                    cmCommand.ExecuteNonQuery();
                    con.Close();
                });
                }
            catch (Exception)
                {
                    con.Close();
                throw new Exception("Log capture was not complete" + "\nLog Details Not Successful");
                }
            }
        public static void CheckPrvilege()
            {
                SqlConnection con = new DBConnection().getConnection();
            try
                { 
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT UserName FROM Admin ORDER BY ID  ASC " , con);
                da.Fill(dt);
                int x = dt.Rows.Count;
                string use = "";
                if (x > 0)
                    {
                    foreach (DataRow dr in dt.Rows)
                        {
                        use = dr["UserName"].ToString();
                        break;
                        }
                    if (Admin != use)
                        {
                        throw new Exception("Privilege denied to perform this operation");
                        }
                    }

                }
            catch (Exception ex)
                {
                    con.Close();
                throw new Exception(ex.Message);
                }
            }
    }
}
