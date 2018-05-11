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
    public partial class FrmANJCX : Form
    {
        public FrmANJCX()
        {
            InitializeComponent();
        }
        #region 字段
        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;Pwd=huyi1314520";

        private SqlConnection objsqlconn;

        private SqlCommand objsqlcomm;

        #endregion

        #region 属性
        #endregion

        #region 事件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.select();
        }
        #endregion

        #region 方法
        public void select()
        {
            #region 设置变量
            string Name = this.txtName.Text.Trim();

            #endregion

            #region 验证数据

            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("请输入要查询的年级！！！");
                return;
            }

            #endregion

            #region 查询方法
            this.lvSelect1.Items.Clear();
            this.lblyc.Text = string.Empty;
            //创建连接对象
            objsqlconn = new SqlConnection(sql);

            //创建执行命令
            string sqlText = string.Format(" select count(*) ")
            + string.Format(" from Student")
            + string.Format(" where GradeId = {0} ", Name);
            //创建执行对象
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
                    this.lvSelect1.View = View.Details;
                    objsqlconn.Close();
                    objsqlconn = new SqlConnection(sql);
                    string sqlText1 = string.Format(" select StudentNo,StudentName,sex,GradeId,phone,bornDate,Address,Email ")
                      + string.Format(" from Student")
                      + string.Format(" where GradeId = {0} ", Name);
                    objsqlcomm = new SqlCommand(sqlText1, objsqlconn);
                    try
                    {
                        //打开数据库
                        objsqlconn.Open();

                        //执行操作
                        SqlDataReader dataReader = objsqlcomm.ExecuteReader();

                        //处理数据
                        this.lvSelect1.Items.Clear();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                //添加项
                                ListViewItem objItem = new ListViewItem(dataReader["StudentNo"].ToString());

                                //添加子项
                                objItem.SubItems.Add(dataReader["StudentName"].ToString());

                                objItem.SubItems.Add(dataReader["sex"].ToString());

                                objItem.SubItems.Add(dataReader["GradeId"].ToString());

                                objItem.SubItems.Add(dataReader["phone"].ToString());

                                objItem.SubItems.Add(dataReader["bornDate"].ToString());

                                objItem.SubItems.Add(dataReader["Address"].ToString());

                                objItem.SubItems.Add(dataReader["Email"].ToString());

                                //加载ListView中

                                this.lvSelect1.Items.Add(objItem);
                            }
                        }

                        //关闭数据库
                        objsqlconn.Close();

                    }
                    catch
                    {
                        MessageBox.Show("连接数据库失败!!!");
                    }
                    finally
                    {
                        objsqlconn.Close();
                    }



                }
                else
                {
                    this.lvSelect1.View = View.LargeIcon;
                    objsqlconn.Close();
                    this.lblyc.Text = "经查询没有该年级！！";
                    return;
                }

                //关闭数据库
                objsqlconn.Close();

            }
            catch
            {
                MessageBox.Show("连接数据库失败!!!");
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
