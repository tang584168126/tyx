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
        //登录按钮事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录系统
            this.LoginSys();
        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出程序?", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 登录系统
        /// </summary>
        private void LoginSys()
        {
            #region 设置变量
            //学生实体类对象
            StudentEntity objStuEntity = new StudentEntity();

            //登录业务逻辑类对象
            LoginBLL objLoginBll = new LoginBLL();

            //用户名
            string strStuNO = this.txtStuNO.Text.Trim();

            //密码
            string strLoginPwd = this.txtLoginPwd.Text.Trim();

            //登录类型
            string strType = this.cmbType.Text.Trim();
            #endregion

            #region 数据验证

            #endregion

            #region 登录操作
            objStuEntity.StudentNo = int.Parse(strStuNO);

            objStuEntity.LoginPwd = strLoginPwd;

            try
            {
                bool result = objLoginBll.LoginSys(objStuEntity);

                if (result)
                {
                    FrmMain objMain = new FrmMain();

                    objMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败!");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败,请联系管理员!");
            }
            #endregion
        }
        #endregion

    }
}
