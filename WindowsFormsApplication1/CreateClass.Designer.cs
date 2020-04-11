namespace WindowsFormsApplication1
{
    partial class CreateClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClass));
            this.listClass = new System.Windows.Forms.ListBox();
            this.panhead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtNewclass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.btnPromote = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panhead.SuspendLayout();
            this.SuspendLayout();
            // 
            // listClass
            // 
            this.listClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 20;
            this.listClass.Location = new System.Drawing.Point(4, 70);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(175, 204);
            this.listClass.TabIndex = 0;
            this.listClass.Click += new System.EventHandler(this.listClass_Click);
            // 
            // panhead
            // 
            this.panhead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panhead.Controls.Add(this.btnclose);
            this.panhead.Controls.Add(this.label5);
            this.panhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panhead.Location = new System.Drawing.Point(0, 0);
            this.panhead.Name = "panhead";
            this.panhead.Size = new System.Drawing.Size(337, 19);
            this.panhead.TabIndex = 56;
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
            this.btnclose.Location = new System.Drawing.Point(311, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Class Information";
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(185, 62);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(140, 26);
            this.txtClass.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Edit Present Class";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panhead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtNewclass
            // 
            this.txtNewclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewclass.Location = new System.Drawing.Point(185, 159);
            this.txtNewclass.Name = "txtNewclass";
            this.txtNewclass.Size = new System.Drawing.Size(140, 26);
            this.txtNewclass.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "New Class";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.BackColor = System.Drawing.Color.White;
            this.lblclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.Location = new System.Drawing.Point(51, 280);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(83, 20);
            this.lblclass.TabIndex = 64;
            this.lblclass.Text = "New Class";
            this.lblclass.Visible = false;
            // 
            // btnPromote
            // 
            this.btnPromote.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPromote.FlatAppearance.BorderSize = 0;
            this.btnPromote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPromote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromote.ForeColor = System.Drawing.Color.Snow;
            this.btnPromote.Location = new System.Drawing.Point(195, 191);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(85, 29);
            this.btnPromote.TabIndex = 65;
            this.btnPromote.Text = "Promote";
            this.btnPromote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPromote.UseVisualStyleBackColor = false;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Snow;
            this.btnUpdate.Location = new System.Drawing.Point(195, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 29);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 306);
            this.panel1.TabIndex = 67;
            // 
            // CreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 306);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewclass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panhead);
            this.Controls.Add(this.listClass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateClass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Class";
            this.Load += new System.EventHandler(this.CreateClass_Load);
            this.panhead.ResumeLayout(false);
            this.panhead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.Panel panhead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox txtNewclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}