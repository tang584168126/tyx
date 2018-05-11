using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建类的对象
            Student objStu = new Student();

            //2.引用类的属性(字段)
            Console.Write("请输入学号:");
            objStu.stuNO = Console.ReadLine();
            Console.Write("请输入姓名:");
            objStu.stuName = Console.ReadLine();

            //3.引用类的方法
            objStu.SayHi();

            Console.ReadLine();
        }
    }
}
