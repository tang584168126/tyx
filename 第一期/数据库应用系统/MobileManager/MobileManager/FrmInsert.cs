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

namespace MobileManager
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = MobileManager; User ID = sa; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //加载下拉列表事件
        private void FrmInsert_Load(object sender, EventArgs e)
        {
            this.BinData();
        }

        //增加按钮事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddData();
        }

        //清空按钮事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        //关闭按钮事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载下拉菜单
        /// </summary>
        public void BinData()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = string.Format("select BrandID,Brand from MobileBrand");

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        this.cmbBrandID.Items.Add(dataReader["Brand"].ToString());
                    }
                }

                this.cmbBrandID.SelectedIndex = 0;

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
        /// 清空的方法
        /// </summary>
        public void ClearData()
        {
            this.txtType.Text = string.Empty;

            this.txtPrice.Text = string.Empty;

            this.txtSize.Text = string.Empty;

            this.txtWeight.Text = string.Empty;

            this.txtStyle.Text = string.Empty;

            this.cmbBrandID.SelectedIndex = 0;
        }

        /// <summary>
        /// 增加的方法
        /// </summary>
        public void AddData()
        {
            string strBandID = this.cmbBrandID.SelectedIndex.ToString();
            string strType = this.txtType.Text.Trim();
            string strPrice = this.txtPrice.Text.Trim();
            string strSize = this.txtSize.Text.Trim();
            string strWeight = this.txtWeight.Text.Trim();
            string strStyle = this.txtStyle.Text.Trim();

            if(string.IsNullOrEmpty(strType))
            {
                MessageBox.Show("手机型号不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strPrice))
            {
                MessageBox.Show("手机价格不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strSize))
            {
                MessageBox.Show("手机尺寸不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strWeight))
            {
                MessageBox.Show("重量不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strStyle))
            {
                MessageBox.Show("终端款式不能为空！");
                return;
            }
            objSqlConn = new SqlConnection(sql);

            StringBuilder objBuilder = new StringBuilder();
            objBuilder.AppendFormat("insert into MobileInfo");
            objBuilder.AppendFormat(" (ID,BrandID,Type,Price,Size,Weight,Style)");
            objBuilder.AppendFormat(" values ({0},'{1}',{2},'{3}','{4}','{5}')", strBandID, strType, strPrice, strSize, strWeight, strStyle);

            objSqlComm = new SqlCommand(objBuilder.ToString(),objSqlConn);

            try
            {
                objSqlConn.Open();

                int count = objSqlComm.ExecuteNonQuery();

                if (count >= 1)
                {
                    MessageBox.Show("增加成功！");
                    this.ClearData();
                }
                else
                {
                    MessageBox.Show("增加失败！");
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
        }
        #endregion      
    }
}
