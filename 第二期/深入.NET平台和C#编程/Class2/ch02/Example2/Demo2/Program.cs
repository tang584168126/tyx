using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    /// <summary>
    /// 装箱与拆箱
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //值类型
            int num1 = 10;
            int num2 = 20;

            //引用类型
            object objTest = null;

            Console.WriteLine("装箱前,num1 = " + num1 + ",num2=" + num2);

            //装箱,值类型=>引用类型
            objTest = num2;

            objTest = 30;

            //拆箱,引用类型 => 值类型
            num2 = (int)objTest;

            Console.WriteLine("拆箱后,num1 = " + num1 + ",num2=" + num2);

            Console.ReadLine();
        }
    }
}
