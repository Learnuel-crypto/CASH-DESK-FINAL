namespace WindowsFormsApplication1
{
    partial class AllTallerPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTallerPaymentForm));
            this.dataGridTallerView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panhead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureTaller = new System.Windows.Forms.PictureBox();
            this.btnViewTaller = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtTallerNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioThird = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.radioFirst = new System.Windows.Forms.RadioButton();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrintPayRecords = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTallerView)).BeginInit();
            this.panhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTaller)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTallerView
            // 
            this.dataGridTallerView.AllowUserToAddRows = false;
            this.dataGridTallerView.AllowUserToDeleteRows = false;
            this.dataGridTallerView.AllowUserToOrderColumns = true;
            this.dataGridTallerView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTallerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTallerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTallerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Names,
            this.Class,
            this.Fee_Name,
            this.Amount,
            this.Terms,
            this.Fee_Type,
            this.Pay_Date});
            this.dataGridTallerView.Location = new System.Drawing.Point(8, 108);
            this.dataGridTallerView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridTallerView.Name = "dataGridTallerView";
            this.dataGridTallerView.ReadOnly = true;
            this.dataGridTallerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTallerView.Size = new System.Drawing.Size(677, 532);
            this.dataGridTallerView.TabIndex = 77;
            this.dataGridTallerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTallerView_CellContentClick);
            this.dataGridTallerView.Click += new System.EventHandler(this.dataGridTallerView_Click);
            this.dataGridTallerView.DoubleClick += new System.EventHandler(this.dataGridTallerView_DoubleClick);
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
            this.Names.ToolTipText = "Double Click to View Image";
            this.Names.Width = 127;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.ToolTipText = "Double Click to View Image";
            this.Class.Width = 71;
            // 
            // Fee_Name
            // 
            this.Fee_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fee_Name.HeaderText = "Fee Name";
            this.Fee_Name.Name = "Fee_Name";
            this.Fee_Name.ReadOnly = true;
            this.Fee_Name.ToolTipText = "Double Click to View Image";
            this.Fee_Name.Width = 102;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.ToolTipText = "Double Click to View Image";
            this.Amount.Width = 84;
            // 
            // Terms
            // 
            this.Terms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Terms.HeaderText = "Term";
            this.Terms.Name = "Terms";
            this.Terms.ReadOnly = true;
            this.Terms.ToolTipText = "Double Click to View Image";
            this.Terms.Width = 68;
            // 
            // Fee_Type
            // 
            this.Fee_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fee_Type.HeaderText = "Type";
            this.Fee_Type.Name = "Fee_Type";
            this.Fee_Type.ReadOnly = true;
            this.Fee_Type.ToolTipText = "Double Click to View Image";
            this.Fee_Type.Width = 65;
            // 
            // Pay_Date
            // 
            this.Pay_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pay_Date.HeaderText = "Date";
            this.Pay_Date.Name = "Pay_Date";
            this.Pay_Date.ReadOnly = true;
            this.Pay_Date.ToolTipText = "Double Click to View Image";
            this.Pay_Date.Width = 64;
            // 
            // panhead
            // 
            this.panhead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panhead.Controls.Add(this.btnclose);
            this.panhead.Controls.Add(this.label5);
            this.panhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panhead.Location = new System.Drawing.Point(0, 0);
            this.panhead.Name = "panhead";
            this.panhead.Size = new System.Drawing.Size(1071, 19);
            this.panhead.TabIndex = 78;
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
            this.btnclose.Location = new System.Drawing.Point(1045, 0);
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
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Teller Payments";
            // 
            // pictureTaller
            // 
            this.pictureTaller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTaller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureTaller.Location = new System.Drawing.Point(707, 156);
            this.pictureTaller.Name = "pictureTaller";
            this.pictureTaller.Size = new System.Drawing.Size(352, 186);
            this.pictureTaller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTaller.TabIndex = 79;
            this.pictureTaller.TabStop = false;
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
            this.btnViewTaller.Location = new System.Drawing.Point(957, 363);
            this.btnViewTaller.Name = "btnViewTaller";
            this.btnViewTaller.Size = new System.Drawing.Size(102, 29);
            this.btnViewTaller.TabIndex = 81;
            this.btnViewTaller.Text = "View Teller";
            this.btnViewTaller.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewTaller.UseVisualStyleBackColor = false;
            this.btnViewTaller.Click += new System.EventHandler(this.btnViewTaller_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panhead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtTallerNum
            // 
            this.txtTallerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTallerNum.Location = new System.Drawing.Point(839, 123);
            this.txtTallerNum.Name = "txtTallerNum";
            this.txtTallerNum.ReadOnly = true;
            this.txtTallerNum.Size = new System.Drawing.Size(220, 26);
            this.txtTallerNum.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Teller Number:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.radioAll);
            this.panel2.Controls.Add(this.radioThird);
            this.panel2.Controls.Add(this.radioSecond);
            this.panel2.Controls.Add(this.radioFirst);
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(4, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 75);
            this.panel2.TabIndex = 84;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.ForeColor = System.Drawing.Color.White;
            this.radioAll.Location = new System.Drawing.Point(276, 45);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(47, 24);
            this.radioAll.TabIndex = 93;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.Click += new System.EventHandler(this.radioAll_Click);
            // 
            // radioThird
            // 
            this.radioThird.AutoSize = true;
            this.radioThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThird.ForeColor = System.Drawing.Color.White;
            this.radioThird.Location = new System.Drawing.Point(182, 43);
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
            this.radioSecond.Location = new System.Drawing.Point(85, 43);
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
            this.radioFirst.Location = new System.Drawing.Point(13, 43);
            this.radioFirst.Name = "radioFirst";
            this.radioFirst.Size = new System.Drawing.Size(63, 24);
            this.radioFirst.TabIndex = 90;
            this.radioFirst.TabStop = true;
            this.radioFirst.Text = "First";
            this.radioFirst.UseVisualStyleBackColor = true;
            this.radioFirst.Click += new System.EventHandler(this.radioFirst_Click);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(474, 7);
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
            this.dateTimeFrom.Location = new System.Drawing.Point(306, 7);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 26);
            this.dateTimeFrom.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(442, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(252, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "From";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(70, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Search";
            // 
            // btnPrintPayRecords
            // 
            this.btnPrintPayRecords.BackColor = System.Drawing.Color.Blue;
            this.btnPrintPayRecords.FlatAppearance.BorderSize = 0;
            this.btnPrintPayRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintPayRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPayRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPayRecords.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintPayRecords.Location = new System.Drawing.Point(707, 363);
            this.btnPrintPayRecords.Name = "btnPrintPayRecords";
            this.btnPrintPayRecords.Size = new System.Drawing.Size(82, 29);
            this.btnPrintPayRecords.TabIndex = 85;
            this.btnPrintPayRecords.Text = "Print";
            this.btnPrintPayRecords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintPayRecords.UseVisualStyleBackColor = false;
            this.btnPrintPayRecords.Click += new System.EventHandler(this.btnPrintPayRecords_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 645);
            this.panel1.TabIndex = 86;
            // 
            // AllTallerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.btnPrintPayRecords);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTallerNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewTaller);
            this.Controls.Add(this.pictureTaller);
            this.Controls.Add(this.panhead);
            this.Controls.Add(this.dataGridTallerView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllTallerPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Teller Payment";
            this.Load += new System.EventHandler(this.AllTallerPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTallerView)).EndInit();
            this.panhead.ResumeLayout(false);
            this.panhead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTaller)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTallerView;
        private System.Windows.Forms.Panel panhead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureTaller;
        private System.Windows.Forms.Button btnViewTaller;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox txtTallerNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay_Date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioThird;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.RadioButton radioFirst;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrintPayRecords;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Panel panel1;
    }
}