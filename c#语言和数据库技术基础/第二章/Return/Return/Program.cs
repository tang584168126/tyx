using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明变量
            int i = 0;
            int j = 0;
            #endregion

            #region 循环
            for (i = 1; i <= 5; i++ )
            {
                for (j = 1; j <= i; j++ )
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            #endregion

            Console.ReadLine();
        }
    }
}
