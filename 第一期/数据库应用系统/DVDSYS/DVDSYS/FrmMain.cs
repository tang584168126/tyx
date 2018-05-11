using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDSYS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //基本信息查询按钮事件
        private void dVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfo objInfo = new FrmInfo();

            objInfo.MdiParent = this;

            objInfo.Show();
        }

        //退出按钮事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        

        #region 方法

        #endregion
    }
}
