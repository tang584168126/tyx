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

namespace MySchool_1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa;Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //登录按钮事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoginData();
        }

        //取消按钮事件
        private void btnCansole_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消吗？","确定",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 登录方法
        /// </summary>
        public void LoginData()
        {
            #region 设置变量
            string strStuNo = this.txtStuNo.Text.Trim();

            string strPwd = this.txtPwd.Text.Trim();

            string strStyle = this.cmbStyle.Text.Trim();
            #endregion

            #region 登录验证
            if(string.IsNullOrEmpty(strStuNo))
            {
                MessageBox.Show("请输入用户名！");
                return;
            }

            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("请输入密码！");
                return;
            }

            if (string.IsNullOrEmpty(strStyle))
            {
                MessageBox.Show("请选择登录类型！");
                return;
            }
            #endregion

            #region 登录操作
            objSqlConn = new SqlConnection(sql);

            string sqlText = string.Format("select count(StudentNo) from Student")
                            + string.Format(" where StudentNo = {0} and LoginPwd = '{1}'", strStuNo, strPwd);

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = (int)objSqlComm.ExecuteScalar();

                if (result >= 1)
                {
                    FrmMain objMain = new FrmMain();

                    objMain.Show();
                }
                else
                {
                    MessageBox.Show("登录失败，用户名或密码错误！");
                }
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
