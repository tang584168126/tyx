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
    public partial class FrmStuInsert : Form
    {
        public FrmStuInsert()
        {
            InitializeComponent();
        }

        #region 字段

        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;pwd=huyi1314520";

        private SqlConnection objsqlconn;

        private SqlCommand objsqlcomm;
        #endregion

        #region 属性


        #endregion

        #region 事件
        private void FrmStuInsert_Load(object sender, EventArgs e)
        {
            cmbSex.Text = "男";
        }

        //新增事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save();
        }


        private void btnConcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 方法

        //新增操作
        public void save()
        {
            #region  设置变量

            int a = 0;

            string stuNo = this.txtStuNo.Text.Trim();

            string pwd = this.txtPwd.Text.Trim();

            string name = this.txtName.Text.Trim();

            string sex = this.cmbSex.Text.Trim();

            string gradID = this.txtGradID.Text.Trim();

            string phone = this.txtPhone.Text.Trim();

            string bornDate = this.txtBornDate.Text.Trim();

            string addess = this.txtAddess.Text.Trim();

            string email = this.txtEmail.Text.Trim();

            
            #endregion 

            #region  数据验证

            if (sex.Equals("男"))
            {
                 a = 1;
            }
            else 
            {
                a = 0;
            }

            if (string.IsNullOrEmpty(stuNo))
            {
                MessageBox.Show("学号不能为空！！！");
                return;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空！！！");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不能为空！！！");
                return;
            }

            if (string.IsNullOrEmpty(gradID))
            {
                MessageBox.Show("年级不能为空！！！");
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("电话不能为空！！！");
                return;
            }



            if (string.IsNullOrEmpty(bornDate))
            {
                MessageBox.Show("出生日期不能为空！！！");
                return;
            }


            #endregion

            #region  新增操作
            objsqlconn = new SqlConnection(sql);

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(" insert into Student ");

            sb.AppendFormat(" ( StudentNo , Loginpwd , StudentName , sex , GradeId , phone , bornDate , Address , Email , IDENTITYCard ) ");

            sb.AppendFormat(" values ");

            sb.AppendFormat(" ({0}, '{1}' , '{2}' , {3} , {4} , '{5}' , '{6}' , '{7}' , '{8}' , '{9}') ", stuNo , pwd, name, a, gradID , phone, Convert.ToDateTime(bornDate), addess, email, stuNo);

            objsqlcomm = new SqlCommand(Convert.ToString(sb),objsqlconn);

            try
            {
                objsqlconn.Open();

                int result = objsqlcomm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("新增成功！！");

                }
                else
                {

                    MessageBox.Show("新增失败！！");
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败 ！！！");
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
