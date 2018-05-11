using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
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
        //ListView双击事件
        private void lvList_DoubleClick(object sender, EventArgs e)
        {
            //判断是否有资料选中
            if (this.lvList.SelectedItems.Count > 0)
            {
                this.txtNO.Text = this.lvList.SelectedItems[0].Text;
                this.txtName.Text = this.lvList.SelectedItems[0].SubItems[1].Text;
                this.txtAge.Text = this.lvList.SelectedItems[0].SubItems[3].Text;
                this.txtAddress.Text = this.lvList.SelectedItems[0].SubItems[4].Text;

                if (this.lvList.SelectedItems[0].SubItems[2].Text.Equals("女"))
                {
                    this.rbtF.Checked = true;
                }

                //更改样式
                this.txtNO.Enabled = false;
                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("请选择有效数据!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //新增按钮事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.InsertStu();
        }

        //修改按钮事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateStu();
        }

        //删除按钮事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteStu();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 新增学员方法
        /// </summary>
        public void InsertStu()
        {
            
        }

        /// <summary>
        /// 修改学员方法
        /// </summary>
        public void UpdateStu()
        {

        }

        /// <summary>
        /// 删除学员方法
        /// </summary>
        public void DeleteStu()
        {

        }

        /// <summary>
        /// 显示学员信息
        /// </summary>
        public void BindData()
        {
            
        }

        /// <summary>
        /// 清空选项
        /// </summary>
        public void ClearData()
        {
            this.txtNO.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtAge.Text = string.Empty;
            this.txtAddress.Text = string.Empty;

            this.rbtM.Checked = true;
        }
        #endregion
    }
}
