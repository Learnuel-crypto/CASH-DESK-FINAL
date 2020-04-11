namespace WindowsFormsApplication1
    {
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnClassView = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEventClassId = new System.Windows.Forms.TextBox();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEventFeeName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtEventAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridEvents = new System.Windows.Forms.DataGridView();
            this.Event_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listEventClass = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.txtEdithClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.combClass = new System.Windows.Forms.ComboBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 22);
            this.panel1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Events";
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
            this.button4.Location = new System.Drawing.Point(914, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.White;
            this.btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Black;
            this.btndel.Location = new System.Drawing.Point(155, 219);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(98, 29);
            this.btndel.TabIndex = 73;
            this.btndel.Text = "Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnClassView
            // 
            this.btnClassView.BackColor = System.Drawing.Color.White;
            this.btnClassView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClassView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnClassView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassView.ForeColor = System.Drawing.Color.Black;
            this.btnClassView.Location = new System.Drawing.Point(259, 366);
            this.btnClassView.Name = "btnClassView";
            this.btnClassView.Size = new System.Drawing.Size(96, 29);
            this.btnClassView.TabIndex = 72;
            this.btnClassView.Text = "Add Class";
            this.btnClassView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClassView.UseVisualStyleBackColor = false;
            this.btnClassView.Click += new System.EventHandler(this.btnClassView_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Event Name";
            // 
            // txtEventClassId
            // 
            this.txtEventClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventClassId.Location = new System.Drawing.Point(563, 316);
            this.txtEventClassId.Name = "txtEventClassId";
            this.txtEventClassId.Size = new System.Drawing.Size(80, 26);
            this.txtEventClassId.TabIndex = 61;
            this.txtEventClassId.Visible = false;
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.White;
            this.btnaddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnaddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.Black;
            this.btnaddnew.Location = new System.Drawing.Point(266, 184);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(98, 29);
            this.btnaddnew.TabIndex = 71;
            this.btnaddnew.Text = "Add New";
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(146, 33);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(91, 26);
            this.txtEventID.TabIndex = 60;
            this.txtEventID.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(266, 219);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 29);
            this.btnCreate.TabIndex = 70;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.White;
            this.btnUpdateEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateEvent.Location = new System.Drawing.Point(266, 254);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(98, 29);
            this.btnUpdateEvent.TabIndex = 68;
            this.btnUpdateEvent.Text = "Update";
            this.btnUpdateEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Add Class To Event";
            // 
            // txtEventFeeName
            // 
            this.txtEventFeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventFeeName.Location = new System.Drawing.Point(125, 109);
            this.txtEventFeeName.Name = "txtEventFeeName";
            this.txtEventFeeName.Size = new System.Drawing.Size(260, 26);
            this.txtEventFeeName.TabIndex = 65;
            this.txtEventFeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEventFeeName_KeyPress);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.White;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(32, 326);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(94, 20);
            this.lblClass.TabIndex = 67;
            this.lblClass.Text = "Class Name";
            // 
            // txtEventAmount
            // 
            this.txtEventAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventAmount.Location = new System.Drawing.Point(125, 142);
            this.txtEventAmount.Name = "txtEventAmount";
            this.txtEventAmount.Size = new System.Drawing.Size(189, 29);
            this.txtEventAmount.TabIndex = 64;
            this.txtEventAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEventAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Fee Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(392, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 40);
            this.panel2.TabIndex = 74;
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // dataGridEvents
            // 
            this.dataGridEvents.AllowUserToAddRows = false;
            this.dataGridEvents.AllowUserToDeleteRows = false;
            this.dataGridEvents.AllowUserToResizeColumns = false;
            this.dataGridEvents.AllowUserToResizeRows = false;
            this.dataGridEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridEvents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event_ID,
            this.Event_Name,
            this.Fee_Name,
            this.Amount,
            this.Date});
            this.dataGridEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEvents.Location = new System.Drawing.Point(391, 72);
            this.dataGridEvents.MultiSelect = false;
            this.dataGridEvents.Name = "dataGridEvents";
            this.dataGridEvents.ReadOnly = true;
            this.dataGridEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEvents.Size = new System.Drawing.Size(536, 237);
            this.dataGridEvents.StandardTab = true;
            this.dataGridEvents.TabIndex = 75;
            this.dataGridEvents.Click += new System.EventHandler(this.dataGridEvents_Click);
            // 
            // Event_ID
            // 
            this.Event_ID.HeaderText = "ID";
            this.Event_ID.Name = "Event_ID";
            this.Event_ID.ReadOnly = true;
            this.Event_ID.Visible = false;
            this.Event_ID.Width = 46;
            // 
            // Event_Name
            // 
            this.Event_Name.HeaderText = "Event Name";
            this.Event_Name.Name = "Event_Name";
            this.Event_Name.ReadOnly = true;
            this.Event_Name.Width = 121;
            // 
            // Fee_Name
            // 
            this.Fee_Name.HeaderText = "Fee Name";
            this.Fee_Name.Name = "Fee_Name";
            this.Fee_Name.ReadOnly = true;
            this.Fee_Name.Width = 108;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 90;
            // 
            // Date
            // 
            this.Date.HeaderText = "Set Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 98;
            // 
            // listEventClass
            // 
            this.listEventClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEventClass.FormattingEnabled = true;
            this.listEventClass.ItemHeight = 20;
            this.listEventClass.Location = new System.Drawing.Point(431, 350);
            this.listEventClass.Name = "listEventClass";
            this.listEventClass.Size = new System.Drawing.Size(212, 204);
            this.listEventClass.TabIndex = 76;
            this.listEventClass.Click += new System.EventHandler(this.listEventClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Event Class";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.White;
            this.btnUpdateClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClass.Location = new System.Drawing.Point(657, 409);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(80, 29);
            this.btnUpdateClass.TabIndex = 80;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Visible = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // txtEdithClass
            // 
            this.txtEdithClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdithClass.Location = new System.Drawing.Point(657, 368);
            this.txtEdithClass.Name = "txtEdithClass";
            this.txtEdithClass.ReadOnly = true;
            this.txtEdithClass.Size = new System.Drawing.Size(230, 26);
            this.txtEdithClass.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Class";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.combClass);
            this.panel3.Controls.Add(this.btnPdf);
            this.panel3.Controls.Add(this.txtEdithClass);
            this.panel3.Controls.Add(this.btnUpdateClass);
            this.panel3.Controls.Add(this.dataGridEvents);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtEventAmount);
            this.panel3.Controls.Add(this.txtEventFeeName);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.txtEventName);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblClass);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnClassView);
            this.panel3.Controls.Add(this.btndel);
            this.panel3.Controls.Add(this.btnUpdateEvent);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Controls.Add(this.btnaddnew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 560);
            this.panel3.TabIndex = 81;
            // 
            // combClass
            // 
            this.combClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combClass.FormattingEnabled = true;
            this.combClass.Location = new System.Drawing.Point(153, 323);
            this.combClass.Name = "combClass";
            this.combClass.Size = new System.Drawing.Size(202, 28);
            this.combClass.TabIndex = 89;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.White;
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.Black;
            this.btnPdf.Location = new System.Drawing.Point(155, 254);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(98, 29);
            this.btnPdf.TabIndex = 85;
            this.btnPdf.Text = "PDF";
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(743, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 29);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(125, 76);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(260, 26);
            this.txtEventName.TabIndex = 84;
            this.txtEventName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEventName_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 26);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(69, 179);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 82;
            this.lblDate.Text = "Date";
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEventClass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEventClassId);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnClassView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEventClassId;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEventFeeName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtEventAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridEvents;
        private System.Windows.Forms.ListBox listEventClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.TextBox txtEdithClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ComboBox combClass;
    }
    }