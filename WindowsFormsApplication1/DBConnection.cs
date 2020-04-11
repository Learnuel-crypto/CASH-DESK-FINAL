using System.Data.SqlClient;
using System.Configuration;
using EncryptString;

namespace WindowsFormsApplication1
{
    class DBConnection
    {
        #region
        /// <summary>
        /// database connection class
        /// </summary>
        /// <returns>conntion string</returns>
        StringEncryptor StrCrypt = new StringEncryptor();
        public SqlConnection getConnection()
        { 
            return new SqlConnection(StrCrypt.Decrypt( ConfigurationManager.ConnectionStrings["cashDesk"].ConnectionString));
        }
        #endregion
    }
}
