using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSet.Models
{
    [Serializable]
    public class ShoppingCar
    {
        /// <summary>
        ///购物车编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 书籍
        /// </summary>
        public Book Book { get; set; }
    }
}
