using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ShoppingItem
    {
        private Book book;

        public Book Book
        {
            get { return book;}
            set { book = value; }
        }


        private int quantity;


        [DisplayName("数量")]
        [Required(ErrorMessage = "{0}必须填写")]
        [Range(1, int.MaxValue, ErrorMessage = "{0}必须是大于1的整数")]
       // [RegularExpression(@"^\+?[1-9][0-9]*$", ErrorMessage = "{0}必须是大于1的整数")]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public ShoppingItem()
        {

        }

        public ShoppingItem(Book book, int quantity)
        {
            this.book = book;
            this.quantity = quantity;
        }
    }
}
