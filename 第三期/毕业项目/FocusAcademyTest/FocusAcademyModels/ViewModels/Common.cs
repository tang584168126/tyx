using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusAcademy.Models
{
    /// <summary>
    /// 评论
    /// </summary>
    public class Common
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 虚拟书编号
        /// </summary>
        public int EBookId { get; set; }

        /// <summary>
        /// 实体书编号
        /// </summary>
        public int EntityBookId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
