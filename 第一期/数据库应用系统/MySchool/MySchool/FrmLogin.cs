using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1.引用命名空间
using System.Data.Sql;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        
        #region 字段
        //2.创建数据库连接字符串
        private string sql = @"Data Source = TANG;Initial Catalog = MySchool182; User ID = sa;Pwd = 123";
        //创建连接对象
        private SqlConnection objSqlConn;
        //创建执行对象
        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //登陆按钮事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoginFunc();
        }
        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("确定取消吗？","取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (Result == DialogResult.OK)
            {
                //关闭窗体
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 登录操作
        /// </summary>
        public void LoginFunc()
        {
            #region 设置变量
            //用户名
            string strStuNO = this.txtStuNo.Text.Trim();
            //密码
            string strLoginPwd = this.txtLoginPwd.Text.Trim();
            //登录类型
            string strType = this.cmbType.Text.Trim();
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(strStuNO))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strLoginPwd))
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
            //3.利用数据库连接字符串创建连接对象
            objSqlConn = new SqlConnection(sql);
            //4.创建SQL命令
            string sqlText = string.Format("select count(*) from Student ")
                            +string.Format(" where StudentNO = {0} AND LoginPwd = {1}", strStuNO, strLoginPwd);
            //5.利用SQL命令和连接对象创建执行对象
            objSqlComm = new SqlCommand(sqlText,objSqlConn);
            try
            {
                //6.打开数据库
                objSqlConn.Open();
                //7.执行SQL命令
                int result = (int)objSqlComm.ExecuteScalar();
                //8.处理数据
                if (result >= 1)
                {
                    //窗体跳转
                    FrmMain objMain = new FrmMain();

                    objMain.Show();

                    //隐藏当前窗体
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败，用户名或密码错误！");
                }
                //9.关闭数据库
                objSqlConn.Close();
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
