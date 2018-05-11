using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookShop.Helpers
{
    public static class Extension
    {


       /// <summary>
        /// 截断字符串
       /// </summary>
       /// <param name="str"></param>
       /// <param name="num"></param>
       /// <returns></returns>
        public static string CutString(this string str, int num)
        {
            if (str.Length > num - 2)
                return str.Substring(0, num - 2) + "...";
            else
                return str;
        }
        /// <summary>
        /// 货币
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToMoney(this string str)
        {
            return String.Format("{0:C}", str);
        }
        /// <summary>
        /// 短日期
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToShortDate(this object obj)
        {
            return Convert.ToDateTime(obj).ToShortDateString();
        }

    }
}
