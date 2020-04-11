namespace WindowsFormsApplication1
    {
    partial class AdminLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogs));
            this.btnDeleteActivities = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dataGridActivity = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTodayActivity = new System.Windows.Forms.Button();
            this.panDrag = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivity)).BeginInit();
            this.panDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteActivities
            // 
            this.btnDeleteActivities.BackColor = System.Drawing.Color.Blue;
            this.btnDeleteActivities.FlatAppearance.BorderSize = 0;
            this.btnDeleteActivities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDeleteActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteActivities.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteActivities.Location = new System.Drawing.Point(281, 542);
            this.btnDeleteActivities.Name = "btnDeleteActivities";
            this.btnDeleteActivities.Size = new System.Drawing.Size(84, 29);
            this.btnDeleteActivities.TabIndex = 52;
            this.btnDeleteActivities.Text = "Delete";
            this.btnDeleteActivities.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteActivities.UseVisualStyleBackColor = false;
            this.btnDeleteActivities.Click += new System.EventHandler(this.btnDeleteActivities_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnDeleteActivities);
            this.panel3.Controls.Add(this.btnViewAll);
            this.panel3.Controls.Add(this.dataGridActivity);
            this.panel3.Controls.Add(this.btnTodayActivity);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 594);
            this.panel3.TabIndex = 55;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Blue;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Snow;
            this.btnExport.Location = new System.Drawing.Point(385, 542);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(84, 29);
            this.btnExport.TabIndex = 53;
            this.btnExport.Text = "PDF";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Blue;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.Snow;
            this.btnViewAll.Location = new System.Drawing.Point(75, 542);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(84, 29);
            this.btnViewAll.TabIndex = 51;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
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
            this.ID,
            this.UserName,
            this.Log,
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
            this.dataGridActivity.Location = new System.Drawing.Point(37, 5);
            this.dataGridActivity.MultiSelect = false;
            this.dataGridActivity.Name = "dataGridActivity";
            this.dataGridActivity.ReadOnly = true;
            this.dataGridActivity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridActivity.Size = new System.Drawing.Size(469, 515);
            this.dataGridActivity.StandardTab = true;
            this.dataGridActivity.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserName.FillWeight = 15F;
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.ToolTipText = "Activity Done successfully";
            this.UserName.Width = 114;
            // 
            // Log
            // 
            this.Log.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Log.HeaderText = "Logs";
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Width = 69;
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
            // btnTodayActivity
            // 
            this.btnTodayActivity.BackColor = System.Drawing.Color.Blue;
            this.btnTodayActivity.FlatAppearance.BorderSize = 0;
            this.btnTodayActivity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTodayActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodayActivity.ForeColor = System.Drawing.Color.Snow;
            this.btnTodayActivity.Location = new System.Drawing.Point(175, 542);
            this.btnTodayActivity.Name = "btnTodayActivity";
            this.btnTodayActivity.Size = new System.Drawing.Size(84, 29);
            this.btnTodayActivity.TabIndex = 2;
            this.btnTodayActivity.Text = "Today";
            this.btnTodayActivity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTodayActivity.UseVisualStyleBackColor = false;
            this.btnTodayActivity.Click += new System.EventHandler(this.btnTodayActivity_Click);
            // 
            // panDrag
            // 
            this.panDrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panDrag.Controls.Add(this.label5);
            this.panDrag.Controls.Add(this.btnclose);
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDrag.Location = new System.Drawing.Point(0, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(546, 22);
            this.panDrag.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Admin Log";
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
            this.btnclose.Location = new System.Drawing.Point(520, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 22);
            this.btnclose.TabIndex = 19;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AdminLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 616);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Logs";
            this.Load += new System.EventHandler(this.AdminLogs_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivity)).EndInit();
            this.panDrag.ResumeLayout(false);
            this.panDrag.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button btnDeleteActivities;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dataGridActivity;
        private System.Windows.Forms.Button btnTodayActivity;
        private System.Windows.Forms.Panel panDrag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        }
    }