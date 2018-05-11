using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
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
        //学员信息列表按钮事件
        private void 学员信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuList objStuList = new FrmStuList();

            objStuList.MdiParent = this;

            objStuList.Show();
        }

        //新增学员信息按钮事件
        private void 新增学员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuInsert objStuInsert = new FrmStuInsert();

            objStuInsert.MdiParent = this;

            objStuInsert.Show();
        }
        #endregion

        #region 方法

        #endregion
    }
}
