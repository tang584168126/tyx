using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Models
{
   public class ExpertModel
    {
        public string HeaderImage { get; set; }//头像图片

        public int ExpertId { get; set; }

        public int Prize { get; set; }//青鸟豆

        public string Name { get; set; }//专家姓名

        public string Title { get; set; }//专家头衔

    }
}
