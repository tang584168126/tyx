using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsManagerSystem.Model;
using NewsManagerSystem.BLL;

namespace NewsManagerSystem
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //插入按钮事件
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            this.InsertData();
        }

        /// <summary>
        /// 插入新闻
        /// </summary>
        public void InsertData()
        {
            #region 设置变量
            //新闻信息实体类对象
            NewsInfoEntity objNewsInfo = new NewsInfoEntity();
            //业务类对象
            NewsInfoBLL nib = new NewsInfoBLL();
            //主题
            string title = this.txtTitle.Text.Trim();
            //内容
            string content = this.txtContent.Text.Trim();
            #endregion

            #region 非空验证
            if (string.IsNullOrEmpty("title") || string.IsNullOrEmpty("content"))
            {
                this.lblMsg.Text = "主题或内容不能为空！";
            }
            #endregion

            #region 数据操作
            objNewsInfo.Name = title;
            objNewsInfo.Content = content;
            if (nib.IsInsert(objNewsInfo))
            {
                this.lblMsg.Text = "插入成功！";
            }
            else
            {
                this.lblMsg.Text = "插入失败！";
            }
            #endregion
        }
    }
}