namespace mini选课习题.StudentRegister
{
    partial class userRegist
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
            label6 = new Label();
            textBox1 = new TextBox();
            rBman = new RadioButton();
            rBfemal = new RadioButton();
            tbPasswd = new TextBox();
            tbpasswdCheck = new TextBox();
            cbDepartment = new ComboBox();
            cbMajor = new ComboBox();
            btcommit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 60);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "学生姓名：";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 167);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "密码：";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 116);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 0;
            label3.Text = "性别：";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 222);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 0;
            label4.Text = "再次输入密码：";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(96, 278);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "所在院系：";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 331);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 0;
            label6.Text = "所属专业：";
            label6.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // rBman
            // 
            rBman.AutoSize = true;
            rBman.Location = new Point(271, 115);
            rBman.Name = "rBman";
            rBman.Size = new Size(38, 21);
            rBman.TabIndex = 2;
            rBman.TabStop = true;
            rBman.Text = "男";
            rBman.UseVisualStyleBackColor = true;
            // 
            // rBfemal
            // 
            rBfemal.AutoSize = true;
            rBfemal.Location = new Point(410, 115);
            rBfemal.Name = "rBfemal";
            rBfemal.Size = new Size(38, 21);
            rBfemal.TabIndex = 2;
            rBfemal.TabStop = true;
            rBfemal.Text = "女";
            rBfemal.UseVisualStyleBackColor = true;
            // 
            // tbPasswd
            // 
            tbPasswd.Location = new Point(237, 164);
            tbPasswd.Name = "tbPasswd";
            tbPasswd.PasswordChar = '*';
            tbPasswd.Size = new Size(361, 23);
            tbPasswd.TabIndex = 3;
            tbPasswd.TextChanged += textBox2_TextChanged;
            // 
            // tbpasswdCheck
            // 
            tbpasswdCheck.Location = new Point(237, 219);
            tbpasswdCheck.Name = "tbpasswdCheck";
            tbpasswdCheck.PasswordChar = '*';
            tbpasswdCheck.Size = new Size(361, 23);
            tbpasswdCheck.TabIndex = 4;
            // 
            // cbDepartment
            // 
            cbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "软件学院", "石油工程学院", "计算机学院" });
            cbDepartment.Location = new Point(237, 273);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(361, 25);
            cbDepartment.TabIndex = 5;
            cbDepartment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbMajor
            // 
            cbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMajor.FormattingEnabled = true;
            cbMajor.Location = new Point(237, 326);
            cbMajor.Name = "cbMajor";
            cbMajor.Size = new Size(361, 25);
            cbMajor.TabIndex = 6;
            // 
            // btcommit
            // 
            btcommit.Location = new Point(333, 376);
            btcommit.Name = "btcommit";
            btcommit.Size = new Size(105, 35);
            btcommit.TabIndex = 7;
            btcommit.Text = "提交";
            btcommit.UseVisualStyleBackColor = true;
            btcommit.Click += btcommit_Click;
            // 
            // userRegist
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 433);
            Controls.Add(btcommit);
            Controls.Add(cbMajor);
            Controls.Add(cbDepartment);
            Controls.Add(rBfemal);
            Controls.Add(rBman);
            Controls.Add(tbpasswdCheck);
            Controls.Add(tbPasswd);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "userRegist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userRegist";
            Load += userRegist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private RadioButton rBman;
        private RadioButton rBfemal;
        private TextBox tbPasswd;
        private TextBox tbpasswdCheck;
        private ComboBox cbDepartment;
        private ComboBox cbMajor;
        private Button btcommit;
    }
}