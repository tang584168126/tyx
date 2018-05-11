using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    [Serializable]
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }

        public string ISBN { get; set; }

        public decimal UnitPrice { get; set; }

        public string ContentDescription { get; set; }

        public string TOC { get; set; }

        public int Clicks { get; set; }

        public Publisher Publisher { get; set; }  //FK

        public Category Category { get; set; }  //FK
    }
}