using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 查询单表数据
            Console.WriteLine("==========查询单表数据===========");
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                Grade grade = entities.Grades.SingleOrDefault(g => g.GradeName == "S2");
                if(grade != null)
                {
                    Console.WriteLine("S2的年级编号为{0}", grade.GradeId);
                }

                //用where方法查询多个学生的信息
                IQueryable<Student> stus = entities.Students.Where(s => s.Gender == "男" && s.GradeId == grade.GradeId );
                List<Student> studentList = stus.ToList();
                Console.WriteLine("学号\t姓名");
                foreach(var stu in studentList)
                {
                    Console.WriteLine("{0}\t{1}", stu.StudentNo, stu.StudentName);
                }
            }
            #endregion

            #region 添加学生数据
            Console.WriteLine("==========添加学生数据===========");
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                entities.Students.Add(new Student()
                {
                    LoginPwd = "123",
                    StudentName = "白富美",
                    Gender = "男",
                    GradeId = 2,
                    Birthday = Convert.ToDateTime("1988-09-01")
                });

                if(entities.SaveChanges() > 0)
                {
                    Console.WriteLine("学生数据添加成功！");
                }

                //用where方法查询多个学生的信息
                IQueryable<Student> stus = entities.Students.Where(s => s.Gender == "男" && s.GradeId == 2);
                List<Student> studentList = stus.ToList();
                Console.WriteLine("学号\t姓名");
                foreach (var stu in studentList)
                {
                    Console.WriteLine("{0}\t{1}", stu.StudentNo, stu.StudentName);
                }               
            }
            #endregion

            #region 修改学生数据
            Console.WriteLine("==========修改学生数据===========");
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                Student stu = entities.Students.SingleOrDefault(s => s.StudentNo == 23242);

                stu.StudentName = "高富帅";

                if(entities.SaveChanges() > 0)
                {
                    Console.WriteLine("修改数据成功！");
                }

                //用where方法查询多个学生的信息
                IQueryable<Student> stus = entities.Students.Where(s => s.Gender == "男" && s.GradeId == 2);
                List<Student> studentList = stus.ToList();
                Console.WriteLine("学号\t姓名");
                foreach (var item in studentList)
                {
                    Console.WriteLine("{0}\t{1}", item.StudentNo, item.StudentName);
                }
            }
            #endregion

            #region 删除指定学生数据
            Console.WriteLine("==========删除指定学生数据===========");
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                Student stu = entities.Students.SingleOrDefault(s => s.StudentNo == 23241);

                entities.Students.Remove(stu);

                if(entities.SaveChanges() > 0)
                {
                    Console.WriteLine("删除学生成功！");
                }

                //用where方法查询多个学生的信息
                IQueryable<Student> stus = entities.Students.Where(s => s.Gender == "男" && s.GradeId == 2);
                List<Student> studentList = stus.ToList();
                Console.WriteLine("学号\t姓名");
                foreach (var item in studentList)
                {
                    Console.WriteLine("{0}\t{1}", item.StudentNo, item.StudentName);
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
