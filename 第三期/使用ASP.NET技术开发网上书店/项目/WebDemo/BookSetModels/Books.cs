using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSet.Models
{
   public class Books
    {
       /// <summary>
       /// 书籍Id
       /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书籍名称
        /// </summary>
        public string BookName { get; set; }


        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }


        /// <summary>
        /// 单价
        /// </summary>
        public int SellMoney { get; set; }



        /// <summary>
        /// 书籍页数
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 出售时间
        /// </summary>
        public DateTime BuyDate { get; set; }


        /// <summary>
        /// 出版时间
        /// </summary>
        public DateTime PublisherDate { get; set; }


        /// <summary>
        /// 出版社Id
        /// </summary>
        public int PublisherId { get; set; }

       

       /// <summary>
       /// 书籍简介
       /// </summary>
        public string Content { get; set; }


       /// <summary>
       /// 书籍图片
       /// </summary>
        public string Picture { get; set; }

       /// <summary>
       /// 书籍点击次数
       /// </summary>
        public int Clicks { get; set; }

       /// <summary>
       /// 书籍条码
       /// </summary>
        public string Isbn { get; set; }

    }
}
