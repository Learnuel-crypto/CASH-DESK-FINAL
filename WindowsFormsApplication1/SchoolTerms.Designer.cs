namespace WindowsFormsApplication1
    {
    partial class SchoolTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolTerms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panhead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioFirst = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panhead.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panhead
            // 
            this.panhead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panhead.Controls.Add(this.btnclose);
            this.panhead.Controls.Add(this.label5);
            this.panhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panhead.Location = new System.Drawing.Point(0, 0);
            this.panhead.Name = "panhead";
            this.panhead.Size = new System.Drawing.Size(629, 19);
            this.panhead.TabIndex = 57;
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnclose.Image = ((System.Drawing.Image) (resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(603, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Term Fees ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(19, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 40);
            this.panel3.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(495, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 39);
            this.button1.TabIndex = 36;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox3.Location = new System.Drawing.Point(90, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 27);
            this.textBox3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Search";
            // 
            // radioFirst
            // 
            this.radioFirst.AutoSize = true;
            this.radioFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioFirst.Location = new System.Drawing.Point(18, 75);
            this.radioFirst.Name = "radioFirst";
            this.radioFirst.Size = new System.Drawing.Size(113, 28);
            this.radioFirst.TabIndex = 65;
            this.radioFirst.TabStop = true;
            this.radioFirst.Text = "First Term";
            this.radioFirst.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioButton1.Location = new System.Drawing.Point(137, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 28);
            this.radioButton1.TabIndex = 66;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Second Term";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioButton2.Location = new System.Drawing.Point(287, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 28);
            this.radioButton2.TabIndex = 67;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Third Term";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(472, 77);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(421, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Year";
            // 
            // dataGridRecords
            // 
            this.dataGridRecords.AllowUserToAddRows = false;
            this.dataGridRecords.AllowUserToDeleteRows = false;
            this.dataGridRecords.AllowUserToOrderColumns = true;
            this.dataGridRecords.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Names,
            this.Class,
            this.Fee_Name,
            this.Amount,
            this.Pay_Date});
            this.dataGridRecords.Location = new System.Drawing.Point(17, 108);
            this.dataGridRecords.Name = "dataGridRecords";
            this.dataGridRecords.ReadOnly = true;
            this.dataGridRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRecords.Size = new System.Drawing.Size(583, 418);
            this.dataGridRecords.TabIndex = 92;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Names.HeaderText = "Student Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 118;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Fee_Name
            // 
            this.Fee_Name.HeaderText = "Fee Name";
            this.Fee_Name.Name = "Fee_Name";
            this.Fee_Name.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Pay_Date
            // 
            this.Pay_Date.HeaderText = "Date";
            this.Pay_Date.Name = "Pay_Date";
            this.Pay_Date.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridRecords);
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 585);
            this.panel1.TabIndex = 93;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Blue;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Snow;
            this.btnPDF.Location = new System.Drawing.Point(237, 546);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(82, 26);
            this.btnPDF.TabIndex = 77;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Blue;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Snow;
            this.btnExcel.Location = new System.Drawing.Point(339, 546);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 26);
            this.btnExcel.TabIndex = 76;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Blue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(129, 546);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 26);
            this.btnPrint.TabIndex = 75;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // SchoolTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioFirst);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panhead);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchoolTerms";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Terms";
            this.panhead.ResumeLayout(false);
            this.panhead.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Panel panhead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioFirst;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay_Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
        }
    }