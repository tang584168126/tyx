using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 字段
        //学生类的集合
        private ArrayList arrStuList = new ArrayList();
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
            //判断是否有资料选中
            if (this.lvList.SelectedItems.Count > 0)
            {
                //确定是否删除
                DialogResult result = MessageBox.Show("确定删除该数据?", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    //删除学员
                    this.DeleteStu();

                    //绑定列表
                    this.BindData();
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
            for (int i = 0; i < arrStuList.Count; i++)
            {
                //拆箱，转为学生类
                Student objStuTemp = (Student)arrStuList[i];

                if (objStuTemp.StuNO.Equals(objStu.StuNO))
                {
                    MessageBox.Show("该学生已存在!");

                    return;
                }
            }
            #endregion

            #region 新增操作
            //加入集合
            this.arrStuList.Add(objStu);

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
            //循环读取列表
            for (int i = 0; i < this.arrStuList.Count; i++)
            {
                //拆箱,转换为学生类
                Student objStuTemp = (Student)this.arrStuList[i];

                if (objStuTemp.StuNO.Equals(objStu.StuNO))
                {
                    objStuTemp.StuName = objStu.StuName;
                    objStuTemp.StuSex = objStu.StuSex;
                    objStuTemp.StuAge = objStu.StuAge;
                    objStuTemp.StuAddress = objStu.StuAddress;

                    //绑定列表
                    this.BindData();

                    //清空数据
                    this.ClearData();

                    //更改样式
                    this.txtNO.Enabled = true;
                    this.btnAdd.Enabled = true;
                    this.btnDelete.Enabled = true;

                    break;
                }
            }
            #endregion
        }

        /// <summary>
        /// 删除学员方法
        /// </summary>
        public void DeleteStu()
        {
            #region 设置变量
            //删除学生的学号
            string stuNO = this.lvList.SelectedItems[0].Text.Trim();
            #endregion

            #region 删除操作
            //循环读取列表
            for(int i=0;i<this.arrStuList.Count;i++)
            {
                //拆箱，转换为学生类
                Student objStuTemp = (Student)this.arrStuList[i];

                if (objStuTemp.StuNO.Equals(stuNO))
                {
                    //删除
                    this.arrStuList.RemoveAt(i);

                    MessageBox.Show("删除成功!");

                    break;
                }
            }
            #endregion
        }

        /// <summary>
        /// 显示学员信息
        /// </summary>
        public void BindData()
        {
            //清空列表
            this.lvList.Items.Clear();

            //循环读取列表
            foreach (Object objTemp in this.arrStuList)
            {
                //拆箱，转换为学生类
                Student objStuTemp = (Student)objTemp;

                //绑定至ListView
                ListViewItem objItem = new ListViewItem(objStuTemp.StuNO);

                objItem.SubItems.Add(objStuTemp.StuName.ToString().Trim());
                objItem.SubItems.Add(objStuTemp.StuSex.ToString().Trim());
                objItem.SubItems.Add(objStuTemp.StuAge.ToString().Trim());
                objItem.SubItems.Add(objStuTemp.StuAddress.ToString().Trim());

                this.lvList.Items.Add(objItem);
            }
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
