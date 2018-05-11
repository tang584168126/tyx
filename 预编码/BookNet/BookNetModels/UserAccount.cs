using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNet.Models
{
    [Serializable]
    public class UserAccount
    {
        /// <summary>
        /// 用户账目编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        public int Integral { get; set; }

        /// <summary>
        /// 书籍
        /// </summary>
        public Book Book { get; set; }
    }
}
