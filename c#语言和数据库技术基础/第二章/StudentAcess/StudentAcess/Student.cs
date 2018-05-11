using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcess
{
    public class Student
    {
        #region 学生信息
        string name;     //学生名字
        double[] scores = new double[3];      //学生3门课程的成绩
        public double sum = 0;      //学生总成绩
        double avg = 0;      //学生平均分
        #endregion

        /// <summary>
        /// 接收学生信息的方法
        /// </summary>
        public void AddStudent()
        {
            #region 输入学生信息
            Console.Write("学生姓名：");
            name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("第{0}门课程考试成绩是：", (i + 1));
                scores[i] = double.Parse(Console.ReadLine());

                sum += scores[i];
            }
            avg = sum / 3;
            Console.WriteLine("三门课程总成绩是：{0}，平均成绩是：{1}", sum, avg);

            #endregion
        }
        
        
       
    }
}
