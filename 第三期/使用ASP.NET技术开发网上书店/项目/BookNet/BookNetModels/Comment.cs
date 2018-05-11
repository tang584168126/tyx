using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNet.Models
{
    [Serializable]
    public class Comment
    {
        /// <summary>
        /// 评论编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
