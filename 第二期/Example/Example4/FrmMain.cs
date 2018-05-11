using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
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
        //单元格双击事件
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvList.SelectedCells.Count > 0)
            {
                //读取选中的值
                this.txtNO.Text = this.dgvList.SelectedRows[0].Cells[0].Value.ToString();
                this.txtName.Text = this.dgvList.SelectedRows[0].Cells[1].Value.ToString();
                this.txtAge.Text = this.dgvList.SelectedRows[0].Cells[3].Value.ToString();
                this.txtAddress.Text = this.dgvList.SelectedRows[0].Cells[4].Value.ToString();

                if (this.dgvList.SelectedRows[0].Cells[2].Value.ToString().Equals("男"))
                {
                    this.rbtM.Checked = true;
                }
                else
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
                MessageBox.Show("请选择需要的数据!");
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
