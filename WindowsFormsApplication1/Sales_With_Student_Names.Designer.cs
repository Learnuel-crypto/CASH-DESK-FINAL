namespace WindowsFormsApplication1
    {
    partial class Sales_With_Student_Names
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_With_Student_Names));
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrintSaleRecord = new System.Windows.Forms.Button();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.dataGridNamesSalesRecord = new System.Windows.Forms.DataGridView();
            this.Sales_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.combItemName = new System.Windows.Forms.ComboBox();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNamesSalesRecord)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(107, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 29);
            this.btnDelete.TabIndex = 147;
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
            this.lblTotal.Location = new System.Drawing.Point(456, 519);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 18);
            this.lblTotal.TabIndex = 146;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
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
            this.btnPrintSaleRecord.Location = new System.Drawing.Point(22, 516);
            this.btnPrintSaleRecord.Name = "btnPrintSaleRecord";
            this.btnPrintSaleRecord.Size = new System.Drawing.Size(72, 29);
            this.btnPrintSaleRecord.TabIndex = 144;
            this.btnPrintSaleRecord.Text = "Print";
            this.btnPrintSaleRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSaleRecord.UseVisualStyleBackColor = false;
            this.btnPrintSaleRecord.Click += new System.EventHandler(this.btnPrintSaleRecord_Click);
            // 
            // checkTotal
            // 
            this.checkTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkTotal.AutoSize = true;
            this.checkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotal.Location = new System.Drawing.Point(385, 517);
            this.checkTotal.Name = "checkTotal";
            this.checkTotal.Size = new System.Drawing.Size(64, 22);
            this.checkTotal.TabIndex = 145;
            this.checkTotal.Text = "Total ";
            this.checkTotal.UseVisualStyleBackColor = true;
            this.checkTotal.Click += new System.EventHandler(this.checkTotal_Click);
            // 
            // dataGridNamesSalesRecord
            // 
            this.dataGridNamesSalesRecord.AllowUserToAddRows = false;
            this.dataGridNamesSalesRecord.AllowUserToDeleteRows = false;
            this.dataGridNamesSalesRecord.AllowUserToOrderColumns = true;
            this.dataGridNamesSalesRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNamesSalesRecord.BackgroundColor = System.Drawing.Color.White;
            this.dataGridNamesSalesRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridNamesSalesRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNamesSalesRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNamesSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNamesSalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sales_Id,
            this.Firstname,
            this.Lastname,
            this.Gender,
            this.Item,
            this.Qty,
            this.Cost,
            this.Discount,
            this.Amount,
            this.Date_Sold});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNamesSalesRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridNamesSalesRecord.Location = new System.Drawing.Point(4, 69);
            this.dataGridNamesSalesRecord.Name = "dataGridNamesSalesRecord";
            this.dataGridNamesSalesRecord.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNamesSalesRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridNamesSalesRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNamesSalesRecord.Size = new System.Drawing.Size(919, 433);
            this.dataGridNamesSalesRecord.TabIndex = 143;
            this.dataGridNamesSalesRecord.Click += new System.EventHandler(this.dataGridNamesSalesRecord_Click);
            // 
            // Sales_Id
            // 
            this.Sales_Id.HeaderText = "Sales_Id";
            this.Sales_Id.Name = "Sales_Id";
            this.Sales_Id.ReadOnly = true;
            this.Sales_Id.Visible = false;
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
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 92;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 78;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 56;
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
            this.Discount.Width = 105;
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
            this.Date_Sold.HeaderText = "Sold_Date";
            this.Date_Sold.Name = "Date_Sold";
            this.Date_Sold.ReadOnly = true;
            this.Date_Sold.Width = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(338, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 142;
            this.label1.Text = "Select Item";
            // 
            // combItemName
            // 
            this.combItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combItemName.FormattingEnabled = true;
            this.combItemName.Location = new System.Drawing.Point(339, 34);
            this.combItemName.Name = "combItemName";
            this.combItemName.Size = new System.Drawing.Size(342, 28);
            this.combItemName.TabIndex = 141;
            this.combItemName.SelectedIndexChanged += new System.EventHandler(this.combItemName_SelectedIndexChanged);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(760, 10);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 140;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(706, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "From";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(760, 40);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 26);
            this.dateTimeTo.TabIndex = 138;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(728, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 137;
            this.label2.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 135;
            this.label7.Text = "Search";
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.Location = new System.Drawing.Point(22, 36);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(311, 26);
            this.txtItemSearch.TabIndex = 134;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
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
            this.btnRefresh.Location = new System.Drawing.Point(574, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 26);
            this.btnRefresh.TabIndex = 136;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Sales_With_Student_Names
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 555);
            this.Controls.Add(this.combItemName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPrintSaleRecord);
            this.Controls.Add(this.checkTotal);
            this.Controls.Add(this.dataGridNamesSalesRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.btnRefresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales_With_Student_Names";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales With Student Names";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNamesSalesRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrintSaleRecord;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.DataGridView dataGridNamesSalesRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combItemName;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sold;
        }
    }