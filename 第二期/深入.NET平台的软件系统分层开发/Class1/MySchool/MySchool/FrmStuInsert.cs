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

using MySchoolBLL;
using MySchoolModel;
using MySchoolTool;

namespace MySchool
{
    public partial class FrmStuInsert : Form
    {
        public FrmStuInsert()
        {
            InitializeComponent();
        }
        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmStuInsert_Load(object sender, EventArgs e)
        {
            //绑定下拉菜单

            this.BindData();
        }

        //保存按钮事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }
        //清空按钮事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        #endregion

        #region 方法
        /// <summary>
        /// 加载下拉菜单选项方法
        /// </summary>
        public void BindData()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = "select GradeID,GradeName from Grade";

            objSqlComm = new SqlCommand(sqlText, objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                this.cmbGradeID.Items.Clear();      //清空下拉菜单选项

                this.cmbGradeID.Items.Add("请选择");   //添加请选择选项

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //循环添加下拉菜单选项
                        this.cmbGradeID.Items.Add(dataReader["GradeName"].ToString());
                    }
                }

                this.cmbGradeID.SelectedIndex = 0; //选中下拉菜单默认选项

                dataReader.Close();
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
        }

        /// <summary>
        /// 清空的方法
        /// </summary>
        public void ClearData()
        {
            //文本框
            this.txtStuNo.Text = string.Empty;
            this.txtPwd.Text = string.Empty;
            this.txtPwdSure.Text = string.Empty;

            this.txtName.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtAdress.Text = string.Empty;
            this.txtEmail.Text = string.Empty;

            //单选框
            this.rbtMale.Checked = true;

            //下拉菜单
            this.cmbGradeID.SelectedIndex = 0;

            //日期控件
            this.dtpBornDate.Value = System.DateTime.Now;
        }

        /// <summary>
        /// 保存的方法
        /// </summary>
        public void SaveData()
        {
            #region 设置变量
            //学生业务逻辑类对象
            StudentBLL objStuBLL = new StudentBLL();

            //学生实体类对象
            StudentEntity objStuEnity = new StudentEntity();

            //学号
            string strStuNo = this.txtStuNo.Text.Trim();

            //密码
            string strPwd = this.txtPwd.Text.Trim();

            //确认密码
            string strPwdSure = this.txtPwdSure.Text.Trim();

            //姓名
            string strName = this.txtName.Text.Trim();
            bool strSex = false;
            if (this.rbtFemale.Checked)
            {
                strSex = true;
            }

            //年级
            string strGradeID = this.cmbGradeID.SelectedValue.ToString().Trim();

            //电话
            string strPhone = this.txtPhone.Text.Trim();

            //地址
            string strAdress = this.txtAdress.Text.Trim();

            //出生日期
            DateTime dtBornDate = Convert.ToDateTime(this.dtpBornDate.Value.ToString());

            //Email
            string strEmail = this.txtEmail.Text.Trim();
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(strStuNo))
            {
                MessageBox.Show("学号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("姓名不能为空！");
                return;
            }
            if (strGradeID.Equals("-1"))
            {
                MessageBox.Show("请选择年级！");
                return;
            }
            if (string.IsNullOrEmpty(strPhone))
            {
                MessageBox.Show("电话不能为空！");
                return;
            }

            //密码与确认密码是否一致
            if (strPwdSure.Equals(strPwd))
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }

            //学号是否为数字
            try
            {
                int intTemp = int.Parse(strStuNo);

                //int intTemp1;
                //if(!int.TryParse(strStuNo,out intTemp1))
                //{
                //    MessageBox.Show("学号应为数字，请输入正确的学号！");
                //    return;
                //}
            }
            catch
            {
                MessageBox.Show("学号应为数字，请输入正确的学号！");
                return;
            }
            //学号是否已存在
            if(Public_Helper.CheckData("StudentNo","Student",strStuNo))
            {
                MessageBox.Show("该学号已存在，请重新输入！");
                return;
            }
            #endregion

            #region 新增操作
            try
            {
                objStuEnity.StudentNo = int.Parse(strStuNo);
                objStuEnity.LoginPwd = strPwd;
                objStuEnity.StudentName = strName;
                objStuEnity.Sex = strSex;
                objStuEnity.GradeId = int.Parse(strGradeID);
                objStuEnity.Phone = strPhone;
                objStuEnity.Adress = strAdress;
                objStuEnity.BornDate = Convert.ToDateTime(dtBornDate);
                objStuEnity.Email = strEmail;

                bool result = objStuBLL.InsertStudent(objStuEnity);

                if (result)
                {
                    MessageBox.Show("新增成功！");
                    this.ClearData();
                }
                else
                {
                    MessageBox.Show("新增失败！");
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败，请联系管理员！");
            }
            #endregion
        }
        #endregion
    }
}
