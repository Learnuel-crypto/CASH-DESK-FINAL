using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication1
    {
        public partial class ReceiptView : Form
        {
            private string SchoolName;
            private string Address;
            private int count = 0; 

            SqlConnection con = new DBConnection().getConnection();
            public ReceiptView()
            {
                InitializeComponent();
                receiptInfor();

            }

            private void ReceiptView_Load(object sender, EventArgs e)
            {
                count = 15;
                timer1.Enabled = true;
                timer1.Start();
                
                receiptInfor();
                printReceipt.DefaultPageSettings.PaperSize=new PaperSize("MyPaper",this.Width,this.Height);
                var barcode = new BarCodeGen();
                barcode.Barcode(pictureBarCode);
                barcode.QRcode(pictureQRCode);
                 }

            public void OnAppStarted(object source, EventArgs args)
            {
                schoolDetails();
            }

            void receiptInfor()
                {
                    schoolDetails();
                lblAddress.Text = Address;
                lblschoolName.Text = SchoolName;
                con.Open();
                SqlCommand receipt = new SqlCommand("select * from Cash where ID='" + dataAccess.DcashId + "'", con);
                SqlDataAdapter recDt = new SqlDataAdapter(receipt);
                DataTable dtrec = new DataTable();
                recDt.Fill(dtrec);
                foreach (DataRow dtR in dtrec.Rows)
                {
                    lblName.Text = dtR["Names"].ToString();
                    lblclass.Text = dtR["Class"].ToString();
                    lblFee.Text = dtR["Fee_Name"].ToString();
                    lblTerm.Text = dtR["Term"].ToString();
                    lblPaytype.Text = dtR["Fee_Type"].ToString();
                    lblDate.Text =dtR["Pay_Date"].ToString();
                    lblAmount.Text =string.Format("{0:00.#0}", dtR["Amount"]);
                    lblTime.Text = DateTime.Now.ToShortTimeString();
                    lblprintDate.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
                    lblCasher.Text = AdminLog.Admin;
                }
                con.Close();
            } 
            void schoolDetails()
            {

                con.Open();
                SqlCommand cmdS = new SqlCommand("select * from ReceiptName ", con);
                SqlDataAdapter recsch = new SqlDataAdapter(cmdS);
                DataTable dtSch = new DataTable();
                DataSet ds = new DataSet();
                recsch.Fill(dtSch);
                recsch.Fill(ds);
                int x = dtSch.Rows.Count;
                
                if (x <= 0)
                {
                    SchoolName = "Cash Desh App";
                    pictureLogo.Image = null;
                }
                else
                {
                    //GET THE SCHOOL LOGO IMAGE
                    byte[] pic = (byte[]) ds.Tables[0].Rows[0]["Logo"];
                    MemoryStream ms = new MemoryStream(pic);
                    pictureLogo.Image = Image.FromStream(ms);
                    foreach (DataRow drs in dtSch.Rows)
                    {
                        SchoolName = drs[1].ToString();
                        Address = drs[2].ToString();
                    }

                    con.Close();
                }
                con.Close();
            }

            //private void btnPrint_Click(object sender, EventArgs e)
            //{
            //    printPreviewDialog.Document = printReceipt;
            //        if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            printReceipt.Print();
            //        }
            //    }

            private void printReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                int w = this.Width;
                int h = this.Height;
                Bitmap bmp = new Bitmap(w, h);
                Rectangle Rec = new Rectangle(0, 0, w, h);
                ////set the print font and papersize
                //Font font = new Font("Courier New", 10);
                //PaperSize size =new PaperSize("Custom",100,200);
                //printPreviewDialog.Document.PrinterSettings.PaperSizes = size;
                //printPreviewDialog.Document.DefaultPageSettings.PaperSize.Height = this.Height;
                //printPreviewDialog.Document.DefaultPageSettings.PaperSize.Width = this.Width;
                this.DrawToBitmap(bmp, Rec);
                e.Graphics.DrawImage(bmp, Rec);
                //e.Graphics.DrawString("new font", A);


            }

            private void timer1_Tick(object sender, EventArgs e)
            {
               //TIMER FOR HOW LONG THE RECEIPT DISPLAY BEFORE PRINTING
                count -= 1;
                    if (count == 0)
                    {
                       
                        printPreviewDialog.Document = printReceipt;
                        if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                        {
                            printReceipt.Print();
                        }
                        this.Close();
                    }
                }
             
             
        }
    }
