using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo4.Class;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEm1 = new Employee();

            Employee objEm2 = new Employee();

            objEm1.GoHome(new TrafficCar());

            objEm2.GoHome(new TrafficMetro());

            Console.ReadLine();
        }
    }
}
