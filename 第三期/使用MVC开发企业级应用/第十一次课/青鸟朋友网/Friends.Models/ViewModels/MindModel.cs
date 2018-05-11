using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Friends.Models
{
    public class MindModel
    {
        [DisplayName("内容")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Content { get; set; }

        [DisplayName("心情")]
        [Required(ErrorMessage = "需要选择一种{0}")]
        public byte MindType { get; set; }
    }
}