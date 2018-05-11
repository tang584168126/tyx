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
        //学生信息字典
        private Dictionary<string, Student> objDicStuList = new Dictionary<string, Student>();
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
            if (this.dgvList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定删除此学员信息?", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    this.DeleteStu();
                }
            }
            else
            {
                MessageBox.Show("请选中需要删除的数据!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 新增学员方法
        /// </summary>
        public void InsertStu()
        {
            #region 设置变量
            //学生类对象
            Student objStu = new Student();

            //学号
            objStu.StuNO = this.txtNO.Text.Trim();

            //姓名
            objStu.StuName = this.txtName.Text.Trim();

            //年龄
            objStu.StuAge = int.Parse(this.txtAge.Text.Trim().ToString());

            //地址
            objStu.StuAddress = this.txtAddress.Text.Trim();

            //性别
            if (this.rbtM.Checked)
            {
                objStu.StuSex = Sex.男;
            }
            else
            {
                objStu.StuSex = Sex.女;
            }
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(objStu.StuNO))
            {
                MessageBox.Show("学号不能为空!");
                return;
            }

            //验证学生是否存在
            if (this.objDicStuList.ContainsKey(objStu.StuNO))
            {
                MessageBox.Show("该学生已存在!");

                return;
            }
            #endregion

            #region 新增操作
            //加入集合
            this.objDicStuList.Add(objStu.StuNO, objStu);

            //绑定列表
            this.BindData();

            //清空数据
            this.ClearData();
            #endregion
        }

        /// <summary>
        /// 修改学员方法
        /// </summary>
        public void UpdateStu()
        {
            #region 设置变量
            //学生类对象
            Student objStu = new Student();

            //学号
            objStu.StuNO = this.txtNO.Text.Trim();

            //姓名
            objStu.StuName = this.txtName.Text.Trim();

            //年龄
            objStu.StuAge = int.Parse(this.txtAge.Text.Trim().ToString());

            //地址
            objStu.StuAddress = this.txtAddress.Text.Trim();

            //性别
            if (this.rbtM.Checked)
            {
                objStu.StuSex = Sex.男;
            }
            else
            {
                objStu.StuSex = Sex.女;
            }
            #endregion

            #region 数据验证
            
            #endregion

            #region 修改操作
            //修改元素
            this.objDicStuList[objStu.StuNO] = objStu;

            //绑定数据
            this.BindData();

            //清除数据
            this.ClearData();

            //更改样式
            this.txtNO.Enabled = true;
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            #endregion
        }

        /// <summary>
        /// 删除学员方法
        /// </summary>
        public void DeleteStu()
        {
            #region 设置变量
            //需要删除的学号
            string stuNO = this.dgvList.SelectedRows[0].Cells["Column1"].Value.ToString().Trim();
            #endregion

            #region 删除操作
            this.objDicStuList.Remove(stuNO);

            //绑定数据
            this.BindData();
            #endregion
        }

        /// <summary>
        /// 显示学员信息
        /// </summary>
        public void BindData()
        {
            this.dgvList.AutoGenerateColumns = false;

            BindingSource bs = new BindingSource();
            bs.DataSource = this.objDicStuList.Values;
            this.dgvList.DataSource = bs;
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
