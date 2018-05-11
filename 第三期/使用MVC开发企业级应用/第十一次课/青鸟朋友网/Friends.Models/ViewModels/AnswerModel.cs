using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Models
{
     [MetadataType(typeof(AnswerMetaData))]
    public partial class Answer
    {
        //元数据类
        public class AnswerMetaData
        {
            [DisplayName("答案")]
            [Required(ErrorMessage = "{0}不得为空")]
            public string Content { get; set; }


        }
    }
}
