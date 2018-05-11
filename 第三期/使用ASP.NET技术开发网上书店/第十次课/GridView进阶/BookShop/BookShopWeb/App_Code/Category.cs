using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShopWeb
{
    [Serializable]
    public class Category
    {
        public Category() { }
        public Category(int id, string name) 
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int PId { get; set; }

        public int SortNum { get; set; }
    }
}