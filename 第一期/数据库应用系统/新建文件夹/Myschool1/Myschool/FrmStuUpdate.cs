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
    public partial class FrmStuUpdate : Form
    {
        public FrmStuUpdate()
        {
            InitializeComponent();
        }
        #region  字段
        private string stuNo;

        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;Pwd=huyi1314520";

       private SqlConnection objsqlconn;

       private SqlCommand objsqlcomm;
        #endregion 

        #region  属性

        public string StuNo
        {
            get { return stuNo; }
            set { stuNo = value; }
        }
        #endregion 

        #region  事件

        private void FrmStuUpdate_Load(object sender, EventArgs e)
        {
            this.BindData();

            this.select();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }


        private void btnConcel_Click(object sender, EventArgs e)
        {

            this.select();
        }

        #endregion 
    
        #region  方法
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
            objsqlcomm = new SqlCommand(Convert.ToString(sb), objsqlconn);

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
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        //循环添加下拉菜单选项
                        this.cmbGradID.Items.Add(dataReader["GradeName"].ToString());


                    }
                }

                //设置下拉选项第一行的值
                this.cmbGradID.SelectedIndex = 0;

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

        public void select()
        {
            #region 设置变量
            #endregion

            #region 方法
            objsqlconn = new SqlConnection(sql);

            string sqlText = " select StudentNo , StudentName , sex , GradeId , phone , bornDate , Address , Email"
                + " from Student"
                + " where StudentNo =" + this.StuNo;

            objsqlcomm = new SqlCommand(sqlText,objsqlconn);

            try
            {
                objsqlconn.Open();

                SqlDataReader dataReader = objsqlcomm.ExecuteReader();

                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        this.txtStuNo.Text = stuNo;

                        this.txtName.Text = dataReader["StudentName"].ToString();

                        if(dataReader["sex"].ToString().Equals("False"))
                        {
                            rbtFemale.Checked = true;

                        }
                    
                        this.cmbGradID.SelectedIndex=int.Parse(dataReader["GradeId"].ToString());

                        this.txtPhone.Text = dataReader["phone"].ToString();

                        this.txtAddess.Text = dataReader["Address"].ToString();

                        this.dtpBornDate.Value=Convert.ToDateTime(dataReader["bornDate"].ToString());

                        this.txtEmail.Text = dataReader["Email"].ToString();
                    }
                }

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


            #endregion
        }

        public void Save()
        {
            #region 设置变量
            //学号
            string stuNo = this.txtStuNo.Text.Trim();

            //姓名
            string strName = this.txtName.Text.Trim();

            //性别
            string strSex = "1";

            //如果单选按钮被选中则给其值(1为默认的男 0为女)
            if (this.rbtFemale.Checked == true)
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
            if (this.cmbGradID.SelectedIndex == 0)
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

         
            #endregion

            #region 修改操作

            objsqlconn = new SqlConnection(sql);

            StringBuilder sb = new StringBuilder();


            sb.AppendFormat(" update  Student set ");

            sb.AppendFormat(" StudentName ='{0}',sex={1},GradeId={2},phone='{3}',Address='{4}', bornDate='{5}', Email='{6}'", strName, strSex, strGradeID, strPhone, strAdess, Convert.ToDateTime(strBornDate), strEmail);

            sb.AppendFormat(" where StudentNo='{0}' ",this.StuNo);
         

            objsqlcomm = new SqlCommand(Convert.ToString(sb), objsqlconn);

            try
            {
                objsqlconn.Open();

                int result = objsqlcomm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
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
