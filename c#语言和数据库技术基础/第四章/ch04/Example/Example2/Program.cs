using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    /// <summary>
    /// 字符串的比较
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //字符串一
            string str1 = "Michael";

            //字符串二
            string str2 = "michael";

            if (str1.Equals(str2))
            {
                Console.WriteLine(str1 + " 与 " + str2 + " 相等!");
            }
            else
            {
                Console.WriteLine(str1 + " 与 " + str2 + " 不相等!");
            }

            Console.ReadLine();
        }
    }
}
