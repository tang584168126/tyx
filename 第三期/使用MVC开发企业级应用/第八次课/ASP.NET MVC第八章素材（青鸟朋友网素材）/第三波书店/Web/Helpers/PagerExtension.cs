using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc.Html;
using System.Web.Routing;
using BookShop.Helpers;
namespace System.Web.Mvc
{
    public static class PagerExtension
    {


        public static string Pager<T>(this HtmlHelper html, PagedList<T> data)
        {
            int start = (data.PageIndex - 5) >= 1 ? (data.PageIndex - 5) : 1;
            int end = (data.TotalPages - start) > 10 ? start + 10 : data.TotalPages;

            RouteValueDictionary vs = html.ViewContext.RouteData.Values;

            var queryString = html.ViewContext.HttpContext.Request.QueryString;

            foreach (string key in queryString.Keys)
                //if (queryString[key] != null && !string.IsNullOrEmpty(key))
                vs[key] = queryString[key];

            var FormString = html.ViewContext.HttpContext.Request.Form;
            foreach (string key in FormString.Keys)
                vs[key] = FormString[key];

            var builder = new StringBuilder();
            builder.AppendFormat("<div class=\"mvc_pager\">");

            if (data.HasPreviousPage)
            {
                vs["pageIndex"] = 1;
                builder.Append(LinkExtensions.ActionLink(html, "首页", vs["action"].ToString(), vs));
                vs["pageIndex"] = data.PageIndex - 1;
                builder.Append(LinkExtensions.ActionLink(html, "上页", vs["action"].ToString(), vs));
            }

            for (int i = start; i <= end; i++) //前后各显示5个数字页码
            {
                vs["pageIndex"] = i;
                if (i == data.PageIndex)
                {
                    builder.Append("<font class='thispagethis'>" + i.ToString() + "</font>");
                }
                else
                {
                    builder.Append(LinkExtensions.ActionLink(html, i.ToString(), vs["action"].ToString(), vs));
                }
            }

            if (data.HasNextPage)
            {
                vs["pageIndex"] = data.PageIndex + 1;
                builder.Append(LinkExtensions.ActionLink(html, "下页", vs["action"].ToString(), vs));
                vs["pageIndex"] = data.TotalPages;
                builder.Append(LinkExtensions.ActionLink(html, "末页", vs["action"].ToString(), vs));
            }
            builder.Append("共" + data.TotalCount + "条 第" + data.PageIndex + "页/共" + data.TotalPages + "页 </div>");
            return builder.ToString();
        }
    }
}