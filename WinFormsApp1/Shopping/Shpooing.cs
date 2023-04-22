using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    lbgoods.Items.AddRange(new object[] { "富士XT4相机", "佳能50mm F1.8镜头", "索尼豪华钛合金三角架","索尼a6400", "适马30mm F1.4","小米12SUltra" });
                    break;
                case 2:
                    lbgoods.Items.Clear();
                    lbgoods.Items.AddRange(new object[] { "摄影技巧大全", "高等数学", "大学生心理健康", "C#程序设计" });
                    break;
            }
        }


    }
}
