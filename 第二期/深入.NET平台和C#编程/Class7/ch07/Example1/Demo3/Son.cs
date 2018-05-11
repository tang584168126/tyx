using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class Son : Father
    {
        public override void GetMoney()
        {
            Console.WriteLine("儿子会挣钱了!");
        }

        public void GetFriend()
        {
            Console.WriteLine("儿子谈恋爱!");
        }

        public void GetMarry()
        {
            Console.WriteLine("儿子打算结婚!");
        }
    }
}
