namespace WindowsFormsApplication1
    {
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panHead = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(172, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Password";
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.label55);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(371, 21);
            this.panHead.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(273, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 77;
            this.label3.Text = "Cash Desk";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label55.Location = new System.Drawing.Point(3, -3);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(75, 27);
            this.label55.TabIndex = 76;
            this.label55.Text = "Admin";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnResetPass);
            this.panel1.Controls.Add(this.btnCreateAdmin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 230);
            this.panel1.TabIndex = 82;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(167, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(167, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnResetPass
            // 
            this.btnResetPass.BackColor = System.Drawing.Color.White;
            this.btnResetPass.FlatAppearance.BorderSize = 0;
            this.btnResetPass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnResetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.ForeColor = System.Drawing.Color.Black;
            this.btnResetPass.Location = new System.Drawing.Point(12, 191);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(135, 31);
            this.btnResetPass.TabIndex = 5;
            this.btnResetPass.Text = "Forget Password ?";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.BackColor = System.Drawing.Color.White;
            this.btnCreateAdmin.FlatAppearance.BorderSize = 0;
            this.btnCreateAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCreateAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCreateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAdmin.Location = new System.Drawing.Point(292, 191);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(66, 32);
            this.btnCreateAdmin.TabIndex = 4;
            this.btnCreateAdmin.Text = "Create";
            this.btnCreateAdmin.UseVisualStyleBackColor = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(284, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(167, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnImportDb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 230);
            this.panel2.TabIndex = 47;
            // 
            // btnImportDb
            // 
            this.btnImportDb.BackColor = System.Drawing.Color.White;
            this.btnImportDb.FlatAppearance.BorderSize = 0;
            this.btnImportDb.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnImportDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnImportDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportDb.ForeColor = System.Drawing.Color.Black;
            this.btnImportDb.Image = ((System.Drawing.Image)(resources.GetObject("btnImportDb.Image")));
            this.btnImportDb.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnImportDb.Location = new System.Drawing.Point(170, 190);
            this.btnImportDb.Name = "btnImportDb";
            this.btnImportDb.Size = new System.Drawing.Size(99, 32);
            this.btnImportDb.TabIndex = 7;
            this.btnImportDb.Text = "   Import";
            this.btnImportDb.UseVisualStyleBackColor = false;
            this.btnImportDb.Click += new System.EventHandler(this.btnImportDb_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 230);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label55;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImportDb;
        }
    }