using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            
            car.Name = "奔驰";
            car.Color = "蓝";
            car.ProductPlace = "德国";
            car.Run();
            Console.ReadLine();

        }
    }
}
