using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace NotePat___
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {

            InitializeComponent();

        }

        #region 字段
        string strName = string.Empty;
        #endregion

        #region 属性

        #endregion

        #region 事件
        //保存按钮事件
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNote.Text.Trim()))
            {
                this.Save();
            }
        }

        //打开按钮事件
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Open();
        }

        //另存为按钮事件
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        //新建按钮事件
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNote.Text.Trim()))
            {
                DialogResult reslut= MessageBox.Show("是否保存","记事本",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (reslut == DialogResult.Yes)
                {
                    this.Save();
                    this.txtNote.Text = string.Empty;
                }
                else
                {
                    this.txtNote.Text = string.Empty;
                }  
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 保存方法
        /// </summary>
        public void Save()
        {
            SaveFileDialog objFeile = new SaveFileDialog();

            objFeile.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";

            DialogResult result = objFeile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string strPath = objFeile.FileName;

                FileStream objFS = new FileStream(strPath,FileMode.Create);

                StreamWriter objSW = new StreamWriter(objFS,Encoding.Default);

                objSW.Write(this.txtNote.Text.Trim());

                strName = Path.GetFileName(strPath);

                if (!string.IsNullOrEmpty(strName))
                {
                    Text = strName;
                }

                objSW.Close();
                objFS.Close();
            }
        }

        /// <summary>
        /// 打开方法
        /// </summary>
        public void Open()
        {
            OpenFileDialog objFeile = new OpenFileDialog();

            objFeile.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";

            DialogResult result = objFeile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string strPath = objFeile.FileName;

                FileStream objFS = new FileStream(strPath, FileMode.Open);

                StreamReader objSR = new StreamReader(objFS, Encoding.Default);

                this.txtNote.Text = objSR.ReadToEnd();

                strName = Path.GetFileName(strPath);

                if (!string.IsNullOrEmpty(strName))
                {
                    Text = strName;
                }

                objSR.Close();
                objFS.Close();
            }
        }
        #endregion
    }
}
