namespace WindowsFormsApplication1
    {
    partial class Credit_Sales_Record
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credit_Sales_Record));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combItemName = new System.Windows.Forms.ComboBox();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.dataGridCreditSalesRecord = new System.Windows.Forms.DataGridView();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.btnPrintSaleRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCreditSalesRecord)).BeginInit();
            this.SuspendLayout();
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
            this.btnRefresh.Location = new System.Drawing.Point(612, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 26);
            this.btnRefresh.TabIndex = 121;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 127;
            this.label1.Text = "Select Item";
            // 
            // combItemName
            // 
            this.combItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combItemName.FormattingEnabled = true;
            this.combItemName.Location = new System.Drawing.Point(335, 32);
            this.combItemName.Name = "combItemName";
            this.combItemName.Size = new System.Drawing.Size(342, 28);
            this.combItemName.TabIndex = 126;
            this.combItemName.SelectedIndexChanged += new System.EventHandler(this.combItemName_SelectedIndexChanged);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(756, 8);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 125;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(702, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "From";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(756, 38);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 26);
            this.dateTimeTo.TabIndex = 123;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(724, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 120;
            this.label7.Text = "Search";
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.Location = new System.Drawing.Point(18, 34);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(311, 26);
            this.txtItemSearch.TabIndex = 119;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // dataGridCreditSalesRecord
            // 
            this.dataGridCreditSalesRecord.AllowUserToAddRows = false;
            this.dataGridCreditSalesRecord.AllowUserToDeleteRows = false;
            this.dataGridCreditSalesRecord.AllowUserToOrderColumns = true;
            this.dataGridCreditSalesRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCreditSalesRecord.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCreditSalesRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCreditSalesRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCreditSalesRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCreditSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCreditSalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstname,
            this.Lastname,
            this.Contact,
            this.Item,
            this.Qty,
            this.Cost,
            this.Discount,
            this.Amount,
            this.Date_Sold,
            this.Sales_Id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCreditSalesRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCreditSalesRecord.Location = new System.Drawing.Point(2, 67);
            this.dataGridCreditSalesRecord.Name = "dataGridCreditSalesRecord";
            this.dataGridCreditSalesRecord.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCreditSalesRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCreditSalesRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCreditSalesRecord.Size = new System.Drawing.Size(976, 433);
            this.dataGridCreditSalesRecord.TabIndex = 128;
            this.dataGridCreditSalesRecord.Click += new System.EventHandler(this.dataGridCreditSalesRecord_Click);
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Width = 122;
            // 
            // Lastname
            // 
            this.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 92;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Width = 123;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
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
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(103, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 29);
            this.btnDelete.TabIndex = 132;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(452, 517);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 18);
            this.lblTotal.TabIndex = 131;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // checkTotal
            // 
            this.checkTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotal.Location = new System.Drawing.Point(381, 515);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(64, 22);
            this.checkTotal.TabIndex = 130;
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
            this.btnPrintSaleRecord.Location = new System.Drawing.Point(18, 514);
            this.btnPrintSaleRecord.Name = "btnPrintSaleRecord";
            this.btnPrintSaleRecord.Size = new System.Drawing.Size(72, 29);
            this.btnPrintSaleRecord.TabIndex = 129;
            this.btnPrintSaleRecord.Text = "Print";
            this.btnPrintSaleRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSaleRecord.UseVisualStyleBackColor = false;
            this.btnPrintSaleRecord.Click += new System.EventHandler(this.btnPrintSaleRecord_Click);
            // 
            // Credit_Sales_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 555);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkTotal);
            this.Controls.Add(this.btnPrintSaleRecord);
            this.Controls.Add(this.dataGridCreditSalesRecord);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combItemName);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Credit_Sales_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Sales Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCreditSalesRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combItemName;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.DataGridView dataGridCreditSalesRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.Button btnPrintSaleRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Id;
        }
    }