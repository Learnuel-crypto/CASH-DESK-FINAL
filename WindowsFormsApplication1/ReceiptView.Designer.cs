namespace WindowsFormsApplication1
    {
    partial class ReceiptView
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptView));
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printReceipt = new System.Drawing.Printing.PrintDocument();
            this.lblschoolName = new System.Windows.Forms.Label();
            this.pictureQRCode = new System.Windows.Forms.PictureBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPaytype = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pictureBarCode = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblprintDate = new System.Windows.Forms.Label();
            this.lblCasher = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printReceipt
            // 
            this.printReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReceipt_PrintPage);
            // 
            // lblschoolName
            // 
            this.lblschoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschoolName.Location = new System.Drawing.Point(0, 74);
            this.lblschoolName.Name = "lblschoolName";
            this.lblschoolName.Size = new System.Drawing.Size(158, 66);
            this.lblschoolName.TabIndex = 61;
            this.lblschoolName.Text = "School Name";
            this.lblschoolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblschoolName.UseCompatibleTextRendering = true;
            // 
            // pictureQRCode
            // 
            this.pictureQRCode.Location = new System.Drawing.Point(40, 458);
            this.pictureQRCode.Name = "pictureQRCode";
            this.pictureQRCode.Size = new System.Drawing.Size(116, 61);
            this.pictureQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQRCode.TabIndex = 64;
            this.pictureQRCode.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Location = new System.Drawing.Point(30, 6);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(100, 72);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 65;
            this.pictureLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(46, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 16);
            this.lblName.TabIndex = 67;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblclass
            // 
            this.lblclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.Location = new System.Drawing.Point(49, 196);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(117, 16);
            this.lblclass.TabIndex = 69;
            this.lblclass.Text = "Class";
            this.lblclass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "Class";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "Your Receipt";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaytype
            // 
            this.lblPaytype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaytype.Location = new System.Drawing.Point(98, 261);
            this.lblPaytype.Name = "lblPaytype";
            this.lblPaytype.Size = new System.Drawing.Size(66, 16);
            this.lblPaytype.TabIndex = 72;
            this.lblPaytype.Text = "Type";
            this.lblPaytype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 71;
            this.label9.Text = "Fee";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(84, 244);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(82, 16);
            this.lblTerm.TabIndex = 74;
            this.lblTerm.Text = "Term";
            this.lblTerm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 73;
            this.label11.Text = "Term";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFee
            // 
            this.lblFee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(67, 213);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(99, 16);
            this.lblFee.TabIndex = 76;
            this.lblFee.Text = "Fee";
            this.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 75;
            this.label13.Text = "Fee Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(70, 279);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 16);
            this.lblDate.TabIndex = 78;
            this.lblDate.Text = "Pay Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 77;
            this.label15.Text = "Date";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(78, 310);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 16);
            this.lblAmount.TabIndex = 80;
            this.lblAmount.Text = "Total";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 311);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 79;
            this.label17.Text = "Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(5, 344);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(161, 60);
            this.lblAddress.TabIndex = 81;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddress.UseCompatibleTextRendering = true;
            // 
            // pictureBarCode
            // 
            this.pictureBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBarCode.Location = new System.Drawing.Point(12, 410);
            this.pictureBarCode.Name = "pictureBarCode";
            this.pictureBarCode.Size = new System.Drawing.Size(172, 50);
            this.pictureBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBarCode.TabIndex = 82;
            this.pictureBarCode.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(101, 326);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 16);
            this.lblTime.TabIndex = 83;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(196, 526);
            this.shapeContainer1.TabIndex = 84;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 5;
            this.lineShape2.X2 = 286;
            this.lineShape2.Y1 = 405;
            this.lineShape2.Y2 = 405;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 286;
            this.lineShape1.Y1 = 343;
            this.lineShape1.Y2 = 343;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "NGN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Legal Tender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblprintDate
            // 
            this.lblprintDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblprintDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprintDate.Location = new System.Drawing.Point(73, 161);
            this.lblprintDate.Name = "lblprintDate";
            this.lblprintDate.Size = new System.Drawing.Size(91, 16);
            this.lblprintDate.TabIndex = 87;
            this.lblprintDate.Text = "Date";
            this.lblprintDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCasher
            // 
            this.lblCasher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCasher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasher.Location = new System.Drawing.Point(52, 229);
            this.lblCasher.Name = "lblCasher";
            this.lblCasher.Size = new System.Drawing.Size(114, 16);
            this.lblCasher.TabIndex = 89;
            this.lblCasher.Text = "CName";
            this.lblCasher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 88;
            this.label5.Text = "Cashier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Cashdesk";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(196, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCasher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblprintDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBarCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPaytype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.pictureQRCode);
            this.Controls.Add(this.lblschoolName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiptView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receipt View";
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printReceipt;
        private System.Windows.Forms.Label lblschoolName;
        private System.Windows.Forms.PictureBox pictureQRCode;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPaytype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox pictureBarCode;
        private System.Windows.Forms.Label lblTime;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblprintDate;
        private System.Windows.Forms.Label lblCasher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        }
    }