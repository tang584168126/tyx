using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Category
    {
        /// <summary>
        /// 类型编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }

        public int PId { get; set; }

        /// <summary>
        /// 分类的数目
        /// </summary>
        public int SortNum { get; set; }
    }
}
