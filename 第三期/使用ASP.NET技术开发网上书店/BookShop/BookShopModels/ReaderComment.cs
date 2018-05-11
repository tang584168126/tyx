using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class ReaderComment
    {
        /// <summary>
        /// 读者评论编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// 读者昵称
        /// </summary>
        public string ReaderName { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 评论
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Date { get; set; }
    }
}
