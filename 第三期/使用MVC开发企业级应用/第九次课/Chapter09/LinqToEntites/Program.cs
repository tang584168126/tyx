using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntites
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 关联查询
            //查询张姓男生，并且出生日期大于1996-8-1
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                DateTime birthday = DateTime.Parse("1996-8-1");
                //var query = from stu in entities.Student
                //            where stu.StudentName.StartsWith("张") && stu.Gender == "男" && stu.Birthday > birthday
                //            select new { stu.StudentName, stu.Grade.GradeName };
                var query = from stu in entities.Student
                            join grade in entities.Grade
                            on stu.GradeId equals grade.GradeId
                            where stu.StudentName.StartsWith("张") && stu.Gender == "男"
                            select new { stu.StudentName, grade.GradeName };

                foreach(var stu in query)
                {
                    Console.WriteLine("学生姓名：{0}\t学生年级：{1}", stu.StudentName, stu.GradeName);
                }

            }
            #endregion

            #region 嵌套查询
            Console.WriteLine("=======嵌套查询=======");
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                DateTime date = DateTime.Parse("1996-8-1");
                var query = from s in
                                (from s in entities.Student
                                 where s.GradeId == 1
                                 select new { s.Grade.GradeName, s.StudentName, s.StudentNo })
                            where s.StudentNo > 10000
                            select s;
                var query1 = from s in entities.Student
                             select new
                             {
                                 Name = s.StudentName,
                                 Exam = from r in s.Result
                                        where r.ExamDate == date
                                        select new { r.Subject.SubjectName, r.StudentResult }
                             };
                foreach(var stu in query)
                {
                    Console.WriteLine("年级：{0},姓名：{1}",stu.GradeName,stu.StudentName);
                    //Console.WriteLine("姓名：{0},成绩：{1}", stu.Name,stu.Exam.First());
                }
                
            }
            #endregion

            #region 关联操作
            Console.WriteLine("==========关联操作==========");
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                var stu = new Student()
                {
                    StudentName = "姚云",
                    GradeId = (from g in entities.Grade
                               where g.GradeName == "S2"
                               select g.GradeId).SingleOrDefault()
                };
                entities.Student.Add(stu);
                #region 通过导航属性添加数据
                (from g in entities.Grade
                 where g.GradeName == "S2"
                 select g).SingleOrDefault().Student.Add(stu);
                #endregion

                #region 删除级联数据
                //先删除与年级所有学生，在删除y2年级
                var grade = (from g in entities.Grade
                             where g.GradeName == "y2"
                             select g).SingleOrDefault();
                for(int i = 0; i<grade.Student.Count;)
                {
                    entities.Student.Remove(grade.Student.FirstOrDefault());
                }
                entities.Grade.Remove(grade);
                entities.SaveChanges();
                #endregion
            }
            #endregion

            Console.ReadLine();
        }
    }
}
