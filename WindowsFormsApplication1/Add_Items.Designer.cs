namespace WindowsFormsApplication1
    {
    partial class Add_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panHead = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSeachBox = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeAdded = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkTotalAmount = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHowtoUpdate = new System.Windows.Forms.Button();
            this.dataGridItmes = new System.Windows.Forms.DataGridView();
            this.Item_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClick = new System.Windows.Forms.Label();
            this.lblinfor = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Infortimer = new System.Windows.Forms.Timer(this.components);
            this.how_to_Update_items1 = new WindowsFormsApplication1.how_to_Update_items();
            this.panHead.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItmes)).BeginInit();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panHead.Controls.Add(this.label5);
            this.panHead.Controls.Add(this.btnClose);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1006, 22);
            this.panHead.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(475, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Add Item";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(980, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 22);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSeachBox
            // 
            this.txtSeachBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachBox.Location = new System.Drawing.Point(346, 34);
            this.txtSeachBox.Name = "txtSeachBox";
            this.txtSeachBox.Size = new System.Drawing.Size(402, 26);
            this.txtSeachBox.TabIndex = 11;
            this.txtSeachBox.Text = "Search";
            this.txtSeachBox.Click += new System.EventHandler(this.txtSeachBox_Click);
            this.txtSeachBox.TextChanged += new System.EventHandler(this.txtSeachBox_TextChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(16, 60);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(317, 26);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Text = "Enter item name";
            this.txtItemName.Click += new System.EventHandler(this.txtItemName_Click);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(775, 35);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(121, 26);
            this.dateTimeFrom.TabIndex = 12;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 107;
            this.label6.Text = "Item name";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(106, 158);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(114, 29);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(107, 125);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(114, 26);
            this.txtquantity.TabIndex = 1;
            this.txtquantity.Text = "0";
            this.txtquantity.Click += new System.EventHandler(this.txtquantity_Click);
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "Selling Price";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(107, 92);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(114, 26);
            this.txtSellingPrice.TabIndex = 2;
            this.txtSellingPrice.Text = "0";
            this.txtSellingPrice.Click += new System.EventHandler(this.txtSellingPrice_Click);
            this.txtSellingPrice.TextChanged += new System.EventHandler(this.txtSellingPrice_TextChanged);
            this.txtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingPrice_KeyPress);
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.White;
            this.btnaddnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnaddnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.Color.Black;
            this.btnaddnew.Location = new System.Drawing.Point(228, 91);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(105, 29);
            this.btnaddnew.TabIndex = 5;
            this.btnaddnew.Text = "Clear";
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Date";
            // 
            // dateTimeAdded
            // 
            this.dateTimeAdded.CustomFormat = "dd-mm-yyyyy";
            this.dateTimeAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAdded.Location = new System.Drawing.Point(106, 195);
            this.dateTimeAdded.Name = "dateTimeAdded";
            this.dateTimeAdded.Size = new System.Drawing.Size(114, 26);
            this.dateTimeAdded.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(228, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(228, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(228, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(228, 256);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 29);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(14, 262);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 122;
            this.lblTotal.Text = "label4";
            this.lblTotal.Visible = false;
            // 
            // checkTotalAmount
            // 
            this.checkTotalAmount.AutoSize = true;
            this.checkTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotalAmount.Location = new System.Drawing.Point(16, 231);
            this.checkTotalAmount.Name = "checkTotalAmount";
            this.checkTotalAmount.Size = new System.Drawing.Size(60, 22);
            this.checkTotalAmount.TabIndex = 10;
            this.checkTotalAmount.Text = "Total";
            this.checkTotalAmount.UseVisualStyleBackColor = true;
            this.checkTotalAmount.Click += new System.EventHandler(this.checkTotalAmount_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStock);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.how_to_Update_items1);
            this.panel2.Controls.Add(this.btnHowtoUpdate);
            this.panel2.Controls.Add(this.dataGridItmes);
            this.panel2.Controls.Add(this.lblClick);
            this.panel2.Controls.Add(this.lblinfor);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.txtSeachBox);
            this.panel2.Controls.Add(this.txtquantity);
            this.panel2.Controls.Add(this.txtSellingPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 562);
            this.panel2.TabIndex = 123;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Black;
            this.btnStock.Location = new System.Drawing.Point(227, 222);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(105, 29);
            this.btnStock.TabIndex = 124;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(143, 228);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 29);
            this.btnRefresh.TabIndex = 124;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHowtoUpdate
            // 
            this.btnHowtoUpdate.AutoSize = true;
            this.btnHowtoUpdate.BackColor = System.Drawing.Color.White;
            this.btnHowtoUpdate.FlatAppearance.BorderSize = 0;
            this.btnHowtoUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnHowtoUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnHowtoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowtoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowtoUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnHowtoUpdate.Location = new System.Drawing.Point(11, 529);
            this.btnHowtoUpdate.Name = "btnHowtoUpdate";
            this.btnHowtoUpdate.Size = new System.Drawing.Size(104, 26);
            this.btnHowtoUpdate.TabIndex = 128;
            this.btnHowtoUpdate.Text = "How to update";
            this.btnHowtoUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHowtoUpdate.UseVisualStyleBackColor = false;
            this.btnHowtoUpdate.Click += new System.EventHandler(this.btnHowtoUpdate_Click);
            // 
            // dataGridItmes
            // 
            this.dataGridItmes.AllowUserToAddRows = false;
            this.dataGridItmes.AllowUserToDeleteRows = false;
            this.dataGridItmes.AllowUserToOrderColumns = true;
            this.dataGridItmes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridItmes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridItmes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridItmes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridItmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Id,
            this.Item_Name,
            this.Qty_Avail,
            this.Selling_Price,
            this.Amount,
            this.Date,
            this.Updated});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridItmes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridItmes.Location = new System.Drawing.Point(346, 67);
            this.dataGridItmes.Name = "dataGridItmes";
            this.dataGridItmes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridItmes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridItmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItmes.Size = new System.Drawing.Size(655, 482);
            this.dataGridItmes.TabIndex = 104;
            this.dataGridItmes.Click += new System.EventHandler(this.dataGridItmes_Click_1);
            // 
            // Item_Id
            // 
            this.Item_Id.HeaderText = "Item_Id";
            this.Item_Id.Name = "Item_Id";
            this.Item_Id.ReadOnly = true;
            this.Item_Id.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 122;
            // 
            // Qty_Avail
            // 
            this.Qty_Avail.HeaderText = "Qty";
            this.Qty_Avail.Name = "Qty_Avail";
            this.Qty_Avail.ReadOnly = true;
            // 
            // Selling_Price
            // 
            this.Selling_Price.HeaderText = "Selling Price";
            this.Selling_Price.Name = "Selling_Price";
            this.Selling_Price.ReadOnly = true;
            this.Selling_Price.Width = 123;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 123;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 69;
            // 
            // Updated
            // 
            this.Updated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Updated.HeaderText = "Updated";
            this.Updated.Name = "Updated";
            this.Updated.ReadOnly = true;
            this.Updated.Width = 96;
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.BackColor = System.Drawing.Color.Transparent;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.ForeColor = System.Drawing.Color.Blue;
            this.lblClick.Location = new System.Drawing.Point(667, 39);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(67, 16);
            this.lblClick.TabIndex = 103;
            this.lblClick.Text = "Click here";
            this.lblClick.Visible = false;
            this.lblClick.Click += new System.EventHandler(this.lblClick_Click);
            // 
            // lblinfor
            // 
            this.lblinfor.AutoSize = true;
            this.lblinfor.BackColor = System.Drawing.Color.Transparent;
            this.lblinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfor.ForeColor = System.Drawing.Color.Blue;
            this.lblinfor.Location = new System.Drawing.Point(238, 35);
            this.lblinfor.Name = "lblinfor";
            this.lblinfor.Size = new System.Drawing.Size(91, 20);
            this.lblinfor.TabIndex = 35;
            this.lblinfor.Text = "Succesful...";
            this.lblinfor.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Infortimer
            // 
            this.Infortimer.Tick += new System.EventHandler(this.Infortimer_Tick);
            // 
            // how_to_Update_items1
            // 
            this.how_to_Update_items1.BackColor = System.Drawing.Color.White;
            this.how_to_Update_items1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.how_to_Update_items1.Location = new System.Drawing.Point(3, 318);
            this.how_to_Update_items1.Name = "how_to_Update_items1";
            this.how_to_Update_items1.Size = new System.Drawing.Size(261, 211);
            this.how_to_Update_items1.TabIndex = 129;
            this.how_to_Update_items1.Visible = false;
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 562);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkTotalAmount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimeAdded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Items";
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSeachBox;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeAdded;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkTotalAmount;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblinfor;
        private System.Windows.Forms.Timer Infortimer;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.DataGridView dataGridItmes;
        private how_to_Update_items how_to_Update_items1;
        private System.Windows.Forms.Button btnHowtoUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updated;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStock;
        }
    }