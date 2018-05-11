using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 定义数组
            int[] number = new int[] { 1, 2, 3, 4, 5 };
            #endregion

            #region 使用foreach遍历
            foreach(int temp in number)
            {
                if(temp ==3)
                {
                    continue;
                }
                if(temp == 5)
                {
                    break;
                }
                Console.Write("{0}\t",temp);
            }
            #endregion

            Console.ReadLine();
        }

    }
}
