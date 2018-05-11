using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNet.Models
{
    [Serializable]
    public class Rebate
    {
        /// <summary>
        /// 折扣编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书籍
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// 折扣多少
        /// </summary>
        public decimal RebatePrice { get; set; }
    }
}
