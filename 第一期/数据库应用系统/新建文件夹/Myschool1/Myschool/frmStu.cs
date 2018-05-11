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
namespace Myschool
{
    public partial class frmStu : Form
    {
        public frmStu()
        {
            InitializeComponent();
        }

        #region 字段

        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;Pwd=huyi1314520";
        private SqlConnection objsqlconn;
        private SqlCommand objsqlcomm;
        public static string strstuNO;

        public static string strLoginPwd;
        #endregion

        #region 属性

        //窗体创建完毕事件
        private void frmStu_Load(object sender, EventArgs e)
        {
            this.start();
        }
    
        //登陆按钮事件
        private void button1_Click(object sender, EventArgs e)
        {

            //调用登陆方法
          this.LoginFunc();

            //string strstuNO = this.txtStuNO.Text.Trim();

            ////密码
            //string strLoginPwd = this.txtLoginPwd.Text.Trim();

            //if (strstuNO.Equals("1148577609") && strLoginPwd.Equals("huyi1314520"))
            //{
            //    MessageBox.Show("登陆成功！！");

            //}
            //else
            //{
            //    MessageBox.Show("登录失败");
            //}

        }

        //取消按钮事件
        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("确定取消吗？");（纯属出语句）
           // MessageBox.Show("确定取消吗？", "取消");//带有标题的输出语句
          //MessageBox.Show("确定取消吗？", "取消",MessageBoxButtons.OKCancel);//带有选项的输出语句
           DialogResult result=MessageBox.Show("确定取消吗？", "取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);//带有图标的输出语句
           if (result == DialogResult.OK)
           {
               //只关闭当前窗体（若程序只有一个窗体则将关闭程序）
               //this.Close();

               //关闭当前程序
               Application.Exit();
           }
           else
           {
              
           }
        }
        #endregion

        #region 方法

        //登陆方法
        public void LoginFunc()
        {
            #region  设置变量
            //登录名
             strstuNO = this.txtStuNO.Text.Trim();

            //密码
            strLoginPwd = this.txtLoginPwd.Text.Trim();

            //登录类型
            string strType = this.cmbType.Text.Trim();
            #endregion

            #region 数据验证

            //非空验证
            if(string.IsNullOrEmpty(strstuNO))
            {
                MessageBox.Show("用户名不能为空！");

                return;
            }
            if(string.IsNullOrEmpty(strLoginPwd))
                {
                    MessageBox.Show("密码不能为空！");
                return;
            }
           if(string.IsNullOrEmpty(strType))
           {
               MessageBox.Show("请选择登陆类型！");
               return;
           }

            #endregion

            #region  登陆操作

            //利用连接字符串 创建连接对象
           objsqlconn = new SqlConnection(sql);

            //创建SQL命令
           string sqlText = string.Format(" select count(*)")
                    + string.Format(" from Student ")
                    + string.Format(" where StudentNo='{0}' and Loginpwd='{1}'", strstuNO, strLoginPwd);

            //利用执行命令和连接对象 创建执行对象
           objsqlcomm = new SqlCommand(sqlText, objsqlconn);

           try
           {
               //打开数据库
               objsqlconn.Open();
               
               //执行操作
               int result = (int)objsqlcomm.ExecuteScalar();

               //处理数据
               if (result >= 1)
               {
                   //窗体跳转
                   frmMain objMain = new frmMain();
                   objMain.Show();

                   //隐藏当前窗体
                   this.Hide();

               }
               else
               {
                   MessageBox.Show("登录失败！！！用户名或者密码错误");
               }

               //关闭数据库
               objsqlconn.Close();

           }
           catch
           {
               MessageBox.Show("连接数据库失败！！！");
           }
           finally
           {
               objsqlconn.Close();
           }
         

            #endregion
        }

        public void start()
        {
            string strStuNo = string.Empty;
            string strLoginPwd = string.Empty;
            objsqlconn = new SqlConnection(sql);

            string sqlText = string.Format(" select top 1 * ")
                           + string.Format(" from Student");

            objsqlcomm = new SqlCommand(sqlText,objsqlconn);

            try
            {
                objsqlconn.Open();
                SqlDataReader dataReader = objsqlcomm.ExecuteReader();

                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        strStuNo = dataReader["StudentNo"].ToString();
                        strLoginPwd = dataReader["Loginpwd"].ToString();

                    }

                }

                txtStuNO.Text = strStuNo;
                txtLoginPwd.Text = strLoginPwd;

                cmbType.Text = "管理员";

                dataReader.Close();
                objsqlconn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败！！");
            }
            finally
            {
                objsqlconn.Close();
            }
        }
        #endregion

   
    }
}
