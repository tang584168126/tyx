using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.Models;
using BookShop.BLL;

namespace BookShop.UserControl
{
    public partial class SpecialBookList : System.Web.UI.UserControl
    {
        private string title = "";      //标题

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private int num = 5;            //显示的数据条数

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.rptRankings.DataSource = new BookManager().GetRankings(this.Num);
            this.rptRankings.DataBind();
        }


    }
}