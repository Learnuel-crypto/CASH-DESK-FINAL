using System;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
    {
    class MyPrinter
        {
            public MyPrinter()
            {

            }
        private static string printTitle="";
        public static bool Print = true;
        public static void SetPrintTitle(string title)
            {
            printTitle = title;
            }
        public static string GetPrintTile()
            {
            return printTitle;
            }
#region
            /// <summary>
            /// Printer Class
            /// </summary>
            
            public static void PrintRecordsPortrate(DataGridView recordsDataGridView, string title)
            {
                try
                {
                    schoolInfor sch = new schoolInfor();
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = sch.SchoolName.ToUpper();
                    printer.SubTitle = title.ToUpper();
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PageNumberAlignment = StringAlignment.Near;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Motto: " + sch.Motto.ToLower(); 
                    printer.FooterSpacing = 15;
                    printer.PrintDialogSettings.AllowPrintToFile = true;
                    printer.ShowTotalPageNumber = true;
                    printer.PrintDataGridView(recordsDataGridView);
                }
                catch (Exception)
                {
                    
                }
            }
            public static void PrintRecords(DataGridView recordsDataGridView, string title)
            {
                try
                {
                    schoolInfor sch = new schoolInfor(); 
                    DGVPrinter printer = new DGVPrinter();
                    recordsDataGridView.AutoSize = true;
                    printer.Title = sch.SchoolName.ToUpper();
                    printer.SubTitle = title.ToUpper();
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true; 
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer ="Motto: " +sch.Motto.ToLower();
                    printer.FooterSpacing = 15; 
                    printer.PrintDialogSettings.AllowPrintToFile = true;
                    printer.ShowTotalPageNumber = true;
                    printer.printDocument.DefaultPageSettings.Landscape = true;
                    printer.PrintDataGridView(recordsDataGridView);
                }
                catch (Exception)
                {

                }
            }
        }
}
#endregion
