using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcess
{

    class Program
    {
        static void Main(string[] args)
        {
            #region 班级成绩信息
            int count = 0;      //计数器，记录参考人数
            int i = 0, j = 0;      //循环变量
            double temp = 0;     //临时变量
            double max = 0;     //最高分
            double avgs = 0;        //班级平均分
            double sums = 0;        //班级总成绩
            #endregion

            #region 创建五个学生类
            Student[] stu = new Student[5];
            #endregion
            #region 班级成绩汇总
            #region 参考人数

            for (i = 0; i < stu.Length;i++ )
            {
                stu[i] = new Student();
            }
            for (i = 0; i < stu.Length;i++)
            {
                
                stu[i].AddStudent();
                count++;
                sums += stu[i].sum;
            }

            #endregion

            #region 最高分和平均分
            for (i = 0; i < stu.Length - 1;i++ )
            {
                for (j = 0; j < stu.Length - 1 - i;i++ )
                {
                    if (stu[j].sum < stu[j + 1].sum)
                    {
                        temp = stu[j].sum;
                        stu[j].sum = stu[j + 1].sum;
                        stu[j + 1].sum = temp;
                    }
                }
            }
            max = stu[0].sum;
            avgs = sums / stu.Length;
            Console.WriteLine("班级参考人数：{0}，最高分：{1}，平均分：{2}",count,max,avgs);
            #endregion
            #endregion
            Console.ReadLine();
        }
    }
}
