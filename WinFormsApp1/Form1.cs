using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class SimpleSelect : Form
    {
        public SimpleSelect()
        {
            InitializeComponent();
            this.Lbhave.Items.AddRange(new object[] { "���������", "������Ļ�����", "�����߼�", "��ɢ��ѧ",
            "���ݿ⼼��","��ѧӢ��","������̼������ƺ����¼ƻ�"});
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
            if (this.TBnew.Text == "") MessageBox.Show("����Ϊ������������", "��ʾ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                for (int i = 0; i < this.Lbhave.Items.Count; i++)
                {
                    if (this.TBnew.Text == this.Lbhave.Items[i].ToString())
                    {
                        exist = true;
                        MessageBox.Show("����ѡ���ظ�����������", "��ʾ��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (this.Lbhave.SelectedItem == null)                 //��ֹɶ��ûѡ��ʱ�򱨴�
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
                if (this.RBselect.SelectedItem == null)                 //��ֹɶ��ûѡ��ʱ�򱨴�
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