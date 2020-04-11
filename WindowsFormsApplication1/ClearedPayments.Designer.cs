namespace WindowsFormsApplication1
    {
    partial class ClearedPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearedPayments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldrag = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.dataGridPayment = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnPrintCleared = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.infor1 = new WindowsFormsApplication1.Infor();
            this.paneldrag.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldrag
            // 
            this.paneldrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneldrag.Controls.Add(this.btnClose);
            this.paneldrag.Controls.Add(this.label5);
            this.paneldrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldrag.Location = new System.Drawing.Point(0, 0);
            this.paneldrag.Name = "paneldrag";
            this.paneldrag.Size = new System.Drawing.Size(820, 22);
            this.paneldrag.TabIndex = 68;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(794, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 22);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cleared Payments";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.BackColor = System.Drawing.Color.Yellow;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNotice.Location = new System.Drawing.Point(605, 657);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(87, 20);
            this.lblNotice.TabIndex = 87;
            this.lblNotice.Text = "Processing";
            this.lblNotice.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(349, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Search";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnAll);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dateTimeDate);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtsearch);
            this.panel4.Location = new System.Drawing.Point(13, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 40);
            this.panel4.TabIndex = 88;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 26);
            this.dateTimePicker1.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(183, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "From";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Snow;
            this.btnAll.Location = new System.Drawing.Point(682, -3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(44, 46);
            this.btnAll.TabIndex = 89;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(51, 7);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(130, 26);
            this.dateTimeDate.TabIndex = 85;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(631, -6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 53);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(420, 7);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(207, 26);
            this.txtsearch.TabIndex = 37;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.infor1);
            this.panel1.Controls.Add(this.btnInstruction);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblNotice);
            this.panel1.Controls.Add(this.dataGridPayment);
            this.panel1.Controls.Add(this.btnpdf);
            this.panel1.Controls.Add(this.btnPrintCleared);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 690);
            this.panel1.TabIndex = 69;
            // 
            // btnInstruction
            // 
            this.btnInstruction.AutoSize = true;
            this.btnInstruction.BackColor = System.Drawing.Color.White;
            this.btnInstruction.FlatAppearance.BorderSize = 0;
            this.btnInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruction.ForeColor = System.Drawing.Color.Black;
            this.btnInstruction.Location = new System.Drawing.Point(707, 628);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(99, 23);
            this.btnInstruction.TabIndex = 99;
            this.btnInstruction.Text = "How to search";
            this.btnInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInstruction.UseVisualStyleBackColor = false;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // dataGridPayment
            // 
            this.dataGridPayment.AllowUserToAddRows = false;
            this.dataGridPayment.AllowUserToDeleteRows = false;
            this.dataGridPayment.AllowUserToOrderColumns = true;
            this.dataGridPayment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Sex,
            this.Class,
            this.Fee_Name,
            this.Paid_Amount,
            this.Balance,
            this.Term,
            this.Status,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPayment.Location = new System.Drawing.Point(13, 89);
            this.dataGridPayment.Name = "dataGridPayment";
            this.dataGridPayment.ReadOnly = true;
            this.dataGridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPayment.Size = new System.Drawing.Size(771, 533);
            this.dataGridPayment.TabIndex = 66;
            // 
            // Names
            // 
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 58;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 71;
            // 
            // Fee_Name
            // 
            this.Fee_Name.HeaderText = "Fee";
            this.Fee_Name.Name = "Fee_Name";
            this.Fee_Name.ReadOnly = true;
            // 
            // Paid_Amount
            // 
            this.Paid_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Paid_Amount.HeaderText = "Amount";
            this.Paid_Amount.Name = "Paid_Amount";
            this.Paid_Amount.ReadOnly = true;
            this.Paid_Amount.Width = 84;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 86;
            // 
            // Term
            // 
            this.Term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Term.HeaderText = "Term";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            this.Term.Width = 68;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 75;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 64;
            // 
            // btnpdf
            // 
            this.btnpdf.BackColor = System.Drawing.Color.Blue;
            this.btnpdf.FlatAppearance.BorderSize = 0;
            this.btnpdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnpdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.ForeColor = System.Drawing.Color.Snow;
            this.btnpdf.Location = new System.Drawing.Point(354, 648);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(67, 29);
            this.btnpdf.TabIndex = 48;
            this.btnpdf.Text = "PDF";
            this.btnpdf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpdf.UseVisualStyleBackColor = false;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnPrintCleared
            // 
            this.btnPrintCleared.BackColor = System.Drawing.Color.Blue;
            this.btnPrintCleared.FlatAppearance.BorderSize = 0;
            this.btnPrintCleared.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintCleared.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintCleared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCleared.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintCleared.Location = new System.Drawing.Point(261, 648);
            this.btnPrintCleared.Name = "btnPrintCleared";
            this.btnPrintCleared.Size = new System.Drawing.Size(67, 29);
            this.btnPrintCleared.TabIndex = 47;
            this.btnPrintCleared.Text = "Print";
            this.btnPrintCleared.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintCleared.UseVisualStyleBackColor = false;
            this.btnPrintCleared.Click += new System.EventHandler(this.btnPrintCleared_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneldrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // infor1
            // 
            this.infor1.BackColor = System.Drawing.Color.White;
            this.infor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infor1.Location = new System.Drawing.Point(439, 433);
            this.infor1.Name = "infor1";
            this.infor1.Size = new System.Drawing.Size(367, 189);
            this.infor1.TabIndex = 100;
            this.infor1.Visible = false;
            // 
            // ClearedPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 690);
            this.Controls.Add(this.paneldrag);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClearedPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleared Payments";
            this.Load += new System.EventHandler(this.ClearedPayments_Load);
            this.paneldrag.ResumeLayout(false);
            this.paneldrag.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayment)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel paneldrag;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridPayment;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnPrintCleared;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Infor infor1;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        }
    }