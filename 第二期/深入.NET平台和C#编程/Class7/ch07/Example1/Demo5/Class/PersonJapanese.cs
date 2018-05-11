using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.Class
{
    public class PersonJapanese : Person
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        public override void Eat()
        {
            Console.WriteLine("日本人吃寿司!");
        }

        public override void Speak()
        {
            Console.WriteLine("日本人讲日语!");
        }
        #endregion
    }
}
