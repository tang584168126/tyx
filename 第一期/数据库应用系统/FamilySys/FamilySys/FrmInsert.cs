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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }
 
        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = FamilySys;Integrated Security = true";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            this.InsertData();
        }

        //清空按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        //退出按钮
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出！","退出",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        #endregion

        #region 方法
        /// <summary>
        /// 清空
        /// </summary>
        public void ClearData()
        {
            this.txtName.Text = string.Empty;

            this.txtCause.Text = string.Empty;

            this.txtMoney.Text = string.Empty;

            this.dtpDateTime.Value = System.DateTime.Now;
        }

        /// <summary>
        /// 添加
        /// </summary>
        public void InsertData()
        {
            #region 设置变量
            string strName = this.txtName.Text.Trim();

            string strDateTime = this.dtpDateTime.Value.ToString();

            string strCause = this.txtCause.Text.Trim();

            string strMoney = this.txtMoney.Text.Trim();
            #endregion

            #region 数据验证
            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("消费人姓名不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strCause))
            {
                MessageBox.Show("消费原因不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strMoney))
            {
                MessageBox.Show("消费金额不能为空！");
                return;
            }
            #endregion

            #region 添加操作

            #endregion
            objSqlConn = new SqlConnection(sql);

            StringBuilder objBuilder = new StringBuilder();
            objBuilder.AppendFormat("insert into FamilyAssetInfo");
            objBuilder.AppendFormat(" (AssetName,AssetDate,AssetCause,AssetMoney)");
            objBuilder.AppendFormat(" values ('{0}','{1}','{2}',{3})", txtName, strDateTime, strCause, strMoney);

            objSqlComm = new SqlCommand(objBuilder.ToString(),objSqlConn);

            try
            {
                objSqlConn.Open();

                int result = objSqlComm.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("添加成功！");
                    this.ClearData();
                }
                else
                {
                    MessageBox.Show("添加失败！");
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
