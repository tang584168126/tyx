using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSet.Models
{
    [Serializable]
    public class Publisher
    {
        /// <summary>
        /// 出版社编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 出版社名称
        /// </summary>
        public string Name { get; set; }
    }
}
