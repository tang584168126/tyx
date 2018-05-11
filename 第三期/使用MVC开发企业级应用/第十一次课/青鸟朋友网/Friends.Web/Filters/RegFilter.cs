using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends.Web.Filters
{
    public class RegFilter : FilterAttribute, IActionFilter, IResultFilter
    {
        public int Minutes { get; set; }//时间间隔分钟数
        public RegFilter(int minutes)
        {
            this.Minutes = minutes;
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }
        //
        // 摘要:
        //     在操作结果执行之前调用。
        //
        // 参数:
        //   filterContext:
        //     筛选器上下文。
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Result.GetType() == typeof(ContentResult))//注册成功！
            {
                filterContext.HttpContext.Session["lastRegisterTime"] = DateTime.Now;//更新注册时间
                
            }
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
           var context= filterContext.HttpContext;
           if (context.Session["lastRegisterTime"] != null)
            {
                DateTime time = (DateTime)context.Session["lastRegisterTime"];
                if (time.AddMinutes(this.Minutes) > DateTime.Now)//注册时间间隔小于Minutes分钟
                {
                    filterContext.Result = new ContentResult() { Content = "<script>alert('注册过于频繁！');window.location='" 
                        + UrlHelper.GenerateContentUrl("~/",context) + "'</script>" };
                }
            }

        }

    }
}
