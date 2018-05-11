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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        #region 字段
        //创建数据库连接字符串
        private string sql = @"Data Source = WIN-0HN87S676NI, Initial Catalog = GoodsManager, Integrated Security = true";

        //创建数据库连接对象
        private SqlConnection objSqlConn;

        //创建执行对象
        private SqlCommand objSqlComm;

        #endregion

        #region 属性
        
        #endregion

        #region 事件
        //窗体加载事件
        private void InsertForm_Load(object sender, EventArgs e)
        {
            this.bindData();
        }

        //保存按钮事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveData();
        }

        //取消按钮事件
        private void btnCalsole_Click(object sender, EventArgs e)
        {
            this.clearData();
        }

        //关闭按钮事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 绑定下拉菜单
        /// </summary>
        public void bindData() {
            objSqlConn = new SqlConnection(sql);

            string sqlText = "select id,brand form Brand";

            objSqlComm = new SqlCommand(sqlText, objSqlConn);
            try
            {

                objSqlConn.Open();
                SqlDataReader dataReader = objSqlComm.ExecuteReader();
                //清空下拉列表
                this.cmbBrand.Items.Clear();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        this.cmbBrand.Items.Add(dataReader["brand"].ToString());
                    }
                }
                this.cmbBrand.SelectedIndex = 0;
                dataReader.Close();
                
            }
            catch
            {
                MessageBox.Show("连接数据库失败！");
            }
            finally {
                objSqlConn.Close();
            }
 
        }

        /// <summary>
        /// 保存信息的方法
        /// </summary>
        public void saveData()
        {
            #region 设置变量
            //商品名
            string strName = this.txtName.Text.Trim();
            //品牌
            string strBrand = this.cmbBrand.Text.Trim().ToString();
            //到货
            string strReceive = "1";
            if(this.rbtNot.Checked){
                strReceive = "0";
            }
            //价格
            string strPrice = this.txtPrice.Text.Trim();
            //配置
            string strDetail = this.txtDetail.Text.Trim();
            //备注
            string strRemark = this.txtRemark.Text.Trim();
            #endregion

            #region 数据验证
            //非空验证
            if(string.IsNullOrEmpty("strName")){
                MessageBox.Show("商品名不能为空！");
                return;
            }
            if(strBrand.Equals("0")){
                MessageBox.Show("请选择品牌！");
                return;
            }
            if (string.IsNullOrEmpty("strPrice"))
            {
                MessageBox.Show("价格不能为空！");
                return;
            }
            if (string.IsNullOrEmpty("strDetail"))
            {
                MessageBox.Show("配置不能为空！");
                return;
            }
            #endregion

            #region 新增操作
            objSqlConn = new SqlConnection(sql);
            StringBuilder objBuilder = new StringBuilder();
            objBuilder.AppendFormat(" insert into PcInfo ");
            objBuilder.AppendFormat(" (pcName,brandId,isReceive,pcPrice,pcDetail,pcRemark,timeStamp) values ");
            objBuilder.AppendFormat(" ('{0}','{1}','{2}',{3},'{4}','{5}','{6}',default) ", strName, strBrand, strReceive, strPrice, strDetail, strRemark);

            objSqlComm = new SqlCommand(objBuilder.ToString(), objSqlConn);

            try
            {
                objSqlConn.Open();
                int count = objSqlComm.ExecuteNonQuery();
                if (count >= 1)
                {
                    MessageBox.Show("保存成功！");
                    this.clearData();
                }
                else 
                {
                    MessageBox.Show("保存失败！");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败！");
            }
            finally 
            {
                objSqlConn.Close();
            }

            #endregion

        }

        /// <summary>
        /// 清空数据的方法
        /// </summary>
        public void clearData() 
        {
            this.txtName.Text = string.Empty;
            this.cmbBrand.SelectedIndex = 0;
            this.txtPrice.Text = string.Empty;
            this.txtRemark.Text = string.Empty;
            this.txtDetail.Text = string.Empty;
            this.rbtYet.Checked = true;
        }
        #endregion
    }
}
