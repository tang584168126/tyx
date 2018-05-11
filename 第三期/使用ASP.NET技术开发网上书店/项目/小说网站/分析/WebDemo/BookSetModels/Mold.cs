using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSet.Models
{
    [Serializable]
    public class Mold
    {
        /// <summary>
        /// 书籍类型编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 书籍类型名称
        /// </summary>
        public string Name { get; set; }
    }
}
