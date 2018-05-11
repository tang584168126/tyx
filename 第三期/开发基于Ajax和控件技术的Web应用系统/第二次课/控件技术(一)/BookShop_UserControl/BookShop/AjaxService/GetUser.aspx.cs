using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.Models;
using BookShop.BLL;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace BookShop.AjaxService
{
    public partial class GetUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.Response.ContentType = "text/xml";
            //Context.Response.ContentType = "application/json";

            if(Context.Request.QueryString["loginId"] != null)
            {
                //根据loginId获取账户信息
                User user = new UserManager().GetUserByLoginId(
                    Context.Request.QueryString["loginId"].ToString());

                if (user != null)
                {
                    //创建一个XmlSerializer对象，用于将User对象序列化为XML文档
                    XmlSerializer serializer = new XmlSerializer(user.GetType());

                    //将XMLWriter对象赋值为XMLTextWriter对象
                    XmlWriter writer = new XmlTextWriter(Context.Response.OutputStream, Encoding.UTF8);

                    //调用序列化方法
                    serializer.Serialize(writer, user);

                    writer.Close();
                }

                //if (user != null)
                //{
                //    DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(User));
                //    json.WriteObject(Context.Response.OutputStream,user);
                //}
            }
        }
    }
}