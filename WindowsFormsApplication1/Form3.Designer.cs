namespace WindowsFormsApplication1
{
    partial class AddStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentsForm));
            this.btnedite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblinfor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comClass = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnedite
            // 
            this.btnedite.BackColor = System.Drawing.Color.Blue;
            this.btnedite.FlatAppearance.BorderSize = 0;
            this.btnedite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnedite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedite.ForeColor = System.Drawing.Color.Snow;
            this.btnedite.Location = new System.Drawing.Point(89, 285);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(67, 29);
            this.btnedite.TabIndex = 7;
            this.btnedite.Text = "Edit";
            this.btnedite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnedite.UseVisualStyleBackColor = false;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 22);
            this.panel1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Add Students";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(354, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.ForeColor = System.Drawing.Color.Black;
            this.radioFemale.Location = new System.Drawing.Point(254, 235);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(38, 24);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "F";
            this.radioFemale.UseVisualStyleBackColor = false;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.BackColor = System.Drawing.Color.Transparent;
            this.radioMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.ForeColor = System.Drawing.Color.Black;
            this.radioMale.Location = new System.Drawing.Point(151, 235);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(41, 24);
            this.radioMale.TabIndex = 4;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "M";
            this.radioMale.UseVisualStyleBackColor = false;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Gender";
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.BackColor = System.Drawing.Color.Blue;
            this.btnAddStudents.FlatAppearance.BorderSize = 0;
            this.btnAddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudents.ForeColor = System.Drawing.Color.Snow;
            this.btnAddStudents.Location = new System.Drawing.Point(177, 285);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(67, 29);
            this.btnAddStudents.TabIndex = 6;
            this.btnAddStudents.Text = "Add";
            this.btnAddStudents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.Location = new System.Drawing.Point(129, 106);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(211, 26);
            this.txtMname.TabIndex = 1;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(129, 150);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(211, 26);
            this.txtLname.TabIndex = 2;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(129, 62);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(211, 26);
            this.txtFname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "First Name";
            // 
            // bnclear
            // 
            this.bnclear.BackColor = System.Drawing.Color.Blue;
            this.bnclear.FlatAppearance.BorderSize = 0;
            this.bnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnclear.ForeColor = System.Drawing.Color.Snow;
            this.bnclear.Location = new System.Drawing.Point(273, 285);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(67, 29);
            this.bnclear.TabIndex = 8;
            this.bnclear.Text = "Clear";
            this.bnclear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnclear.UseVisualStyleBackColor = false;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Middle Name";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblinfor
            // 
            this.lblinfor.AutoSize = true;
            this.lblinfor.BackColor = System.Drawing.Color.Transparent;
            this.lblinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfor.ForeColor = System.Drawing.Color.Blue;
            this.lblinfor.Location = new System.Drawing.Point(245, 40);
            this.lblinfor.Name = "lblinfor";
            this.lblinfor.Size = new System.Drawing.Size(91, 20);
            this.lblinfor.TabIndex = 34;
            this.lblinfor.Text = "Succesful...";
            this.lblinfor.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comClass
            // 
            this.comClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comClass.FormattingEnabled = true;
            this.comClass.Location = new System.Drawing.Point(129, 191);
            this.comClass.Name = "comClass";
            this.comClass.Size = new System.Drawing.Size(211, 28);
            this.comClass.TabIndex = 35;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(151, 253);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(189, 26);
            this.txtClass.TabIndex = 3;
            this.txtClass.Visible = false;
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 338);
            this.Controls.Add(this.comClass);
            this.Controls.Add(this.lblinfor);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddStudents);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudentsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnclear;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblinfor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comClass;
        private System.Windows.Forms.TextBox txtClass;
        }
}