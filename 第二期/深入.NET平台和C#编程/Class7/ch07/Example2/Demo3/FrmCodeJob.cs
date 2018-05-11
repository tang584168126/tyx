using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class FrmCodeJob : Form
    {
        public FrmCodeJob()
        {
            InitializeComponent();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //提交按钮事件
        private void btnSure_Click(object sender, EventArgs e)
        {
            this.Submit();
        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 提交方法
        /// </summary>
        public void Submit()
        { 
        
        }
        #endregion
    }
}
