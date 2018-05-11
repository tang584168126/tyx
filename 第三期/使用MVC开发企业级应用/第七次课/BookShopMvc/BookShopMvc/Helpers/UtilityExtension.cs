using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShopMvc.Helpers
{
    public static class UtilityExtension
    {
        /// <summary>
        /// 截断字符串
        /// </summary>
        /// <param name="content"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string CutString(this string str, int num)
        {
            if (str.Length > num - 2)
                return str.Substring(0, num - 2) + "...";
            else
                return str;
        }
    }
}