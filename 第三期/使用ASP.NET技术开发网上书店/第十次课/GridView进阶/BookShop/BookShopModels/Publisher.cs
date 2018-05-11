using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    [Serializable]
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}