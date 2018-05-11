using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSet.Models
{
    public class UserRole
    {
        /// <summary>
        /// 用户权限编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户权限名称
        /// </summary>
        public string Name { get; set; }
    }
}
