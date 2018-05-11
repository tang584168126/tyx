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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindList1();
                BindList2();
                BindList3();
                BindList4();
                BindList5();
                BindList6();
            }
        }

        public void BindList1()
        {
            this.dl1.DataSource = new BookManager().GetBooksByClick(2);
            this.dl1.DataBind();
            this.dl2.DataSource = new BookManager().GetBooksByDate(2);
            this.dl2.DataBind();
            this.dl3.DataSource = new BookManager().GetBooksByWordCount(2);
            this.dl3.DataBind();
            this.dl4.DataSource = new BookManager().GetBooksByBookState(2);
            this.dl4.DataBind();
        }
        public void BindList2()
        {
            this.dl5.DataSource = new BookManager().GetBooksByClick(1);
            this.dl5.DataBind();
            this.dl6.DataSource = new BookManager().GetBooksByDate(1);
            this.dl6.DataBind();
            this.dl7.DataSource = new BookManager().GetBooksByWordCount(1);
            this.dl7.DataBind();
            this.dl8.DataSource = new BookManager().GetBooksByBookState(1);
            this.dl8.DataBind();
        }
        public void BindList3()
        {
            this.dl9.DataSource = new BookManager().GetBooksByClick(3);
            this.dl9.DataBind();
            this.dl10.DataSource = new BookManager().GetBooksByDate(3);
            this.dl10.DataBind();
            this.dl11.DataSource = new BookManager().GetBooksByWordCount(3);
            this.dl11.DataBind();
            this.dl12.DataSource = new BookManager().GetBooksByBookState(3);
            this.dl12.DataBind();
        }
        public void BindList4()
        {
            this.dl13.DataSource = new BookManager().GetBooksByClick(6);
            this.dl13.DataBind();
            this.dl14.DataSource = new BookManager().GetBooksByDate(6);
            this.dl14.DataBind();
            this.dl15.DataSource = new BookManager().GetBooksByWordCount(6);
            this.dl15.DataBind();
            this.dl16.DataSource = new BookManager().GetBooksByBookState(6);
            this.dl16.DataBind();
        }
        public void BindList5()
        {
            this.dl17.DataSource = new BookManager().GetBooksByClick(4);
            this.dl17.DataBind();
            this.dl18.DataSource = new BookManager().GetBooksByDate(4);
            this.dl18.DataBind();
            this.dl19.DataSource = new BookManager().GetBooksByWordCount(4);
            this.dl19.DataBind();
            this.dl20.DataSource = new BookManager().GetBooksByBookState(4);
            this.dl20.DataBind();
        }
        public void BindList6()
        {
            
        }
    } 
}