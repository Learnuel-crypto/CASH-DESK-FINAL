using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using  System.IO;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using Zen.Barcode;

namespace WindowsFormsApplication1
    {
        class BarCodeGen
        {
            private string code;
            public void Barcode(PictureBox picture)
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picture.Image = barcode.Draw(codeGen(), 40);
            }

            public void QRcode(PictureBox picture)
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picture.Image = qrcode.Draw(codeGen(), 2);
            }

            private string codeGen()
            {
                code = "CDV1AppReciPt";
                return code;
            }

            public void BarcodeWithText(PictureBox picture)
            {
                Bitmap bmp = new Bitmap(code.Length*40,40);
                using (Graphics graphic = Graphics.FromImage(bmp))
                {
                    System.Drawing.Font oFont =new System.Drawing.Font("Arial", 20);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    graphic.FillRectangle(white,0,0,bmp.Width,bmp.Height);
                    graphic.DrawString(code,oFont,black,point);
                }

            }
        }
    }
