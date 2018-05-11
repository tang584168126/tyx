using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    /// <summary>
    /// for和foreach选择结构
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 设置变量
            //数组一
            int[] numList1 = new int[5] { 1, 2, 3, 4, 5 };

            //数组二
            int[] numList2 = new int[5] { 1, 2, 3, 4, 5 };
            #endregion

            #region 使用for循环读取数组值
            Console.WriteLine("数组的元素有(使用for循环读取):");
            for (int i = 0; i < numList1.Length; i++)
            {
                Console.Write(numList1[i] + "\t");
            }
            #endregion

            //换行
            Console.WriteLine();
            Console.WriteLine();

            #region 使用foreach循环读取数组值
            Console.WriteLine("数组的元素有(使用foreach循环读取):");
            foreach (int temp in numList2)
            {
                Console.Write(temp + "\t");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
