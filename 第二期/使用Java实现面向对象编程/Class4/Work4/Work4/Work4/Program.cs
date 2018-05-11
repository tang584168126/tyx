using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建打印机对象
            Printer printer = new Printer();

            //创建墨盒对象
            InkBox inkBox = null;

            //创建纸张对象
            Paper paper = null;

            //使用黑白墨盒在A4纸上打印
            inkBox = new GrayInkBox();
            paper = new A4Paper();
            printer.InkBox = inkBox;
            printer.Paper = paper;
            printer.Print();

            //使用黑白墨盒在B5纸上打印
            inkBox = new GrayInkBox();
            paper = new B5Paper();
            printer.InkBox = inkBox;
            printer.Paper = paper;
            printer.Print();

            //使用彩色墨盒在A4纸上打印
            inkBox = new ColourInkBox();
            paper = new A4Paper();
            printer.InkBox = inkBox;
            printer.Paper = paper;
            printer.Print();

            //使用彩色墨盒在B5纸上打印
            inkBox = new ColourInkBox();
            paper = new B5Paper();
            printer.InkBox = inkBox;
            printer.Paper = paper;
            printer.Print();

            Console.ReadLine();
        }
    }
}
