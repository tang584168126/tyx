using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        /// <summary>
        /// 当前节点的父节点编号
        /// </summary>
        public int PId { get; set; }

        /// <summary>
        /// 显示顺序编号
        /// </summary>
        public int SortNum { get; set; }
    }
}
