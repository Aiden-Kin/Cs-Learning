using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mini选课习题.StudentRegister
{
    public partial class userRegist : Form
    {
        public userRegist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDepartment.SelectedIndex)
            {
                case 0:
                    cbMajor.Items.Clear();
                    cbMajor.Items.AddRange(new object[] { "软件工程专业", "数字媒体专业" });
                    break;

                case 1:
                    cbMajor.Items.Clear();
                    cbMajor.Items.AddRange(new object[] { "石油工程专业", "储运工程专业" });
                    break;
                case 2:
                    cbMajor.Items.Clear();
                    cbMajor.Items.AddRange(new object[] { "计算机工程", "电子信息专业" });
                    break;

                default:
                    break;
            }
        }

        private void userRegist_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcommit_Click(object sender, EventArgs e)
        {
            string sex;
            if (this.tbPasswd.Text != this.tbpasswdCheck.Text)
            {
                MessageBox.Show("两次输入的密码不一致请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbPasswd.Clear();
                this.tbpasswdCheck.Clear();
                this.tbPasswd.Focus();
                return;
            }
            if (this.tbpasswdCheck.Text == null || this.textBox1.Text == "" || this.rBfemal.Checked == false            //没输入完毕判断
                && this.rBman.Checked == false || this.cbDepartment.SelectedIndex == -1 || this.cbMajor.SelectedIndex == -1)
            {
                MessageBox.Show("有未填写项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RegistInformation Infom = new RegistInformation();
            if (rBman.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女"; 
            }

            Infom.MustText = "姓名：" + this.textBox1.Text + "\r\n" +
                "性别：" + sex + "\r\n"+
                "密码：" + tbPasswd.Text + "\r\n" +
                "所在院系：" + this.cbDepartment.SelectedItem.ToString() + "\r\n" +
                "所属专业：" + this.cbMajor.SelectedItem.ToString();
            Infom.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
