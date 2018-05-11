using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Models
{
    public class Publisher
    {
        public Publisher() { }
        public Publisher(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// 出版社编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 出版社名称
        /// </summary>
        public string Name { get; set; }
    }
}
