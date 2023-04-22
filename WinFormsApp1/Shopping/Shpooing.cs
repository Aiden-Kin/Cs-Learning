using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini选课习题.Shopping
{
    public partial class Shpooing : Form
    {
        public Shpooing()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbselect.SelectedIndex)
            {
                case 0:
                    lbgoods.Items.Clear();
                    lbgoods.Items.AddRange(new object[] { "RTX4090显卡", "固态硬盘", "金士顿DDR4 8G内存条", "外科技开机按钮贴膜" });
                    break;
                case 1:
                    lbgoods.Items.Clear();
                    lbgoods.Items.AddRange(new object[] { "富士XT4相机", "佳能50mm F1.8镜头", "索尼豪华钛合金三角架", "索尼a6400", "适马30mm F1.4", "小米12SUltra" });
                    break;
                case 2:
                    lbgoods.Items.Clear();
                    lbgoods.Items.AddRange(new object[] { "摄影技巧大全", "高等数学", "大学生心理健康", "C#程序设计" });
                    break;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("    是否要退出", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { Application.Exit(); }
            else { return; }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = lbselect.Items.Count - 1; i >= 0; i--)
            {
                if (lbselect.Items[i] == lbgoods.SelectedItem)
                {
                    MessageBox.Show("不能重复添加商品", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if (this.lbgoods.SelectedItem != null)
                this.lbselect.Items.Add(this.lbgoods.SelectedItem);


        }

        private void btConfirm_Click(object sender, EventArgs e)
        {

            string selectGoods = "", payWay="", confirmWay = "";

            for (int i = lbselect.Items.Count - 1; i >= 0; i--)//添加已选商品到选择字符串
            {
                selectGoods += ("   " + Convert.ToString(lbselect.Items[i]));
                if (i % 3 == 0) { selectGoods += "\r\n"; }
            }

            if (rbAlipay.Checked) { payWay = Convert.ToString(rbAlipay.Text); }
            if (rbWechat.Checked) { payWay = "  微信"; }

            if (cbPhone.Checked) confirmWay += "  电话";
            if (cbLine.Checked) confirmWay += "  传真";
            if (cbEmail.Checked) confirmWay += "  Email";

            if (tbName.Text == "" || tbPhoneNumber.Text == "" || lbselect.Items.Count == 0 || payWay == "" || confirmWay == "")
            {
                MessageBox.Show("有未填写项目，请补充完整。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tbInformation.Show();
            tbInformation.Text =
    "姓名：" + tbName.Text + "\r\n" +
    "电话：" + tbPhoneNumber.Text + "\r\n" +
    "已选商品:" + selectGoods + "\r\n" +
    "支付方式:" + payWay + "\r\n" +
    "确认方式:" + confirmWay;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbselect.Items.Remove(lbselect.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = lbgoods.Items.Count - 1; i >= 0; i--)
            {
                for (int j = lbselect.Items.Count - 1; j >= 0; j--)
                {
                    if (lbgoods.Items[i] == lbselect.Items[j])
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    lbselect.Items.Add(lbgoods.Items[i]);
                }
            }

        }
    }
}
