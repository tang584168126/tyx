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
            //设置学生类对象
            Student objStu = new Student();

            //设置姓名
            objStu.SetName("Michael");

            //获取姓名
            Console.WriteLine("我取的英文名字是:" + objStu.GetName());

            Console.ReadLine();
        }
    }
}
