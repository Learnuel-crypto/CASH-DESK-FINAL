namespace WindowsFormsApplication1
    {
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panHead = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.panelsetting = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnViewSetFees = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnSetFees = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnEventFee = new System.Windows.Forms.Button();
            this.btnViewActivity = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSetSession = new System.Windows.Forms.Button();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteLogs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcreateUserAdmin = new System.Windows.Forms.TextBox();
            this.bnClear = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.bnDelete = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtAdminpass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.ReceiptTab = new System.Windows.Forms.TabPage();
            this.txtMotto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnloadImage = new System.Windows.Forms.Button();
            this.lblPictureName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brnSet = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportdata = new System.Windows.Forms.Button();
            this.btnDbBackup = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuest2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txQuest1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panHead.SuspendLayout();
            this.panelsetting.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.ReceiptTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panHead.Controls.Add(this.btnclose);
            this.panHead.Controls.Add(this.label55);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(794, 32);
            this.panHead.TabIndex = 80;
            this.panHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panHead_Paint);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(759, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 32);
            this.btnclose.TabIndex = 78;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label55.Image = ((System.Drawing.Image)(resources.GetObject("label55.Image")));
            this.label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label55.Location = new System.Drawing.Point(3, 2);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(89, 27);
            this.label55.TabIndex = 76;
            this.label55.Text = "        Admin";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelsetting
            // 
            this.panelsetting.BackColor = System.Drawing.Color.RosyBrown;
            this.panelsetting.Controls.Add(this.btnSales);
            this.panelsetting.Controls.Add(this.btnLogs);
            this.panelsetting.Controls.Add(this.btnViewSetFees);
            this.panelsetting.Controls.Add(this.btnIncome);
            this.panelsetting.Controls.Add(this.btnSetFees);
            this.panelsetting.Controls.Add(this.btnCreateEvent);
            this.panelsetting.Controls.Add(this.btnEventFee);
            this.panelsetting.Controls.Add(this.btnViewActivity);
            this.panelsetting.Controls.Add(this.btnReports);
            this.panelsetting.Controls.Add(this.btnSetSession);
            this.panelsetting.Controls.Add(this.btnAddStudents);
            this.panelsetting.Location = new System.Drawing.Point(606, 78);
            this.panelsetting.Name = "panelsetting";
            this.panelsetting.Size = new System.Drawing.Size(165, 490);
            this.panelsetting.TabIndex = 81;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSales.Location = new System.Drawing.Point(-2, 413);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(169, 29);
            this.btnSales.TabIndex = 58;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogs.Location = new System.Drawing.Point(-2, 453);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(169, 29);
            this.btnLogs.TabIndex = 57;
            this.btnLogs.Text = "View Log";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnViewSetFees
            // 
            this.btnViewSetFees.BackColor = System.Drawing.Color.Transparent;
            this.btnViewSetFees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewSetFees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewSetFees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewSetFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSetFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSetFees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewSetFees.Location = new System.Drawing.Point(-2, 372);
            this.btnViewSetFees.Name = "btnViewSetFees";
            this.btnViewSetFees.Size = new System.Drawing.Size(169, 29);
            this.btnViewSetFees.TabIndex = 56;
            this.btnViewSetFees.Text = "View Set Fees";
            this.btnViewSetFees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewSetFees.UseVisualStyleBackColor = false;
            this.btnViewSetFees.Click += new System.EventHandler(this.btnViewSetFees_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnIncome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIncome.Location = new System.Drawing.Point(-2, 326);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(169, 29);
            this.btnIncome.TabIndex = 55;
            this.btnIncome.Text = "View Income";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnSetFees
            // 
            this.btnSetFees.BackColor = System.Drawing.Color.Transparent;
            this.btnSetFees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetFees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSetFees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSetFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFees.ForeColor = System.Drawing.Color.Black;
            this.btnSetFees.Location = new System.Drawing.Point(-2, 96);
            this.btnSetFees.Name = "btnSetFees";
            this.btnSetFees.Size = new System.Drawing.Size(169, 29);
            this.btnSetFees.TabIndex = 54;
            this.btnSetFees.Text = "Set Fees";
            this.btnSetFees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetFees.UseVisualStyleBackColor = false;
            this.btnSetFees.Click += new System.EventHandler(this.btnSetFees_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateEvent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCreateEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateEvent.Location = new System.Drawing.Point(-2, 280);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(169, 29);
            this.btnCreateEvent.TabIndex = 53;
            this.btnCreateEvent.Text = "Create Events";
            this.btnCreateEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnEventFee
            // 
            this.btnEventFee.BackColor = System.Drawing.Color.Transparent;
            this.btnEventFee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEventFee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEventFee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEventFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEventFee.Location = new System.Drawing.Point(-2, 234);
            this.btnEventFee.Name = "btnEventFee";
            this.btnEventFee.Size = new System.Drawing.Size(169, 29);
            this.btnEventFee.TabIndex = 52;
            this.btnEventFee.Text = "Event Fees";
            this.btnEventFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventFee.UseVisualStyleBackColor = false;
            this.btnEventFee.Click += new System.EventHandler(this.btnEventFee_Click);
            // 
            // btnViewActivity
            // 
            this.btnViewActivity.BackColor = System.Drawing.Color.Transparent;
            this.btnViewActivity.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewActivity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewActivity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewActivity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewActivity.Location = new System.Drawing.Point(-2, 188);
            this.btnViewActivity.Name = "btnViewActivity";
            this.btnViewActivity.Size = new System.Drawing.Size(169, 29);
            this.btnViewActivity.TabIndex = 51;
            this.btnViewActivity.Text = "View Activities";
            this.btnViewActivity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewActivity.UseVisualStyleBackColor = false;
            this.btnViewActivity.Click += new System.EventHandler(this.btnViewActivity_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReports.Location = new System.Drawing.Point(-2, 142);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(169, 29);
            this.btnReports.TabIndex = 50;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSetSession
            // 
            this.btnSetSession.BackColor = System.Drawing.Color.Transparent;
            this.btnSetSession.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSetSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSetSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSession.ForeColor = System.Drawing.Color.Black;
            this.btnSetSession.Location = new System.Drawing.Point(-2, 50);
            this.btnSetSession.Name = "btnSetSession";
            this.btnSetSession.Size = new System.Drawing.Size(169, 29);
            this.btnSetSession.TabIndex = 48;
            this.btnSetSession.Text = "Set Session";
            this.btnSetSession.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetSession.UseVisualStyleBackColor = false;
            this.btnSetSession.Click += new System.EventHandler(this.btnSetSession_Click);
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudents.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudents.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudents.Location = new System.Drawing.Point(-2, 4);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(169, 29);
            this.btnAddStudents.TabIndex = 47;
            this.btnAddStudents.Text = "Add Students";
            this.btnAddStudents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.ReceiptTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(21, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 378);
            this.tabControl1.TabIndex = 82;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.btnDeleteLogs);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(533, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reset Password";
            // 
            // btnDeleteLogs
            // 
            this.btnDeleteLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLogs.FlatAppearance.BorderSize = 0;
            this.btnDeleteLogs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDeleteLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDeleteLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLogs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLogs.Image")));
            this.btnDeleteLogs.Location = new System.Drawing.Point(394, 2);
            this.btnDeleteLogs.Name = "btnDeleteLogs";
            this.btnDeleteLogs.Size = new System.Drawing.Size(20, 22);
            this.btnDeleteLogs.TabIndex = 109;
            this.btnDeleteLogs.UseVisualStyleBackColor = false;
            this.btnDeleteLogs.Click += new System.EventHandler(this.btnDeleteLogs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangePassword);
            this.groupBox2.Controls.Add(this.txtCurrentPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtConPass);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 139);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Snow;
            this.btnChangePassword.Location = new System.Drawing.Point(367, 87);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(89, 29);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Set";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(165, 28);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(185, 26);
            this.txtCurrentPassword.TabIndex = 4;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Current Password";
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.Location = new System.Drawing.Point(165, 92);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(185, 26);
            this.txtConPass.TabIndex = 6;
            this.txtConPass.TextChanged += new System.EventHandler(this.txtConPass_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(13, 95);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(137, 20);
            this.label41.TabIndex = 44;
            this.label41.Text = "Confirm Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(165, 60);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(185, 26);
            this.txtNewPass.TabIndex = 5;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(37, 62);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(113, 20);
            this.label40.TabIndex = 42;
            this.label40.Text = "New Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNewUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCurrentPass);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 133);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username";
            // 
            // txtNewUser
            // 
            this.txtNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.Location = new System.Drawing.Point(165, 55);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(185, 26);
            this.txtNewUser.TabIndex = 1;
            this.txtNewUser.TextChanged += new System.EventHandler(this.txtNewUser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "New Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(165, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.Snow;
            this.btnSet.Location = new System.Drawing.Point(366, 84);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(89, 29);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Current Username";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(165, 88);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(185, 26);
            this.txtCurrentPass.TabIndex = 2;
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(13, 88);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(135, 20);
            this.label35.TabIndex = 36;
            this.label35.Text = "Current Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(94, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "To update Username Delete Admin logs first.";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtcreateUserAdmin);
            this.tabPage4.Controls.Add(this.bnClear);
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label38);
            this.tabPage4.Controls.Add(this.btnAdd);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label36);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(533, 345);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Admin Password";
            // 
            // txtcreateUserAdmin
            // 
            this.txtcreateUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreateUserAdmin.Location = new System.Drawing.Point(180, 167);
            this.txtcreateUserAdmin.Name = "txtcreateUserAdmin";
            this.txtcreateUserAdmin.Size = new System.Drawing.Size(185, 26);
            this.txtcreateUserAdmin.TabIndex = 3;
            this.txtcreateUserAdmin.TextChanged += new System.EventHandler(this.txtcreateUserAdmin_TextChanged);
            // 
            // bnClear
            // 
            this.bnClear.BackColor = System.Drawing.Color.Transparent;
            this.bnClear.FlatAppearance.BorderSize = 0;
            this.bnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClear.ForeColor = System.Drawing.Color.Snow;
            this.bnClear.Location = new System.Drawing.Point(278, 207);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(87, 29);
            this.bnClear.TabIndex = 5;
            this.bnClear.Text = "Clear";
            this.bnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnClear.UseVisualStyleBackColor = false;
            this.bnClear.Click += new System.EventHandler(this.bnClear_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(28, 136);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(137, 20);
            this.label43.TabIndex = 58;
            this.label43.Text = "Confirm Password";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(180, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(180, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(91, 94);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 20);
            this.label38.TabIndex = 51;
            this.label38.Text = "Password";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Location = new System.Drawing.Point(180, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(180, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(80, 52);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(89, 20);
            this.label36.TabIndex = 48;
            this.label36.Text = "User Name";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage5.Controls.Add(this.btnViewUser);
            this.tabPage5.Controls.Add(this.label53);
            this.tabPage5.Controls.Add(this.bnDelete);
            this.tabPage5.Controls.Add(this.label50);
            this.tabPage5.Controls.Add(this.label52);
            this.tabPage5.Controls.Add(this.txtAdminpass);
            this.tabPage5.Controls.Add(this.txtUser);
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(533, 345);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Delete User";
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnViewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.Snow;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.Location = new System.Drawing.Point(3, 312);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(54, 29);
            this.btnViewUser.TabIndex = 76;
            this.btnViewUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(35, 117);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(408, 20);
            this.label53.TabIndex = 75;
            this.label53.Text = "Admin Password is the currently logged in user password";
            // 
            // bnDelete
            // 
            this.bnDelete.BackColor = System.Drawing.Color.Transparent;
            this.bnDelete.FlatAppearance.BorderSize = 0;
            this.bnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnDelete.ForeColor = System.Drawing.Color.Snow;
            this.bnDelete.Location = new System.Drawing.Point(285, 160);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(84, 29);
            this.bnDelete.TabIndex = 5;
            this.bnDelete.Text = "Delete";
            this.bnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnDelete.UseVisualStyleBackColor = false;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(51, 84);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(127, 20);
            this.label50.TabIndex = 73;
            this.label50.Text = "Admin Password";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(89, 49);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(89, 20);
            this.label52.TabIndex = 71;
            this.label52.Text = "User Name";
            // 
            // txtAdminpass
            // 
            this.txtAdminpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminpass.Location = new System.Drawing.Point(184, 81);
            this.txtAdminpass.Name = "txtAdminpass";
            this.txtAdminpass.Size = new System.Drawing.Size(185, 26);
            this.txtAdminpass.TabIndex = 2;
            this.txtAdminpass.TextChanged += new System.EventHandler(this.txtAdminpass_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(184, 49);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(185, 26);
            this.txtUser.TabIndex = 0;
            // 
            // ReceiptTab
            // 
            this.ReceiptTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReceiptTab.Controls.Add(this.txtMotto);
            this.ReceiptTab.Controls.Add(this.label4);
            this.ReceiptTab.Controls.Add(this.label3);
            this.ReceiptTab.Controls.Add(this.btnloadImage);
            this.ReceiptTab.Controls.Add(this.lblPictureName);
            this.ReceiptTab.Controls.Add(this.pictureBoxLogo);
            this.ReceiptTab.Controls.Add(this.txtAddress);
            this.ReceiptTab.Controls.Add(this.label1);
            this.ReceiptTab.Controls.Add(this.brnSet);
            this.ReceiptTab.Controls.Add(this.txtName);
            this.ReceiptTab.Controls.Add(this.label2);
            this.ReceiptTab.Location = new System.Drawing.Point(4, 29);
            this.ReceiptTab.Name = "ReceiptTab";
            this.ReceiptTab.Size = new System.Drawing.Size(533, 345);
            this.ReceiptTab.TabIndex = 6;
            this.ReceiptTab.Text = "Set Receipt";
            // 
            // txtMotto
            // 
            this.txtMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotto.Location = new System.Drawing.Point(133, 81);
            this.txtMotto.Name = "txtMotto";
            this.txtMotto.Size = new System.Drawing.Size(227, 26);
            this.txtMotto.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "School Motto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "Abbreviate some";
            // 
            // btnloadImage
            // 
            this.btnloadImage.BackColor = System.Drawing.Color.Black;
            this.btnloadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloadImage.FlatAppearance.BorderSize = 0;
            this.btnloadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnloadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnloadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadImage.ForeColor = System.Drawing.Color.Snow;
            this.btnloadImage.Location = new System.Drawing.Point(366, 212);
            this.btnloadImage.Name = "btnloadImage";
            this.btnloadImage.Size = new System.Drawing.Size(146, 29);
            this.btnloadImage.TabIndex = 60;
            this.btnloadImage.Text = "Load Logo";
            this.btnloadImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnloadImage.UseVisualStyleBackColor = false;
            this.btnloadImage.Click += new System.EventHandler(this.btnloadImage_Click);
            // 
            // lblPictureName
            // 
            this.lblPictureName.AutoSize = true;
            this.lblPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPictureName.Location = new System.Drawing.Point(374, 215);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(104, 20);
            this.lblPictureName.TabIndex = 59;
            this.lblPictureName.Text = "School Name";
            this.lblPictureName.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Location = new System.Drawing.Point(366, 81);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(146, 131);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 58;
            this.pictureBoxLogo.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(135, 124);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 108);
            this.txtAddress.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "School Address";
            // 
            // brnSet
            // 
            this.brnSet.BackColor = System.Drawing.Color.Transparent;
            this.brnSet.FlatAppearance.BorderSize = 0;
            this.brnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.brnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.brnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSet.ForeColor = System.Drawing.Color.Snow;
            this.brnSet.Location = new System.Drawing.Point(147, 259);
            this.brnSet.Name = "brnSet";
            this.brnSet.Size = new System.Drawing.Size(105, 29);
            this.brnSet.TabIndex = 55;
            this.brnSet.Text = "Set";
            this.brnSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brnSet.UseVisualStyleBackColor = false;
            this.brnSet.Click += new System.EventHandler(this.brnSet_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 26);
            this.txtName.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "School Name";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btnImportdata);
            this.tabPage1.Controls.Add(this.btnDbBackup);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtAnswer2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtQuest2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtAnswer1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txQuest1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 345);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Security";
            // 
            // btnImportdata
            // 
            this.btnImportdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportdata.BackColor = System.Drawing.Color.Transparent;
            this.btnImportdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportdata.FlatAppearance.BorderSize = 0;
            this.btnImportdata.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnImportdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnImportdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportdata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportdata.Image = ((System.Drawing.Image)(resources.GetObject("btnImportdata.Image")));
            this.btnImportdata.Location = new System.Drawing.Point(45, 310);
            this.btnImportdata.Name = "btnImportdata";
            this.btnImportdata.Size = new System.Drawing.Size(33, 28);
            this.btnImportdata.TabIndex = 110;
            this.btnImportdata.UseVisualStyleBackColor = false;
            this.btnImportdata.Click += new System.EventHandler(this.btnImportdata_Click);
            // 
            // btnDbBackup
            // 
            this.btnDbBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDbBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnDbBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDbBackup.FlatAppearance.BorderSize = 0;
            this.btnDbBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDbBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDbBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDbBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnDbBackup.Image")));
            this.btnDbBackup.Location = new System.Drawing.Point(4, 310);
            this.btnDbBackup.Name = "btnDbBackup";
            this.btnDbBackup.Size = new System.Drawing.Size(35, 28);
            this.btnDbBackup.TabIndex = 109;
            this.btnDbBackup.UseVisualStyleBackColor = false;
            this.btnDbBackup.Click += new System.EventHandler(this.btnDbBackup_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(443, 298);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(65, 29);
            this.btnSubmit.TabIndex = 106;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(113, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(349, 20);
            this.label14.TabIndex = 105;
            this.label14.Text = "Set Security questions for password reset.";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(27, 239);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(484, 26);
            this.txtAnswer2.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(23, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "Answer";
            // 
            // txtQuest2
            // 
            this.txtQuest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuest2.Location = new System.Drawing.Point(27, 186);
            this.txtQuest2.Name = "txtQuest2";
            this.txtQuest2.Size = new System.Drawing.Size(484, 26);
            this.txtQuest2.TabIndex = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(23, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 102;
            this.label11.Text = "Question 2:";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(27, 123);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(484, 26);
            this.txtAnswer1.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(23, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 100;
            this.label12.Text = "Answer";
            // 
            // txQuest1
            // 
            this.txQuest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuest1.Location = new System.Drawing.Point(27, 72);
            this.txQuest1.Name = "txQuest1";
            this.txQuest1.Size = new System.Drawing.Size(484, 26);
            this.txQuest1.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(23, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 98;
            this.label13.Text = "Question 1:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelsetting);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panHead.ResumeLayout(false);
            this.panelsetting.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ReceiptTab.ResumeLayout(false);
            this.ReceiptTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Panel panelsetting;
        private System.Windows.Forms.Button btnViewActivity;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSetSession;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Button btnEventFee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtAdminpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnSetFees;
        private System.Windows.Forms.TabPage ReceiptTab;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnSet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnViewSetFees;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblPictureName;
        private System.Windows.Forms.Button btnloadImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViewUser;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcreateUserAdmin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuest2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txQuest1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDeleteLogs;
        private System.Windows.Forms.Button btnImportdata;
        private System.Windows.Forms.Button btnDbBackup;
        }
    }