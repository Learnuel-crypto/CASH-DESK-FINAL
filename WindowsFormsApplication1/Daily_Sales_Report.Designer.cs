namespace WindowsFormsApplication1
    {
    partial class Daily_Sales_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_Sales_Report));
            this.dataGridDailyReport = new System.Windows.Forms.DataGridView();
            this.Report_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names_of_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combItemName = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotal = new System.Windows.Forms.CheckBox();
            this.btnPrintSaleRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDailyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDailyReport
            // 
            this.dataGridDailyReport.AllowUserToAddRows = false;
            this.dataGridDailyReport.AllowUserToDeleteRows = false;
            this.dataGridDailyReport.AllowUserToOrderColumns = true;
            this.dataGridDailyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDailyReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDailyReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDailyReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDailyReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDailyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Report_Id,
            this.Names_of_Items,
            this.Qty_Sold,
            this.Amount,
            this.Date_Sold,
            this.Report_Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDailyReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDailyReport.Location = new System.Drawing.Point(12, 76);
            this.dataGridDailyReport.Name = "dataGridDailyReport";
            this.dataGridDailyReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDailyReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDailyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDailyReport.Size = new System.Drawing.Size(763, 471);
            this.dataGridDailyReport.TabIndex = 115;
            this.dataGridDailyReport.Click += new System.EventHandler(this.dataGridDailyReport_Click);
            // 
            // Report_Id
            // 
            this.Report_Id.HeaderText = "Report_Id";
            this.Report_Id.Name = "Report_Id";
            this.Report_Id.ReadOnly = true;
            this.Report_Id.Visible = false;
            // 
            // Names_of_Items
            // 
            this.Names_of_Items.HeaderText = "Items";
            this.Names_of_Items.Name = "Names_of_Items";
            this.Names_of_Items.ReadOnly = true;
            this.Names_of_Items.Width = 122;
            // 
            // Qty_Sold
            // 
            this.Qty_Sold.HeaderText = "Qty Sold";
            this.Qty_Sold.Name = "Qty_Sold";
            this.Qty_Sold.ReadOnly = true;
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
            this.Date_Sold.HeaderText = "Date_Sold";
            this.Date_Sold.Name = "Date_Sold";
            this.Date_Sold.ReadOnly = true;
            this.Date_Sold.Width = 97;
            // 
            // Report_Date
            // 
            this.Report_Date.HeaderText = "Report_Date";
            this.Report_Date.Name = "Report_Date";
            this.Report_Date.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(8, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 117;
            this.label7.Text = "Search";
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.Location = new System.Drawing.Point(12, 43);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(236, 26);
            this.txtItemSearch.TabIndex = 116;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(648, 14);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 121;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(594, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "From";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(648, 44);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 26);
            this.dateTimeTo.TabIndex = 119;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(616, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "To";
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
            this.btnRefresh.Location = new System.Drawing.Point(497, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 26);
            this.btnRefresh.TabIndex = 122;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Select Item";
            // 
            // combItemName
            // 
            this.combItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combItemName.FormattingEnabled = true;
            this.combItemName.Location = new System.Drawing.Point(262, 41);
            this.combItemName.Name = "combItemName";
            this.combItemName.Size = new System.Drawing.Size(318, 28);
            this.combItemName.TabIndex = 123;
            this.combItemName.SelectedIndexChanged += new System.EventHandler(this.combItemName_SelectedIndexChanged);
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
            this.btnDelete.Location = new System.Drawing.Point(108, 561);
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
            this.lblTotal.Location = new System.Drawing.Point(307, 568);
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
            this.checkTotal.Location = new System.Drawing.Point(236, 566);
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
            this.btnPrintSaleRecord.Location = new System.Drawing.Point(12, 561);
            this.btnPrintSaleRecord.Name = "btnPrintSaleRecord";
            this.btnPrintSaleRecord.Size = new System.Drawing.Size(72, 29);
            this.btnPrintSaleRecord.TabIndex = 129;
            this.btnPrintSaleRecord.Text = "Print";
            this.btnPrintSaleRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSaleRecord.UseVisualStyleBackColor = false;
            this.btnPrintSaleRecord.Click += new System.EventHandler(this.btnPrintSaleRecord_Click);
            // 
            // Daily_Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 602);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkTotal);
            this.Controls.Add(this.btnPrintSaleRecord);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combItemName);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.dataGridDailyReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Daily_Sales_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDailyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridDailyReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combItemName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotal;
        private System.Windows.Forms.Button btnPrintSaleRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names_of_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_Date;
        }
    }