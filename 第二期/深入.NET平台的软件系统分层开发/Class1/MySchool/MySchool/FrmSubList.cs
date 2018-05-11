﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySchoolBLL;
using MySchoolModel;
using MySchoolTool;

namespace MySchool
{
    public partial class FrmSubList : Form
    {
        public FrmSubList()
        {
            InitializeComponent();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmSubList_Load(object sender, EventArgs e)
        {
            //加载下拉菜单、
            Public_Helper.BindDropDownList(this.cmbSubName);
        }

        //查询按钮事件
        private void btnQuary_Click(object sender, EventArgs e)
        {

        }

        //更新按钮事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 方法
        /// <summary>
        /// 查询数据
        /// </summary>
        public void QuaryData()
        {
            //设定DataGridView为手动绑定


            #region 设置变量
            //科目实体类对象
            SubjectEntity objSubEnity = new SubjectEntity();

            //科目业务逻辑类对象
            SubjectBLL objSubBLL = new SubjectBLL();

            //科目信息列表
            List<SubjectEntity> objSubList = new List<SubjectEntity>();

            //年级
            string strGradeId = this.cmbSubName.SelectedValue.ToString();
            #endregion

            #region 获取变量值
            objSubEnity.GradeId1 = int.Parse(strGradeId);
            #endregion

            #region 查询操作
            try
            {
                //获取科目信息列表
                objSubList = objSubBLL.GetSubList(objSubEnity);

                //绑定DataGridView
                this.dgvSubList.DataSource = new BindingList<SubjectEntity>(objSubList);
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }
            #endregion
        }
        #endregion

        
    }
}
