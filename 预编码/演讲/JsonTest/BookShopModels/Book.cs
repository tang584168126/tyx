using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Models
{
    public class Book
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }       

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// 图书编号
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 内容简介
        /// </summary>
        public string ContentDescription { get; set; }

        /// <summary>
        /// 目录
        /// </summary>
        public string TOC { get; set; }

        /// <summary>
        /// 点击数
        /// </summary>
        public int Clicks { get; set; }

        /// <summary>
        /// 发布
        /// </summary>
        public Publisher Publisher { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public Category Category { get; set; }
    }
}
