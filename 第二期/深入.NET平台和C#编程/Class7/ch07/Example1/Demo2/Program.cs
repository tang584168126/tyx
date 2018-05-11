using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //里氏替代原则
            Traffic objTraffic1 = new TrafficCar();

            Traffic objTraffic2 = new TrafficMetro();

            objTraffic1.Run();

            objTraffic2.Run();

            Console.ReadLine();
        }
    }
}
