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
    public partial class FrmLog : Form
    {
        public FrmLog()
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
        //登陆
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoginFre();
        }

       
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("确定取消吗？","取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 登陆方法
        /// </summary>
        public void LoginFre()
        {
            #region 设置变量
            string strName = this.txtName.Text.Trim();

            string strPwd = this.txtPwd.Text.Trim();
            #endregion

            #region 数据验证
            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            #endregion

            #region 登录操作
            objSqlConn = new SqlConnection(sql);

            string sqlText = string.Format("select count(*) from Users where UserID = '{0}' and UserPass = '{1}'", strName,strPwd);

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = (int)objSqlComm.ExecuteScalar();

                if (result >= 1)
                {
                    FrmMain objMain = new FrmMain();

                    objMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
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
