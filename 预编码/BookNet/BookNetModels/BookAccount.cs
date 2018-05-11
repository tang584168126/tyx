using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNet.Models
{
    [Serializable]
    public class BookAccount
    {
        /// <summary>
        /// 书籍账目编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书籍
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// 公司购书价格
        /// </summary>
        public decimal BuyMoney { get; set; }

        /// <summary>
        /// 书籍交易时间
        /// </summary>
        public DateTime Date { get; set; }
    }
}
