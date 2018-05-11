using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置学生类对象
            Student objStu = new Student();

            //引用学生类的属性
            objStu.Name = "Michael";

            objStu.Age = 20;

            Console.WriteLine("我取的英文名字是:" + objStu.Name);
            Console.WriteLine("学生的年龄是:" + objStu.Age + "岁");


            Console.ReadLine();
        }
    }
}
