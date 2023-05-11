using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using mini选课习题.SqlServer;



namespace mini选课习题.SqlServer
{
    public partial class StudentManager : Form
    {
        public StudentManager()
        {
            InitializeComponent();
        }

        string strcon = "data source=AIR\\MYSQL;uid=sa;pwd=123456;database=SelectCourse";
        SqlConnection stuConn;
        SqlDataAdapter stuadapter;
        DataSet ds;
        public void SetHeaderText()
        {
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "年龄";
            dataGridView1.Columns[4].HeaderText = "所在系";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearchall_Click(object sender, EventArgs e)
        {
            string search = "select * from tbl_Student ";
            DataSet ds = SqlHelper.DbAdapter(search);
            dataGridView1.DataSource = ds.Tables["studentAll"];
            SetHeaderText();

        }

        private void btSelectByID_Click(object sender, EventArgs e)
        {
            string search = string.Format("select * from tbl_Student where Son = '{0}'", tbNo.Text);
            DataSet ds = SqlHelper.DbAdapter(search);
            dataGridView1.DataSource = ds.Tables["studentAll"];
            SetHeaderText();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int changed = -1;
            string search = string.Format("insert into tbl_Student(Son,Sname,Ssex,Sage,Sdept) values ({0},'{1}','{2}',{3},'{4}')", tbNo.Text, tbName.Text, cbSex.Text, tbAge.Text, tbDepartment.Text);
            changed = SqlHelper.DbCommand(search);
            btSearchall.PerformClick();
            messageShow(changed);
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            int changed;
            string change = string.Format("update tbl_Student set Sname = '{0}',Ssex='{1}',Sage={2},Sdept='{3}' where Son = {4}", tbName.Text, cbSex.Text, tbAge.Text, tbDepartment.Text, tbNo.Text);
            changed = SqlHelper.DbCommand(change);
            btSearchall.PerformClick();
            messageShow(changed);
        }

        public void messageShow(int code)
        {
            if (code == 0 || code == -1)
            {
                MessageBox.Show("修改失败，请重新添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message;
                message = string.Format("修改成功，{0}行受影响。", code);
                MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = this.dataGridView1.CurrentRow.Index;
            this.tbNo.Text = this.dataGridView1.CurrentRow.Cells["Son"].Value.ToString();
            this.tbName.Text = this.dataGridView1.CurrentRow.Cells["Sname"].Value.ToString();
            this.cbSex.Text = this.dataGridView1.CurrentRow.Cells["Ssex"].Value.ToString();
            this.tbAge.Text = this.dataGridView1.CurrentRow.Cells["Sage"].Value.ToString();
            this.tbDepartment.Text = this.dataGridView1.CurrentRow.Cells["Sdept"].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int stateCode;
            string deletInformation;
            deletInformation = string.Format("是否要删除 学号：{0}  姓名：{1} 此名学生？", tbNo.Text, tbName.Text);
            string sqlDlete;
            DialogResult drReturn = MessageBox.Show(deletInformation, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (drReturn == DialogResult.Cancel)
            {
                return;
            }
            sqlDlete = string.Format("delete from tbl_Student where Son = '{0}'", tbNo.Text);
            stateCode = SqlHelper.DbCommand(sqlDlete);
            btSearchall.PerformClick();
            messageShow(stateCode);
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {

        }
    }
}
