namespace WindowsFormsApplication1
    {
    partial class ActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridActivity = new System.Windows.Forms.DataGridView();
            this.Act_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnTodayActivity = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteActivities = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 22);
            this.panel1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Activities";
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
            this.btnclose.Location = new System.Drawing.Point(608, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 22);
            this.btnclose.TabIndex = 19;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridActivity
            // 
            this.dataGridActivity.AllowUserToAddRows = false;
            this.dataGridActivity.AllowUserToDeleteRows = false;
            this.dataGridActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridActivity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridActivity.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Act_Id,
            this.Description,
            this.Time,
            this.Date});
            this.dataGridActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridActivity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridActivity.Location = new System.Drawing.Point(11, 86);
            this.dataGridActivity.MultiSelect = false;
            this.dataGridActivity.Name = "dataGridActivity";
            this.dataGridActivity.ReadOnly = true;
            this.dataGridActivity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivity.Size = new System.Drawing.Size(610, 464);
            this.dataGridActivity.StandardTab = true;
            this.dataGridActivity.TabIndex = 1;
            // 
            // Act_Id
            // 
            this.Act_Id.HeaderText = "ID";
            this.Act_Id.Name = "Act_Id";
            this.Act_Id.ReadOnly = true;
            this.Act_Id.Visible = false;
            // 
            // Description
            // 
            this.Description.FillWeight = 15F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ToolTipText = "Activity Done successfully";
            // 
            // Time
            // 
            this.Time.FillWeight = 6F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 7F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(38, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 40);
            this.panel2.TabIndex = 50;
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
            this.btnSearch.Location = new System.Drawing.Point(346, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 39);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(90, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Blue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(279, 568);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 29);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnTodayActivity
            // 
            this.btnTodayActivity.BackColor = System.Drawing.Color.Blue;
            this.btnTodayActivity.FlatAppearance.BorderSize = 0;
            this.btnTodayActivity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTodayActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodayActivity.ForeColor = System.Drawing.Color.Snow;
            this.btnTodayActivity.Location = new System.Drawing.Point(179, 568);
            this.btnTodayActivity.Name = "btnTodayActivity";
            this.btnTodayActivity.Size = new System.Drawing.Size(84, 29);
            this.btnTodayActivity.TabIndex = 2;
            this.btnTodayActivity.Text = "Today";
            this.btnTodayActivity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTodayActivity.UseVisualStyleBackColor = false;
            this.btnTodayActivity.Click += new System.EventHandler(this.btnTodayActivity_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dateTimeFrom);
            this.panel3.Controls.Add(this.btnDeleteActivities);
            this.panel3.Controls.Add(this.btnViewAll);
            this.panel3.Controls.Add(this.dataGridActivity);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnTodayActivity);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 616);
            this.panel3.TabIndex = 53;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(469, 48);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(121, 26);
            this.dateTimeFrom.TabIndex = 53;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // btnDeleteActivities
            // 
            this.btnDeleteActivities.BackColor = System.Drawing.Color.Blue;
            this.btnDeleteActivities.FlatAppearance.BorderSize = 0;
            this.btnDeleteActivities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDeleteActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteActivities.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteActivities.Location = new System.Drawing.Point(379, 568);
            this.btnDeleteActivities.Name = "btnDeleteActivities";
            this.btnDeleteActivities.Size = new System.Drawing.Size(84, 29);
            this.btnDeleteActivities.TabIndex = 52;
            this.btnDeleteActivities.Text = "Delete";
            this.btnDeleteActivities.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteActivities.UseVisualStyleBackColor = false;
            this.btnDeleteActivities.Click += new System.EventHandler(this.btnDeleteActivities_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Blue;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.Snow;
            this.btnViewAll.Location = new System.Drawing.Point(79, 568);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(84, 29);
            this.btnViewAll.TabIndex = 51;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActivityForm";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridActivity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnTodayActivity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnDeleteActivities;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        }
    }