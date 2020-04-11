namespace WindowsFormsApplication1
{
    partial class DailyExpense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyExpense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsaveex = new System.Windows.Forms.Button();
            this.btnexportex = new System.Windows.Forms.Button();
            this.btnprintex = new System.Windows.Forms.Button();
            this.txttotalex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtamounts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 22);
            this.panel1.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1181, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 22);
            this.btnclose.TabIndex = 37;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Today Expense";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnsaveex);
            this.panel2.Controls.Add(this.btnexportex);
            this.panel2.Controls.Add(this.btnprintex);
            this.panel2.Controls.Add(this.txttotalex);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.metroGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 606);
            this.panel2.TabIndex = 1;
            // 
            // btnsaveex
            // 
            this.btnsaveex.BackColor = System.Drawing.Color.OliveDrab;
            this.btnsaveex.FlatAppearance.BorderSize = 0;
            this.btnsaveex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnsaveex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveex.ForeColor = System.Drawing.Color.Snow;
            this.btnsaveex.Location = new System.Drawing.Point(19, 246);
            this.btnsaveex.Name = "btnsaveex";
            this.btnsaveex.Size = new System.Drawing.Size(67, 29);
            this.btnsaveex.TabIndex = 44;
            this.btnsaveex.Text = "Save";
            this.btnsaveex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsaveex.UseVisualStyleBackColor = false;
            // 
            // btnexportex
            // 
            this.btnexportex.BackColor = System.Drawing.Color.OliveDrab;
            this.btnexportex.FlatAppearance.BorderSize = 0;
            this.btnexportex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnexportex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportex.ForeColor = System.Drawing.Color.Snow;
            this.btnexportex.Location = new System.Drawing.Point(19, 194);
            this.btnexportex.Name = "btnexportex";
            this.btnexportex.Size = new System.Drawing.Size(67, 29);
            this.btnexportex.TabIndex = 43;
            this.btnexportex.Text = "Export";
            this.btnexportex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportex.UseVisualStyleBackColor = false;
            // 
            // btnprintex
            // 
            this.btnprintex.BackColor = System.Drawing.Color.OliveDrab;
            this.btnprintex.FlatAppearance.BorderSize = 0;
            this.btnprintex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnprintex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintex.ForeColor = System.Drawing.Color.Snow;
            this.btnprintex.Location = new System.Drawing.Point(19, 144);
            this.btnprintex.Name = "btnprintex";
            this.btnprintex.Size = new System.Drawing.Size(67, 29);
            this.btnprintex.TabIndex = 42;
            this.btnprintex.Text = "Print";
            this.btnprintex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnprintex.UseVisualStyleBackColor = false;
            // 
            // txttotalex
            // 
            this.txttotalex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalex.Location = new System.Drawing.Point(19, 324);
            this.txttotalex.Name = "txttotalex";
            this.txttotalex.Size = new System.Drawing.Size(115, 27);
            this.txttotalex.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Total Expense";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.txtamounts);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.txtdescription);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(156, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 40);
            this.panel3.TabIndex = 1;
            // 
            // txtamounts
            // 
            this.txtamounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamounts.Location = new System.Drawing.Point(400, 7);
            this.txtamounts.Name = "txtamounts";
            this.txtamounts.Size = new System.Drawing.Size(115, 27);
            this.txtamounts.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Amount";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Snow;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(530, 1);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(54, 36);
            this.btnsearch.TabIndex = 36;
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(110, 7);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(207, 27);
            this.txtdescription.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Description";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(156, 81);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(621, 439);
            this.metroGrid1.TabIndex = 0;
            // 
            // DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DailyExpense";
            this.Size = new System.Drawing.Size(1207, 628);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.TextBox txttotalex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtamounts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsaveex;
        private System.Windows.Forms.Button btnexportex;
        private System.Windows.Forms.Button btnprintex;
        private System.Windows.Forms.Button btnclose;
    }
}
