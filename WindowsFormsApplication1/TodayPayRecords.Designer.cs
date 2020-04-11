namespace WindowsFormsApplication1
    {
    partial class TodayPayRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayPayRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.panhead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllTallerPayments = new System.Windows.Forms.Button();
            this.btnViewTaller = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnViewTodayAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.combFeeName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panhead.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Today  Records";
            // 
            // panhead
            // 
            this.panhead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panhead.Controls.Add(this.btnclose);
            this.panhead.Controls.Add(this.label5);
            this.panhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panhead.Location = new System.Drawing.Point(0, 0);
            this.panhead.Name = "panhead";
            this.panhead.Size = new System.Drawing.Size(986, 19);
            this.panhead.TabIndex = 61;
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(960, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Blue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(257, 572);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 29);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAllTallerPayments);
            this.panel1.Controls.Add(this.btnViewTaller);
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnViewTodayAll);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.checkTotal);
            this.panel1.Controls.Add(this.dataGridRecords);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 624);
            this.panel1.TabIndex = 62;
            // 
            // btnAllTallerPayments
            // 
            this.btnAllTallerPayments.BackColor = System.Drawing.Color.White;
            this.btnAllTallerPayments.FlatAppearance.BorderSize = 0;
            this.btnAllTallerPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAllTallerPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAllTallerPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTallerPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTallerPayments.ForeColor = System.Drawing.Color.Black;
            this.btnAllTallerPayments.Location = new System.Drawing.Point(737, 589);
            this.btnAllTallerPayments.Name = "btnAllTallerPayments";
            this.btnAllTallerPayments.Size = new System.Drawing.Size(137, 29);
            this.btnAllTallerPayments.TabIndex = 80;
            this.btnAllTallerPayments.Text = "Teller Payments";
            this.btnAllTallerPayments.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAllTallerPayments.UseVisualStyleBackColor = false;
            this.btnAllTallerPayments.Click += new System.EventHandler(this.btnAllTallerPayments_Click);
            // 
            // btnViewTaller
            // 
            this.btnViewTaller.BackColor = System.Drawing.Color.White;
            this.btnViewTaller.FlatAppearance.BorderSize = 0;
            this.btnViewTaller.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnViewTaller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnViewTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTaller.ForeColor = System.Drawing.Color.Black;
            this.btnViewTaller.Location = new System.Drawing.Point(775, 558);
            this.btnViewTaller.Name = "btnViewTaller";
            this.btnViewTaller.Size = new System.Drawing.Size(88, 29);
            this.btnViewTaller.TabIndex = 73;
            this.btnViewTaller.Text = "Teller";
            this.btnViewTaller.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewTaller.UseVisualStyleBackColor = false;
            this.btnViewTaller.Visible = false;
            this.btnViewTaller.Click += new System.EventHandler(this.btnViewTaller_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Blue;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Snow;
            this.btnPDF.Location = new System.Drawing.Point(880, 558);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(82, 29);
            this.btnPDF.TabIndex = 72;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Blue;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Snow;
            this.btnReport.Location = new System.Drawing.Point(880, 591);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(82, 29);
            this.btnReport.TabIndex = 71;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnViewTodayAll
            // 
            this.btnViewTodayAll.BackColor = System.Drawing.Color.Blue;
            this.btnViewTodayAll.FlatAppearance.BorderSize = 0;
            this.btnViewTodayAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnViewTodayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTodayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTodayAll.ForeColor = System.Drawing.Color.Snow;
            this.btnViewTodayAll.Location = new System.Drawing.Point(43, 572);
            this.btnViewTodayAll.Name = "btnViewTodayAll";
            this.btnViewTodayAll.Size = new System.Drawing.Size(82, 29);
            this.btnViewTodayAll.TabIndex = 5;
            this.btnViewTodayAll.Text = "View All";
            this.btnViewTodayAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewTodayAll.UseVisualStyleBackColor = false;
            this.btnViewTodayAll.Click += new System.EventHandler(this.btnViewTodayAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(460, 589);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 18);
            this.lblTotal.TabIndex = 69;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // checkTotal
            // 
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotal.Location = new System.Drawing.Point(442, 558);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(67, 24);
            this.checkTotal.TabIndex = 68;
            this.checkTotal.Text = "Total ";
            this.checkTotal.UseVisualStyleBackColor = true;
            this.checkTotal.Click += new System.EventHandler(this.checkTotal_Click);
            // 
            // dataGridRecords
            // 
            this.dataGridRecords.AllowUserToAddRows = false;
            this.dataGridRecords.AllowUserToDeleteRows = false;
            this.dataGridRecords.AllowUserToOrderColumns = true;
            this.dataGridRecords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Term,
            this.Amount,
            this.Pay_Date,
            this.Intallment,
            this.Fee_Type,
            this.Year,
            this.Time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRecords.Location = new System.Drawing.Point(19, 79);
            this.dataGridRecords.Name = "dataGridRecords";
            this.dataGridRecords.ReadOnly = true;
            this.dataGridRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRecords.Size = new System.Drawing.Size(943, 473);
            this.dataGridRecords.TabIndex = 4;
            this.dataGridRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecords_CellContentClick);
            this.dataGridRecords.Click += new System.EventHandler(this.dataGridRecords_Click);
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
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Student Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 137;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 73;
            // 
            // Fee_Name
            // 
            this.Fee_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fee_Name.HeaderText = "Fee Name";
            this.Fee_Name.Name = "Fee_Name";
            this.Fee_Name.ReadOnly = true;
            this.Fee_Name.Width = 108;
            // 
            // Term
            // 
            this.Term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Term.HeaderText = "Term";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            this.Term.Width = 70;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 90;
            // 
            // Pay_Date
            // 
            this.Pay_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pay_Date.HeaderText = "Date";
            this.Pay_Date.Name = "Pay_Date";
            this.Pay_Date.ReadOnly = true;
            this.Pay_Date.Width = 69;
            // 
            // Intallment
            // 
            this.Intallment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Intallment.HeaderText = "Instal..";
            this.Intallment.Name = "Intallment";
            this.Intallment.ReadOnly = true;
            this.Intallment.Width = 81;
            // 
            // Fee_Type
            // 
            this.Fee_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fee_Type.HeaderText = "Type";
            this.Fee_Type.Name = "Fee_Type";
            this.Fee_Type.ReadOnly = true;
            this.Fee_Type.Width = 68;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 68;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.combFeeName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(19, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 40);
            this.panel2.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Fee Name";
            // 
            // combFeeName
            // 
            this.combFeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFeeName.FormattingEnabled = true;
            this.combFeeName.Location = new System.Drawing.Point(505, 7);
            this.combFeeName.Name = "combFeeName";
            this.combFeeName.Size = new System.Drawing.Size(227, 28);
            this.combFeeName.TabIndex = 90;
            this.combFeeName.SelectedIndexChanged += new System.EventHandler(this.combFeeName_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(342, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(71, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.Blue;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.Snow;
            this.btnReceipt.Location = new System.Drawing.Point(150, 572);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(82, 29);
            this.btnReceipt.TabIndex = 6;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panhead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TodayPayRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 624);
            this.Controls.Add(this.panhead);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TodayPayRecords";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Today Pay Records";
            this.Load += new System.EventHandler(this.TodayPayRecords_Load);
            this.panhead.ResumeLayout(false);
            this.panhead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panhead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridRecords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.Button btnViewTodayAll;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnReport;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button btnViewTaller;
        private System.Windows.Forms.Button btnAllTallerPayments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combFeeName;
    }
    }