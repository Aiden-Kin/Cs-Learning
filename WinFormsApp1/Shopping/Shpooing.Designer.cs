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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox4 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "顾客信息";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
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
            groupBox2.Location = new Point(21, 127);
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
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(29, 462);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(149, 120);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "付款方式";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 21);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "支付宝";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "微信";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Location = new Point(214, 462);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(137, 120);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "确认方式";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(25, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(58, 21);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "Email";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "传真";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(51, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "电话";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(380, 480);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 4;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(381, 530);
            button2.Name = "button2";
            button2.Size = new Size(100, 42);
            button2.TabIndex = 4;
            button2.Text = "退出";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 615);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 126);
            textBox3.TabIndex = 5;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Shpooing
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 778);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox3;
    }
}