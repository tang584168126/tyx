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

namespace DVDSYS
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = DVDSYS; Integrated Security = true";

        private SqlConnection objSqlConn;

        private SqlDataAdapter dataAdapter;

        private DataSet objDS = new DataSet();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //加载下拉菜单事件
        private void FrmInfo_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载下拉菜单
        /// </summary>
        public void LoadData()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = "select TYPE_ID,TYPE_NAME from DVD_TYPE";

            dataAdapter = new SqlDataAdapter(sqlText, objSqlConn);

            DataSet objDS1 = new DataSet();
            dataAdapter.Fill(objDS1, "DVD_TYPE");

            DataRow objDR = objDS1.Tables["DVD_TYPE"].NewRow();
            objDR["TYPE_ID"] = -1;
            objDR["TYPE_NAME"] = "全部";
            objDS1.Tables["DVD_TYPE"].Rows.InsertAt(objDR,0);
            

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    this.cmbType.Items.Clear();
                    this.cmbType.Items.Add("全部");

                    while(dataReader.Read())
                    {
                        this.cmbType.Items.Add(dataReader["TYPE_NAME"].ToString());
                    }
                }
                this.cmbType.SelectedItem.Add();
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
        #endregion
    }
}
