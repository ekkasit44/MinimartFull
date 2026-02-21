namespace MinimartMIS
{
    partial class frmEditEmployees
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
            btnSave = new Button();
            label7 = new Label();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cboPosition = new ComboBox();
            cboTitle = new ComboBox();
            txtUsername = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label9 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtEmployeeID = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(164, 377);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 26);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(160, 404);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 43;
            label7.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(281, 377);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 26);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboPosition);
            groupBox1.Controls.Add(cboTitle);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmployeeID);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(35, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(480, 356);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "จัดการข้อมูลพนักงาน";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(129, 292);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(228, 26);
            txtConfirmPassword.TabIndex = 23;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 254);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 26);
            txtPassword.TabIndex = 22;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 292);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 21;
            label6.Text = "ยืนยันรหัสผ่าน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 257);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 20;
            label5.Text = "รหัสผ่าน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 222);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 19;
            label4.Text = "ชื่อผู้ใช้";
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(129, 180);
            cboPosition.Margin = new Padding(4);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(228, 28);
            cboPosition.TabIndex = 18;
            // 
            // cboTitle
            // 
            cboTitle.FormattingEnabled = true;
            cboTitle.Location = new Point(129, 72);
            cboTitle.Margin = new Padding(4);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(228, 28);
            cboTitle.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 216);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(228, 26);
            txtUsername.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 149);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 15;
            label8.Text = "นามสกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 14;
            label3.Text = "ชื่อ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(129, 146);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(228, 26);
            txtLastName.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 183);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 3;
            label9.Text = "ตำแหน่ง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "คำนำหน้า";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(129, 109);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(228, 26);
            txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสพนักงาน";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Enabled = false;
            txtEmployeeID.Location = new Point(129, 36);
            txtEmployeeID.Margin = new Padding(4);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(162, 26);
            txtEmployeeID.TabIndex = 0;
            // 
            // frmEditEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(groupBox1);
            Name = "frmEditEmployees";
            Text = "frmEditEmployees";
            Load += frmEditEmployees_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label7;
        private Button btnClear;
        private GroupBox groupBox1;
        private ComboBox cboTitle;
        private TextBox txtUsername;
        private Label label8;
        private Label label3;
        private TextBox txtLastName;
        private Label label9;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtEmployeeID;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboPosition;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
    }
}