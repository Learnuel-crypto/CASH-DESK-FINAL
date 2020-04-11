namespace WindowsFormsApplication1
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listClass = new System.Windows.Forms.ListBox();
            this.checkTaller = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ntmReceipt = new System.Windows.Forms.Button();
            this.btnOtherPayments = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panyear = new System.Windows.Forms.Panel();
            this.listYear = new System.Windows.Forms.ListBox();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdebtyear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridAmount = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.combTerm = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combInstall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combFeeName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioCurrent = new System.Windows.Forms.RadioButton();
            this.radioDebt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerPrint = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panyear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.listClass);
            this.groupBox1.Controls.Add(this.checkTaller);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.ntmReceipt);
            this.groupBox1.Controls.Add(this.btnOtherPayments);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panyear);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.combTerm);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.combInstall);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combFeeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioCurrent);
            this.groupBox1.Controls.Add(this.radioDebt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 449);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regular Fee Payment";
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
            this.NameID,
            this.First_Name,
            this.Middle_Name,
            this.Last_Name});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(424, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(398, 358);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // NameID
            // 
            this.NameID.HeaderText = "NameID";
            this.NameID.Name = "NameID";
            this.NameID.ReadOnly = true;
            this.NameID.Visible = false;
            this.NameID.Width = 93;
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 111;
            // 
            // Middle_Name
            // 
            this.Middle_Name.HeaderText = "Middle Name";
            this.Middle_Name.Name = "Middle_Name";
            this.Middle_Name.ReadOnly = true;
            this.Middle_Name.Width = 126;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 111;
            // 
            // listClass
            // 
            this.listClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 20;
            this.listClass.Location = new System.Drawing.Point(102, 71);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(198, 244);
            this.listClass.TabIndex = 13;
            this.listClass.Visible = false;
            this.listClass.Click += new System.EventHandler(this.listClass_Click);
            // 
            // checkTaller
            // 
            this.checkTaller.AutoSize = true;
            this.checkTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTaller.Location = new System.Drawing.Point(168, 248);
            this.checkTaller.Name = "checkTaller";
            this.checkTaller.Size = new System.Drawing.Size(72, 24);
            this.checkTaller.TabIndex = 107;
            this.checkTaller.Text = "Teller";
            this.checkTaller.UseVisualStyleBackColor = true;
            this.checkTaller.Click += new System.EventHandler(this.checkTaller_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Payment Type";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Snow;
            this.btnClear.Location = new System.Drawing.Point(343, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ntmReceipt
            // 
            this.ntmReceipt.BackColor = System.Drawing.Color.White;
            this.ntmReceipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ntmReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ntmReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ntmReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntmReceipt.ForeColor = System.Drawing.Color.Black;
            this.ntmReceipt.Location = new System.Drawing.Point(734, 321);
            this.ntmReceipt.Name = "ntmReceipt";
            this.ntmReceipt.Size = new System.Drawing.Size(88, 29);
            this.ntmReceipt.TabIndex = 15;
            this.ntmReceipt.Text = "Receipt";
            this.ntmReceipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ntmReceipt.UseVisualStyleBackColor = false;
            this.ntmReceipt.Click += new System.EventHandler(this.ntmReceipt_Click);
            // 
            // btnOtherPayments
            // 
            this.btnOtherPayments.BackColor = System.Drawing.Color.White;
            this.btnOtherPayments.FlatAppearance.BorderSize = 0;
            this.btnOtherPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnOtherPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOtherPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherPayments.ForeColor = System.Drawing.Color.Blue;
            this.btnOtherPayments.Location = new System.Drawing.Point(10, 281);
            this.btnOtherPayments.Name = "btnOtherPayments";
            this.btnOtherPayments.Size = new System.Drawing.Size(153, 29);
            this.btnOtherPayments.TabIndex = 14;
            this.btnOtherPayments.Text = "Make Other Payments";
            this.btnOtherPayments.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOtherPayments.UseVisualStyleBackColor = false;
            this.btnOtherPayments.Click += new System.EventHandler(this.btnOtherPayments_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(458, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 26);
            this.txtname.TabIndex = 11;
            this.txtname.Click += new System.EventHandler(this.txtname_Click);
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(102, 44);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(198, 26);
            this.txtClass.TabIndex = 9;
            this.txtClass.Click += new System.EventHandler(this.txtClass_Click);
            this.txtClass.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Class";
            // 
            // panyear
            // 
            this.panyear.Controls.Add(this.listYear);
            this.panyear.Controls.Add(this.txtFeeAmount);
            this.panyear.Controls.Add(this.label11);
            this.panyear.Controls.Add(this.txtdebtyear);
            this.panyear.Controls.Add(this.label8);
            this.panyear.Controls.Add(this.dataGridAmount);
            this.panyear.Location = new System.Drawing.Point(450, 178);
            this.panyear.Name = "panyear";
            this.panyear.Size = new System.Drawing.Size(284, 262);
            this.panyear.TabIndex = 7;
            this.panyear.Visible = false;
            // 
            // listYear
            // 
            this.listYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.listYear.FormattingEnabled = true;
            this.listYear.ItemHeight = 20;
            this.listYear.Location = new System.Drawing.Point(62, 64);
            this.listYear.Name = "listYear";
            this.listYear.Size = new System.Drawing.Size(126, 184);
            this.listYear.TabIndex = 12;
            this.listYear.Visible = false;
            this.listYear.Click += new System.EventHandler(this.listYear_Click);
            this.listYear.MouseLeave += new System.EventHandler(this.listYear_MouseLeave);
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeAmount.Location = new System.Drawing.Point(28, 95);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(98, 26);
            this.txtFeeAmount.TabIndex = 10;
            this.txtFeeAmount.Click += new System.EventHandler(this.txtFeeAmount_Click);
            this.txtFeeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeeAmount_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Fee Amount Then";
            // 
            // txtdebtyear
            // 
            this.txtdebtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdebtyear.Location = new System.Drawing.Point(28, 34);
            this.txtdebtyear.Name = "txtdebtyear";
            this.txtdebtyear.Size = new System.Drawing.Size(100, 26);
            this.txtdebtyear.TabIndex = 8;
            this.txtdebtyear.Click += new System.EventHandler(this.txtdebtyear_Click);
            this.txtdebtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdebtyear_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter Year";
            // 
            // dataGridAmount
            // 
            this.dataGridAmount.AllowUserToAddRows = false;
            this.dataGridAmount.AllowUserToDeleteRows = false;
            this.dataGridAmount.AllowUserToResizeColumns = false;
            this.dataGridAmount.AllowUserToResizeRows = false;
            this.dataGridAmount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridAmount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAmount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAmount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAmount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAmount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridAmount.Location = new System.Drawing.Point(8, 122);
            this.dataGridAmount.MultiSelect = false;
            this.dataGridAmount.Name = "dataGridAmount";
            this.dataGridAmount.ReadOnly = true;
            this.dataGridAmount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridAmount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAmount.Size = new System.Drawing.Size(261, 137);
            this.dataGridAmount.StandardTab = true;
            this.dataGridAmount.TabIndex = 12;
            this.dataGridAmount.Visible = false;
            this.dataGridAmount.Click += new System.EventHandler(this.dataGridAmount_Click);
            this.dataGridAmount.MouseLeave += new System.EventHandler(this.dataGridAmount_MouseLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fee Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 108;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnSubmit.Location = new System.Drawing.Point(215, 321);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.combTerm.SelectedIndexChanged += new System.EventHandler(this.combTerm_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Names";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 144);
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
            this.combInstall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combInstall_KeyPress);
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
            // combFeeName
            // 
            this.combFeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFeeName.FormattingEnabled = true;
            this.combFeeName.Location = new System.Drawing.Point(102, 92);
            this.combFeeName.Name = "combFeeName";
            this.combFeeName.Size = new System.Drawing.Size(198, 28);
            this.combFeeName.TabIndex = 4;
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
            this.txtAmount.Location = new System.Drawing.Point(102, 203);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(168, 29);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 209);
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
            this.radioCurrent.CheckedChanged += new System.EventHandler(this.radioCurrent_CheckedChanged);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btnclose);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 19);
            this.panel3.TabIndex = 56;
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
            this.timerPrint.Tick += new System.EventHandler(this.timerPrint_Tick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regular Fees";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.Click += new System.EventHandler(this.Payment_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panyear.ResumeLayout(false);
            this.panyear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panyear;
        private System.Windows.Forms.TextBox txtdebtyear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox combTerm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combInstall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combFeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioCurrent;
        private System.Windows.Forms.RadioButton radioDebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listYear;
        private System.Windows.Forms.DataGridView dataGridAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.Button btnOtherPayments;
        private System.Windows.Forms.Button ntmReceipt;
        private System.Windows.Forms.Button btnClear;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkTaller;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.Timer timerPrint;
        }
}