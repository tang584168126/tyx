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
    public partial class FrmSubList : Form
    {
        public FrmSubList()
        {
            InitializeComponent();
        }

        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = MySchool182;User ID = sa;Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlDataAdapter dataAdapter;

        private DataSet objDS = new DataSet();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmSubList_Load(object sender, EventArgs e)
        {
            this.BindDropDownList();
            this.QueryData();
        }

        //查询按钮事件
        private void btnQuary_Click(object sender, EventArgs e)
        {
            this.QueryData();
        }

        //更新按钮事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder objCommBuilder = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(objDS, "Subject");

            MessageBox.Show("更新成功！");
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
                objSqlConn = new SqlConnection(sql);

                string sqlText = "select GradeID,GradeName from Grade";

                dataAdapter = new SqlDataAdapter(sqlText, objSqlConn);

                DataSet objDS1 = new DataSet();
                dataAdapter.Fill(objDS1,"Grade");

                DataRow objDR = objDS1.Tables["Grade"].NewRow();
                objDR["GradeID"] = -1;
                objDR["GradeName"] = "全部";
                objDS1.Tables["Grade"].Rows.InsertAt(objDR,0);

                this.cmbGradeID.DataSource = objDS1.Tables["Grade"];
                this.cmbGradeID.DisplayMember = "GradeName";
                this.cmbGradeID.ValueMember = "GradeID";
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        public void QueryData()
        {
            this.dgvSubList.AutoGenerateColumns = false;

            #region 设置变量
            //课程名称
            string strSubName = this.txtGradeName.Text.Trim();

            //年级
            string strGradeID = this.cmbGradeID.SelectedValue.ToString();
            #endregion

            #region 查询操作
            try
            {
                objSqlConn = new SqlConnection(sql);

                string sqlText = "select SubjectNo,SubjectName,GradeId,ClassHour from Subject where 1=1";

                if(!string.IsNullOrEmpty(strSubName))
                {
                    sqlText += string.Format(" and SubjectName like '%{0}%'",strSubName);
                }
                if (!strGradeID.Equals("-1"))
                {
                    sqlText += string.Format(" and GradeID = {0}",strGradeID);
                }

                dataAdapter = new SqlDataAdapter(sqlText,objSqlConn);

                if (objDS.Tables["Subject"] != null)
                {
                    objDS.Tables["Subject"].Clear();
                }
                dataAdapter.Fill(objDS,"Subject");

                this.dgvSubList.DataSource = objDS.Tables["Subject"];
            }
            catch 
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }
            #endregion
        }
        #endregion

       

        
    }
}
