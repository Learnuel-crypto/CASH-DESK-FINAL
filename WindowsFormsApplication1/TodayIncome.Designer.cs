namespace WindowsFormsApplication1
    {
    partial class TodayIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayIncome));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAtHand = new System.Windows.Forms.RadioButton();
            this.radioBank = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btnclose);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 19);
            this.panel3.TabIndex = 58;
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
            this.btnclose.Location = new System.Drawing.Point(291, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Today Income";
            // 
            // txtExpense
            // 
            this.txtExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpense.Location = new System.Drawing.Point(99, 108);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.ReadOnly = true;
            this.txtExpense.Size = new System.Drawing.Size(205, 26);
            this.txtExpense.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Expense";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(99, 61);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.ReadOnly = true;
            this.txtIncome.Size = new System.Drawing.Size(205, 26);
            this.txtIncome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Income";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(99, 155);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(205, 26);
            this.txtBalance.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Balance";
            // 
            // radioAtHand
            // 
            this.radioAtHand.AutoSize = true;
            this.radioAtHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAtHand.Location = new System.Drawing.Point(99, 199);
            this.radioAtHand.Name = "radioAtHand";
            this.radioAtHand.Size = new System.Drawing.Size(86, 24);
            this.radioAtHand.TabIndex = 2;
            this.radioAtHand.TabStop = true;
            this.radioAtHand.Text = "At Hand";
            this.radioAtHand.UseVisualStyleBackColor = true;
            // 
            // radioBank
            // 
            this.radioBank.AutoSize = true;
            this.radioBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBank.Location = new System.Drawing.Point(213, 201);
            this.radioBank.Name = "radioBank";
            this.radioBank.Size = new System.Drawing.Size(64, 24);
            this.radioBank.TabIndex = 3;
            this.radioBank.TabStop = true;
            this.radioBank.Text = "Bank";
            this.radioBank.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Cash:";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Black;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Snow;
            this.btnsave.Location = new System.Drawing.Point(227, 257);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(78, 29);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtExpense);
            this.panel1.Controls.Add(this.radioBank);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioAtHand);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 298);
            this.panel1.TabIndex = 112;
            // 
            // TodayIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 298);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TodayIncome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Today Income";
            this.Load += new System.EventHandler(this.TodayIncome_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAtHand;
        private System.Windows.Forms.RadioButton radioBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel1;
        }
    }