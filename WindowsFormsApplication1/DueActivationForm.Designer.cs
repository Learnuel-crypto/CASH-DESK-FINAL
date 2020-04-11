namespace WindowsFormsApplication1
{
    partial class DueActivationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueActivationForm));
            this.panHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActivation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnAboutus = new System.Windows.Forms.Button();
            this.panHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panHead.Controls.Add(this.btnClose);
            this.panHead.Controls.Add(this.label55);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(417, 21);
            this.panHead.TabIndex = 91;
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
            this.btnClose.Location = new System.Drawing.Point(391, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 21);
            this.btnClose.TabIndex = 77;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label55.Location = new System.Drawing.Point(3, -3);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(208, 27);
            this.label55.TabIndex = 76;
            this.label55.Text = "Activate Product ";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Activation Key";
            // 
            // txtActivation
            // 
            this.txtActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivation.Location = new System.Drawing.Point(113, 87);
            this.txtActivation.Name = "txtActivation";
            this.txtActivation.Size = new System.Drawing.Size(291, 26);
            this.txtActivation.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Product ID";
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(113, 45);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(291, 26);
            this.txtProID.TabIndex = 97;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.White;
            this.btnActivate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnActivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.Black;
            this.btnActivate.Location = new System.Drawing.Point(183, 128);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(94, 29);
            this.btnActivate.TabIndex = 1;
            this.btnActivate.Text = "Activate";
            this.btnActivate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnAboutus
            // 
            this.btnAboutus.BackColor = System.Drawing.Color.White;
            this.btnAboutus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAboutus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAboutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutus.ForeColor = System.Drawing.Color.Black;
            this.btnAboutus.Location = new System.Drawing.Point(311, 128);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.Size = new System.Drawing.Size(94, 29);
            this.btnAboutus.TabIndex = 2;
            this.btnAboutus.Text = "About Us";
            this.btnAboutus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAboutus.UseVisualStyleBackColor = false;
            this.btnAboutus.Click += new System.EventHandler(this.btnAboutus_Click);
            // 
            // DueActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 202);
            this.Controls.Add(this.btnAboutus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DueActivationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activate Product";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DueActivationForm_Load);
            this.panHead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActivation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnAboutus;
    }
}