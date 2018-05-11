using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.Class
{
    /// <summary>
    /// 英国人
    /// </summary>
    public class PersonEnglish : Person
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Eat()
        {
            Console.WriteLine("英国人吃牛排!");
        }

        public override void Speak()
        {
            Console.WriteLine("英国人讲英语!");
        }
        #endregion
    }
}
