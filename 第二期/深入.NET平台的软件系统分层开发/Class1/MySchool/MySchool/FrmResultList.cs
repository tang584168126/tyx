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
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件

        #endregion

        #region 方法
        /// <summary>
        /// 查询数据
        /// </summary>
        public void QueryData()
        {
            this.dgvResult.AutoGenerateColumns = true;

            #region 设置变量
            //成绩业务类对象
            ResultBLL objResultBLL = new ResultBLL();

            //成绩实体扩张类对象
            ResultBusinessEntity objResultBusiEntity = new ResultBusinessEntity();

            //成绩列表
            List<ResultBusinessEntity> objResBusList = new List<ResultBusinessEntity>();
            #endregion

            #region 获取变量值
            objResultBusiEntity.StrName = this.txtStuName.Text.Trim();

            objResultBusiEntity.SubName = this.txtSubName.Text.Trim();

            if(!string.IsNullOrEmpty(this.txtScore.Text.Trim()))
            {
                objResultBusiEntity.StudentResult1= int.Parse(this.txtScore.Text.Trim());
            }
            else
            {
                objResultBusiEntity.StudentResult1 = -1;
            }
            #endregion

            #region 查询操作
            try
            {
                objResultBusiList = new ResultBLL().GetResBusiEntity(objResultBusiEntity);

                this.dgvResult.DataSource = ;
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
