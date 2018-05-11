using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class Father
    {
        public virtual void GetMoney()
        {
            Console.WriteLine("父亲要挣钱!");
        }

        public void GetMarry()
        {
            Console.WriteLine("父亲已结婚!");
        }

    }

}
