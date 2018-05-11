using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int NumberChange(int n);
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            NumberChange nc1 = new NumberChange(AddNum);
            nc1(25);
            Console.WriteLine("Value of num:{0}", num);

            MyClass mc = new MyClass();
            NumberChange nc2 = new NumberChange(mc.AddNum);
            nc2(36);
            Console.WriteLine("Value of instance num:{0}", mc.num);
            
            Console.ReadLine();
        }

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
    }

    class MyClass
    {
        public int num = 10;

        public int AddNum(int p)
        {
            num += p;
            return num;
        }
    }
}
