namespace WindowsFormsApplication1
{
    partial class TallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TallerForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTallerNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnloadImage = new System.Windows.Forms.Button();
            this.pictureTaller = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTallerPath = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTaller)).BeginInit();
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
            this.panel3.Size = new System.Drawing.Size(873, 19);
            this.panel3.TabIndex = 57;
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
            this.btnclose.Location = new System.Drawing.Point(847, 0);
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
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Teller Details";
            // 
            // txtTallerNumber
            // 
            this.txtTallerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTallerNumber.Location = new System.Drawing.Point(137, 34);
            this.txtTallerNumber.Name = "txtTallerNumber";
            this.txtTallerNumber.Size = new System.Drawing.Size(168, 29);
            this.txtTallerNumber.TabIndex = 0;
            this.txtTallerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTallerNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Teller Number";
            // 
            // btnloadImage
            // 
            this.btnloadImage.BackColor = System.Drawing.Color.Black;
            this.btnloadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloadImage.FlatAppearance.BorderSize = 0;
            this.btnloadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnloadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnloadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadImage.ForeColor = System.Drawing.Color.Snow;
            this.btnloadImage.Location = new System.Drawing.Point(363, 29);
            this.btnloadImage.Name = "btnloadImage";
            this.btnloadImage.Size = new System.Drawing.Size(155, 34);
            this.btnloadImage.TabIndex = 1;
            this.btnloadImage.Text = "UpLoad Image";
            this.btnloadImage.UseVisualStyleBackColor = false;
            this.btnloadImage.Click += new System.EventHandler(this.btnloadImage_Click);
            // 
            // pictureTaller
            // 
            this.pictureTaller.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureTaller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureTaller.Location = new System.Drawing.Point(12, 70);
            this.pictureTaller.Name = "pictureTaller";
            this.pictureTaller.Size = new System.Drawing.Size(849, 366);
            this.pictureTaller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTaller.TabIndex = 63;
            this.pictureTaller.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Snow;
            this.btnOk.Location = new System.Drawing.Point(413, 442);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTallerPath
            // 
            this.lblTallerPath.AutoSize = true;
            this.lblTallerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallerPath.Location = new System.Drawing.Point(14, 442);
            this.lblTallerPath.Name = "lblTallerPath";
            this.lblTallerPath.Size = new System.Drawing.Size(107, 20);
            this.lblTallerPath.TabIndex = 65;
            this.lblTallerPath.Text = "Teller Number";
            this.lblTallerPath.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(299, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 29);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 483);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pictureTaller);
            this.Controls.Add(this.btnloadImage);
            this.Controls.Add(this.txtTallerNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTallerPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TallerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upload Taller";
            this.Load += new System.EventHandler(this.TallerForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTaller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTallerNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnloadImage;
        private System.Windows.Forms.PictureBox pictureTaller;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTallerPath;
        private System.Windows.Forms.Button btnExit;
    }
}