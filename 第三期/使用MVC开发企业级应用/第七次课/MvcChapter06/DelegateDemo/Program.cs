using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate double MultiOp(double num);

    public class Program
    {
        //求平方
        public static double Multiply(double x)
        {
            return x * x;
        }

        //求开方
        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        //把方法作为另一个方法的参数
        public static double Operation(double x,MultiOp op)
        {
            return op(x);
        }

        static void Main(string[] args)
        {
            //实例化一个委托并求平方
            MultiOp op = Multiply;
            Console.WriteLine("{0}的平方为{1}", 4, op(4));

            //实例化一个委托并开方
            op = Sqrt;
            Console.WriteLine("{0}的平方为{1}", 9, op(9));

            double result = Operation(4, Multiply);
            Console.WriteLine(result);

            //匿名方法  x => x*x
            //MultiOp anomimousResult = Operation(double x) { return x * x; };
            double anomimousResult = Operation(4, x => x * x);
            Console.WriteLine(anomimousResult);

            Console.Read();
        }
    }
}
