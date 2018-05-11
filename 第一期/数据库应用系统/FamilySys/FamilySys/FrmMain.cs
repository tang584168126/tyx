using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilySys
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region 事件
        //消费查询
        private void 消费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelect objSelect = new FrmSelect();

            objSelect.MdiParent = this;

            objSelect.Show();
        }

        //添加消费
        private void 添加消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsert objInsert = new FrmInsert();

            objInsert.MdiParent = this;

            objInsert.Show();
        }

        //退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

       

        
    }
}
