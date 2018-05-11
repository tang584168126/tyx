using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemo.AjaxService
{
    /// <summary>
    /// GetUser 的摘要说明
    /// </summary>
    public class GetUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            //判断传递过来的值是否为空
            //接收Ajax请求过来的LooginId然后获取数据
            if(context.Request.QueryString["loginId"]!=null)
            {
            
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