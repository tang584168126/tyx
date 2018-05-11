using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
                new Student{Name = "张明",Gender="男",Birthday=DateTime.Parse("1996-2-1")},
                new Student{Name = "王强",Gender="男",Birthday=DateTime.Parse("1995-6-11")},
            };

            //FirstOrDefault()方法的应用
            Student student = (from stu in students select stu).FirstOrDefault();
            Console.WriteLine("学生姓名：{0}", student.Name);

            //SingleOrDefault()方法的应用
            students.Remove(student);
            student = (from stu in students select stu).SingleOrDefault();
            Console.WriteLine("学生姓名：{0}", student.Name);

            Console.ReadLine();
        }
    }
}
