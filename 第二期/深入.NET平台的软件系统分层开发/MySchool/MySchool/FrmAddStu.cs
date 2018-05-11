using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySchoolBLL;
using MySchoolModel;
using MySchoolTool;

namespace MySchool
{
    public partial class FrmAddStu : Form
    {
        public FrmAddStu()
        {
            InitializeComponent();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmAddStu_Load(object sender, EventArgs e)
        {
            //绑定下拉菜单
            Public_Helper.BindDropDownList(this.cmbGradeID, "GradeId", "GradeName", "Grade", "请选择");

            this.cmbGradeID.SelectedIndex = 0;
        }

        //保存按钮事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            //保存方法
            this.SaveFunc();
        }

        //清空按钮事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            //清空方法
            this.ClearFunc();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 保存方法
        /// </summary>
        public void SaveFunc()
        {
            #region 设置变量
            //学生业务逻辑类对象
            StudentBLL objStuBLL = new StudentBLL();

            //学生实体类对象
            StudentEntity objStuEntity = new StudentEntity();

            //学号
            string strStuNO = this.txtStuNO.Text.Trim();

            //密码
            string strLoginPwd = this.txtLoginPwd.Text.Trim();

            //确认密码
            string strPwdSure = this.txtPwdSure.Text.Trim();

            //姓名
            string strStuName = this.txtStuName.Text.Trim();

            //年级
            string strGradeID = this.cmbGradeID.SelectedValue.ToString().Trim();

            //电话
            string strPhone = this.txtPhone.Text.Trim();

            //地址
            string strAddress = this.txtAddress.Text.Trim();

            //出生日期
            DateTime dtBornDate = Convert.ToDateTime(this.dtpBornDate.Value.ToString());

            //Email
            string strEmail = this.txtEmail.Text.Trim();

            //性别
            bool bolSex = true;
            if (this.rbtFemale.Checked)
            {
                bolSex = false;
            }
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(strStuNO))
            {
                MessageBox.Show("学号不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(strLoginPwd))
            {
                MessageBox.Show("密码不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(strStuName))
            {
                MessageBox.Show("姓名不能为空!");
                return;
            }
            if (strGradeID.Equals("-1"))
            {
                MessageBox.Show("请选择年级!");
                return;
            }
            if (string.IsNullOrEmpty(strPhone))
            {
                MessageBox.Show("电话不能为空!");
                return;
            }

            //密码与确认密码是否一致
            if (!strLoginPwd.Equals(strPwdSure))
            {
                MessageBox.Show("密码与确认密码不一致!");
                return;
            }

            //学号是否为数字
            try
            {
                int intTemp = int.Parse(strStuNO);

                //int intTemp1;
                //if (!int.TryParse(strStuNO, out intTemp1))
                //{
                //    MessageBox.Show("学号应为数字,请输入正确的学号!");
                //    return;
                //}
            }
            catch
            {
                MessageBox.Show("学号应为数字,请输入正确的学号!");
                return;
            }

            //学号是否已存在
            if (Public_Helper.CheckData("StudentNo", "Student", strStuNO))
            {
                MessageBox.Show("该学号已存在,请重新输入!");
                return;
            }
            #endregion

            #region 新增操作
            try
            {
                objStuEntity.StudentNo = int.Parse(strStuNO);
                objStuEntity.LoginPwd = strLoginPwd;
                objStuEntity.StudentName = strStuName;
                objStuEntity.Sex = bolSex;
                objStuEntity.GradeId = int.Parse(strGradeID);
                objStuEntity.Phone = strPhone;
                objStuEntity.Address = strAddress;
                objStuEntity.BornDate = dtBornDate;
                objStuEntity.Email = strEmail;
                objStuEntity.IdentityCard = strStuNO;

                bool result = objStuBLL.InsertStudent(objStuEntity);

                if (result)
                {
                    MessageBox.Show("新增成功!");

                    this.ClearFunc();
                }
                else
                {
                    MessageBox.Show("新增失败");
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败,请联系管理员!");
            }
            #endregion
        }

        /// <summary>
        /// 清空方法
        /// </summary>
        public void ClearFunc()
        {
            //文本框
            this.txtStuNO.Text = string.Empty;
            this.txtLoginPwd.Text = string.Empty;
            this.txtPwdSure.Text = string.Empty;
            this.txtStuName.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtEmail.Text = string.Empty;

            //单选按钮
            this.rbtMale.Checked = true;

            //下拉菜单
            this.cmbGradeID.SelectedIndex = 0;

            //日期控件
            this.dtpBornDate.Value = System.DateTime.Now;
        }
        #endregion
    }
}
