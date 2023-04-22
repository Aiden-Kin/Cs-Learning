using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class SimpleSelect : Form
    {
        public SimpleSelect()
        {
            InitializeComponent();
            this.Lbhave.Items.AddRange(new object[] { "计算机导论", "计算机文化基础", "数字逻辑", "离散数学",
            "数据库技术","大学英语","火箭工程技术控制和逐月计划"});
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exist = true;
            if (this.TBnew.Text == "") MessageBox.Show("输入为空请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                for (int i = 0; i < this.Lbhave.Items.Count; i++)
                {
                    if (this.TBnew.Text == this.Lbhave.Items[i].ToString())
                    {
                        exist = true;
                        MessageBox.Show("输入选项重复请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TBnew.Clear();
                        break;
                    }
                }
                if (exist)
                {
                    this.Lbhave.Items.Add(this.TBnew.Text);
                }
            }
        }

        private void Lbhave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBnew_TextChanged(object sender, EventArgs e)
        {

        }

        private void singleRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Lbhave.SelectedItem == null)                 //防止啥都没选的时候报错
                { }
                else
                {
                    this.RBselect.Items.Add(this.Lbhave.SelectedItem);
                    this.Lbhave.Items.Remove(this.Lbhave.SelectedItem);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void RBselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void singleLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.RBselect.SelectedItem == null)                 //防止啥都没选的时候报错
                { }
                else
                {
                    this.Lbhave.Items.Add(this.RBselect.SelectedItem);
                    this.RBselect.Items.Remove(this.RBselect.SelectedItem);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void allRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Lbhave.Items.Count; i++)
            {
                this.RBselect.Items.Add(this.Lbhave.Items[i]);
            }
            this.Lbhave.Items.Clear();
        }

        private void allLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.RBselect.Items.Count; i++)
            {
                this.Lbhave.Items.Add(this.RBselect.Items[i]);
            }
            this.RBselect.Items.Clear();
        }

        private void SimpleSelect_Load(object sender, EventArgs e)
        {

        }
    }
}