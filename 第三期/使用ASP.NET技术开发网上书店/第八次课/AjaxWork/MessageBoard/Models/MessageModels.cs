using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Models
{
    public class MessageModels
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 主人姓名
        /// </summary>
        public string AdminName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}