using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class SearchKeyword
    {
        /// <summary>
        /// 搜索关键字编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 搜索数目
        /// </summary>
        public int SearchCount { get; set; }
    }
}
