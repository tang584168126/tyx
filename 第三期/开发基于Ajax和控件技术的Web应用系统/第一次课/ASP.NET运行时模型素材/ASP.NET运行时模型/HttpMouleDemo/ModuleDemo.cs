using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpMouleDemo
{
    public class ModuleDemo:IHttpModule
    {
        public void Dispose()
        {
            //释放资源
        }

        public void Init(HttpApplication context)
        {
            //初始化模块，为处理请求做准备
            context.BeginRequest += new EventHandler(Context_BeginRequest);
            context.EndRequest += new EventHandler(Context_EndRequest);
        }

        public void Context_BeginRequest(Object sender,EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            application.Response.Write("HttpModule:BeginRequest");
        }

        public void Context_EndRequest(object sender, EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            application.Response.Write("HttpModule:EndRequest");
        }
    }
}