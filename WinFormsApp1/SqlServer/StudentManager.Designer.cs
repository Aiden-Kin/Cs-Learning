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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            tbNo = new TextBox();
            tbDepartment = new TextBox();
            textBox3 = new TextBox();
            tbAge = new TextBox();
            cbSex = new ComboBox();
            btSearchall = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btSearchall);
            groupBox1.Controls.Add(cbSex);
            groupBox1.Controls.Add(tbDepartment);
            groupBox1.Controls.Add(tbAge);
            groupBox1.Controls.Add(textBox3);
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
            groupBox1.Enter += groupBox1_Enter;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "学生学号：";
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
            // tbNo
            // 
            tbNo.Location = new Point(93, 29);
            tbNo.Name = "tbNo";
            tbNo.Size = new Size(100, 23);
            tbNo.TabIndex = 1;
            // 
            // tbDepartment
            // 
            tbDepartment.Location = new Point(83, 74);
            tbDepartment.Name = "tbDepartment";
            tbDepartment.Size = new Size(153, 23);
            tbDepartment.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(267, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 23);
            textBox3.TabIndex = 1;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(617, 29);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(108, 23);
            tbAge.TabIndex = 1;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Location = new Point(433, 27);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(98, 25);
            cbSex.TabIndex = 2;
            // 
            // btSearchall
            // 
            btSearchall.Location = new Point(267, 74);
            btSearchall.Name = "btSearchall";
            btSearchall.Size = new Size(82, 33);
            btSearchall.TabIndex = 3;
            btSearchall.Text = "查询全部";
            btSearchall.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(358, 74);
            button2.Name = "button2";
            button2.Size = new Size(82, 33);
            button2.TabIndex = 3;
            button2.Text = "按学号查询";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(449, 74);
            button3.Name = "button3";
            button3.Size = new Size(82, 33);
            button3.TabIndex = 3;
            button3.Text = "添加";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(537, 74);
            button4.Name = "button4";
            button4.Size = new Size(82, 33);
            button4.TabIndex = 3;
            button4.Text = "修改";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(631, 74);
            button5.Name = "button5";
            button5.Size = new Size(82, 33);
            button5.TabIndex = 3;
            button5.Text = "删除";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 326);
            dataGridView1.TabIndex = 1;
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
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btSearchall;
        private ComboBox cbSex;
        private TextBox tbDepartment;
        private TextBox tbAge;
        private TextBox textBox3;
        private TextBox tbNo;
        private Label label5;
        private DataGridView dataGridView1;
    }
}