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

namespace UserManage
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = UserManage; User ID = sa ; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion 

        #region 属性

        #endregion

        #region 事件
        //登陆
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoginFunc();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("确定取消吗？","取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (DialogResult.OK == Result)
            {
                //关闭窗体
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        public void LoginFunc()
        {
            #region 设置变量
            string strID = this.txtID.Text.Trim();

            string strPwd = this.txtPwd.Text.Trim();

            string strType = this.cmbType.Text.Trim();
            #endregion

            #region 验证数据
            if (string.IsNullOrEmpty(strID))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strType))
            {
                MessageBox.Show("请选择登录类型！");
                return;
            }
            #endregion

            #region 登录操作
            objSqlConn = new SqlConnection(sql);

            string sqlText = string.Format("select count(*) from SysUser where UserName = {0} AND PassWord = {1}", strID, strPwd);

            objSqlComm = new SqlCommand(sqlText, objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = (int)objSqlComm.ExecuteScalar();

                if (result >= 1)
                {
                    FrmRegion objRegion = new FrmRegion();

                    objRegion.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败，用户名或密码错误！");
                }
                objSqlConn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败，请联系管理员！");
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
