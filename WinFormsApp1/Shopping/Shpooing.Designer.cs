namespace mini选课习题.Shopping
{
    partial class Shpooing
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
            groupBox1 = new GroupBox();
            tbPhoneNumber = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            groupBox6 = new GroupBox();
            lbgoods = new ListBox();
            groupBox5 = new GroupBox();
            lbselect = new ListBox();
            cbselect = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            rbAlipay = new RadioButton();
            rbWechat = new RadioButton();
            groupBox4 = new GroupBox();
            cbEmail = new CheckBox();
            cbLine = new CheckBox();
            cbPhone = new CheckBox();
            btConfirm = new Button();
            btExit = new Button();
            tbInformation = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPhoneNumber);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "顾客信息";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(287, 30);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(147, 23);
            tbPhoneNumber.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(73, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(147, 23);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 33);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 0;
            label2.Text = "电话：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(cbselect);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(22, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "商品列表";
            // 
            // button6
            // 
            button6.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(194, 239);
            button6.Name = "button6";
            button6.Size = new Size(81, 39);
            button6.TabIndex = 3;
            button6.Text = "<<";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(193, 192);
            button5.Name = "button5";
            button5.Size = new Size(81, 38);
            button5.TabIndex = 3;
            button5.Text = ">>";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(192, 145);
            button4.Name = "button4";
            button4.Size = new Size(83, 36);
            button4.TabIndex = 3;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(191, 97);
            button3.Name = "button3";
            button3.Size = new Size(85, 40);
            button3.TabIndex = 3;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbgoods);
            groupBox6.Location = new Point(20, 81);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(156, 205);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "商品列表";
            // 
            // lbgoods
            // 
            lbgoods.FormattingEnabled = true;
            lbgoods.ItemHeight = 17;
            lbgoods.Location = new Point(15, 28);
            lbgoods.Name = "lbgoods";
            lbgoods.Size = new Size(127, 157);
            lbgoods.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbselect);
            groupBox5.Location = new Point(285, 83);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(159, 205);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "已选商品列表";
            // 
            // lbselect
            // 
            lbselect.FormattingEnabled = true;
            lbselect.ItemHeight = 17;
            lbselect.Location = new Point(16, 28);
            lbselect.Name = "lbselect";
            lbselect.Size = new Size(130, 157);
            lbselect.TabIndex = 0;
            // 
            // cbselect
            // 
            cbselect.FormattingEnabled = true;
            cbselect.Items.AddRange(new object[] { "电脑配件", "摄影器材", "图书" });
            cbselect.Location = new Point(118, 34);
            cbselect.Name = "cbselect";
            cbselect.Size = new Size(152, 25);
            cbselect.TabIndex = 1;
            cbselect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 37);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 0;
            label3.Text = "商品信息：";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbAlipay);
            groupBox3.Controls.Add(rbWechat);
            groupBox3.Location = new Point(31, 437);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(149, 120);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "付款方式";
            // 
            // rbAlipay
            // 
            rbAlipay.AutoSize = true;
            rbAlipay.Location = new Point(23, 75);
            rbAlipay.Name = "rbAlipay";
            rbAlipay.Size = new Size(62, 21);
            rbAlipay.TabIndex = 0;
            rbAlipay.TabStop = true;
            rbAlipay.Text = "支付宝";
            rbAlipay.UseVisualStyleBackColor = true;
            // 
            // rbWechat
            // 
            rbWechat.AutoSize = true;
            rbWechat.Location = new Point(23, 35);
            rbWechat.Name = "rbWechat";
            rbWechat.Size = new Size(50, 21);
            rbWechat.TabIndex = 0;
            rbWechat.TabStop = true;
            rbWechat.Text = "微信";
            rbWechat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbEmail);
            groupBox4.Controls.Add(cbLine);
            groupBox4.Controls.Add(cbPhone);
            groupBox4.Location = new Point(216, 437);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(137, 120);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "确认方式";
            // 
            // cbEmail
            // 
            cbEmail.AutoSize = true;
            cbEmail.Location = new Point(25, 83);
            cbEmail.Name = "cbEmail";
            cbEmail.Size = new Size(58, 21);
            cbEmail.TabIndex = 1;
            cbEmail.Text = "Email";
            cbEmail.UseVisualStyleBackColor = true;
            // 
            // cbLine
            // 
            cbLine.AutoSize = true;
            cbLine.Location = new Point(25, 52);
            cbLine.Name = "cbLine";
            cbLine.Size = new Size(51, 21);
            cbLine.TabIndex = 1;
            cbLine.Text = "传真";
            cbLine.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            cbPhone.AutoSize = true;
            cbPhone.Location = new Point(25, 25);
            cbPhone.Name = "cbPhone";
            cbPhone.Size = new Size(51, 21);
            cbPhone.TabIndex = 0;
            cbPhone.Text = "电话";
            cbPhone.UseVisualStyleBackColor = true;
            // 
            // btConfirm
            // 
            btConfirm.Location = new Point(382, 455);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(100, 42);
            btConfirm.TabIndex = 4;
            btConfirm.Text = "确定";
            btConfirm.UseVisualStyleBackColor = true;
            btConfirm.Click += btConfirm_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(383, 505);
            btExit.Name = "btExit";
            btExit.Size = new Size(100, 42);
            btExit.TabIndex = 4;
            btExit.Text = "退出";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // tbInformation
            // 
            tbInformation.Location = new Point(30, 590);
            tbInformation.Multiline = true;
            tbInformation.Name = "tbInformation";
            tbInformation.ScrollBars = ScrollBars.Vertical;
            tbInformation.Size = new Size(452, 126);
            tbInformation.TabIndex = 5;
            tbInformation.Visible = false;
            tbInformation.TextChanged += textBox3_TextChanged;
            // 
            // Shpooing
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 732);
            Controls.Add(tbInformation);
            Controls.Add(btExit);
            Controls.Add(btConfirm);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Shpooing";
            Text = "在线购物";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btConfirm;
        private Button btExit;
        private TextBox tbPhoneNumber;
        private TextBox tbName;
        private Label label2;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private ComboBox cbselect;
        private Label label3;
        private ListBox lbgoods;
        private ListBox lbselect;
        private RadioButton rbAlipay;
        private RadioButton rbWechat;
        private CheckBox cbEmail;
        private CheckBox cbLine;
        private CheckBox cbPhone;
        private TextBox tbInformation;
    }
}