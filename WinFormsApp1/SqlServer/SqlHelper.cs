using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace mini选课习题.SqlServer
{
    public class SqlHelper
    {
        public static string strcon= "data source=AIR\\MYSQL;uid=sa;pwd=123456;database=SelectCourse";

        public static DataSet DbAdapter(string sqlSearch)
        {
            try
            {
                SqlConnection connStu = new SqlConnection(strcon);
                connStu.Open();
                //string sqlID = "select * from tbl_Student ";
                SqlDataAdapter stuadapter = new SqlDataAdapter(sqlSearch, connStu);
                DataSet dsStu = new DataSet();
                stuadapter.Fill(dsStu, "studentAll");
                connStu.Close();
                return dsStu;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return null;
        }

        public static int DbCommand(string sqlChange)
        {
            int changed = -1;
            try
            {
                SqlConnection myconn = new SqlConnection(strcon);
                myconn.Open();
                SqlCommand myCommand = myconn.CreateCommand();
                myCommand.CommandText = sqlChange;
                changed = myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

            return changed;
        }
    

    }
}
