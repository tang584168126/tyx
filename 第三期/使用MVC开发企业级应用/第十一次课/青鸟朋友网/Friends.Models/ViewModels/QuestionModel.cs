using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Models
{
    [MetadataType(typeof(QuestionMetaData))]
    public partial class Question
    {
        [DisplayName("标签")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string TagList { get; set; }

        //元数据类
        public class QuestionMetaData
        {
            [DisplayName("标题")]
            [Required(ErrorMessage = "{0}不得为空")]
            public string Title { get; set; }

            [DisplayName("内容")]
            [Required(ErrorMessage = "{0}不得为空")]
            public string Content { get; set; }

            [DisplayName("悬赏")]
            [Required(ErrorMessage = "{0}不得为空")]
            public int Prize { get; set; }
           
        }


    }
}
