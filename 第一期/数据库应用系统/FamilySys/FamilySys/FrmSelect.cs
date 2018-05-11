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

namespace FamilySys
{
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }
        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = FamilySys;Integrated Security = true";

        private SqlConnection objSqlConn;

        private SqlDataAdapter dataAdapter;

        private DataSet objDS = new DataSet();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            this.SelectData();
        }

        //查询按钮
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.SelectData();
        }

        //退出按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出！", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 查询方法
        /// </summary>
        public void SelectData()
        {
            this.dgvSelect.AutoGenerateColumns = false;

            #region 设置变量
            string strName = this.txtName.Text.Trim();
            #endregion

            #region 查询操作
            try
            {
                objSqlConn = new SqlConnection(sql);

                string sqlText = "select AssetID,AssetName,AssetDate,AssetCause,AssetMoney from FamilyAssetInfo where 1=1";

                if (!string.IsNullOrEmpty(strName))
                { 
                    sqlText += string.Format(" and AssetName like '%{0}%'",strName);
                }

                dataAdapter = new SqlDataAdapter(sqlText,objSqlConn);

                if (objDS.Tables["FamilyAssetInfo"] != null)
                {
                    objDS.Tables["FamilyAssetInfo"].Clear();
                }

                dataAdapter.Fill(objDS, "FamilyAssetInfo");

                this.dgvSelect.DataSource = objDS.Tables["FamilyAssetInfo"];
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
