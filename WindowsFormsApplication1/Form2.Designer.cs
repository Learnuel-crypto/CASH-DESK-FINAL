namespace WindowsFormsApplication1
{
    partial class EventPayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPayForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkTaller = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.txtFeeName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listClass = new System.Windows.Forms.ListBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.combTerm = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combInstall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combEventName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioCurrent = new System.Windows.Forms.RadioButton();
            this.radioDebt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerPrint = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnSubmit.Location = new System.Drawing.Point(223, 321);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 29);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.checkTaller);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnReceipt);
            this.groupBox1.Controls.Add(this.txtFeeName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.listClass);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.combTerm);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.combInstall);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combEventName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioCurrent);
            this.groupBox1.Controls.Add(this.radioDebt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 449);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Fee Payment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.First_Name,
            this.Middle_Name,
            this.Last_Name});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(427, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(414, 373);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Names
            // 
            this.Names.HeaderText = "NamesID";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Visible = false;
            this.Names.Width = 101;
            // 
            // First_Name
            // 
            this.First_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 111;
            // 
            // Middle_Name
            // 
            this.Middle_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Middle_Name.HeaderText = "Middle Name";
            this.Middle_Name.Name = "Middle_Name";
            this.Middle_Name.ReadOnly = true;
            this.Middle_Name.Width = 126;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 111;
            // 
            // checkTaller
            // 
            this.checkTaller.AutoSize = true;
            this.checkTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTaller.Location = new System.Drawing.Point(453, 188);
            this.checkTaller.Name = "checkTaller";
            this.checkTaller.Size = new System.Drawing.Size(72, 24);
            this.checkTaller.TabIndex = 110;
            this.checkTaller.Text = "Teller";
            this.checkTaller.UseVisualStyleBackColor = true;
            this.checkTaller.Click += new System.EventHandler(this.checkTaller_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 108;
            this.label8.Text = "Payment Type";
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.White;
            this.btnReceipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnReceipt.Location = new System.Drawing.Point(734, 324);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(88, 29);
            this.btnReceipt.TabIndex = 16;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // txtFeeName
            // 
            this.txtFeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeName.Location = new System.Drawing.Point(102, 89);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.ReadOnly = true;
            this.txtFeeName.Size = new System.Drawing.Size(198, 26);
            this.txtFeeName.TabIndex = 15;
            this.txtFeeName.TextChanged += new System.EventHandler(this.txtFeeName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Fee Name";
            // 
            // listClass
            // 
            this.listClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 20;
            this.listClass.Location = new System.Drawing.Point(101, 161);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(198, 144);
            this.listClass.TabIndex = 13;
            this.listClass.Visible = false;
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            this.listClass.MouseLeave += new System.EventHandler(this.listClass_MouseLeave);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(518, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 26);
            this.txtname.TabIndex = 11;
            this.txtname.Click += new System.EventHandler(this.txtname_Click);
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(101, 131);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(198, 26);
            this.txtClass.TabIndex = 9;
            this.txtClass.Click += new System.EventHandler(this.txtClass_Click);
            this.txtClass.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Class";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(360, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // combTerm
            // 
            this.combTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combTerm.FormattingEnabled = true;
            this.combTerm.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third"});
            this.combTerm.Location = new System.Drawing.Point(458, 95);
            this.combTerm.Name = "combTerm";
            this.combTerm.Size = new System.Drawing.Size(126, 28);
            this.combTerm.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Names";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date";
            // 
            // combInstall
            // 
            this.combInstall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combInstall.FormattingEnabled = true;
            this.combInstall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.combInstall.Location = new System.Drawing.Point(697, 95);
            this.combInstall.Name = "combInstall";
            this.combInstall.Size = new System.Drawing.Size(88, 28);
            this.combInstall.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Intallment";
            // 
            // combEventName
            // 
            this.combEventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combEventName.FormattingEnabled = true;
            this.combEventName.Location = new System.Drawing.Point(102, 44);
            this.combEventName.Name = "combEventName";
            this.combEventName.Size = new System.Drawing.Size(226, 28);
            this.combEventName.TabIndex = 4;
            this.combEventName.SelectedIndexChanged += new System.EventHandler(this.combFeeName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Term";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(102, 242);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(168, 29);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount";
            // 
            // radioCurrent
            // 
            this.radioCurrent.AutoSize = true;
            this.radioCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCurrent.Location = new System.Drawing.Point(540, 147);
            this.radioCurrent.Name = "radioCurrent";
            this.radioCurrent.Size = new System.Drawing.Size(80, 24);
            this.radioCurrent.TabIndex = 1;
            this.radioCurrent.TabStop = true;
            this.radioCurrent.Text = "Current";
            this.radioCurrent.UseVisualStyleBackColor = true;
            // 
            // radioDebt
            // 
            this.radioDebt.AutoSize = true;
            this.radioDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDebt.Location = new System.Drawing.Point(453, 147);
            this.radioDebt.Name = "radioDebt";
            this.radioDebt.Size = new System.Drawing.Size(62, 24);
            this.radioDebt.TabIndex = 1;
            this.radioDebt.TabStop = true;
            this.radioDebt.Text = "Debt";
            this.radioDebt.UseVisualStyleBackColor = true;
            this.radioDebt.CheckedChanged += new System.EventHandler(this.radioDebt_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fee Type";
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
            this.btnclose.Location = new System.Drawing.Point(847, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 19);
            this.btnclose.TabIndex = 21;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btnclose);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 19);
            this.panel3.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Payments";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timerPrint
            // 
            this.timerPrint.Interval = 1000;
            // 
            // EventPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Fees ";
            this.Load += new System.EventHandler(this.EventPayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combTerm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combInstall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioCurrent;
        private System.Windows.Forms.RadioButton radioDebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFeeName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReceipt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkTaller;
        private System.Windows.Forms.Timer timerPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        }
}