using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Friends.Models
{
    public enum PrivateSet
    {
        /// <summary>
        /// 完全公开
        /// </summary>
        Public,
        /// <summary>
        /// 好友可见
        /// </summary>
        Friend,
        /// <summary>
        /// 完全保密
        /// </summary>
        Private
    }
}