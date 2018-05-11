using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Order
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 订单时间
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}
