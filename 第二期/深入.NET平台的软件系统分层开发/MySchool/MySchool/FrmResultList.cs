using System;
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

namespace MySchool
{
    public partial class FrmResultList : Form
    {
        public FrmResultList()
        {
            InitializeComponent();

            //this.QueryData1();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmResultList_Load(object sender, EventArgs e)
        {
            //查询数据
            this.QueryData();
        }

        //查询按钮事件
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.QueryData();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 查询数据
        /// </summary>
        public void QueryData()
        {
            this.dgvResultList.AutoGenerateColumns = true;

            #region 设置变量
            //成绩业务类对象
            ResultBLL objResultBLL = new ResultBLL();

            //成绩实体扩展类对象
            ResultBusinessEntity objResBusiEntity = new ResultBusinessEntity();

            //成绩列表
            List<ResultBusinessEntity> objResBusiList = new List<ResultBusinessEntity>();
            #endregion

            #region 获取变量值
            objResBusiEntity.StuName = this.txtStuName.Text.Trim();

            objResBusiEntity.SubName = this.txtSubName.Text.Trim();

            if (!string.IsNullOrEmpty(this.txtStudentResult.Text.Trim()))
            {
                objResBusiEntity.StudentResult = Convert.ToDecimal(this.txtStudentResult.Text.Trim());
            }
            else
            {
                objResBusiEntity.StudentResult = -1;
            }
            #endregion

            #region 查询操作
            try
            {
                objResBusiList = new ResultBLL().GetResBusiEntity(objResBusiEntity);

                this.dgvResultList.DataSource = new BindingList<ResultBusinessEntity>(objResBusiList);
            }
            catch
            {
                MessageBox.Show("连接数据库错误,请联系管理员!");
            }
            #endregion
        }
        #endregion
    }
}
