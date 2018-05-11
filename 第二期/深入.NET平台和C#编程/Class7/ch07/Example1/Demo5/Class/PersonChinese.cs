using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.Class
{
    /// <summary>
    /// 中国人
    /// </summary>
    public class PersonChinese : Person
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Eat()
        {
            Console.WriteLine("中国人吃米饭!");
        }

        public override void Speak()
        {
            Console.WriteLine("中国人讲中文!");
        }
        #endregion
    }
}
