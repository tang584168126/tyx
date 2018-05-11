using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text3
{
    class Program
    {
        static void Main(string[] args)
        {
            Text4_1 rechargeable = new Text4_1();
            rechargeable.AddMoney();
            if (rechargeable.Isok == true)
            {
                Console.WriteLine("充值成功！");
            }
            else
            {
                Console.WriteLine("充值失败！");
            }
            Console.ReadLine();
        }
    }
}
