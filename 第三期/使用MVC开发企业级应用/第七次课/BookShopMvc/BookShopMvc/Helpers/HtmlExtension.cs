using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookShopMvc.Helpers
{
    public static class HtmlExtension
    {
        /// <summary>
        /// 输出表单提交按钮
        /// </summary>
        /// <param name="helper">对象</param>
        /// <param name="name">属性值</param>
        /// <param name="value">属性值</param>
        /// <returns></returns>
        public static string Submit(this HtmlHelper helper, string name, string value)
        {
            var builder = new TagBuilder("input");
            builder.MergeAttribute("type", "submit");
            builder.MergeAttribute("value", value);
            builder.MergeAttribute("name", name);
            builder.GenerateId(name);
            return builder.ToString();
        }

        /// <summary>
        /// 输出表单提交按钮
        /// </summary>
        /// <param name="helper">对象</param>
        /// <param name="name">属性值</param>
        /// <param name="value">属性值</param>
        /// <param name="htmlAttributes">属性匿名对象集合</param>
        /// <returns></returns>
        public static string Submit(this HtmlHelper helper,string name,string value,object htmlAttributes)
        {
            var builder = new TagBuilder("input");
            builder.MergeAttribute("type", "submit");
            builder.MergeAttribute("value", value);
            builder.MergeAttribute("name", name);
            builder.GenerateId(name);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return builder.ToString();
        }
    }
}