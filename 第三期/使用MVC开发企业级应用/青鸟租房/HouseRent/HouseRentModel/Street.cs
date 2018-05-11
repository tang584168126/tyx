using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRent.Model
{
    public class Street
    {
        /// <summary>
        /// 街道编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 街道地区
        /// </summary>
        public District District { get; set; }
    }
}
