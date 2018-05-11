using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FrmLog
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 字段
        private string sql = @"Data Source = TANG;Initial Catalog = UserManagerSys;Integrated Security = true ";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        

        #region 属性

        #endregion

        #region 事件
        //关闭后事件
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        #endregion

        #region 方法
        public void LoginFrem()
        {

            #region 保存操作
            string strEmail = this.txtEmail.Text.Trim();
            string strAdress = this.txtAdress.Text.Trim();
            string strBlood = this.cmbBlood.Text.Trim();

            objSqlConn = new SqlConnection(sql);

            string sqlText = string.Format("update Users set Email = {0},Adress = {1},Blood = {2}", strEmail, strAdress, strBlood);

            objSqlComm = new SqlCommand(sqlText, objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = objSqlComm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }
            finally
            {
                objSqlConn.Close();
            }
            #endregion
        }
        #endregion
    }
}
