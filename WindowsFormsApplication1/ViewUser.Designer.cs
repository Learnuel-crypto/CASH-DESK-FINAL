namespace WindowsFormsApplication1
    {
    partial class ViewUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneldrag = new System.Windows.Forms.Panel();
            this.btclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.paneldrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToOrderColumns = true;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridUsers.Location = new System.Drawing.Point(22, 28);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(328, 331);
            this.dataGridUsers.TabIndex = 79;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 114;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 103;
            // 
            // paneldrag
            // 
            this.paneldrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneldrag.Controls.Add(this.btclose);
            this.paneldrag.Controls.Add(this.label5);
            this.paneldrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldrag.Location = new System.Drawing.Point(0, 0);
            this.paneldrag.Name = "paneldrag";
            this.paneldrag.Size = new System.Drawing.Size(376, 22);
            this.paneldrag.TabIndex = 80;
            // 
            // btclose
            // 
            this.btclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.Image = ((System.Drawing.Image)(resources.GetObject("btclose.Image")));
            this.btclose.Location = new System.Drawing.Point(350, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(26, 22);
            this.btclose.TabIndex = 37;
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Admins";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneldrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 389);
            this.panel1.TabIndex = 81;
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 389);
            this.Controls.Add(this.paneldrag);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admins";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.paneldrag.ResumeLayout(false);
            this.paneldrag.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Panel paneldrag;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        }
    }