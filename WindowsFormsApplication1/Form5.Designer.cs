namespace WindowsFormsApplication1
{
    partial class ExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            this.btnrecordExpense = new System.Windows.Forms.Button();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtexpensename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panDrag = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panDrag.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrecordExpense
            // 
            this.btnrecordExpense.BackColor = System.Drawing.Color.Blue;
            this.btnrecordExpense.FlatAppearance.BorderSize = 0;
            this.btnrecordExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnrecordExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnrecordExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecordExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecordExpense.ForeColor = System.Drawing.Color.Snow;
            this.btnrecordExpense.Location = new System.Drawing.Point(170, 210);
            this.btnrecordExpense.Name = "btnrecordExpense";
            this.btnrecordExpense.Size = new System.Drawing.Size(77, 29);
            this.btnrecordExpense.TabIndex = 53;
            this.btnrecordExpense.Text = "Record";
            this.btnrecordExpense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnrecordExpense.UseVisualStyleBackColor = false;
            this.btnrecordExpense.Click += new System.EventHandler(this.btnrecordExpense_Click);
            // 
            // txtcost
            // 
            this.txtcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.Location = new System.Drawing.Point(115, 92);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(140, 26);
            this.txtcost.TabIndex = 48;
            this.txtcost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcost_KeyDown);
            this.txtcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcost_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Cost";
            // 
            // txtexpensename
            // 
            this.txtexpensename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpensename.Location = new System.Drawing.Point(115, 49);
            this.txtexpensename.Name = "txtexpensename";
            this.txtexpensename.Size = new System.Drawing.Size(254, 26);
            this.txtexpensename.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Expense";
            // 
            // panDrag
            // 
            this.panDrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panDrag.Controls.Add(this.label5);
            this.panDrag.Controls.Add(this.btnclose);
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDrag.Location = new System.Drawing.Point(0, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(382, 22);
            this.panDrag.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Expense";
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
            this.btnclose.Location = new System.Drawing.Point(356, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 22);
            this.btnclose.TabIndex = 19;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dateTimeDate);
            this.metroPanel1.Controls.Add(this.btnrecordExpense);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.txtcost);
            this.metroPanel1.Controls.Add(this.txtexpensename);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(382, 285);
            this.metroPanel1.TabIndex = 54;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CustomFormat = "yyy-mm-dd";
            this.dateTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(122, 143);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(125, 26);
            this.dateTimeDate.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Date";
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 285);
            this.Controls.Add(this.panDrag);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.ExpenseForm_Load);
            this.panDrag.ResumeLayout(false);
            this.panDrag.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrecordExpense;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtexpensename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panDrag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeDate;

    }
}