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

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

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
            string strStuNo = this.txtStuNo.Text.Trim();
            string strPwd = this.txtPwd.Text.Trim();
            string strPwdSure = this.txtPwdSure.Text.Trim();
            string strName = this.txtName.Text.Trim();
            string strSex = "1";
            if (this.rbtFemale.Checked)
            {
                strSex = "0";
            }
            string strGradeID = this.cmbGradeID.SelectedIndex.ToString();
            string strPhone = this.txtPhone.Text.Trim();
            string strAdress = this.txtAdress.Text.Trim();
            string strBornDate = this.dtpBornDate.Value.ToString();
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
            if (strGradeID.Equals("0"))
            {
                MessageBox.Show("请选择年级！");
                return;
            }
            if (string.IsNullOrEmpty(strPhone))
            {
                MessageBox.Show("电话不能为空！");
                return;
            }
            if (strPwdSure != strPwd)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            #endregion

            #region 新增操作
            objSqlConn = new SqlConnection(sql);

            StringBuilder objBuilder = new StringBuilder();
            objBuilder.AppendFormat(" insert into Student");
            objBuilder.AppendFormat(" (StudentNo,LoginPwd,StudentName,Sex,GradeId,Phone,BornDate,Address,Email,IDENTITYCard) ");
            objBuilder.AppendFormat(" values ({0},'{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}','{9}')", strStuNo, strPwd, strName, strSex, strGradeID, strPhone, Convert.ToDateTime(strBornDate), strAdress, strEmail, strStuNo);

            objSqlComm = new SqlCommand(objBuilder.ToString(), objSqlConn);

            try
            {
                objSqlConn.Open();

                int count = objSqlComm.ExecuteNonQuery();

                if (count >= 1)
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
            finally
            {
                objSqlConn.Close();
            }
            #endregion
        }
        #endregion

    }
}
