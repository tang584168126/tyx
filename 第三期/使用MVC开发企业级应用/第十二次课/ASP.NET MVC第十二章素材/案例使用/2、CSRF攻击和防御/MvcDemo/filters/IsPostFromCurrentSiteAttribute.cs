using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.filters
{
    public class IsPostFromCurrentSiteAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext != null)
            {
                var request = filterContext.HttpContext.Request;

                if (request.UrlReferrer == null)
                    throw new System.Web.HttpException("无效的提交请求");
                if (request.UrlReferrer.Host != "localhost" || request.UrlReferrer.Port!=1930)
                    throw new System.Web.HttpException("这个表单不是从本站提交的!");
            }

        }
    }

}