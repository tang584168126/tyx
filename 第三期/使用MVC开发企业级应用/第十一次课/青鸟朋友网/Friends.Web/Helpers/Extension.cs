using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Friends.Web.Helpers
{
    public static class Extension
    {


        /// <summary>
        /// 截断字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToShortString(this string str, int num)
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


        /// <summary>
        /// 显示XX天
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ToSpanDays(this System.DateTime time)
        {
            DateTime t1 = DateTime.Now;
            DateTime t2 = time;
            TimeSpan tspan = t1 - t2;

            string mess = "";
            if (tspan.Days >= 1)//间隔天数1天以上
            {
                mess = time.ToString("yyyy年MM月dd日hh时mm分");
            }
            else if (tspan.Hours >= 1)
            {
                mess = string.Format("{0}小时前", tspan.Hours);
            }
            else
            {
                mess = string.Format("{0}分钟前", tspan.Minutes);

            }
            return mess;
        }


        public static string ToQuestionState(this byte state)
        {
            switch (state)
            {
                case 0:
                    return "待解决";
                case 1:
                    return "已解决";
                case 2:
                    return "已关闭";
                default:
                    return "";
            }
         
        }

    }
}
