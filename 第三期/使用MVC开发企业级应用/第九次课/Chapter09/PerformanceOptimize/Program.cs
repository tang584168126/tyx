using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceOptimize
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MySchoolEntities entities = new MySchoolEntities())
            {
                //关闭状态管理
                entities.Configuration.AutoDetectChangesEnabled = false;
                //var query = from stu in entities.Student
                //            where stu.Gender == "男"
                //            select stu;
                ////string sql = query.ToString();
                //List<Student> list = query.ToList();

                var query1 = from s in entities.Student
                             where s.StudentNo == 23221
                             select s;
                var stu1 = query1.ToList();

                int stuNo = 23221;
                var query2 = from s in entities.Student
                             where s.StudentNo == stuNo
                             select s;
                var stu2 = query2.ToList();
            }

            Console.ReadLine();
        }
    }
}
