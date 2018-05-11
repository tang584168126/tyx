using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //电脑
            LapTop ibmLap = new LapTop();

            LapTop hpLap = new LapTop();

            //能源
            PowerBattery objBattery = new PowerBattery();
            PowerAc objAc = new PowerAc();

            ibmLap.ObjPower = objBattery;

            hpLap.ObjPower = objAc;

            Console.WriteLine("IBM电脑:");
            ibmLap.ObjPower.GetPower();

            Console.WriteLine("HP电脑:");
            hpLap.ObjPower.GetPower();

            Console.ReadLine();
        }
    }
}
