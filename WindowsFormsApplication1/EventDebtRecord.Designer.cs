namespace WindowsFormsApplication1
    {
    partial class EventDebtRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDebtRecord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAll = new System.Windows.Forms.Button();
            this.paneldrag = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnPrintEventDebtors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.lblNotice = new System.Windows.Forms.Label();
            this.dataGridEventPayment = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.inforDebt1 = new WindowsFormsApplication1.InforDebt();
            this.paneldrag.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventPayment)).BeginInit();
            this.SuspendLayout();
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
            this.btnAll.Location = new System.Drawing.Point(687, -3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(44, 46);
            this.btnAll.TabIndex = 89;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
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
            this.paneldrag.TabIndex = 72;
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
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Uncleared event payments";
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
            // btnPrintEventDebtors
            // 
            this.btnPrintEventDebtors.BackColor = System.Drawing.Color.Blue;
            this.btnPrintEventDebtors.FlatAppearance.BorderSize = 0;
            this.btnPrintEventDebtors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintEventDebtors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintEventDebtors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintEventDebtors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintEventDebtors.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintEventDebtors.Location = new System.Drawing.Point(261, 648);
            this.btnPrintEventDebtors.Name = "btnPrintEventDebtors";
            this.btnPrintEventDebtors.Size = new System.Drawing.Size(67, 29);
            this.btnPrintEventDebtors.TabIndex = 47;
            this.btnPrintEventDebtors.Text = "Print";
            this.btnPrintEventDebtors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintEventDebtors.UseVisualStyleBackColor = false;
            this.btnPrintEventDebtors.Click += new System.EventHandler(this.btnPrintEventDebtors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(355, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Search";
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(50, 7);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(130, 26);
            this.dateTimeDate.TabIndex = 85;
            this.dateTimeDate.ValueChanged += new System.EventHandler(this.dateTimeDate_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnAll);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dateTimeDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtsearch);
            this.panel4.Location = new System.Drawing.Point(13, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(724, 40);
            this.panel4.TabIndex = 88;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 26);
            this.dateTimePicker1.TabIndex = 93;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(185, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "From";
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
            this.btnSearch.Location = new System.Drawing.Point(637, -6);
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
            this.txtsearch.Location = new System.Drawing.Point(421, 7);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(207, 26);
            this.txtsearch.TabIndex = 37;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.inforDebt1);
            this.panel1.Controls.Add(this.btnInstruction);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblNotice);
            this.panel1.Controls.Add(this.dataGridEventPayment);
            this.panel1.Controls.Add(this.btnpdf);
            this.panel1.Controls.Add(this.btnPrintEventDebtors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 690);
            this.panel1.TabIndex = 73;
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
            this.btnInstruction.Location = new System.Drawing.Point(700, 628);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(99, 23);
            this.btnInstruction.TabIndex = 99;
            this.btnInstruction.Text = "How to search";
            this.btnInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInstruction.UseVisualStyleBackColor = false;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.BackColor = System.Drawing.Color.Yellow;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNotice.Location = new System.Drawing.Point(611, 653);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(83, 20);
            this.lblNotice.TabIndex = 87;
            this.lblNotice.Text = "Fee Name";
            this.lblNotice.Visible = false;
            // 
            // dataGridEventPayment
            // 
            this.dataGridEventPayment.AllowUserToAddRows = false;
            this.dataGridEventPayment.AllowUserToDeleteRows = false;
            this.dataGridEventPayment.AllowUserToOrderColumns = true;
            this.dataGridEventPayment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEventPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEventPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEventPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridEventPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEventPayment.Location = new System.Drawing.Point(13, 89);
            this.dataGridEventPayment.Name = "dataGridEventPayment";
            this.dataGridEventPayment.ReadOnly = true;
            this.dataGridEventPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEventPayment.Size = new System.Drawing.Size(793, 533);
            this.dataGridEventPayment.TabIndex = 66;
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
            this.Sex.Width = 61;
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
            this.Paid_Amount.Width = 90;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 92;
            // 
            // Term
            // 
            this.Term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Term.HeaderText = "Term";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            this.Term.Width = 70;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 81;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 7;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 69;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneldrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // inforDebt1
            // 
            this.inforDebt1.BackColor = System.Drawing.Color.White;
            this.inforDebt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inforDebt1.Location = new System.Drawing.Point(441, 435);
            this.inforDebt1.Name = "inforDebt1";
            this.inforDebt1.Size = new System.Drawing.Size(365, 187);
            this.inforDebt1.TabIndex = 100;
            this.inforDebt1.Visible = false;
            // 
            // EventDebtRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 690);
            this.Controls.Add(this.paneldrag);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventDebtRecord";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Debt Record";
            this.Load += new System.EventHandler(this.EventDebtRecord_Load);
            this.paneldrag.ResumeLayout(false);
            this.paneldrag.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventPayment)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel paneldrag;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnPrintEventDebtors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.DataGridView dataGridEventPayment;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private InforDebt inforDebt1;
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