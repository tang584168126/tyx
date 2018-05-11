using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BookRating
    {
        /// <summary>
        /// 等级编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// 评论
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
}
