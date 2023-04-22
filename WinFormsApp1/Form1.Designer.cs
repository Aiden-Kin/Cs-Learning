namespace WinFormsApp1
{
    partial class SimpleSelect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TBnew = new TextBox();
            BuNew = new Button();
            label2 = new Label();
            label3 = new Label();
            Lbhave = new ListBox();
            RBselect = new ListBox();
            singleRight = new Button();
            singleLeft = new Button();
            allRight = new Button();
            allLeft = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(152, 17);
            label1.TabIndex = 0;
            label1.Text = "请输入要添加的课程名称：";
            label1.Click += label1_Click;
            // 
            // TBnew
            // 
            TBnew.Location = new Point(66, 100);
            TBnew.Name = "TBnew";
            TBnew.Size = new Size(301, 23);
            TBnew.TabIndex = 1;
            TBnew.TextChanged += TBnew_TextChanged;
            // 
            // BuNew
            // 
            BuNew.Location = new Point(407, 93);
            BuNew.Name = "BuNew";
            BuNew.Size = new Size(109, 37);
            BuNew.TabIndex = 2;
            BuNew.Text = "添加新的课程";
            BuNew.UseVisualStyleBackColor = true;
            BuNew.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 165);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 0;
            label2.Text = "已有的课程：";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 165);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 0;
            label3.Text = "所选的课程：";
            label3.Click += label1_Click;
            // 
            // Lbhave
            // 
            Lbhave.FormattingEnabled = true;
            Lbhave.ItemHeight = 17;
            Lbhave.Items.AddRange(new object[] { "C#程序设计基础" });
            Lbhave.Location = new Point(58, 216);
            Lbhave.Name = "Lbhave";
            Lbhave.Size = new Size(173, 310);
            Lbhave.TabIndex = 3;
            Lbhave.SelectedIndexChanged += Lbhave_SelectedIndexChanged;
            // 
            // RBselect
            // 
            RBselect.FormattingEnabled = true;
            RBselect.ItemHeight = 17;
            RBselect.Location = new Point(389, 216);
            RBselect.Name = "RBselect";
            RBselect.Size = new Size(177, 310);
            RBselect.TabIndex = 3;
            RBselect.SelectedIndexChanged += RBselect_SelectedIndexChanged;
            // 
            // singleRight
            // 
            singleRight.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            singleRight.Location = new Point(269, 243);
            singleRight.Name = "singleRight";
            singleRight.Size = new Size(86, 36);
            singleRight.TabIndex = 4;
            singleRight.Text = "->";
            singleRight.UseVisualStyleBackColor = true;
            singleRight.Click += singleRight_Click;
            // 
            // singleLeft
            // 
            singleLeft.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            singleLeft.Location = new Point(269, 315);
            singleLeft.Name = "singleLeft";
            singleLeft.Size = new Size(86, 36);
            singleLeft.TabIndex = 5;
            singleLeft.Text = "<-";
            singleLeft.UseVisualStyleBackColor = true;
            singleLeft.Click += singleLeft_Click;
            // 
            // allRight
            // 
            allRight.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            allRight.Location = new Point(269, 389);
            allRight.Name = "allRight";
            allRight.Size = new Size(86, 36);
            allRight.TabIndex = 6;
            allRight.Text = ">>";
            allRight.UseVisualStyleBackColor = true;
            allRight.Click += allRight_Click;
            // 
            // allLeft
            // 
            allLeft.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            allLeft.Location = new Point(269, 463);
            allLeft.Name = "allLeft";
            allLeft.Size = new Size(86, 36);
            allLeft.TabIndex = 7;
            allLeft.Text = "<<";
            allLeft.UseVisualStyleBackColor = true;
            allLeft.Click += allLeft_Click;
            // 
            // SimpleSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 558);
            Controls.Add(allLeft);
            Controls.Add(allRight);
            Controls.Add(singleLeft);
            Controls.Add(singleRight);
            Controls.Add(RBselect);
            Controls.Add(Lbhave);
            Controls.Add(BuNew);
            Controls.Add(TBnew);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SimpleSelect";
            Text = "简单选课窗体";
            Load += SimpleSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBnew;
        private Button BuNew;
        private Label label2;
        private Label label3;
        private ListBox Lbhave;
        private ListBox RBselect;
        private Button singleRight;
        private Button singleLeft;
        private Button allRight;
        private Button allLeft;
    }
}