using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends.Models
{
    /// <summary>
    /// 查找到的用户
    /// </summary>
    public class FriendViewModel
    {
        public int UserId { get; set; }
        //public string Mail { get; set; }
        public string RealName { get; set; }
        public string Gender { get; set; }
        public System.DateTime Birthday { get; set; }
        public string City { get; set; }
        public string HomeCity { get; set; }
        public string Situation { get; set; }
        public string BloodStyle { get; set; }
        public string HeaderImage { get; set; }
        /// <summary>
        /// 是否好友
        /// </summary>
        public bool IsFriend { get; set; }

        /// <summary>
        /// 所属好友分组
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        public SelectList Groups { get; set; }
    }
}