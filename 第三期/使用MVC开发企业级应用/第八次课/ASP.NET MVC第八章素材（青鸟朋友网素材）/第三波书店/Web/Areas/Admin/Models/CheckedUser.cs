using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace Web.Areas.Admin.Models
{
    public class CheckedUser
    {
        /// <summary>
        /// 选择状态
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id { get; set; }
    }
}