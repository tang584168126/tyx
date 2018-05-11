using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            var chars = from c in str 
                        where char.IsUpper(c)
                        select c;
            foreach(var c in chars)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
