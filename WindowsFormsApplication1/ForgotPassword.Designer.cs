namespace WindowsFormsApplication1
    {
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panHead = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.label55);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(329, 21);
            this.panHead.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(234, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 77;
            this.label3.Text = "Cash Desk";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label55.Location = new System.Drawing.Point(3, -3);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(131, 27);
            this.label55.TabIndex = 76;
            this.label55.Text = "Forgot Password";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(11, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(305, 26);
            this.txtUsername.TabIndex = 83;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(56, 120);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 29);
            this.btnBack.TabIndex = 85;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(207, 120);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 29);
            this.btnNext.TabIndex = 84;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Enter  Username or Password";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 180);
            this.panel1.TabIndex = 87;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 180);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.panHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        }
    }