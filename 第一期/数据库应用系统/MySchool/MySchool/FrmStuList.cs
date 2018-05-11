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
    public partial class FrmStuList : Form
    {
        public FrmStuList()
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
        private void FrmStuList_Load(object sender, EventArgs e)
        {
            this.QueryData();
        }
        //修改按钮事件
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否数据被选中
            if (this.lvStuList.SelectedItems.Count != 0)
            {
                //学号
                string strStuNO = this.lvStuList.SelectedItems[0].Text.Trim();

                FrmStuUpdate objStuUpdate = new FrmStuUpdate();

                objStuUpdate.MdiParent = this.MdiParent;

                objStuUpdate.StuNO = strStuNO;
                objStuUpdate.Show();
            }
            else 
            {
                MessageBox.Show("请选择需要删除的学生信息！");
            }
        }
        //删除按钮事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否有数据被选中
            if (this.lvStuList.SelectedItems.Count != 0)
            {
                //确定删除
                DialogResult result = MessageBox.Show("确定删除此学生？","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if(result == DialogResult.OK)
                {
                    //删除数据
                    this.DeleteData();
                }
            }
            else
            {
                MessageBox.Show("请选择需要删除的学生信息！");
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 查询学生信息
        /// </summary>
        public void QueryData()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = string.Format("select StudentNo,StudentName,Sex,GradeID,Phone,BornDate,Address,Email from Student");

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                this.lvStuList.Items.Clear();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //添加项
                        ListViewItem objItem = new ListViewItem(dataReader["StudentNo"].ToString());

                        //添加子项
                        objItem.SubItems.Add(dataReader["StudentName"].ToString());
                        objItem.SubItems.Add(dataReader["Sex"].ToString());
                        objItem.SubItems.Add(dataReader["GradeID"].ToString());
                        objItem.SubItems.Add(dataReader["Phone"].ToString());
                        objItem.SubItems.Add(dataReader["BornDate"].ToString());
                        objItem.SubItems.Add(dataReader["Address"].ToString());
                        objItem.SubItems.Add(dataReader["Email"].ToString());

                        //加载ListView中
                        this.lvStuList.Items.Add(objItem);
                    }
                }

                dataReader.Close();
                objSqlConn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败，请联系管理员！");
            }
            finally
            {
                objSqlConn.Close();
            }
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        public void DeleteData()
        { 
            #region 设置变量
            string strStuNO = this.lvStuList.SelectedItems[0].Text.Trim();

            #endregion 删除操作
            objSqlConn = new SqlConnection(sql);

            string sqlText = "delete Student where StudentNo = " + strStuNO;

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = objSqlComm.ExecuteNonQuery();

                if(result >= 1)
                {
                    MessageBox.Show("删除成功！");
                    //刷新数据
                    this.QueryData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

                objSqlConn.Close();
            }
            catch
            {
                MessageBox.Show("连接数据库失败，请联系管理员！");
            }
            finally
            {
                objSqlConn.Close();
            }
            #region

            #endregion
        }

        #endregion

        
    }
}
