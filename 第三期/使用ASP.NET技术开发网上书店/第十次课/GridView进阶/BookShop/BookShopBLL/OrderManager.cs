using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.DAL;

namespace BookShop.BLL
{
    public class OrderManager
    {
        //根据编号删除书籍订单信息
        public bool DeleteOrderBookByBookId(int bookId)
        {
            return new OrderService().DeleteOrderBookById(bookId);
        }
    }
}