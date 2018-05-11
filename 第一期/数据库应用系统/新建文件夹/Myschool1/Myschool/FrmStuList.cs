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
    public partial class FrmStuList : Form
    {
        public FrmStuList()
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

        //窗体加载事件
        private void FrmStuList_Load(object sender, EventArgs e)
        {
            //查询学生信息
            this.QueryData();

        }
        //修改单击事件
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuUpdate objStuUpdate = new FrmStuUpdate();

            if (this.lvStuList.SelectedItems.Count != 0)
            {
                string strStuNo = this.lvStuList.SelectedItems[0].Text.Trim();

                objStuUpdate.MdiParent = this.MdiParent;

                objStuUpdate.StuNo = strStuNo;

                objStuUpdate.Show();
            }

            else 
            {
                MessageBox.Show("请选择需要修改的学生信息！");
            }

        }

        //删除单击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否有数据被选中
            if (this.lvStuList.SelectedItems.Count != 0)
            {
                //确定是否删除
                DialogResult result = MessageBox.Show("确定要删除此学生信息吗？？","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if(result==DialogResult.OK)
                {
                    //删除数据
                    this.deleteData();
                }
                
            }
            else
            {
                MessageBox.Show("请选择需要删除的学生信息！");
            }
        }

        private void 刷新列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.QueryData();
        }

 
        #endregion

        #region 方法
        /// <summary>
        /// 查询学生信息
        /// </summary>
        public void QueryData()
        {
            #region 设置变量 
            #endregion

            #region 数据验证
            #endregion

            #region 查询方法
            //创建连接对象
            objsqlconn = new SqlConnection(sql);

            //创建执行命令
            string sqlText = string.Format(" select StudentNo,StudentName,sex,GradeId,phone,bornDate,Address,Email ")
            + string.Format(" from Student");

            //创建执行对象
            objsqlcomm = new SqlCommand(sqlText, objsqlconn);

            try
            {
                //打开数据库
                objsqlconn.Open();

                //执行操作
                SqlDataReader dataReader = objsqlcomm.ExecuteReader();

                //处理数据
                this.lvStuList.Items.Clear();

                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
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

                        this.lvStuList.Items.Add(objItem);
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
            #endregion


        }
        
        /// <summary>
        /// 删除学生信息
        /// </summary>
        public void deleteData()
        {

            #region 设置变量
            string strStuNo = this.lvStuList.SelectedItems[0].Text.Trim();
            #endregion

            #region 删除操作

            objsqlconn = new SqlConnection(sql);

            string sqlText = "delete student where StudentNo = "+strStuNo;

            objsqlcomm = new SqlCommand(sqlText,objsqlconn);

            try
            {
                objsqlconn.Open();

                int result = objsqlcomm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("删除成功！！");

                    //刷新数据！
                    this.QueryData();
           
                }
                else
                {

                    MessageBox.Show("删除失败！！");
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
        }
        #endregion

  



 
    }
}
