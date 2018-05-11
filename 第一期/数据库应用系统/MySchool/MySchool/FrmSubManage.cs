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
    public partial class FrmSubManage : Form
    {
        public FrmSubManage()
        {
            InitializeComponent();
        }

        

        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlDataAdapter dataAdapter;

        private DataSet objDS = new DataSet();

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmSubManage_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        //树形控件节点选中后事件
        private void tvGradeID_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.QuaryData();
        }

        //删除按钮
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否有数据被选中
            if (this.dgvSubList.SelectedRows.Count > 0)
            {
                //确定删除
                DialogResult result = MessageBox.Show("确定删除吗？","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
 
                }
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载数据
        /// </summary>
        public void LoadData()
        {

            //设置DataGridView手动绑定
            try
            {
                objSqlConn = new SqlConnection(sql);

                string sqlText = "select a.SubjectNo, a.SubjectName,a.GradeId,b.GradeName,a.ClassHour"
                +" from Subject as a"
                + " left join Grade as b on a.GradeId = b.GradeId";

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
        }

        /// <summary>
        /// 筛选数据
        /// </summary>
        public void QuaryData()
        { 
            //年级编号
            string strGradeID = string.Empty;

            #region 获取树形菜单节点值（第一种方法）
            strGradeID = this.tvGradeID.SelectedNode.Text.Trim();

            switch(strGradeID)
            {
                case "S1年级":
                    strGradeID = "1";
                    break;

                case "S2年级":
                    strGradeID = "2";
                    break;

                case "S3年级":
                    strGradeID = "3";
                    break;
                default:
                    strGradeID = null;
                    break;
            }
            #endregion

            #region 获取树形菜单节点值（第二种方法）
            if (this.tvGradeID.SelectedNode.Tag != null)
            {
                strGradeID = this.tvGradeID.SelectedNode.Tag.ToString().Trim();
            }
            #endregion

            #region 筛选数据
            //创建数据视图
            DataView objDV = new DataView(objDS.Tables["Subject"]);

            //筛选数据
            if (!string.IsNullOrEmpty(strGradeID))
            {
                objDV.RowFilter = " GradeId = " + strGradeID;
            }
            
            //绑定数据
            this.dgvSubList.DataSource = objDV;
            #endregion
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        public void DeleteData()
        {
            #region 设置变量
            string strSubNO = this.dgvSubList.SelectedRows[0].Cells["Column1"].Value.ToString();

            #endregion

            #region 删除操作
            objSqlConn = new SqlConnection(sql);

            string sqlText = "delete from Subject where SubjectNo = " + strSubNO;

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = objSqlComm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("删除成功！");
                    this.LoadData();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
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
