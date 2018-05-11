using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Friends.Web.Filters
{
    public class LogVisitionFilter:FilterAttribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //记录IP信息的日志文档路径
            string filePath = filterContext.HttpContext.Server.MapPath("~/log.txt");
            //将异常信息保存到异常日志文档
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("访问时间：{0}", DateTime.Now.ToString());
                sw.WriteLine("IP：{0}", filterContext.HttpContext.Request.UserHostAddress);
            }
        }
    }
}