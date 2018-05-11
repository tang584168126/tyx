using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//引用命名空间
using System.Data.Sql;
using System.Data.SqlClient;
namespace Myschool
{
    public partial class FrmSubList : Form
    {
        public FrmSubList()
        {
            InitializeComponent();
        }
        #region 字段
        //创建连接字符串
        private string sql = @"data source=胡逸的电脑;initial catalog=myschool182;user ID=sa;Pwd=huyi1314520";

        //利用数据库连接字符串 创建 连接对象
        private SqlConnection objsqlconn;

        //创建数据适配器
        SqlDataAdapter dataAdepter;

        DataSet objDT = new DataSet();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体下拉菜单事件
        private void txtSubName_Load(object sender, EventArgs e)
        {
            this.BindDropDownList();

            this.QueryData();
        }
        //查询按钮事件
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.QueryData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.BindDropDownList();

            txtSubName.Text = string.Empty;
            this.QueryData();
        }

        private void txtSubName_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region 方法
        /// <summary>
        /// 绑定下拉菜单
        /// </summary>
        public void BindDropDownList()
        { 
            try
            {
                //利用数据库连接字符串 创建 连接对象
                objsqlconn = new SqlConnection(sql);
                //创建Sql命令

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat(" select GradeID,GradeName ");
                sb.AppendFormat(" from Grade");

                //利用数据库连接字符串 创建 数据适配器
                dataAdepter = new SqlDataAdapter(Convert.ToString(sb), objsqlconn);

                //填充数据集
                DataSet objDS1 = new DataSet();
                dataAdepter.Fill(objDS1,"Grade");

                DataRow objDR = objDS1.Tables["Grade"].NewRow();
                objDR["GradeID"] = -1;
                objDR["GradeName"] = "全部";

                objDS1.Tables["Grade"].Rows.InsertAt(objDR, 0);
                //处理数据
                this.cmbGreadID.DataSource = objDS1.Tables["Grade"];
                this.cmbGreadID.DisplayMember = "GradeName";
                this.cmbGreadID.ValueMember = "GradeID";

     
            }
            catch
            {
                MessageBox.Show("连接数据库失败！！！");
            }

        }

        public void QueryData()
        {
            #region 设置变量
            string StrSubName = this.txtSubName.Text.Trim();

            string strGradeID = this.cmbGreadID.SelectedValue.ToString();
            #endregion
      
            #region 查询操作
            try
            {
                objsqlconn = new SqlConnection(sql);

                string sqlText = "select * "
                    + " from Subject "
                    + " where 1 = 1 ";
                if (!string.IsNullOrEmpty(StrSubName))
                {
                    sqlText += string.Format(" and SubjectName like '%{0}%'", StrSubName);
                }

                if (!strGradeID.Equals("-1"))
                {
                    sqlText += " and GradeId  =" + strGradeID;
                }

                dataAdepter = new SqlDataAdapter(sqlText,objsqlconn);

                if(objDT.Tables["Subject"]!=null)
                {
                    objDT.Tables["Subject"].Clear();
                }

                dataAdepter.Fill(objDT,"Subject");
          

                dgvSubList.DataSource = objDT.Tables["Subject"];


            }
            catch
            {
                MessageBox.Show("连接数据库失败！！！");
            }
            #endregion
        }
        #endregion


     

    }
}
