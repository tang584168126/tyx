using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];
            int[] newPoints = new int[5];
            int i = 0;

            Console.WriteLine("请输入5位会员积分：");
            for (i = 0; i < points.Length; i++ )
            {
                Console.Write("第" + (i + 1) + "位会员积分：");
                points[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < newPoints.Length; i++ )
            {
                newPoints[i] = points[i] + 500;

            }
            Console.WriteLine("\n序号\t历史积分\t新年积分");

            for (i = 0; i < newPoints.Length; i++ )
            {
                Console.WriteLine((i + 1) + "\t" + points[i] + "\t\t" + newPoints[i]);
            }

            Console.ReadLine();
        }
    }
}
