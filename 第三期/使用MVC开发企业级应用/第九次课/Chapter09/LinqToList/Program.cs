using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
                new Student{Name = "张明",Gender="男",Birthday=DateTime.Parse("1996-2-1")},
                new Student{Name = "王强",Gender="男",Birthday=DateTime.Parse("1995-6-11")},
                new Student{Name = "张丽丽",Gender="女",Birthday=DateTime.Parse("1996-8-9")},
                new Student{Name = "陈好",Gender="女",Birthday=DateTime.Parse("1994-12-24")},
                new Student{Name = "张无忌",Gender="男",Birthday=DateTime.Parse("1994-4-24")}
            };

            //查询张姓男生，并按生日升序排序
            var list = from stu in students
                       where stu.Name.StartsWith("张") && stu.Gender.Equals("男")
                       orderby stu.Birthday ascending
                       select stu;

            //输出符合条件的学生
            foreach(var stu in list)
            {
                Console.WriteLine("{0}\t{1}", stu.Name, stu.Birthday);
            }
            Console.ReadLine();
        }
    }
}
