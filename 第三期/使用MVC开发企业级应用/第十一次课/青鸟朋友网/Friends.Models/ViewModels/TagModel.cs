using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class TagModel
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int QuestionCount { get; set; }//对应问题个数
    }
}
