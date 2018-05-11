using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class PublisherManager
    {
        /// <summary>
        /// 获取所有的出版社信息
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetPublishers()
        {
            return new PublisherService().GetPublishers();
        }
    }
}
