using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

using System.Xml;
using System.Xml.Serialization;

using BookShop.Models;
using BookShop.BLL;

namespace BookShop.AjaxService
{
    /// <summary>
    /// GetUser 的摘要说明
    /// </summary>
    public class GetUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";     //MIME类型
            //context.Response.ContentType = "text/xml";
            //接收Ajax请求传递过来的loginId，然后获取其数据
            if (context.Request.QueryString["loginId"] != null)
            {
                User oUser = new UserManager().GetUserByLoginId(context.Request.QueryString["loginId"].ToString());

                #region 将User对象序列化为JSON格式的数据
                if (oUser != null)
                {
                    //将User对象序列号为Json格式的数据
                    DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(User));
                    json.WriteObject(context.Response.OutputStream, oUser);
                }
                #endregion

                #region 将User对象序列化为XML格式的数据
                //if (oUser != null)
                //{
                //    XmlSerializer serializer = new XmlSerializer(oUser.GetType());
                //    XmlWriter writer = new XmlTextWriter(context.Response.OutputStream, System.Text.Encoding.UTF8);
                //    serializer.Serialize(writer, oUser);

                //    writer.Close();
                //}
                #endregion

            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}