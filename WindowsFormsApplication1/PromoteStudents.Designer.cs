namespace WindowsFormsApplication1
    {
    partial class PromoteStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromoteStudents));
            this.panhead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPromote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewclass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPresentClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listClass = new System.Windows.Forms.ListBox();
            this.panhead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panhead
            // 
            this.panhead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panhead.Controls.Add(this.btnclose);
            this.panhead.Controls.Add(this.label5);
            this.panhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panhead.Location = new System.Drawing.Point(0, 0);
            this.panhead.Name = "panhead";
            this.panhead.Size = new System.Drawing.Size(372, 19);
            this.panhead.TabIndex = 57;
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
            this.btnclose.Location = new System.Drawing.Point(346, 0);
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
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Promote Students";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPromote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNewclass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPresentClass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 288);
            this.panel1.TabIndex = 58;
            // 
            // btnPromote
            // 
            this.btnPromote.BackColor = System.Drawing.Color.Blue;
            this.btnPromote.FlatAppearance.BorderSize = 0;
            this.btnPromote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPromote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromote.ForeColor = System.Drawing.Color.Snow;
            this.btnPromote.Location = new System.Drawing.Point(187, 140);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(85, 29);
            this.btnPromote.TabIndex = 73;
            this.btnPromote.Text = "Promote";
            this.btnPromote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPromote.UseVisualStyleBackColor = false;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "New Class";
            // 
            // txtNewclass
            // 
            this.txtNewclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewclass.Location = new System.Drawing.Point(187, 107);
            this.txtNewclass.Name = "txtNewclass";
            this.txtNewclass.Size = new System.Drawing.Size(172, 26);
            this.txtNewclass.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Present Class";
            // 
            // txtPresentClass
            // 
            this.txtPresentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentClass.Location = new System.Drawing.Point(187, 49);
            this.txtPresentClass.Name = "txtPresentClass";
            this.txtPresentClass.ReadOnly = true;
            this.txtPresentClass.Size = new System.Drawing.Size(172, 26);
            this.txtPresentClass.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Classes";
            // 
            // listClass
            // 
            this.listClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 20;
            this.listClass.Location = new System.Drawing.Point(11, 49);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(163, 224);
            this.listClass.TabIndex = 67;
            this.listClass.Click += new System.EventHandler(this.listClass_Click);
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            // 
            // PromoteStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panhead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromoteStudents";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PromoteStudents";
            this.Load += new System.EventHandler(this.PromoteStudents_Load);
            this.panhead.ResumeLayout(false);
            this.panhead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panhead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPresentClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listClass;
        }
    }