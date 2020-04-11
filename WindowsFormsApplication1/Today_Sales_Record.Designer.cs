namespace WindowsFormsApplication1
    {
    partial class Today_Sales_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Today_Sales_Record));
            this.dataGridTodaySalesRecord = new System.Windows.Forms.DataGridView();
            this.Names_of_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combItemName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.btnPrintSaleRecord = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotalAmount = new System.Windows.Forms.CheckBox();
            this.btnHowToReport = new System.Windows.Forms.Button();
            this.how_to_Report_Daily_Sales1 = new WindowsFormsApplication1.How_to_Report_Daily_Sales();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTodaySalesRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTodaySalesRecord
            // 
            this.dataGridTodaySalesRecord.AllowUserToAddRows = false;
            this.dataGridTodaySalesRecord.AllowUserToDeleteRows = false;
            this.dataGridTodaySalesRecord.AllowUserToOrderColumns = true;
            this.dataGridTodaySalesRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTodaySalesRecord.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTodaySalesRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTodaySalesRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTodaySalesRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTodaySalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTodaySalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names_of_Items,
            this.Qty,
            this.Selling_Price,
            this.Qty_Sold,
            this.Cost,
            this.Discount,
            this.Amount,
            this.Date_Sold,
            this.Sales_Id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTodaySalesRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTodaySalesRecord.Location = new System.Drawing.Point(8, 57);
            this.dataGridTodaySalesRecord.Name = "dataGridTodaySalesRecord";
            this.dataGridTodaySalesRecord.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTodaySalesRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTodaySalesRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTodaySalesRecord.Size = new System.Drawing.Size(871, 433);
            this.dataGridTodaySalesRecord.TabIndex = 116;
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
            this.Qty.Width = 56;
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
            this.Date_Sold.Width = 64;
            // 
            // Sales_Id
            // 
            this.Sales_Id.HeaderText = "Sales_Id";
            this.Sales_Id.Name = "Sales_Id";
            this.Sales_Id.ReadOnly = true;
            this.Sales_Id.Visible = false;
            // 
            // combItemName
            // 
            this.combItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combItemName.FormattingEnabled = true;
            this.combItemName.Location = new System.Drawing.Point(113, 22);
            this.combItemName.Name = "combItemName";
            this.combItemName.Size = new System.Drawing.Size(381, 28);
            this.combItemName.TabIndex = 115;
            this.combItemName.SelectedIndexChanged += new System.EventHandler(this.combItemName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Select Item";
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
            this.btnReportSales.Location = new System.Drawing.Point(104, 503);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(82, 29);
            this.btnReportSales.TabIndex = 119;
            this.btnReportSales.Text = "Report";
            this.btnReportSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportSales.UseVisualStyleBackColor = false;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
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
            this.btnPrintSaleRecord.Location = new System.Drawing.Point(14, 502);
            this.btnPrintSaleRecord.Name = "btnPrintSaleRecord";
            this.btnPrintSaleRecord.Size = new System.Drawing.Size(72, 29);
            this.btnPrintSaleRecord.TabIndex = 118;
            this.btnPrintSaleRecord.Text = "Print";
            this.btnPrintSaleRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSaleRecord.UseVisualStyleBackColor = false;
            this.btnPrintSaleRecord.Click += new System.EventHandler(this.btnPrintSaleRecord_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(203, 503);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 29);
            this.btnRefresh.TabIndex = 120;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(440, 509);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 18);
            this.lblTotal.TabIndex = 124;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // checkTotalAmount
            // 
            this.checkTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkTotalAmount.AutoSize = true;
            this.checkTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotalAmount.Location = new System.Drawing.Point(349, 506);
            this.checkTotalAmount.Name = "checkTotalAmount";
            this.checkTotalAmount.Size = new System.Drawing.Size(60, 22);
            this.checkTotalAmount.TabIndex = 123;
            this.checkTotalAmount.Text = "Total";
            this.checkTotalAmount.UseVisualStyleBackColor = true;
            this.checkTotalAmount.Click += new System.EventHandler(this.checkTotalAmount_Click);
            // 
            // btnHowToReport
            // 
            this.btnHowToReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHowToReport.AutoSize = true;
            this.btnHowToReport.BackColor = System.Drawing.Color.White;
            this.btnHowToReport.FlatAppearance.BorderSize = 0;
            this.btnHowToReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnHowToReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnHowToReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToReport.ForeColor = System.Drawing.Color.Blue;
            this.btnHowToReport.Location = new System.Drawing.Point(776, 23);
            this.btnHowToReport.Name = "btnHowToReport";
            this.btnHowToReport.Size = new System.Drawing.Size(103, 27);
            this.btnHowToReport.TabIndex = 125;
            this.btnHowToReport.Text = "How to Report";
            this.btnHowToReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHowToReport.UseVisualStyleBackColor = false;
            this.btnHowToReport.Click += new System.EventHandler(this.btnHowToReport_Click);
            // 
            // how_to_Report_Daily_Sales1
            // 
            this.how_to_Report_Daily_Sales1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.how_to_Report_Daily_Sales1.BackColor = System.Drawing.Color.White;
            this.how_to_Report_Daily_Sales1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.how_to_Report_Daily_Sales1.Location = new System.Drawing.Point(568, 54);
            this.how_to_Report_Daily_Sales1.Name = "how_to_Report_Daily_Sales1";
            this.how_to_Report_Daily_Sales1.Size = new System.Drawing.Size(311, 144);
            this.how_to_Report_Daily_Sales1.TabIndex = 126;
            this.how_to_Report_Daily_Sales1.Visible = false;
            // 
            // Today_Sales_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 542);
            this.Controls.Add(this.how_to_Report_Daily_Sales1);
            this.Controls.Add(this.btnHowToReport);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkTotalAmount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReportSales);
            this.Controls.Add(this.btnPrintSaleRecord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridTodaySalesRecord);
            this.Controls.Add(this.combItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Today_Sales_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Today Sales Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTodaySalesRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridTodaySalesRecord;
        private System.Windows.Forms.ComboBox combItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReportSales;
        private System.Windows.Forms.Button btnPrintSaleRecord;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names_of_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Id;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotalAmount;
        private System.Windows.Forms.Button btnHowToReport;
        private How_to_Report_Daily_Sales how_to_Report_Daily_Sales1;
        }
    }