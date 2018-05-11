using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySchoolBLL;
using MySchoolModel;

namespace MySchool
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 字段
        
        #endregion

        #region 属性

        #endregion

        #region 事件
        //登陆按钮事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoginSys();
        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消吗","取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 登陆方法
        /// </summary>
        private void LoginSys()
        {
            #region 设置变量
            //学生实体类对象
            StudentEntity objStuEntity = new StudentEntity();

            //登陆业务逻辑类对象
            LoginBLL objLoginBLL = new LoginBLL();

            //用户名
            string strStuNo = this.txtStuNo.Text.Trim();

            //密码
            string strLoginPwd = this.txtLoginPwd.Text.Trim();

            //登陆类型
            string strType = this.cmbType.Text.Trim();
            #endregion

            #region 数据验证

            #endregion

            #region 登陆操作
            objStuEntity.StudentNo = int.Parse(strStuNo);

            objStuEntity.LoginPwd = strLoginPwd;
            try
            {
                bool result = objLoginBLL.LoginSys(objStuEntity);

                if (result)
                {
                    MessageBox.Show("登陆成功！");

                    //窗体跳转
                    FrmMain objMain = new FrmMain();

                    objMain.Show();

                    //隐藏当前窗体
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登陆失败！");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }

            
            #endregion
        }
        #endregion
    }
}
