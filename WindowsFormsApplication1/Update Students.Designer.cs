namespace WindowsFormsApplication1
{
    partial class Update_Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridDisplayStudent = new System.Windows.Forms.DataGridView();
            this.Name_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewClass = new System.Windows.Forms.ListBox();
            this.btnPrintNames = new System.Windows.Forms.Button();
            this.btnpromoteClass = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnClassView = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.Blue;
            this.btnaddnew.FlatAppearance.BorderSize = 0;
            this.btnaddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnaddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.Snow;
            this.btnaddnew.Location = new System.Drawing.Point(93, 285);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(86, 29);
            this.btnaddnew.TabIndex = 7;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Blue;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Snow;
            this.btnsave.Location = new System.Drawing.Point(222, 285);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 29);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Gender";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Snow;
            this.btnupdate.Location = new System.Drawing.Point(222, 320);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 29);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.White;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(75, 198);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 44;
            this.lblClass.Text = "Class";
            this.lblClass.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Last Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(141, 85);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(189, 26);
            this.txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(141, 123);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(189, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Middle Name";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OliveDrab;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Snow;
            this.btndelete.Location = new System.Drawing.Point(217, 383);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 29);
            this.btndelete.TabIndex = 39;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(141, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(189, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(138, 198);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(169, 26);
            this.txtClass.TabIndex = 5;
            this.txtClass.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(372, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(443, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 39);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(90, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(309, 26);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(141, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 26);
            this.txtID.TabIndex = 25;
            this.txtID.Visible = false;
            // 
            // dataGridDisplayStudent
            // 
            this.dataGridDisplayStudent.AllowUserToAddRows = false;
            this.dataGridDisplayStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridDisplayStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridDisplayStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDisplayStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDisplayStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDisplayStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDisplayStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplayStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Id,
            this.First_Name,
            this.Middle_Name,
            this.Last_Name,
            this.Sex});
            this.dataGridDisplayStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDisplayStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDisplayStudent.Location = new System.Drawing.Point(372, 64);
            this.dataGridDisplayStudent.Name = "dataGridDisplayStudent";
            this.dataGridDisplayStudent.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDisplayStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDisplayStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDisplayStudent.Size = new System.Drawing.Size(510, 484);
            this.dataGridDisplayStudent.TabIndex = 36;
            this.dataGridDisplayStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDisplayStudent_CellContentClick);
            this.dataGridDisplayStudent.Click += new System.EventHandler(this.dataGridDisplayStudent_Click);
            // 
            // Name_Id
            // 
            this.Name_Id.DataPropertyName = "Name_Id";
            this.Name_Id.HeaderText = "ID";
            this.Name_Id.Name = "Name_Id";
            this.Name_Id.ReadOnly = true;
            this.Name_Id.Visible = false;
            this.Name_Id.Width = 48;
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "First_Name";
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 116;
            // 
            // Middle_Name
            // 
            this.Middle_Name.DataPropertyName = "Middle_Name";
            this.Middle_Name.HeaderText = "Middle Name";
            this.Middle_Name.Name = "Middle_Name";
            this.Middle_Name.ReadOnly = true;
            this.Middle_Name.Width = 131;
            // 
            // Last_Name
            // 
            this.Last_Name.DataPropertyName = "Last_Name";
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 114;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Gender";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSex);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listViewClass);
            this.panel2.Controls.Add(this.btnPrintNames);
            this.panel2.Controls.Add(this.btnpromoteClass);
            this.panel2.Controls.Add(this.btndel);
            this.panel2.Controls.Add(this.btnClassView);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridDisplayStudent);
            this.panel2.Controls.Add(this.btnaddnew);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.txtClass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.txtMiddleName);
            this.panel2.Controls.Add(this.lblClass);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 560);
            this.panel2.TabIndex = 54;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(141, 163);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(57, 26);
            this.txtSex.TabIndex = 59;
            this.txtSex.TextChanged += new System.EventHandler(this.txtSex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Class";
            // 
            // listViewClass
            // 
            this.listViewClass.BackColor = System.Drawing.Color.White;
            this.listViewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClass.FormattingEnabled = true;
            this.listViewClass.ItemHeight = 20;
            this.listViewClass.Location = new System.Drawing.Point(30, 427);
            this.listViewClass.Name = "listViewClass";
            this.listViewClass.Size = new System.Drawing.Size(205, 124);
            this.listViewClass.TabIndex = 57;
            this.listViewClass.SelectedIndexChanged += new System.EventHandler(this.listViewClass_SelectedIndexChanged);
            // 
            // btnPrintNames
            // 
            this.btnPrintNames.BackColor = System.Drawing.Color.Blue;
            this.btnPrintNames.FlatAppearance.BorderSize = 0;
            this.btnPrintNames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrintNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintNames.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintNames.Location = new System.Drawing.Point(56, 359);
            this.btnPrintNames.Name = "btnPrintNames";
            this.btnPrintNames.Size = new System.Drawing.Size(123, 29);
            this.btnPrintNames.TabIndex = 9;
            this.btnPrintNames.Text = "Print Names";
            this.btnPrintNames.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintNames.UseVisualStyleBackColor = false;
            this.btnPrintNames.Click += new System.EventHandler(this.btnPrintNames_Click);
            // 
            // btnpromoteClass
            // 
            this.btnpromoteClass.BackColor = System.Drawing.Color.Blue;
            this.btnpromoteClass.FlatAppearance.BorderSize = 0;
            this.btnpromoteClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnpromoteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnpromoteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpromoteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpromoteClass.ForeColor = System.Drawing.Color.Snow;
            this.btnpromoteClass.Location = new System.Drawing.Point(222, 359);
            this.btnpromoteClass.Name = "btnpromoteClass";
            this.btnpromoteClass.Size = new System.Drawing.Size(123, 29);
            this.btnpromoteClass.TabIndex = 10;
            this.btnpromoteClass.Text = "Promote Class";
            this.btnpromoteClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpromoteClass.UseVisualStyleBackColor = false;
            this.btnpromoteClass.Click += new System.EventHandler(this.btnpromoteClass_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Blue;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Snow;
            this.btndel.Location = new System.Drawing.Point(93, 320);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(86, 29);
            this.btndel.TabIndex = 8;
            this.btndel.Text = "Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnClassView
            // 
            this.btnClassView.BackColor = System.Drawing.Color.Wheat;
            this.btnClassView.FlatAppearance.BorderSize = 0;
            this.btnClassView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClassView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClassView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassView.ForeColor = System.Drawing.Color.DimGray;
            this.btnClassView.Location = new System.Drawing.Point(93, 242);
            this.btnClassView.Name = "btnClassView";
            this.btnClassView.Size = new System.Drawing.Size(113, 29);
            this.btnClassView.TabIndex = 56;
            this.btnClassView.Text = "View Class";
            this.btnClassView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClassView.UseVisualStyleBackColor = false;
            this.btnClassView.Visible = false;
            this.btnClassView.Click += new System.EventHandler(this.btnClassView_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Update_Students
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update  Students";
            this.Load += new System.EventHandler(this.Update_Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridDisplayStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClassView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnpromoteClass;
        private System.Windows.Forms.Button btnPrintNames;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listViewClass;
        private System.Windows.Forms.TextBox txtSex;
        }
}