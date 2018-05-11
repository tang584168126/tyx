using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Models
{
    public class AdminModels
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 公布时间
        /// </summary>
        public DateTime PostTime { get; set; }

        /// <summary>
        /// 邮件
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 网站
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 用户协议
        /// </summary>
        public string UserIp { get; set; }

        /// <summary>
        /// 表情路径
        /// </summary>
        public string FaceUrl { get; set; }

        /// <summary>
        /// 头像路径
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool IsHide { get; set; }
    }
}