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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        #region 字段
        //创建数据库连接字符串
        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;Pwd=huyi1314520";

        //创建连接对象
        private SqlConnection objsqlconn;

        //创建执行对象
        private SqlCommand objsqlcomm;
        #endregion

        #region 属性
        #endregion

        #region 事件

        //窗体加载事件
        private void FrmInsert_Load(object sender, EventArgs e)
        {
            this.BindData();

        }

        //清空按钮事件
        private void btnConcel_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        //保存按钮事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        //窗口关闭时的事件

        #endregion

        #region 方法

        /// <summary>
        /// 加载下拉菜单选项方法
        /// </summary>
        public void BindData()
        {

            #region 设置变量
            //利用连接字符串创建连接对象
            objsqlconn = new SqlConnection(sql);

            //创建执行命令
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select GradeName , GradeId");
            sb.AppendFormat(" from Grade ");
          
            //利用连接对象和执行命令 创建执行对象
            objsqlcomm = new SqlCommand(Convert.ToString(sb),objsqlconn);

            try
            {
                //打开数据库
                objsqlconn.Open();

                //执行操作
                SqlDataReader dataReader = objsqlcomm.ExecuteReader();

                //清空下拉菜单选项
                this.cmbGradID.Items.Clear();

                //添加下拉菜单数据
                this.cmbGradID.Items.Add("请选择");

                //判断是否有数据
                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {

                        //循环添加下拉菜单选项
                        this.cmbGradID.Items.Add(dataReader["GradeName"].ToString());


                    }
                }

                //设置下拉选项第一行的值
                this.cmbGradID.SelectedIndex=0;

                //关闭数据库
                objsqlconn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败");
            }
            finally
            {
                objsqlconn.Close();
            }
            #endregion

            #region 验证数据
            #endregion

            #region 加载操作

            #endregion
        }

        /// <summary>
        /// 清空数据方法
        /// </summary>
        public void ClearData()
        {
            //学号清空
            this.txtStuNo.Text = string.Empty;

            //密码清空
            this.txtPwd.Text = string.Empty;

            //密码清空
            this.txtPwd1.Text = string.Empty;

            //名字清空
            this.txtName.Text = string.Empty;

            //电话清空
            this.txtPhone.Text = string.Empty;

            //地址清空
            this.txtAddess.Text = string.Empty;

            //Email清空
            this.txtEmail.Text = string.Empty;

            //性别默认
            this.rbtMale.Checked = true;

            //年级默认
            this.cmbGradID.SelectedIndex = 0;

            //事件默认当前时间
            this.dtpBornDate.Value = System.DateTime.Now;
        }

        /// <summary>
        /// 保存数据方法
        /// </summary>
        public void Save()
        {
            #region 设置变量
            //学号
            string stuNo = this.txtStuNo.Text.Trim();

            //密码
            string strPwd = this.txtPwd.Text.Trim();

            //密码
            string strPwd1 = this.txtPwd1.Text.Trim();

            //姓名
            string strName = this.txtName.Text.Trim();

            //性别
            string strSex = "1";

            //如果单选按钮被选中则给其值(1为默认的男 0为女)
            if(this.rbtFemale.Checked==true)
            {
                strSex = "0";
            }

            //学号
            string strGradeID = this.cmbGradID.SelectedIndex.ToString();

            //电话
            string strPhone = this.txtPhone.Text.Trim();

            //地址
            string strAdess = this.txtAddess.Text.Trim();

            //出生日期
            string strBornDate = this.dtpBornDate.Value.ToString();

            //Email
            string strEmail = this.txtEmail.Text.Trim();

            #endregion 

            #region 数据验证

            //判断学号是否没填
            if (string.IsNullOrEmpty(stuNo))
            {
                MessageBox.Show("请输入学号！！");
                return;
            }

            //判断密码是否没填
            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("请输入密码！！");
                return;
            }

            //判断确认密码是否没填
            if (string.IsNullOrEmpty(strPwd1))
            {
                MessageBox.Show("请确认密码！！");
                return;
            }

            //判断两次输入的密码是否一致
            if (!strPwd.Equals(strPwd1))
            {
                MessageBox.Show("抱歉两次输入的密码不一致！！");
                return;
            }

            //判断姓名是否没填
            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("请输入姓名！！");
                return;
            }

            //判断性别
            if (!rbtFemale.Checked)
            {
                this.lblts.Text = "未点击";  
               
          
            }

            //判断年级是否没选择
            if(this.cmbGradID.SelectedIndex==0)
            {
                MessageBox.Show("请选择年级");
                return;
            }

            //判断电话是否为空
            if (string.IsNullOrEmpty(strPhone))
            {
                MessageBox.Show("请输入电话");
                return;
            }

            objsqlconn = new SqlConnection(sql);

            string sqlText = string.Format(" select count(*) ")
                        + string.Format(" from Student ")
                        + string.Format(" where StudentNo = {0} ", stuNo);
            objsqlcomm = new SqlCommand(sqlText,objsqlconn);

            try
            {
                objsqlconn.Open();

                int result = (int)objsqlcomm.ExecuteScalar();

                if (result == 1)
                {
                    MessageBox.Show("学号已存在！请重新输入");
                    return;
                    
                }
                else
                {
 
                }


            }
            catch
            {
                MessageBox.Show("连接数据库失败！！");
            }
            finally
            {
                objsqlconn.Close();
            }
            
            #endregion

            #region 新增操作

            objsqlconn = new SqlConnection(sql);

            StringBuilder sb = new StringBuilder();


            sb.AppendFormat(" insert into Student ");

            sb.AppendFormat(" ( StudentNo , Loginpwd , StudentName , sex , GradeId , phone , bornDate , Address , Email , IDENTITYCard ) ");

            sb.AppendFormat(" values ");

            sb.AppendFormat(" ({0}, '{1}' , '{2}' , {3} , {4} , '{5}' , '{6}' , '{7}' , '{8}' , '{9}') ", stuNo, strPwd, strName, strSex, strGradeID, strPhone, Convert.ToDateTime(strBornDate), strAdess, strEmail, stuNo);

            objsqlcomm = new SqlCommand(Convert.ToString(sb),objsqlconn);

            try
            {
                objsqlconn.Open();

                int result = objsqlcomm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("新增成功");
                }
                else
                {
                    MessageBox.Show("新增失败");
                }
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
            #endregion
        }
        #endregion



 



   
    }
}
