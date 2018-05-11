using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool_1
{
    public partial class FrmUpdatePwd : Form
    {
        public FrmUpdatePwd()
        {
            InitializeComponent();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //确认按钮事件
        private void btnSure_Click(object sender, EventArgs e)
        {
            this.SureData();
        }
        //清除按钮事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }
        //取消按钮事件
        private void btnCansole_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 清除方法
        /// </summary>
        public void ClearData()
        {
            this.txtOldPwd.Text = string.Empty;

            this.txtNewPwd.Text = string.Empty;

            this.txtSure.Text = string.Empty;
        }

        /// <summary>
        /// 确认方法
        /// </summary>
        public void SureData()
        { 
        }
        #endregion

        

        
    }
}
