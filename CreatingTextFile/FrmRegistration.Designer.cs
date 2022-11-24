namespace CreatingTextFile
{
    partial class FrmRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbStudNo = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.bdayPicker = new System.Windows.Forms.DateTimePicker();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbMI = new System.Windows.Forms.TextBox();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Program";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "M. I.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Contact No";
            // 
            // tbStudNo
            // 
            this.tbStudNo.Location = new System.Drawing.Point(115, 96);
            this.tbStudNo.Name = "tbStudNo";
            this.tbStudNo.Size = new System.Drawing.Size(161, 20);
            this.tbStudNo.TabIndex = 10;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(115, 153);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(136, 20);
            this.tbLname.TabIndex = 11;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(115, 203);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(59, 20);
            this.tbAge.TabIndex = 12;
            // 
            // bdayPicker
            // 
            this.bdayPicker.Location = new System.Drawing.Point(115, 251);
            this.bdayPicker.Name = "bdayPicker";
            this.bdayPicker.Size = new System.Drawing.Size(179, 20);
            this.bdayPicker.TabIndex = 13;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSMMA",
            "BSBA"});
            this.cbProgram.Location = new System.Drawing.Point(392, 100);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(180, 21);
            this.cbProgram.TabIndex = 14;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cbGender.Location = new System.Drawing.Point(392, 207);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(78, 21);
            this.cbGender.TabIndex = 15;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(392, 150);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(136, 20);
            this.tbFname.TabIndex = 16;
            // 
            // tbMI
            // 
            this.tbMI.Location = new System.Drawing.Point(571, 150);
            this.tbMI.Name = "tbMI";
            this.tbMI.Size = new System.Drawing.Size(37, 20);
            this.tbMI.TabIndex = 17;
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(392, 258);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(136, 20);
            this.tbContactNo.TabIndex = 18;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(296, 306);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbContactNo);
            this.Controls.Add(this.tbMI);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.bdayPicker);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbStudNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbStudNo;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.DateTimePicker bdayPicker;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbMI;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
    }
}