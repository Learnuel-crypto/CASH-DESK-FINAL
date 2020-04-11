namespace WindowsFormsApplication1
{
    partial class SetSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetSessionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnset = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dateTimeEndYear = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartYear = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSetDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 22);
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
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Set Session";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(247, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Start Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "End Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(49, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Date";
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.Blue;
            this.btnset.FlatAppearance.BorderSize = 0;
            this.btnset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnset.ForeColor = System.Drawing.Color.Snow;
            this.btnset.Location = new System.Drawing.Point(171, 227);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(67, 29);
            this.btnset.TabIndex = 42;
            this.btnset.Text = "Set";
            this.btnset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dateTimeEndYear);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Controls.Add(this.dateTimeStartYear);
            this.metroPanel1.Controls.Add(this.dateTimeSetDate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(273, 268);
            this.metroPanel1.TabIndex = 43;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dateTimeEndYear
            // 
            this.dateTimeEndYear.CustomFormat = "yyy-mm-dd";
            this.dateTimeEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEndYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEndYear.Location = new System.Drawing.Point(126, 92);
            this.dateTimeEndYear.Name = "dateTimeEndYear";
            this.dateTimeEndYear.Size = new System.Drawing.Size(125, 26);
            this.dateTimeEndYear.TabIndex = 7;
            // 
            // dateTimeStartYear
            // 
            this.dateTimeStartYear.CustomFormat = "yyy-mm-dd";
            this.dateTimeStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStartYear.Location = new System.Drawing.Point(126, 44);
            this.dateTimeStartYear.Name = "dateTimeStartYear";
            this.dateTimeStartYear.Size = new System.Drawing.Size(125, 26);
            this.dateTimeStartYear.TabIndex = 6;
            // 
            // dateTimeSetDate
            // 
            this.dateTimeSetDate.CustomFormat = "yyy-mm-dd";
            this.dateTimeSetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSetDate.Location = new System.Drawing.Point(126, 144);
            this.dateTimeSetDate.Name = "dateTimeSetDate";
            this.dateTimeSetDate.Size = new System.Drawing.Size(125, 26);
            this.dateTimeSetDate.TabIndex = 5;
            // 
            // SetSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(273, 268);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetSessionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetSession";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnset;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DateTimePicker dateTimeEndYear;
        private System.Windows.Forms.DateTimePicker dateTimeStartYear;
        private System.Windows.Forms.DateTimePicker dateTimeSetDate;
    }
}