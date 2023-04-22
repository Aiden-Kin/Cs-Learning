namespace mini选课习题
{
    partial class StudenteRgister
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
            menuStrip1 = new MenuStrip();
            注册ToolStripMenuItem = new ToolStripMenuItem();
            用户注册ToolStripMenuItem = new ToolStripMenuItem();
            修改用户信息ToolStripMenuItem = new ToolStripMenuItem();
            登陆ToolStripMenuItem = new ToolStripMenuItem();
            用户登陆ToolStripMenuItem = new ToolStripMenuItem();
            修改密码ToolStripMenuItem = new ToolStripMenuItem();
            学生成绩管理ToolStripMenuItem = new ToolStripMenuItem();
            录入学生成绩ToolStripMenuItem = new ToolStripMenuItem();
            查询学生成绩ToolStripMenuItem = new ToolStripMenuItem();
            修改学生成绩ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            tBinfo = new TextBox();
            gBrigister = new GroupBox();
            Buagree = new Button();
            menuStrip1.SuspendLayout();
            gBrigister.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 注册ToolStripMenuItem, 登陆ToolStripMenuItem, 学生成绩管理ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1029, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 注册ToolStripMenuItem
            // 
            注册ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 用户注册ToolStripMenuItem, 修改用户信息ToolStripMenuItem });
            注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            注册ToolStripMenuItem.Size = new Size(53, 24);
            注册ToolStripMenuItem.Text = "注册";
            // 
            // 用户注册ToolStripMenuItem
            // 
            用户注册ToolStripMenuItem.Name = "用户注册ToolStripMenuItem";
            用户注册ToolStripMenuItem.Size = new Size(182, 26);
            用户注册ToolStripMenuItem.Text = "用户注册";
            用户注册ToolStripMenuItem.Click += 用户注册ToolStripMenuItem_Click;
            // 
            // 修改用户信息ToolStripMenuItem
            // 
            修改用户信息ToolStripMenuItem.Name = "修改用户信息ToolStripMenuItem";
            修改用户信息ToolStripMenuItem.Size = new Size(182, 26);
            修改用户信息ToolStripMenuItem.Text = "修改用户信息";
            // 
            // 登陆ToolStripMenuItem
            // 
            登陆ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 用户登陆ToolStripMenuItem, 修改密码ToolStripMenuItem });
            登陆ToolStripMenuItem.Name = "登陆ToolStripMenuItem";
            登陆ToolStripMenuItem.Size = new Size(53, 24);
            登陆ToolStripMenuItem.Text = "登陆";
            // 
            // 用户登陆ToolStripMenuItem
            // 
            用户登陆ToolStripMenuItem.Name = "用户登陆ToolStripMenuItem";
            用户登陆ToolStripMenuItem.Size = new Size(152, 26);
            用户登陆ToolStripMenuItem.Text = "用户登陆";
            // 
            // 修改密码ToolStripMenuItem
            // 
            修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            修改密码ToolStripMenuItem.Size = new Size(152, 26);
            修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 学生成绩管理ToolStripMenuItem
            // 
            学生成绩管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 录入学生成绩ToolStripMenuItem, 查询学生成绩ToolStripMenuItem, 修改学生成绩ToolStripMenuItem });
            学生成绩管理ToolStripMenuItem.Name = "学生成绩管理ToolStripMenuItem";
            学生成绩管理ToolStripMenuItem.Size = new Size(113, 24);
            学生成绩管理ToolStripMenuItem.Text = "学生成绩管理";
            // 
            // 录入学生成绩ToolStripMenuItem
            // 
            录入学生成绩ToolStripMenuItem.Name = "录入学生成绩ToolStripMenuItem";
            录入学生成绩ToolStripMenuItem.Size = new Size(182, 26);
            录入学生成绩ToolStripMenuItem.Text = "录入学生成绩";
            // 
            // 查询学生成绩ToolStripMenuItem
            // 
            查询学生成绩ToolStripMenuItem.Name = "查询学生成绩ToolStripMenuItem";
            查询学生成绩ToolStripMenuItem.Size = new Size(182, 26);
            查询学生成绩ToolStripMenuItem.Text = "查询学生成绩";
            // 
            // 修改学生成绩ToolStripMenuItem
            // 
            修改学生成绩ToolStripMenuItem.Name = "修改学生成绩ToolStripMenuItem";
            修改学生成绩ToolStripMenuItem.Size = new Size(182, 26);
            修改学生成绩ToolStripMenuItem.Text = "修改学生成绩";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(53, 24);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tBinfo
            // 
            tBinfo.BackColor = Color.White;
            tBinfo.Location = new Point(107, 75);
            tBinfo.Margin = new Padding(4, 4, 4, 4);
            tBinfo.Multiline = true;
            tBinfo.Name = "tBinfo";
            tBinfo.ReadOnly = true;
            tBinfo.Size = new Size(581, 223);
            tBinfo.TabIndex = 1;
            tBinfo.Text = "（1）提供及时、详尽及准确的个人资料。\r\n（2）不断更新注册资料，符合及时、详尽准确的要求。所有原始键入的资料将引用为注册资料。\r\n......";
            tBinfo.TextChanged += textBox1_TextChanged;
            // 
            // gBrigister
            // 
            gBrigister.Controls.Add(Buagree);
            gBrigister.Controls.Add(tBinfo);
            gBrigister.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gBrigister.ForeColor = Color.Blue;
            gBrigister.Location = new Point(99, 62);
            gBrigister.Margin = new Padding(4, 4, 4, 4);
            gBrigister.Name = "gBrigister";
            gBrigister.Padding = new Padding(4, 4, 4, 4);
            gBrigister.Size = new Size(792, 402);
            gBrigister.TabIndex = 2;
            gBrigister.TabStop = false;
            gBrigister.Text = "“学生成绩管理系统”注册协议";
            gBrigister.Visible = false;
            gBrigister.Enter += groupBox1_Enter;
            // 
            // Buagree
            // 
            Buagree.ForeColor = SystemColors.ActiveCaptionText;
            Buagree.Location = new Point(296, 325);
            Buagree.Margin = new Padding(4, 4, 4, 4);
            Buagree.Name = "Buagree";
            Buagree.Size = new Size(194, 47);
            Buagree.TabIndex = 2;
            Buagree.Text = "我同意";
            Buagree.UseVisualStyleBackColor = true;
            Buagree.Click += button1_Click;
            // 
            // StudenteRgister
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 529);
            Controls.Add(gBrigister);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "StudenteRgister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentRegister";
            Load += StudentRegister_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gBrigister.ResumeLayout(false);
            gBrigister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 注册ToolStripMenuItem;
        private ToolStripMenuItem 用户注册ToolStripMenuItem;
        private ToolStripMenuItem 修改用户信息ToolStripMenuItem;
        private ToolStripMenuItem 登陆ToolStripMenuItem;
        private ToolStripMenuItem 用户登陆ToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private ToolStripMenuItem 学生成绩管理ToolStripMenuItem;
        private ToolStripMenuItem 录入学生成绩ToolStripMenuItem;
        private ToolStripMenuItem 查询学生成绩ToolStripMenuItem;
        private ToolStripMenuItem 修改学生成绩ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private TextBox tBinfo;
        private GroupBox gBrigister;
        private Button Buagree;
    }
}