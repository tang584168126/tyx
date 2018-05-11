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
    public partial class FrmChangePwd : Form
    {
        public FrmChangePwd()
        {
            InitializeComponent();
        }

        #region 字段
        private string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ChangePwd();
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("确认取消吗？","取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if(Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 修改密码
        /// </summary>
        public void ChangePwd()
        {
            #region 设置变量
            string strIntrinsicPwd = this.txtIntrinsicPwd.Text.Trim();

            string strNewPwd = this.txtNewPwd.Text.Trim();

            string strAffirmPwd = this.txtAffirmPwd.Text.Trim();
            #endregion

            #region 数据验证
            
            #endregion

            #region 数据操作
            objSqlConn = new SqlConnection(sql);
            string sqlText = string.Format("update Student set LoginPwd = '{0}' where StudentNo = {1}", strNewPwd);
            objSqlComm = new SqlCommand(sqlText,objSqlConn);
            try
            {
                objSqlConn.Open();
                
            }
            catch
            {
                MessageBox.Show("连接数据库失败，请联系管理员！");
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
