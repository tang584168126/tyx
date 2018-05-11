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


        [DisplayName("������")]
        public Publisher Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }


        [DisplayName("����")]
        public Category Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        [DisplayName("����")]
        [Required(ErrorMessage = "{0}����Ϊ��")]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        [DisplayName("����")]
        [Required(ErrorMessage = "{0}����Ϊ��")]
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        [DisplayName("��������")]
        [Required(ErrorMessage = "{0}����Ϊ��")]
        [DataType(DataType.DateTime)]
        public DateTime PublishDate
        {
            get { return this.publishDate; }
            set { this.publishDate = value; }
        }

        [DisplayName("ISBN")]
        [Required(ErrorMessage = "{0}����Ϊ��")]
        public string ISBN
        {
            get { return this.iSBN; }
            set { this.iSBN = value; }
        }

        [DisplayName("����")]
        [Required(ErrorMessage = "{0}����Ϊ��")]
        public decimal UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        [DisplayName("���ݼ��")]
        [DataType(DataType.EmailAddress)]
        public string ContentDescription
        {
            get { return this.contentDescription; }
            set { this.contentDescription = value; }
        }

        [DisplayName("Ŀ¼")]
        public string TOC
        {
            get { return this.tOC; }
            set { this.tOC = value; }
        }

        [DisplayName("���ʴ���")]
        public int Clicks
        {
            get { return this.clicks; }
            set { this.clicks = value; }
        }

    }
}
