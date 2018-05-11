using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //结束程序
            Application.Exit();
        }

        //退出按钮事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认退出?", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //结束程序
                Application.Exit();
            }
        }

        //新增学员信息按钮事件
        private void 新增学员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStu objAddStu = new FrmAddStu();

            objAddStu.MdiParent = this;

            objAddStu.Show();
        }

        //学员信息列表按钮事件
        private void 学员信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //课程查询按钮事件
        private void 课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubList objSubList = new FrmSubList();

            objSubList.MdiParent = this;

            objSubList.Show();
        }

        //学员成绩列表按钮事件
        private void 学员成绩列表toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResultList objResultList = new FrmResultList();

            objResultList.MdiParent = this;

            objResultList.Show();
        }

        //课程管理按钮事件
        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //关于系统按钮事件
        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region 方法

        #endregion
    }
}
