using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace WindowsFormsApplication1
    {
    class ConvertFormat
    {
        public ConvertFormat()
        {

        }
        #region
        /// <summary>
        /// NOT IN USE YET
        /// </summary>
        /// <param name="gdv"></param>
        /// <param name="fileName"></param>
        public static void convertToPDF(DataGridView gdv, string fileName)
        {
            schoolInfor sch = new schoolInfor();
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1);
            Paragraph prgHeading = new Paragraph();
            //PAGE SETTINGS
            PdfPTable pdft = new PdfPTable(gdv.Columns.Count);
            pdft.DefaultCell.Padding = 1;
            pdft.WidthPercentage = 90;
            pdft.HorizontalAlignment = Element.ALIGN_CENTER;
            pdft.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bfntHead, 12, iTextSharp.text.Font.NORMAL);
           
           
            //ADD HEADER
            foreach (DataGridViewColumn column in gdv.Columns)
            {
                PdfPCell cel = new PdfPCell(new Phrase(column.HeaderText, text));
                cel.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdft.AddCell(cel);
            }

            //ADD DATAROW
            foreach (DataGridViewRow row in gdv.Rows)
            {
                foreach (DataGridViewCell cel in row.Cells)
                {
                    pdft.AddCell(new Phrase(cel.Value.ToString(), text));

                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save As PDF";
            saveFileDialog.FileName = fileName;
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.Filter = "PDF|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    
                    pdfdoc.Open();
                    pdfdoc.Add(pdft);
                    pdfdoc.Close(); 
                    stream.Close(); 
                }
                //System.Diagnostics.Process.Start(@"fileName");  
            }

        }
        #endregion
        #region
         /// <summary>
         /// convert/export to pdf in use
         /// </summary>
         /// <param name="dtblTable"></param>
         /// <param name="strPdfPath"></param>
         /// <param name="strHeader"></param>
        public static void ExportDataTableToPdf(DataGridView dtblTable, String strPdfPath, string strHeader)
        { 
                schoolInfor sch = new schoolInfor(); 
                System.IO.FileStream fs = new  FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                document.SetPageSize(iTextSharp.text.PageSize.A4);
                //document.PageCount = 1; 
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                //Report Header
                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = new Font(bfntHead, 16, 1);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk(sch.SchoolName.ToUpper(), fntHead));
                document.Add(prgHeading);
                //Author
                Paragraph prgTitle = new Paragraph();
                BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntAuthor = new Font(btnAuthor, 12, 2);
                prgTitle.Alignment = Element.ALIGN_CENTER;
                prgTitle.Add(new Chunk(strHeader.ToUpper(), fntAuthor));
                prgTitle.Add(new Chunk("\nDate: " + DateTime.Now.ToString("MM/dd/yyy"), fntAuthor));
                document.Add(prgTitle);
            
                //Add a line seperation
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                document.Add(p);
                //Add line break
                document.Add(new Chunk("\n", fntHead));

                //Write the table
                PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
                table.DefaultCell.Padding = 1;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                //Table header
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
                //Font fntColumnHeader = new Font(btnColumnHeader, 10, 1);
                iTextSharp.text.Font text = new iTextSharp.text.Font(btnColumnHeader, 11, iTextSharp.text.Font.NORMAL);
             
                    //ADD HEADER
                    foreach (DataGridViewColumn column in dtblTable.Columns)
                    {
                        PdfPCell cel = new PdfPCell(new Phrase(column.HeaderText, text));
                        //cel.BackgroundColor = new iTextSharp.text.BaseColor( 240.0, 240.0, 240.0,200.0);
                        table.AddCell(cel);
                    }
                    //table Data
                    foreach (DataGridViewRow row in dtblTable.Rows)
                    {
                        foreach (DataGridViewCell cel in row.Cells)
                        {
                            table.AddCell(new Phrase(cel.Value.ToString(), text)); 
                        }
                    } 
                        document.Add(table);
                        document.Close();
                        writer.Close();
                        fs.Close(); 
#endregion
                        #region
            //Delete the fill after use
                        try
                        {
                            string Destination = @"Document\"+strHeader;
                            string source = @strPdfPath;
                            //Delete the file if it already exist
                            if (File.Exists(Destination))
                            {
                                File.Delete(Destination);
                            }
                            System.IO.Directory.Move(source, Destination);
                            System.Diagnostics.Process.Start(Destination);//open the created file
                        }
                        catch (Exception Ex)
                        {
                            throw new Exception("File Currently in use by another Program\n Close the File and Try Again");
                        }
           
        }

    }
}
                        #endregion