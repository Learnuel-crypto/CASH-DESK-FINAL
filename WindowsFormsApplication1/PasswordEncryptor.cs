using System;
using System.Security.Cryptography;
using System.Text;
namespace AesEncrypt
{
    #region
    /// <summary>
    /// hash the password and store.
    /// </summary>
    class PasswordEncryptor
    {
        public static string Encrypt(string text)
        {
            //hash SHA1
            using(SHA1 sha = new SHA1CryptoServiceProvider())
            {
                sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
                byte[] re = sha.Hash;
                StringBuilder sb = new StringBuilder();
                foreach(byte b in re)
                {
                    sb.Append(b.ToString("x2"));

                }
                return sb.ToString();
            }
        }
        #endregion
        }
    }
