using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Models
{
    public class SearchKeyword
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 搜索次数
        /// </summary>
        public int SearchCount { get; set; }
    }
}
