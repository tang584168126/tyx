using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class PublisherManager
    {
        /// <summary>
        /// 获取所有的publisher
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetAllPublisher()
        {
            return new PublisherService().GetAllPublisher();
        }
    }
}