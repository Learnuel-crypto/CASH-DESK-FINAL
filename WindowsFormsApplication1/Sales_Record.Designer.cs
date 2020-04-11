namespace WindowsFormsApplication1
    {
    partial class Sales_Record
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Record));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnAllSalesInfor = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnCreditSales = new System.Windows.Forms.Button();
            this.btnTodaySales = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combItemName = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.btnPrintSaleRecord = new System.Windows.Forms.Button();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridSalesRecord = new System.Windows.Forms.DataGridView();
            this.Names_of_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnWhatisReport = new System.Windows.Forms.Button();
            this.report_From_SalesForm1 = new WindowsFormsApplication1.Report_From_SalesForm();
            this.what_Is_Report1 = new WindowsFormsApplication1.What_Is_Report();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(38, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(96, 31);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Add Items";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnAllSalesInfor);
            this.panel1.Controls.Add(this.btnSalesReport);
            this.panel1.Controls.Add(this.btnCreditSales);
            this.panel1.Controls.Add(this.btnTodaySales);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.btnMakeSale);
            this.panel1.Controls.Add(this.btnInstruction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 39);
            this.panel1.TabIndex = 11;
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(720, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(71, 31);
            this.btnStock.TabIndex = 104;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnAllSalesInfor
            // 
            this.btnAllSalesInfor.FlatAppearance.BorderSize = 0;
            this.btnAllSalesInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSalesInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSalesInfor.Location = new System.Drawing.Point(634, 3);
            this.btnAllSalesInfor.Name = "btnAllSalesInfor";
            this.btnAllSalesInfor.Size = new System.Drawing.Size(71, 31);
            this.btnAllSalesInfor.TabIndex = 103;
            this.btnAllSalesInfor.Text = "Names ";
            this.btnAllSalesInfor.UseVisualStyleBackColor = true;
            this.btnAllSalesInfor.Click += new System.EventHandler(this.btnAllSalesInfor_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(505, 3);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(114, 31);
            this.btnSalesReport.TabIndex = 102;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnCreditSales
            // 
            this.btnCreditSales.FlatAppearance.BorderSize = 0;
            this.btnCreditSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditSales.Location = new System.Drawing.Point(379, 3);
            this.btnCreditSales.Name = "btnCreditSales";
            this.btnCreditSales.Size = new System.Drawing.Size(111, 31);
            this.btnCreditSales.TabIndex = 101;
            this.btnCreditSales.Text = "Credit Sales";
            this.btnCreditSales.UseVisualStyleBackColor = true;
            this.btnCreditSales.Click += new System.EventHandler(this.btnCreditSales_Click);
            // 
            // btnTodaySales
            // 
            this.btnTodaySales.FlatAppearance.BorderSize = 0;
            this.btnTodaySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodaySales.Location = new System.Drawing.Point(260, 3);
            this.btnTodaySales.Name = "btnTodaySales";
            this.btnTodaySales.Size = new System.Drawing.Size(104, 31);
            this.btnTodaySales.TabIndex = 13;
            this.btnTodaySales.Text = "Today Sales";
            this.btnTodaySales.UseVisualStyleBackColor = true;
            this.btnTodaySales.Click += new System.EventHandler(this.btnTodaySales_Click);
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.FlatAppearance.BorderSize = 0;
            this.btnMakeSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeSale.Location = new System.Drawing.Point(149, 3);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(96, 31);
            this.btnMakeSale.TabIndex = 12;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
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
            this.btnInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruction.ForeColor = System.Drawing.Color.Blue;
            this.btnInstruction.Location = new System.Drawing.Point(824, 8);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(103, 26);
            this.btnInstruction.TabIndex = 100;
            this.btnInstruction.Text = "How to Report";
            this.btnInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInstruction.UseVisualStyleBackColor = false;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.Location = new System.Drawing.Point(12, 66);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(279, 26);
            this.txtItemSearch.TabIndex = 90;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Search";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(676, 41);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 105;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(622, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "From";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(676, 71);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 26);
            this.dateTimeTo.TabIndex = 103;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(644, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "To";
            // 
            // combItemName
            // 
            this.combItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combItemName.FormattingEnabled = true;
            this.combItemName.Location = new System.Drawing.Point(301, 65);
            this.combItemName.Name = "combItemName";
            this.combItemName.Size = new System.Drawing.Size(318, 28);
            this.combItemName.TabIndex = 107;
            this.combItemName.SelectedIndexChanged += new System.EventHandler(this.combItemName_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(446, 552);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 18);
            this.lblTotal.TabIndex = 110;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // checkTotal
            // 
            this.checkTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotal.Location = new System.Drawing.Point(375, 550);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(64, 22);
            this.checkTotal.TabIndex = 109;
            this.checkTotal.Text = "Total ";
            this.checkTotal.UseVisualStyleBackColor = true;
            this.checkTotal.Click += new System.EventHandler(this.checkTotal_Click);
            // 
            // btnPrintSaleRecord
            // 
            this.btnPrintSaleRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintSaleRecord.BackColor = System.Drawing.Color.Blue;
            this.btnPrintSaleRecord.FlatAppearance.BorderSize = 0;
            this.btnPrintSaleRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintSaleRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintSaleRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSaleRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSaleRecord.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintSaleRecord.Location = new System.Drawing.Point(12, 549);
            this.btnPrintSaleRecord.Name = "btnPrintSaleRecord";
            this.btnPrintSaleRecord.Size = new System.Drawing.Size(72, 29);
            this.btnPrintSaleRecord.TabIndex = 108;
            this.btnPrintSaleRecord.Text = "Print";
            this.btnPrintSaleRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSaleRecord.UseVisualStyleBackColor = false;
            this.btnPrintSaleRecord.Click += new System.EventHandler(this.btnPrintSaleRecord_Click);
            // 
            // btnReportSales
            // 
            this.btnReportSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReportSales.BackColor = System.Drawing.Color.Blue;
            this.btnReportSales.FlatAppearance.BorderSize = 0;
            this.btnReportSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnReportSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSales.ForeColor = System.Drawing.Color.Snow;
            this.btnReportSales.Location = new System.Drawing.Point(89, 548);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(82, 29);
            this.btnReportSales.TabIndex = 112;
            this.btnReportSales.Text = "Report";
            this.btnReportSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportSales.UseVisualStyleBackColor = false;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(177, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 29);
            this.btnDelete.TabIndex = 113;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridSalesRecord
            // 
            this.dataGridSalesRecord.AllowUserToAddRows = false;
            this.dataGridSalesRecord.AllowUserToDeleteRows = false;
            this.dataGridSalesRecord.AllowUserToOrderColumns = true;
            this.dataGridSalesRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSalesRecord.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSalesRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSalesRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSalesRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names_of_Items,
            this.Qty,
            this.Selling_Price,
            this.Qty_Sold,
            this.Cost,
            this.Discount,
            this.Amount,
            this.Date_Sold,
            this.Sales_Id,
            this.Name_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSalesRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSalesRecord.Location = new System.Drawing.Point(12, 100);
            this.dataGridSalesRecord.Name = "dataGridSalesRecord";
            this.dataGridSalesRecord.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSalesRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSalesRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSalesRecord.Size = new System.Drawing.Size(900, 433);
            this.dataGridSalesRecord.TabIndex = 114;
            this.dataGridSalesRecord.Click += new System.EventHandler(this.dataGridSalesRecord_Click);
            // 
            // Names_of_Items
            // 
            this.Names_of_Items.HeaderText = "Names of Items";
            this.Names_of_Items.Name = "Names_of_Items";
            this.Names_of_Items.ReadOnly = true;
            this.Names_of_Items.Width = 122;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 53;
            // 
            // Selling_Price
            // 
            this.Selling_Price.HeaderText = "Selling Price";
            this.Selling_Price.Name = "Selling_Price";
            this.Selling_Price.ReadOnly = true;
            this.Selling_Price.Width = 123;
            // 
            // Qty_Sold
            // 
            this.Qty_Sold.HeaderText = "Qty Sold";
            this.Qty_Sold.Name = "Qty_Sold";
            this.Qty_Sold.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 123;
            // 
            // Date_Sold
            // 
            this.Date_Sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date_Sold.HeaderText = "Date";
            this.Date_Sold.Name = "Date_Sold";
            this.Date_Sold.ReadOnly = true;
            this.Date_Sold.Width = 62;
            // 
            // Sales_Id
            // 
            this.Sales_Id.HeaderText = "Sales_Id";
            this.Sales_Id.Name = "Sales_Id";
            this.Sales_Id.ReadOnly = true;
            this.Sales_Id.Visible = false;
            // 
            // Name_id
            // 
            this.Name_id.HeaderText = "Name_id";
            this.Name_id.Name = "Name_id";
            this.Name_id.ReadOnly = true;
            this.Name_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(300, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Select Item";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnRefresh.Location = new System.Drawing.Point(536, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 26);
            this.btnRefresh.TabIndex = 102;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnWhatisReport
            // 
            this.btnWhatisReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhatisReport.AutoSize = true;
            this.btnWhatisReport.BackColor = System.Drawing.Color.White;
            this.btnWhatisReport.FlatAppearance.BorderSize = 0;
            this.btnWhatisReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnWhatisReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnWhatisReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhatisReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatisReport.ForeColor = System.Drawing.Color.Blue;
            this.btnWhatisReport.Location = new System.Drawing.Point(814, 545);
            this.btnWhatisReport.Name = "btnWhatisReport";
            this.btnWhatisReport.Size = new System.Drawing.Size(106, 26);
            this.btnWhatisReport.TabIndex = 129;
            this.btnWhatisReport.Text = "What is Report";
            this.btnWhatisReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWhatisReport.UseVisualStyleBackColor = false;
            this.btnWhatisReport.Click += new System.EventHandler(this.btnWhatisReport_Click);
            // 
            // report_From_SalesForm1
            // 
            this.report_From_SalesForm1.BackColor = System.Drawing.Color.White;
            this.report_From_SalesForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report_From_SalesForm1.Location = new System.Drawing.Point(620, 101);
            this.report_From_SalesForm1.Name = "report_From_SalesForm1";
            this.report_From_SalesForm1.Size = new System.Drawing.Size(285, 241);
            this.report_From_SalesForm1.TabIndex = 131;
            this.report_From_SalesForm1.Visible = false;
            // 
            // what_Is_Report1
            // 
            this.what_Is_Report1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.what_Is_Report1.BackColor = System.Drawing.Color.White;
            this.what_Is_Report1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.what_Is_Report1.Location = new System.Drawing.Point(574, 292);
            this.what_Is_Report1.Name = "what_Is_Report1";
            this.what_Is_Report1.Size = new System.Drawing.Size(338, 259);
            this.what_Is_Report1.TabIndex = 130;
            this.what_Is_Report1.Visible = false;
            // 
            // Sales_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 592);
            this.Controls.Add(this.combItemName);
            this.Controls.Add(this.report_From_SalesForm1);
            this.Controls.Add(this.what_Is_Report1);
            this.Controls.Add(this.btnWhatisReport);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSalesRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReportSales);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkTotal);
            this.Controls.Add(this.btnPrintSaleRecord);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTodaySales;
        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combItemName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.Button btnPrintSaleRecord;
        private System.Windows.Forms.Button btnReportSales;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridSalesRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreditSales;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnWhatisReport;
        private What_Is_Report what_Is_Report1;
        private Report_From_SalesForm report_From_SalesForm1;
        private System.Windows.Forms.Button btnAllSalesInfor;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names_of_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_id;
        private System.Windows.Forms.Button btnStock;
        }
    }