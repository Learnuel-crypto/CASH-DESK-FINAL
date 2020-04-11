namespace WindowsFormsApplication1
    {
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panHead = new System.Windows.Forms.Panel();
            this.label55 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewPass = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtConpass = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panHead.Controls.Add(this.label55);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(279, 21);
            this.panHead.TabIndex = 82;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label55.Location = new System.Drawing.Point(3, -2);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(149, 27);
            this.label55.TabIndex = 76;
            this.label55.Text = "Create Admin";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Username";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.White;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.Black;
            this.btnAdminLogin.Location = new System.Drawing.Point(164, 259);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(65, 25);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(47, 212);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(65, 29);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(164, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewPass);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtConpass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnAdminLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 297);
            this.panel1.TabIndex = 90;
            // 
            // btnViewPass
            // 
            this.btnViewPass.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPass.FlatAppearance.BorderSize = 0;
            this.btnViewPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPass.ForeColor = System.Drawing.Color.Snow;
            this.btnViewPass.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPass.Image")));
            this.btnViewPass.Location = new System.Drawing.Point(235, 112);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(31, 29);
            this.btnViewPass.TabIndex = 93;
            this.btnViewPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewPass.UseVisualStyleBackColor = false;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(47, 61);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(182, 26);
            this.txtusername.TabIndex = 0;
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusername_KeyDown);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(47, 114);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(182, 26);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtConpass
            // 
            this.txtConpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConpass.Location = new System.Drawing.Point(47, 167);
            this.txtConpass.Name = "txtConpass";
            this.txtConpass.Size = new System.Drawing.Size(182, 26);
            this.txtConpass.TabIndex = 2;
            this.txtConpass.TextChanged += new System.EventHandler(this.txtConpass_TextChanged);
            this.txtConpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConpass_KeyDown);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 297);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Admin";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtConpass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnViewPass;
    }
    }