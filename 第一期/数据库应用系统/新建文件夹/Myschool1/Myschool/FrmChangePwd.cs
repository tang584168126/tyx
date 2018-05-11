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
    public partial class FrmChangePwd : Form
    {
        public FrmChangePwd()
        {
            InitializeComponent();
        }
        #region 字段

        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;Pwd=huyi1314520";
        private SqlConnection objsqlconn;
        private SqlCommand objsqlcomm;
        #endregion

        #region 属性

        //取消按钮事件
        private void btnconcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存按钮事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save();
        }
        #endregion

        #region 方法


        public void save()
        {

            #region 设置变量
            string pwd = this.txtPwd.Text.Trim();
            string newPwd = this.txtNewPwd.Text.Trim();
            string newPwd1 = this.txtNewPwd1.Text.Trim();

    
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

            #region 数据验证



            if(string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请输入原密码！！！");
                return;
            }
            if (string.IsNullOrEmpty(newPwd))
            {
                MessageBox.Show("请输入修改后的密码！！！");
                return;
            }
                  if (string.IsNullOrEmpty(newPwd1))
            {
                MessageBox.Show("请确认新密码！！！");
                return;
            }
                  if (!newPwd.Equals(newPwd1))
                  {
                      MessageBox.Show("两次输入的密码不一致请重新输入！");
                      return;
                  }


                  if (!pwd.Equals(strLoginPwd))
            {
               
                MessageBox.Show("对不起原密码不一致！！请重新输入");
                return;
            }
            #endregion
                  objsqlconn = new SqlConnection(sql);

                  StringBuilder sb = new StringBuilder();
                  sb.AppendFormat(" update Student  set ");
                  sb.AppendFormat(" Loginpwd = '{0}' ", newPwd);
                  sb.AppendFormat(" where StudentNo = '{0}' ", frmStu.strstuNO);
                  objsqlcomm = new SqlCommand(Convert.ToString(sb),objsqlconn);

                  try
                  {
                      objsqlconn.Open();

                      int result = objsqlcomm.ExecuteNonQuery();

                      if (result >= 1)
                      {
                          MessageBox.Show("保存成功！！");
                      }
                      else
                      {
                          MessageBox.Show("请检查原密码是否正确！！");
                      }



                  }
                  catch
                  {
                      MessageBox.Show("连接数据库失败！！请联系管理员！！");
                  }
                  finally
                  {
                      objsqlconn.Close();
                  }

            #region 保存操作



            #endregion
        }
        #endregion
       
    }
}
