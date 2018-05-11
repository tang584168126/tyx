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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        
        #region 事件
        //窗体关闭后事件
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //退出按钮事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //修改密码事件
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdatePwd objUpdatePwd = new FrmUpdatePwd();

            objUpdatePwd.MdiParent = this;

            objUpdatePwd.Show();
        }
        #endregion

        
    }
}
