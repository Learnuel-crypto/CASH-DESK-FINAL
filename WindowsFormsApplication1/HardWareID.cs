using System.Text;
using System.Threading.Tasks;
using System;
using System.Management;

namespace CashDeskActivation
{
    /// <summary>
    /// ACTIVATION CODE FOR ANY PROGRAM
    /// </summary>
    class HardWareID
    {
        public static string GET_HardWareID = ReturnHareWareID(); //changed from => to =
        private static string ReturnHareWareID()
        {
            byte[] bytes;
            byte[] harshBytes;
            string Result;
            StringBuilder sb = new StringBuilder();
             
                ManagementObjectSearcher cpu = new ManagementObjectSearcher("SELECT *FROM Win32_Processor");
                ManagementObjectCollection cpu_Collection = cpu.Get();
                foreach(ManagementObject obj in cpu_Collection)
                {
                    sb.Append(obj["ProcessorId"].ToString().Substring(3, sb.Length));
                    break; 
                }
                ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT *FROM Win32_BIOS");
                ManagementObjectCollection bios_Collection = bios.Get();
                foreach (ManagementObject obj in bios_Collection)
                {
                    sb.Append(obj["SerialNumber"].ToString());
                    break;
                }
                
            bytes = System.Text.Encoding.UTF8.GetBytes(sb.ToString());
            harshBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return Result= Convert.ToBase64String(harshBytes).Substring(20).ToUpper();

        }
    }
}
