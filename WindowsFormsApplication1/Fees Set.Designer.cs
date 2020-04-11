namespace WindowsFormsApplication1
    {
    partial class Fees_Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees_Set));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewFees = new System.Windows.Forms.DataGridView();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Set_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnpdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFees)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 22);
            this.panel1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fees Set";
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
            this.btnClose.Location = new System.Drawing.Point(578, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 22);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewFees
            // 
            this.dataGridViewFees.AllowUserToAddRows = false;
            this.dataGridViewFees.AllowUserToDeleteRows = false;
            this.dataGridViewFees.AllowUserToOrderColumns = true;
            this.dataGridViewFees.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section,
            this.Names,
            this.Paid_Amount,
            this.Instal,
            this.Set_Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFees.Location = new System.Drawing.Point(17, 36);
            this.dataGridViewFees.Name = "dataGridViewFees";
            this.dataGridViewFees.ReadOnly = true;
            this.dataGridViewFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFees.Size = new System.Drawing.Size(568, 541);
            this.dataGridViewFees.TabIndex = 67;
            // 
            // Section
            // 
            this.Section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 88;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Names.HeaderText = "Fee Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 108;
            // 
            // Paid_Amount
            // 
            this.Paid_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Paid_Amount.HeaderText = "Amount";
            this.Paid_Amount.Name = "Paid_Amount";
            this.Paid_Amount.ReadOnly = true;
            this.Paid_Amount.Width = 90;
            // 
            // Instal
            // 
            this.Instal.HeaderText = "Instalments";
            this.Instal.Name = "Instal";
            this.Instal.ReadOnly = true;
            // 
            // Set_Date
            // 
            this.Set_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Set_Date.HeaderText = "Date Set";
            this.Set_Date.Name = "Set_Date";
            this.Set_Date.ReadOnly = true;
            this.Set_Date.Width = 98;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnpdf);
            this.panel2.Controls.Add(this.dataGridViewFees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 621);
            this.panel2.TabIndex = 68;
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
            this.btnpdf.Location = new System.Drawing.Point(488, 583);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(103, 29);
            this.btnpdf.TabIndex = 68;
            this.btnpdf.Text = "Export PDF";
            this.btnpdf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpdf.UseVisualStyleBackColor = false;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // Fees_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fees_Set";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Fees Set";
            this.Load += new System.EventHandler(this.Fees_Set_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFees)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewFees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Set_Date;
        }
    }