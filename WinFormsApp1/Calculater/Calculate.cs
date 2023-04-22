using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini选课习题.Calculater
{
    public partial class Calculate : Form
    {
        double[] number = new double[10];
        int i = 0;
        string temp;
        public Calculate()
        {
            InitializeComponent();
        }

        private void Calculate_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
            temp += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
            temp += "1";
            ;        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";
            temp += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
            temp += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
            temp += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";
            temp += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";
            temp += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "+";
            number[i] = Convert.ToDouble(temp);
            i++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";
            temp += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";
            temp += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";
            temp += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "/";
        }
    }
}
