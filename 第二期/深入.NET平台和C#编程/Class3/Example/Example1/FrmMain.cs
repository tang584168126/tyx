using System;
using System.Collections.Generic;
using System.Collections;
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
        //学生列表
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
            if (this.lvList.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定删除此学员吗？","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    this.DeleteStu();
                }
            }
            else
            {
                MessageBox.Show("删除失败！");
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
            //学生来对象
            Student objStu = new Student();

            //学号
            String strStuNo = this.txtNO.Text.Trim();

            //姓名
            String strStuName = this.txtName.Text.Trim();

            //年龄
            String strStuAge = this.txtAge.Text.Trim();

            //地址
            String strStuAddress = this.txtAddress.Text.Trim();
            #endregion

            #region 数据验证
            //非空验证
            if(string.IsNullOrEmpty(strStuNo))
            {
                MessageBox.Show("学号不能为空！");
                return;
            }

            if(string.IsNullOrEmpty(strStuName))
            {
                MessageBox.Show("姓名不能为空！");
                return;
            }

            if(string.IsNullOrEmpty(strStuAge))
            {
                MessageBox.Show("年龄不能为空！");
                return;
            }

            if(string.IsNullOrEmpty(strStuAddress))
            {
                MessageBox.Show("地址不能为空！");
                return;
            }

            //验证学号是否存在
            for (int i = 0; i < this.arrStuList.Count; i++ )
            {
                //拆箱至Student类
                Student objStuTemp = (Student)arrStuList[i];

                if(objStuTemp.StuNO.Equals(strStuNo))
                {
                    MessageBox.Show("学号已存在！");
                    return;
                }
            }
            #endregion

            #region 新增操作
            objStu.StuNO = strStuNo;
            objStu.StuName = strStuName;
            objStu.StuAge = int.Parse(strStuAge);
            objStu.StuAddress = strStuAddress;

            if (this.rbtM.Checked)
            {
                objStu.StuSex = Sex.男;
            }
            else
            {
                objStu.StuSex = Sex.女;
            }

            //新增ArrayList元素
            this.arrStuList.Add(objStu);

            MessageBox.Show("新增成功！");

            this.BindData();
            #endregion
        }

        /// <summary>
        /// 修改学员方法
        /// </summary>
        public void UpdateStu()
        {
            #region 设置变量
            //学生来对象
            Student objStu = new Student();

            //学号
            String strStuNo = this.txtNO.Text.Trim();

            //姓名
            String strStuName = this.txtName.Text.Trim();

            //年龄
            String strStuAge = this.txtAge.Text.Trim();

            //地址
            String strStuAddress = this.txtAddress.Text.Trim();
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(strStuNo))
            {
                MessageBox.Show("请选择学生！");
                return;
            }
            #endregion

            #region 修改操作
            objStu.StuNO = strStuNo;
            objStu.StuName = strStuName;
            objStu.StuAge = int.Parse(strStuAge);
            objStu.StuAddress = strStuAddress;

            if (this.rbtM.Checked)
            {
                objStu.StuSex = Sex.男;
            }
            else
            {
                objStu.StuSex = Sex.女;
            }

            //找到ArrayList元素的下标
            for (int i = 0; i < arrStuList.Count; i++)
            { 
                //拆箱至Student表
                Student objStuList = (Student)arrStuList[i];
                if (objStuList.StuNO.Equals(this.txtNO.Text.Trim()))
                {
                    int index = i;
                }
            }

            objStu = arrStuList[index];
                MessageBox.Show("修改成功！");

            this.BindData();
            #endregion
        }

        /// <summary>
        /// 删除学员方法
        /// </summary>
        public void DeleteStu()
        {
            //获取删除学员的学号
            string strStuNo = this.lvList.SelectedItems[0].Text.Trim();

            //遍历学生列表
            for (int i = 0; i < this.arrStuList.Count; i++ )
            {
                //拆箱至Student表
                Student objStu = (Student)arrStuList[i];

                if(objStu.StuNO.Equals(strStuNo))
                {
                    //删除
                    this.arrStuList.Remove(i);

                    MessageBox.Show("删除成功！");

                    //显示学员信息
                    this.BindData();

                    //结束
                    break;
                }
            }
        }

        /// <summary>
        /// 显示学员信息
        /// </summary>
        public void BindData()
        {
            //清空ListView的数据
            this.lvList.Items.Clear();

            //遍历ArrayList的元素
            for (int i = 0; i < this.arrStuList.Count; i++ )
            {
                //拆箱至Student对象
                Student objStu = (Student)this.arrStuList[i];

                //绑定数据
                ListViewItem objItem = new ListViewItem(objStu.StuNO);

                objItem.SubItems.Add(objStu.StuName);
                objItem.SubItems.Add(objStu.StuSex.ToString());
                objItem.SubItems.Add(objStu.StuAge.ToString());
                objItem.SubItems.Add(objStu.StuAddress);

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
