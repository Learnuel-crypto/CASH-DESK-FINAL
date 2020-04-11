namespace WindowsFormsApplication1
    {
    partial class TotalDailyIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalDailyIncome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridExpense = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashAtHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panDrag = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpense)).BeginInit();
            this.panDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.checkTotal);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.txtcash);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddnew);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeDate);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtExpense);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIncome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridExpense);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 532);
            this.panel1.TabIndex = 68;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(21, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 18);
            this.lblTotal.TabIndex = 108;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // checkTotal
            // 
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotal.Location = new System.Drawing.Point(17, 411);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(64, 22);
            this.checkTotal.TabIndex = 107;
            this.checkTotal.Text = "Total ";
            this.checkTotal.UseVisualStyleBackColor = true;
            this.checkTotal.CheckedChanged += new System.EventHandler(this.checkTotal_CheckedChanged);
            this.checkTotal.Click += new System.EventHandler(this.checkTotal_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Blue;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Snow;
            this.btnExport.Location = new System.Drawing.Point(101, 351);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(78, 29);
            this.btnExport.TabIndex = 106;
            this.btnExport.Text = "PDF";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtcash
            // 
            this.txtcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Location = new System.Drawing.Point(17, 190);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(136, 26);
            this.txtcash.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Cash";
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.Blue;
            this.btnAddnew.FlatAppearance.BorderSize = 0;
            this.btnAddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.ForeColor = System.Drawing.Color.Snow;
            this.btnAddnew.Location = new System.Drawing.Point(17, 316);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(78, 29);
            this.btnAddnew.TabIndex = 103;
            this.btnAddnew.Text = "New";
            this.btnAddnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Date";
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(17, 244);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(130, 26);
            this.dateTimeDate.TabIndex = 101;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(35, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 100;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Location = new System.Drawing.Point(101, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 29);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(101, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 29);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Snow;
            this.btnUpdate.Location = new System.Drawing.Point(17, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 29);
            this.btnUpdate.TabIndex = 96;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtExpense
            // 
            this.txtExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpense.Location = new System.Drawing.Point(17, 138);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(136, 26);
            this.txtExpense.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Expense";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(17, 86);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(136, 26);
            this.txtIncome.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Income";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(83, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 40);
            this.panel2.TabIndex = 63;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(61, 6);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 97;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "From";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(233, 6);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 26);
            this.dateTimeTo.TabIndex = 95;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "To";
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
            this.btnSearch.Location = new System.Drawing.Point(627, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 39);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(461, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(392, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // dataGridExpense
            // 
            this.dataGridExpense.AllowUserToAddRows = false;
            this.dataGridExpense.AllowUserToDeleteRows = false;
            this.dataGridExpense.AllowUserToOrderColumns = true;
            this.dataGridExpense.BackgroundColor = System.Drawing.Color.White;
            this.dataGridExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Total,
            this.Expense,
            this.CashAtHand,
            this.Cash_Type,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridExpense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridExpense.Location = new System.Drawing.Point(185, 62);
            this.dataGridExpense.Name = "dataGridExpense";
            this.dataGridExpense.ReadOnly = true;
            this.dataGridExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExpense.Size = new System.Drawing.Size(574, 457);
            this.dataGridExpense.TabIndex = 65;
            this.dataGridExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridExpense_CellContentClick);
            this.dataGridExpense.Click += new System.EventHandler(this.dataGridExpense_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Total.HeaderText = "Total Income";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 119;
            // 
            // Expense
            // 
            this.Expense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Expense.HeaderText = "Total Expense";
            this.Expense.Name = "Expense";
            this.Expense.ReadOnly = true;
            this.Expense.Width = 127;
            // 
            // CashAtHand
            // 
            this.CashAtHand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CashAtHand.HeaderText = "Cash Avail.";
            this.CashAtHand.Name = "CashAtHand";
            this.CashAtHand.ReadOnly = true;
            this.CashAtHand.Width = 106;
            // 
            // Cash_Type
            // 
            this.Cash_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cash_Type.HeaderText = "Cash Type";
            this.Cash_Type.Name = "Cash_Type";
            this.Cash_Type.ReadOnly = true;
            this.Cash_Type.Width = 104;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 64;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Blue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(17, 351);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 29);
            this.btnPrint.TabIndex = 70;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panDrag
            // 
            this.panDrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panDrag.Controls.Add(this.btnclose);
            this.panDrag.Controls.Add(this.label10);
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDrag.Location = new System.Drawing.Point(0, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(768, 19);
            this.panDrag.TabIndex = 67;
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
            this.btnclose.Location = new System.Drawing.Point(742, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Daily Income";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TotalDailyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TotalDailyIncome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Inocme";
            this.Load += new System.EventHandler(this.TotalDailyIncome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpense)).EndInit();
            this.panDrag.ResumeLayout(false);
            this.panDrag.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridExpense;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panDrag;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashAtHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotal;
        }
    }