using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSet.Models
{
    
   public class Managers
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeadPortrait { get; set; }
        /// <summary>
        /// 留言内容
        /// </summary>
        public string Content { get; set; }

       /// <summary>
       /// 留言时间
       /// </summary>
        public DateTime Date { get; set; }
       /// <summary>
       /// 留言书籍
       /// </summary>
       public string Isbn { get; set; }
    }
}
