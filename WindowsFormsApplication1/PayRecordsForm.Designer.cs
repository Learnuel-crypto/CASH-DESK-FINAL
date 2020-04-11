namespace WindowsFormsApplication1
    {
    partial class PayRecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayRecordsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panhead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeReport = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.radioThird = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.radioFirst = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.combFeeName = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnTodayPayment = new System.Windows.Forms.Button();
            this.btnPrintPayRecords = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnViewTaller = new System.Windows.Forms.Button();
            this.btnAllTallerPayments = new System.Windows.Forms.Button();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dailyPaySearchInfor1 = new WindowsFormsApplication1.DailyPaySearchInfor();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studentnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panhead.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
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
            this.panhead.Size = new System.Drawing.Size(976, 19);
            this.panhead.TabIndex = 58;
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
            this.btnclose.Location = new System.Drawing.Point(950, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Payment Record";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panhead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.dateTimeReport);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnInstruction);
            this.panel2.Controls.Add(this.radioThird);
            this.panel2.Controls.Add(this.radioSecond);
            this.panel2.Controls.Add(this.radioFirst);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.combFeeName);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(32, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 75);
            this.panel2.TabIndex = 62;
            // 
            // dateTimeReport
            // 
            this.dateTimeReport.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeReport.Location = new System.Drawing.Point(649, 40);
            this.dateTimeReport.Name = "dateTimeReport";
            this.dateTimeReport.Size = new System.Drawing.Size(130, 26);
            this.dateTimeReport.TabIndex = 102;
            this.dateTimeReport.ValueChanged += new System.EventHandler(this.dateTimeReport_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(585, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Report";
            // 
            // btnInstruction
            // 
            this.btnInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstruction.AutoSize = true;
            this.btnInstruction.BackColor = System.Drawing.Color.White;
            this.btnInstruction.FlatAppearance.BorderSize = 0;
            this.btnInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruction.ForeColor = System.Drawing.Color.Black;
            this.btnInstruction.Location = new System.Drawing.Point(811, 49);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(99, 23);
            this.btnInstruction.TabIndex = 100;
            this.btnInstruction.Text = "How to search";
            this.btnInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInstruction.UseVisualStyleBackColor = false;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // radioThird
            // 
            this.radioThird.AutoSize = true;
            this.radioThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThird.ForeColor = System.Drawing.Color.White;
            this.radioThird.Location = new System.Drawing.Point(502, 43);
            this.radioThird.Name = "radioThird";
            this.radioThird.Size = new System.Drawing.Size(67, 24);
            this.radioThird.TabIndex = 92;
            this.radioThird.TabStop = true;
            this.radioThird.Text = "Third";
            this.radioThird.UseVisualStyleBackColor = true;
            this.radioThird.Click += new System.EventHandler(this.radioThird_Click);
            // 
            // radioSecond
            // 
            this.radioSecond.AutoSize = true;
            this.radioSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSecond.ForeColor = System.Drawing.Color.White;
            this.radioSecond.Location = new System.Drawing.Point(405, 43);
            this.radioSecond.Name = "radioSecond";
            this.radioSecond.Size = new System.Drawing.Size(88, 24);
            this.radioSecond.TabIndex = 91;
            this.radioSecond.TabStop = true;
            this.radioSecond.Text = "Second";
            this.radioSecond.UseVisualStyleBackColor = true;
            this.radioSecond.Click += new System.EventHandler(this.radioSecond_Click);
            // 
            // radioFirst
            // 
            this.radioFirst.AutoSize = true;
            this.radioFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFirst.ForeColor = System.Drawing.Color.White;
            this.radioFirst.Location = new System.Drawing.Point(333, 43);
            this.radioFirst.Name = "radioFirst";
            this.radioFirst.Size = new System.Drawing.Size(63, 24);
            this.radioFirst.TabIndex = 90;
            this.radioFirst.TabStop = true;
            this.radioFirst.Text = "First";
            this.radioFirst.UseVisualStyleBackColor = true;
            this.radioFirst.Click += new System.EventHandler(this.radioFirst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Fee Name";
            // 
            // combFeeName
            // 
            this.combFeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFeeName.FormattingEnabled = true;
            this.combFeeName.Location = new System.Drawing.Point(99, 41);
            this.combFeeName.Name = "combFeeName";
            this.combFeeName.Size = new System.Drawing.Size(227, 28);
            this.combFeeName.TabIndex = 88;
            this.combFeeName.SelectedIndexChanged += new System.EventHandler(this.combFeeName_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(698, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 26);
            this.txtName.TabIndex = 87;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(636, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Name";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(500, 7);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 26);
            this.dateTimeTo.TabIndex = 85;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(332, 7);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(468, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "From";
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
            this.btnSearch.Location = new System.Drawing.Point(877, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 30);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(73, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 10);
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
            this.btnReceipt.Location = new System.Drawing.Point(241, 616);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(82, 29);
            this.btnReceipt.TabIndex = 61;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnTodayPayment
            // 
            this.btnTodayPayment.BackColor = System.Drawing.Color.Blue;
            this.btnTodayPayment.FlatAppearance.BorderSize = 0;
            this.btnTodayPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTodayPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodayPayment.ForeColor = System.Drawing.Color.Snow;
            this.btnTodayPayment.Location = new System.Drawing.Point(149, 616);
            this.btnTodayPayment.Name = "btnTodayPayment";
            this.btnTodayPayment.Size = new System.Drawing.Size(78, 29);
            this.btnTodayPayment.TabIndex = 60;
            this.btnTodayPayment.Text = "Today";
            this.btnTodayPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTodayPayment.UseVisualStyleBackColor = false;
            this.btnTodayPayment.Click += new System.EventHandler(this.btnTodayPayment_Click);
            // 
            // btnPrintPayRecords
            // 
            this.btnPrintPayRecords.BackColor = System.Drawing.Color.Blue;
            this.btnPrintPayRecords.FlatAppearance.BorderSize = 0;
            this.btnPrintPayRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintPayRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPayRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPayRecords.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintPayRecords.Location = new System.Drawing.Point(337, 616);
            this.btnPrintPayRecords.Name = "btnPrintPayRecords";
            this.btnPrintPayRecords.Size = new System.Drawing.Size(82, 29);
            this.btnPrintPayRecords.TabIndex = 63;
            this.btnPrintPayRecords.Text = "Print";
            this.btnPrintPayRecords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintPayRecords.UseVisualStyleBackColor = false;
            this.btnPrintPayRecords.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Blue;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Snow;
            this.btnAll.Location = new System.Drawing.Point(53, 616);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 29);
            this.btnAll.TabIndex = 65;
            this.btnAll.Text = "View All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // checkTotal
            // 
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotal.Location = new System.Drawing.Point(475, 606);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(64, 22);
            this.checkTotal.TabIndex = 66;
            this.checkTotal.Text = "Total ";
            this.checkTotal.UseVisualStyleBackColor = true;
            this.checkTotal.CheckedChanged += new System.EventHandler(this.checkTotal_CheckedChanged);
            this.checkTotal.Click += new System.EventHandler(this.checkTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(477, 633);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 16);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Blue;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Snow;
            this.btnPDF.Location = new System.Drawing.Point(858, 623);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(82, 29);
            this.btnPDF.TabIndex = 74;
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
            this.btnReport.Location = new System.Drawing.Point(858, 588);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(82, 29);
            this.btnReport.TabIndex = 77;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.btnViewTaller.Location = new System.Drawing.Point(761, 585);
            this.btnViewTaller.Name = "btnViewTaller";
            this.btnViewTaller.Size = new System.Drawing.Size(88, 29);
            this.btnViewTaller.TabIndex = 78;
            this.btnViewTaller.Text = "Teller";
            this.btnViewTaller.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewTaller.UseVisualStyleBackColor = false;
            this.btnViewTaller.Visible = false;
            this.btnViewTaller.Click += new System.EventHandler(this.btnViewTaller_Click);
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
            this.btnAllTallerPayments.Location = new System.Drawing.Point(715, 620);
            this.btnAllTallerPayments.Name = "btnAllTallerPayments";
            this.btnAllTallerPayments.Size = new System.Drawing.Size(137, 29);
            this.btnAllTallerPayments.TabIndex = 79;
            this.btnAllTallerPayments.Text = "Teller Payments";
            this.btnAllTallerPayments.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAllTallerPayments.UseVisualStyleBackColor = false;
            this.btnAllTallerPayments.Click += new System.EventHandler(this.btnAllTallerPayments_Click);
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Studentnames,
            this.Classe,
            this.Fee_names,
            this.Term_s,
            this.Amounts,
            this.Dates,
            this.Installs,
            this.Type,
            this.Years,
            this.Times});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRecords.Location = new System.Drawing.Point(8, 104);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecords.Size = new System.Drawing.Size(960, 475);
            this.dataGridViewRecords.TabIndex = 82;
            this.dataGridViewRecords.Click += new System.EventHandler(this.dataGridViewRecords_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 661);
            this.panel1.TabIndex = 83;
            // 
            // dailyPaySearchInfor1
            // 
            this.dailyPaySearchInfor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyPaySearchInfor1.BackColor = System.Drawing.Color.White;
            this.dailyPaySearchInfor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyPaySearchInfor1.Location = new System.Drawing.Point(422, 98);
            this.dailyPaySearchInfor1.Name = "dailyPaySearchInfor1";
            this.dailyPaySearchInfor1.Size = new System.Drawing.Size(550, 329);
            this.dailyPaySearchInfor1.TabIndex = 80;
            this.dailyPaySearchInfor1.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 47;
            // 
            // Studentnames
            // 
            this.Studentnames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Studentnames.HeaderText = "Student name";
            this.Studentnames.Name = "Studentnames";
            this.Studentnames.ReadOnly = true;
            this.Studentnames.Width = 124;
            // 
            // Classe
            // 
            this.Classe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Classe.HeaderText = "Class";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            this.Classe.Width = 71;
            // 
            // Fee_names
            // 
            this.Fee_names.HeaderText = "Fee name";
            this.Fee_names.Name = "Fee_names";
            this.Fee_names.ReadOnly = true;
            // 
            // Term_s
            // 
            this.Term_s.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Term_s.HeaderText = "Term";
            this.Term_s.Name = "Term_s";
            this.Term_s.ReadOnly = true;
            this.Term_s.Width = 68;
            // 
            // Amounts
            // 
            this.Amounts.HeaderText = "Amount";
            this.Amounts.Name = "Amounts";
            this.Amounts.ReadOnly = true;
            // 
            // Dates
            // 
            this.Dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dates.HeaderText = "Date";
            this.Dates.Name = "Dates";
            this.Dates.ReadOnly = true;
            this.Dates.Width = 64;
            // 
            // Installs
            // 
            this.Installs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Installs.HeaderText = "Install";
            this.Installs.Name = "Installs";
            this.Installs.ReadOnly = true;
            this.Installs.Width = 70;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 65;
            // 
            // Years
            // 
            this.Years.HeaderText = "Year";
            this.Years.Name = "Years";
            this.Years.ReadOnly = true;
            // 
            // Times
            // 
            this.Times.HeaderText = "Time";
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            // 
            // PayRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 661);
            this.Controls.Add(this.dailyPaySearchInfor1);
            this.Controls.Add(this.panhead);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(this.btnAllTallerPayments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnViewTaller);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnTodayPayment);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPrintPayRecords);
            this.Controls.Add(this.checkTotal);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayRecordsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Record";
            this.Load += new System.EventHandler(this.PayRecordsForm_Load);
            this.panhead.ResumeLayout(false);
            this.panhead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Panel panhead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.RadioButton radioThird;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.RadioButton radioFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combFeeName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnTodayPayment;
        private System.Windows.Forms.Button btnPrintPayRecords;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnViewTaller;
        private System.Windows.Forms.Button btnAllTallerPayments;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private DailyPaySearchInfor dailyPaySearchInfor1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studentnames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Years;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times;
        }
    }