using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookSet.Models;
using BookSet.BLL;

namespace WebDemo
{
    public partial class commant : System.Web.UI.Page
    {
        private int pagesize = 5; //翻页次数
        public int PageIndex 
        {
            get
            {
            if(ViewState["PageIndex"] !=null)
            {
                return Convert.ToInt32(ViewState["PageIndex"]);
            }
            return 1;
            }
            set 
            {
                ViewState["PageIndex"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BinLast();
            
            }

        }

        private void BinLast() 
        {
            //获取书籍信息
            string isbn = "9787115145543";
            IList<Books> items = new BookBiz().GetItems(isbn);
            this.dlitems.DataSource = items;
            this.dlitems.DataBind();
            BinBookMany();
        }

        private void BinBookMany() 
        {
            //获取聊天数据
            IList<Managers> magers = new GetMangaer().GetUserManger(PageIndex, pagesize);
         this.dltManger.DataSource=magers;
         this.dltManger.DataBind();  
        }
    }
}