using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Models
{
    public enum QuestionState
    {
        /// <summary>
        /// 初始状态
        /// </summary>
        Initial = 0,
        /// <summary>
        /// 解决状态
        /// </summary>
        Finished = 1,
        /// <summary>
        /// 关闭状态
        /// </summary>
        Closed = 2
    }
}
