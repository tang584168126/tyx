using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNet.Models
{
    [Serializable]
    public class Book
    {
        /// <summary>
        /// 书籍编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书籍名称
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 出售单价
        /// </summary>
        public decimal SellMoney { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 公司购书时间
        /// </summary>
        public DateTime BuyDate { get; set; }

        /// <summary>
        /// 书籍发布时间
        /// </summary>
        public DateTime PublisherDate { get; set; }

        /// <summary>
        /// 评论
        /// </summary>
        public Comment Comment { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        public Publisher Publisher { get; set; }

        /// <summary>
        /// 书籍类型
        /// </summary>
        public Mold Mold { get; set; }

        /// <summary>
        /// 内容简介
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 书籍状态<true:完本，false:未完本>
        /// </summary>
        public bool BookState { get; set; }

        /// <summary>
        /// 字数
        /// </summary>
        public int WordCount { get; set; }

        /// <summary>
        /// 书籍封面图片
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// 点击率
        /// </summary>
        public int Clicks { get; set; }
    }
}
