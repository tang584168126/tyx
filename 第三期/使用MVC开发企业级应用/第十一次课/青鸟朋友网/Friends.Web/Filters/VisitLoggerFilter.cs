using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends.Web.Filters
{
    public class VisitLoggerFilter : FilterAttribute, IActionFilter
    {
        public VisitLoggerFilter()
        {

        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        /// <summary>
        /// 在执行操作方法之前调用
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //定义日志文件路径
            string filePath = filterContext.HttpContext.Server.MapPath(@"~\siteLog.txt");
            var request = filterContext.HttpContext.Request;
            //定义日志信息 IP 时间 访问URL
            string info = string.Format("{0}\t{1}\t{2}", request.UserHostAddress, DateTime.Now.ToString(), request.RawUrl);
            //写入日志信息
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(info);
            }
        }

    }
}
