namespace mini选课习题.SqlServer
{
    partial class StudentManager
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
            btDelete = new Button();
            btChange = new Button();
            btAdd = new Button();
            btSelectByID = new Button();
            btSearchall = new Button();
            cbSex = new ComboBox();
            tbDepartment = new TextBox();
            tbAge = new TextBox();
            tbName = new TextBox();
            tbNo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btDelete);
            groupBox1.Controls.Add(btChange);
            groupBox1.Controls.Add(btAdd);
            groupBox1.Controls.Add(btSelectByID);
            groupBox1.Controls.Add(btSearchall);
            groupBox1.Controls.Add(cbSex);
            groupBox1.Controls.Add(tbDepartment);
            groupBox1.Controls.Add(tbAge);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbNo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(631, 74);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(82, 33);
            btDelete.TabIndex = 10;
            btDelete.Text = "删除";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btChange
            // 
            btChange.Location = new Point(537, 74);
            btChange.Name = "btChange";
            btChange.Size = new Size(82, 33);
            btChange.TabIndex = 9;
            btChange.Text = "修改";
            btChange.UseVisualStyleBackColor = true;
            btChange.Click += btChange_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(449, 74);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(82, 33);
            btAdd.TabIndex = 8;
            btAdd.Text = "添加";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btSelectByID
            // 
            btSelectByID.Location = new Point(358, 74);
            btSelectByID.Name = "btSelectByID";
            btSelectByID.Size = new Size(82, 33);
            btSelectByID.TabIndex = 7;
            btSelectByID.Text = "按学号查询";
            btSelectByID.UseVisualStyleBackColor = true;
            btSelectByID.Click += btSelectByID_Click;
            // 
            // btSearchall
            // 
            btSearchall.Location = new Point(267, 74);
            btSearchall.Name = "btSearchall";
            btSearchall.Size = new Size(82, 33);
            btSearchall.TabIndex = 6;
            btSearchall.Text = "查询全部";
            btSearchall.UseVisualStyleBackColor = true;
            btSearchall.Click += btSearchall_Click;
            // 
            // cbSex
            // 
            cbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "男", "女" });
            cbSex.Location = new Point(433, 27);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(98, 25);
            cbSex.TabIndex = 3;
            // 
            // tbDepartment
            // 
            tbDepartment.Location = new Point(83, 74);
            tbDepartment.Name = "tbDepartment";
            tbDepartment.Size = new Size(153, 23);
            tbDepartment.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(617, 29);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(108, 23);
            tbAge.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(267, 29);
            tbName.Name = "tbName";
            tbName.Size = new Size(85, 23);
            tbName.TabIndex = 2;
            // 
            // tbNo
            // 
            tbNo.Location = new Point(93, 29);
            tbNo.Name = "tbNo";
            tbNo.Size = new Size(100, 23);
            tbNo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 32);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 0;
            label4.Text = "学生年龄：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 32);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 0;
            label3.Text = "学生性别：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 32);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "学生姓名：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 77);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 0;
            label5.Text = "所在系：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "学生学号：";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 326);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // StudentManager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "StudentManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "学生管理信息";
            Load += StudentManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btDelete;
        private Button btChange;
        private Button btAdd;
        private Button btSelectByID;
        private Button btSearchall;
        private ComboBox cbSex;
        private TextBox tbDepartment;
        private TextBox tbAge;
        private TextBox tbName;
        private TextBox tbNo;
        private Label label5;
        private DataGridView dataGridView1;
    }
}