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
        //窗体关闭后事件
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //新增学员信息按钮事件
        private void 新增学员信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmStuInsert objStuInsert = new FrmStuInsert();

            //设置Mdi父窗口
            objStuInsert.MdiParent = this;

            objStuInsert.Show();
        }
        
        //密码修改事件
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePwd objChangePwd = new FrmChangePwd();

            objChangePwd.MdiParent = this;

            objChangePwd.Show();
        }

        //学员信息列表
        private void 学员信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuList objStuList = new FrmStuList();

            objStuList.MdiParent = this;

            objStuList.Show();
        }

        //关于系统按钮事件
        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp objHelp = new FrmHelp();

            objHelp.ShowDialog();
        }

        //课程查询按钮事件
        private void 课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubList objSubList = new FrmSubList();

            objSubList.MdiParent = this;

            objSubList.Show();
        }

        //课程管理
        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubManage objSubManage = new FrmSubManage();

            objSubManage.MdiParent = this;

            objSubManage.Show();
        }
        #endregion

        #region 方法

        #endregion
    }
}
