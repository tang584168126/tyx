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

namespace FormMain
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        #region 字段
        //创建数据库连接字符串
        private string sql = @"Data Source = WIN-0HN87S676NI, Initial Catalog = GoodsManager, Integrated Security = true";

        //创建数据库连接对象
        private SqlConnection objSqlConn;

        //创建执行对象

        private SqlDataAdapter dataAdapter;

        private DataSet objDS = new DataSet();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
        //查询按钮事件
        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
        //关闭按钮事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 查询数据
        /// </summary>
        public void QueryData()
        {
            this.dgvList.AutoGenerateColumns = false;

            #region 设置变量
            string strName = this.txtName.Text.Trim();
            #endregion

            #region 查询操作
            try
            {
                objSqlConn = new SqlConnection(sql);
                string sqlText = "select a.pcName,b.brand,a.pcPrice,a.pcDetail,a.timeStamp from PcInfo as a inner join Brand as b on a.brandId = b.id where 1=1";
                if(!string.IsNullOrEmpty("strName"))
                {
                    sqlText += string.Format(" and pcName like '%{0}%'",strName);
                }
                dataAdapter = new SqlDataAdapter(sqlText,objSqlConn);

                
                }
            }
            catch 
            {
                MessageBox.Show("数据库连接失败！");
            }
            finally 
            { 
            
            }
            #endregion
        }
        #endregion
    }
}
