namespace WindowsFormsApplication1
    {
    partial class AuthenticationRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationRequest));
            this.txtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPassword.Location = new System.Drawing.Point(143, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 26);
            this.txtPassword.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Enter Password";
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "Ok";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = ((System.Drawing.Image) (resources.GetObject("btnOk.Iconimage")));
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 90D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(143, 101);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btnOk.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(76, 29);
            this.btnOk.TabIndex = 40;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Textcolor = System.Drawing.Color.White;
            this.btnOk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image) (resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(249, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (139)))), ((int) (((byte) (87)))));
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (129)))), ((int) (((byte) (77)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // AuthenticationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Name = "AuthenticationRequest";
            this.Size = new System.Drawing.Size(349, 174);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPassword;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        }
    }
