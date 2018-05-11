using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 字段
        #endregion

        #region 属性
        #endregion

        #region 事件
        //增加信息单击事件
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InsertForm objForm = new InsertForm();
            objForm.MdiParent = this;

            objForm.Show();
        }

        //查询信息单击事件
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SelectForm objForm = new SelectForm();
            objForm.MdiParent = this;
            objForm.Show();
        }

        //退出事件
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？","确定",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(result == DialogResult.OK){
                Application.Exit();
            }
        }

        #endregion

        #region 方法
        #endregion
        
    }
}
