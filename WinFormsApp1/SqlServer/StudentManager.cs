using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace mini选课习题.SqlServer
{
    public partial class StudentManager : Form
    {
        public StudentManager()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearchall_Click(object sender, EventArgs e)
        {
            try
            {
                string strcon = "data source = localhost;uid = sa; pwd = 123456; database = SelectCourse";
                //Sqlconnection myysql = new Sqlconnection(strcon);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
