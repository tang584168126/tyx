using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileManager
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
        //增加手机信息
        private void 增加信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsert objInsert = new FrmInsert();
            objInsert.MdiParent = this;
            objInsert.Show();

        }
        #endregion

        #region 方法

        #endregion
        
    }
}
