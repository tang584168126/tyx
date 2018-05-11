using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MvcDemo.Models
{
    public class Comment
    {
        [Required]
        public string CommentName { get; set; }


        public string CommentEmail { get; set; }

        [Required]
        public string CommentHome { get; set; }//网站

        [Required]
        public string CommentBody { get; set; }//内容

        private DateTime _commentTime = DateTime.Now;
        public DateTime CommentTime
        {
            get { return _commentTime; }
        }
    }
}