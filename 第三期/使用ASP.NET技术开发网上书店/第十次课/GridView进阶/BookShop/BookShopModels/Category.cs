using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    [Serializable]
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PId { get; set; }

        public int SortNum { get; set; }
    }
}