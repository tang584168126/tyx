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

namespace MySchool_1
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }
        #region 字段
        private string sql = @"Data Source = TANG; Catalog Initial = MySchool182; User ID = sa; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //加载下拉菜单事件
        private void FrmInsert_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载方法
        /// </summary>
        public void LoadData()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = "select GradeID,GradeName from Grade";

            objSqlComm = new SqlCommand(sqlText,objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                this.cmbGrade.Items.Clear();

                this.cmbGrade.Items.Add("请选择");

                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        this.cmbGrade.Items.Add(dataReader["GradeName"].ToString());
                    }
                }

                this.cmbGrade.SelectedIndex = 0;

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
