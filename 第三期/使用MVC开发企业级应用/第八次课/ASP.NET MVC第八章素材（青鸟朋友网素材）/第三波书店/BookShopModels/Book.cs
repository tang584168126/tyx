using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BookShop.Models
{
    [Serializable()]
    public class Book
    {
        private int id;
        private Publisher publisher;
        private Category category;
        private string title = String.Empty;
        private string author = String.Empty;
        private DateTime publishDate;
        private string iSBN = String.Empty;
        private decimal unitPrice;
        private string contentDescription = String.Empty;
        private string tOC = String.Empty;
        private int clicks;

        public Book() { }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        [DisplayName("出版社")]
        public Publisher Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }


        [DisplayName("分类")]
        public Category Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        [DisplayName("标题")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        [DisplayName("作者")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        [DisplayName("出版日期")]
        [Required(ErrorMessage = "{0}不得为空")]
        [DataType(DataType.DateTime)]
        public DateTime PublishDate
        {
            get { return this.publishDate; }
            set { this.publishDate = value; }
        }

        [DisplayName("ISBN")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string ISBN
        {
            get { return this.iSBN; }
            set { this.iSBN = value; }
        }

        [DisplayName("单价")]
        [Required(ErrorMessage = "{0}不得为空")]
        public decimal UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        [DisplayName("内容简介")]
        [DataType(DataType.EmailAddress)]
        public string ContentDescription
        {
            get { return this.contentDescription; }
            set { this.contentDescription = value; }
        }

        [DisplayName("目录")]
        public string TOC
        {
            get { return this.tOC; }
            set { this.tOC = value; }
        }

        [DisplayName("访问次数")]
        public int Clicks
        {
            get { return this.clicks; }
            set { this.clicks = value; }
        }

    }
}
