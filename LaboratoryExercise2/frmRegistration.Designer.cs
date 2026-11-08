namespace LaboratoryExercise2
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpBirthday = new DateTimePicker();
            txtAge = new TextBox();
            txtLastname = new TextBox();
            txtStudentNo = new TextBox();
            label6 = new Label();
            txtContactNo = new TextBox();
            label7 = new Label();
            cmbProgram = new ComboBox();
            label8 = new Label();
            txtFirstname = new TextBox();
            label9 = new Label();
            cmbGender = new ComboBox();
            label10 = new Label();
            txtMi = new TextBox();
            btnRegister = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 97);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 139);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 178);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(88, 172);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(88, 131);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 6;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(88, 89);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(161, 23);
            txtLastname.TabIndex = 7;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(88, 52);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(161, 23);
            txtStudentNo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 60);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 9;
            label6.Text = "Program";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(380, 172);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(100, 23);
            txtContactNo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 178);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 11;
            label7.Text = "Contact No";
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(340, 52);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(228, 23);
            cmbProgram.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 92);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 13;
            label8.Text = "First Name";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(340, 89);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(150, 23);
            txtFirstname.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 139);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(340, 136);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(71, 23);
            cmbGender.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(496, 97);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 17;
            label10.Text = "M.I.";
            // 
            // txtMi
            // 
            txtMi.Location = new Point(529, 92);
            txtMi.Name = "txtMi";
            txtMi.Size = new Size(40, 23);
            txtMi.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(230, 236);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(493, 236);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(75, 23);
            btnRecords.TabIndex = 20;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 283);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(txtMi);
            Controls.Add(label10);
            Controls.Add(cmbGender);
            Controls.Add(label9);
            Controls.Add(txtFirstname);
            Controls.Add(label8);
            Controls.Add(cmbProgram);
            Controls.Add(label7);
            Controls.Add(txtContactNo);
            Controls.Add(label6);
            Controls.Add(txtStudentNo);
            Controls.Add(txtLastname);
            Controls.Add(txtAge);
            Controls.Add(dtpBirthday);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "frmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpBirthday;
        private TextBox txtAge;
        private TextBox txtLastname;
        private TextBox txtStudentNo;
        private Label label6;
        private TextBox txtContactNo;
        private Label label7;
        private ComboBox cmbProgram;
        private Label label8;
        private TextBox txtFirstname;
        private Label label9;
        private ComboBox cmbGender;
        private Label label10;
        private TextBox txtMi;
        private Button btnRegister;
        private Button btnRecords;
    }
}