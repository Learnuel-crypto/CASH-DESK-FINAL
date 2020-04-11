namespace WindowsFormsApplication1
{
    partial class Payfees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payfees));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioCurrent = new System.Windows.Forms.RadioButton();
            this.radioDebt = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panyear = new System.Windows.Forms.Panel();
            this.txtdebtyear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panyear.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fee Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Names";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date";
            // 
            // radioCurrent
            // 
            this.radioCurrent.AutoSize = true;
            this.radioCurrent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCurrent.Location = new System.Drawing.Point(560, 162);
            this.radioCurrent.Name = "radioCurrent";
            this.radioCurrent.Size = new System.Drawing.Size(88, 25);
            this.radioCurrent.TabIndex = 1;
            this.radioCurrent.TabStop = true;
            this.radioCurrent.Text = "Current";
            this.radioCurrent.UseVisualStyleBackColor = true;
            this.radioCurrent.CheckedChanged += new System.EventHandler(this.radioCurrent_CheckedChanged);
            // 
            // radioDebt
            // 
            this.radioDebt.AutoSize = true;
            this.radioDebt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDebt.Location = new System.Drawing.Point(473, 162);
            this.radioDebt.Name = "radioDebt";
            this.radioDebt.Size = new System.Drawing.Size(68, 25);
            this.radioDebt.TabIndex = 1;
            this.radioDebt.TabStop = true;
            this.radioDebt.Text = "Debt";
            this.radioDebt.UseVisualStyleBackColor = true;
            this.radioDebt.CheckedChanged += new System.EventHandler(this.radioDebt_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 29);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(238, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 29);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(473, 106);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(126, 29);
            this.comboBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 27);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(712, 109);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(88, 29);
            this.comboBox5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Intallment";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(119, 109);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(198, 29);
            this.comboBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fee Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(408, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(203, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.panyear);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioCurrent);
            this.groupBox1.Controls.Add(this.radioDebt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 478);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Class";
            // 
            // panyear
            // 
            this.panyear.Controls.Add(this.txtdebtyear);
            this.panyear.Controls.Add(this.label8);
            this.panyear.Location = new System.Drawing.Point(473, 193);
            this.panyear.Name = "panyear";
            this.panyear.Size = new System.Drawing.Size(140, 80);
            this.panyear.TabIndex = 7;
            this.panyear.Visible = false;
            // 
            // txtdebtyear
            // 
            this.txtdebtyear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdebtyear.Location = new System.Drawing.Point(16, 34);
            this.txtdebtyear.Name = "txtdebtyear";
            this.txtdebtyear.Size = new System.Drawing.Size(110, 27);
            this.txtdebtyear.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter Year";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(1111, 33);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 29);
            this.button10.TabIndex = 40;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Payfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payfees";
            this.Size = new System.Drawing.Size(1172, 628);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panyear.ResumeLayout(false);
            this.panyear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioCurrent;
        private System.Windows.Forms.RadioButton radioDebt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panyear;
        private System.Windows.Forms.TextBox txtdebtyear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
    }
}
