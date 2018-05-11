using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class MessageInfo
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
        /// 发布时间
        /// </summary>
        public DateTime PostTime { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 网站
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 用户IP
        /// </summary>
        public string UserIp { get; set; }

        /// <summary>
        /// 表情
        /// </summary>
        public string FaceUrl { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 匿名
        /// </summary>
        public bool IsHide { get; set; }

    }
}
