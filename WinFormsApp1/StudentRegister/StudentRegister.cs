using mini选课习题.StudentRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini选课习题
{
    public partial class StudenteRgister : Form
    {
        public StudenteRgister()
        {
            InitializeComponent();
        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void 用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gBrigister.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userRegist regist = new userRegist();
            regist.ShowDialog();
        }
    }
}
