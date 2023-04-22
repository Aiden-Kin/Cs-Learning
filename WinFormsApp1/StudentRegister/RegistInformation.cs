using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini选课习题.StudentRegister
{
    public partial class RegistInformation : Form
    {

        public string MustText { get => this.TbInfo.Text; set => this.TbInfo.Text = value; }

        public RegistInformation()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { Application.Exit(); }
            else { return; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistInformation_Load(object sender, EventArgs e)
        {


        }
    }
}
