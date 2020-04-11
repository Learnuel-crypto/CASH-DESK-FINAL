namespace WindowsFormsApplication1
    {
    partial class ControlSettings
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
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.Color.White;
            this.btnAdminLogout.FlatAppearance.BorderSize = 0;
            this.btnAdminLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAdminLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAdminLogout.ForeColor = System.Drawing.Color.Black;
            this.btnAdminLogout.Location = new System.Drawing.Point(0, 8);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(112, 26);
            this.btnAdminLogout.TabIndex = 6;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            this.btnAdminLogout.MouseEnter += new System.EventHandler(this.btnAdminLogout_MouseEnter);
            this.btnAdminLogout.MouseHover += new System.EventHandler(this.btnAdminLogout_MouseHover);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.White;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogs.ForeColor = System.Drawing.Color.Black;
            this.btnLogs.Location = new System.Drawing.Point(-1, 45);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(112, 26);
            this.btnLogs.TabIndex = 7;
            this.btnLogs.Text = "Admin Log";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // ControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnAdminLogout);
            this.Name = "ControlSettings";
            this.Size = new System.Drawing.Size(111, 90);
            this.MouseLeave += new System.EventHandler(this.ControlSettings_MouseLeave);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Button btnLogs;
        }
    }
