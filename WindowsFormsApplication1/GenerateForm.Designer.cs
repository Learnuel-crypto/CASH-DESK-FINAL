namespace WindowsFormsApplication1
{
    partial class GenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateForm));
            this.panHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panHead.TabIndex = 84;
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
            this.label55.Size = new System.Drawing.Size(83, 27);
            this.label55.TabIndex = 76;
            this.label55.Text = "Generate";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(174, 112);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 26);
            this.btnGenerate.TabIndex = 85;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(105, 60);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(291, 26);
            this.txtProID.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Product ID";
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.GenerateForm_Load);
            this.panHead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
    }
}