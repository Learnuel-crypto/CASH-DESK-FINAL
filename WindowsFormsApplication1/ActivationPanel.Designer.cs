namespace WindowsFormsApplication1
{
    partial class ActivationPanel
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(12, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 29);
            this.btnGenerate.TabIndex = 86;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.White;
            this.btnActivate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnActivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.Black;
            this.btnActivate.Location = new System.Drawing.Point(12, 50);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(127, 29);
            this.btnActivate.TabIndex = 87;
            this.btnActivate.Text = "Activate";
            this.btnActivate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.White;
            this.btnAboutUs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.Black;
            this.btnAboutUs.Location = new System.Drawing.Point(12, 91);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(127, 29);
            this.btnAboutUs.TabIndex = 88;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // ActivationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnGenerate);
            this.Name = "ActivationPanel";
            this.Size = new System.Drawing.Size(152, 133);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnAboutUs;
    }
}
