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

namespace TestBook
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
        //新建按钮事件
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.txtNote.Text))
            {
                DialogResult result = MessageBox.Show("是否保存","记事本",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                if (result == DialogResult.OK)
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

        //打开按钮事件
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Open();
        }

        //保存按钮事件
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNote.Text))
            {
                this.Save();
            }
        }

        //另存为按钮事件
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 打开的方法
        /// </summary>
        public void Open()
        {
            OpenFileDialog objOpenFile = new OpenFileDialog();

            objOpenFile.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";

            objOpenFile.ShowDialog();

            DialogResult result = objOpenFile.ShowDialog();

            if(result == DialogResult.OK)
            {
                string strPath = objOpenFile.FileName;

                FileStream objFS = new FileStream(strPath,FileMode.Open);

                StreamReader objSR = new StreamReader(objFS);

                this.txtNote.Text = objSR.ReadToEnd();

                strName = Path.GetFileName(strPath);

                if(!string.IsNullOrEmpty(strName))
                {
                    Text = strName;
                }

                objSR.Close();
                objFS.Close();
            }

            
        }

        /// <summary>
        /// 保存的方法
        /// </summary>
        public void Save()
        { 
            SaveFileDialog objSaveFile = new SaveFileDialog();

            objSaveFile.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";

            objSaveFile.ShowDialog();

            DialogResult result = objSaveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string strPath = objSaveFile.FileName;

                FileStream objFS = new FileStream(strPath, FileMode.Create);

                StreamWriter objSW = new StreamWriter(objFS, Encoding.Default);

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
        #endregion
    }
}
