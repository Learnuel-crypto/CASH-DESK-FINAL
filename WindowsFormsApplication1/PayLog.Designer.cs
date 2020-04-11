namespace WindowsFormsApplication1
{
    partial class PayLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayLog));
            this.paneldrag = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtdates = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comsession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearc = new System.Windows.Forms.Button();
            this.txtfeename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.paneldrag.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldrag
            // 
            this.paneldrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneldrag.Controls.Add(this.button4);
            this.paneldrag.Controls.Add(this.label5);
            this.paneldrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldrag.Location = new System.Drawing.Point(0, 0);
            this.paneldrag.Name = "paneldrag";
            this.paneldrag.Size = new System.Drawing.Size(1367, 22);
            this.paneldrag.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1341, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 37;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "All Payments";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.txtdates);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.comsession);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtamount);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnsearc);
            this.panel5.Controls.Add(this.txtfeename);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1085, 40);
            this.panel5.TabIndex = 4;
            // 
            // txtdates
            // 
            this.txtdates.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdates.Location = new System.Drawing.Point(878, 7);
            this.txtdates.Name = "txtdates";
            this.txtdates.Size = new System.Drawing.Size(115, 27);
            this.txtdates.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(827, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date";
            // 
            // comsession
            // 
            this.comsession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comsession.FormattingEnabled = true;
            this.comsession.Location = new System.Drawing.Point(613, 7);
            this.comsession.Name = "comsession";
            this.comsession.Size = new System.Drawing.Size(189, 29);
            this.comsession.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Session";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(412, 7);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(115, 27);
            this.txtamount.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Amount";
            // 
            // btnsearc
            // 
            this.btnsearc.BackColor = System.Drawing.Color.Transparent;
            this.btnsearc.FlatAppearance.BorderSize = 0;
            this.btnsearc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnsearc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnsearc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearc.ForeColor = System.Drawing.Color.Snow;
            this.btnsearc.Image = ((System.Drawing.Image)(resources.GetObject("btnsearc.Image")));
            this.btnsearc.Location = new System.Drawing.Point(1026, 0);
            this.btnsearc.Name = "btnsearc";
            this.btnsearc.Size = new System.Drawing.Size(56, 40);
            this.btnsearc.TabIndex = 36;
            this.btnsearc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsearc.UseVisualStyleBackColor = false;
            // 
            // txtfeename
            // 
            this.txtfeename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeename.Location = new System.Drawing.Point(95, 7);
            this.txtfeename.Name = "txtfeename";
            this.txtfeename.Size = new System.Drawing.Size(207, 27);
            this.txtfeename.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fee Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1356, 501);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.OliveDrab;
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnexport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.Color.Snow;
            this.btnexport.Location = new System.Drawing.Point(818, 602);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(105, 29);
            this.btnexport.TabIndex = 35;
            this.btnexport.Text = "Export";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.OliveDrab;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Snow;
            this.btnprint.Location = new System.Drawing.Point(675, 602);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(105, 29);
            this.btnprint.TabIndex = 33;
            this.btnprint.Text = "Print";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // PayLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.paneldrag);
            this.Name = "PayLog";
            this.Size = new System.Drawing.Size(1367, 664);
            this.paneldrag.ResumeLayout(false);
            this.paneldrag.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldrag;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearc;
        private System.Windows.Forms.TextBox txtfeename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comsession;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
    }
}
