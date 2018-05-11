using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManage
{
    public partial class FrmRegion : Form
    {
        public FrmRegion()
        {
            InitializeComponent();
        }

        
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //关闭后事件
        private void FrmRegion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 方法

        #endregion
    }
}
