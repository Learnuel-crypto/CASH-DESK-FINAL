namespace WindowsFormsApplication1
{
    partial class EditStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudents));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.dataGridDisplayStudent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(400, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 40);
            this.panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(382, 8);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(115, 27);
            this.textBox6.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Class";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Snow;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(519, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 36);
            this.button9.TabIndex = 36;
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(63, 7);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(242, 27);
            this.textBox5.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sex";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Snow;
            this.btnupdate.Location = new System.Drawing.Point(88, 383);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 29);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(145, 235);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(186, 27);
            this.txtClass.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(148, 151);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(189, 27);
            this.txtMiddleName.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(148, 195);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(189, 27);
            this.txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(142, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(189, 27);
            this.txtFirstName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OliveDrab;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Snow;
            this.btndelete.Location = new System.Drawing.Point(217, 383);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 29);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Student Record";
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.OliveDrab;
            this.btnaddnew.FlatAppearance.BorderSize = 0;
            this.btnaddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnaddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.Snow;
            this.btnaddnew.Location = new System.Drawing.Point(88, 434);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(105, 29);
            this.btnaddnew.TabIndex = 31;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaddnew.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Snow;
            this.btnsave.Location = new System.Drawing.Point(217, 434);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 29);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Sienna;
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnnext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.Snow;
            this.btnnext.Image = ((System.Drawing.Image)(resources.GetObject("btnnext.Image")));
            this.btnnext.Location = new System.Drawing.Point(208, 329);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(54, 29);
            this.btnnext.TabIndex = 33;
            this.btnnext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.Sienna;
            this.btnlast.FlatAppearance.BorderSize = 0;
            this.btnlast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnlast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.ForeColor = System.Drawing.Color.Snow;
            this.btnlast.Image = ((System.Drawing.Image)(resources.GetObject("btnlast.Image")));
            this.btnlast.Location = new System.Drawing.Point(280, 329);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(54, 29);
            this.btnlast.TabIndex = 32;
            this.btnlast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.Sienna;
            this.btnfirst.FlatAppearance.BorderSize = 0;
            this.btnfirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnfirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.ForeColor = System.Drawing.Color.Snow;
            this.btnfirst.Image = ((System.Drawing.Image)(resources.GetObject("btnfirst.Image")));
            this.btnfirst.Location = new System.Drawing.Point(54, 329);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(54, 29);
            this.btnfirst.TabIndex = 35;
            this.btnfirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.Sienna;
            this.btnprevious.FlatAppearance.BorderSize = 0;
            this.btnprevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnprevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.Color.Snow;
            this.btnprevious.Image = ((System.Drawing.Image)(resources.GetObject("btnprevious.Image")));
            this.btnprevious.Location = new System.Drawing.Point(126, 329);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(54, 29);
            this.btnprevious.TabIndex = 34;
            this.btnprevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // dataGridDisplayStudent
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDisplayStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridDisplayStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDisplayStudent.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridDisplayStudent.Location = new System.Drawing.Point(400, 103);
            this.dataGridDisplayStudent.Name = "dataGridDisplayStudent";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDisplayStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridDisplayStudent.Size = new System.Drawing.Size(671, 393);
            this.dataGridDisplayStudent.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtsex);
            this.panel2.Controls.Add(this.dataGridDisplayStudent);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtClass);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 560);
            this.panel2.TabIndex = 37;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(145, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 27);
            this.txtID.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btnclose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 19);
            this.panel3.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1061, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsex.Location = new System.Drawing.Point(145, 270);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(74, 27);
            this.txtsex.TabIndex = 37;
            // 
            // EditStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Name = "EditStudents";
            this.Size = new System.Drawing.Size(1369, 587);
            this.Load += new System.EventHandler(this.EditStudents_Load);
            this.VisibleChanged += new System.EventHandler(this.EditStudents_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridDisplayStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtsex;
    }
}
