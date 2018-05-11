using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Count
    {
        int digital = 0, character = 0, blank = 0, other = 0;
        public void GetCount(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= '0' && arr[i] <= '9')
                {
                    digital++;
                }
                else if ((arr[i] >= 'a' && arr[i] <= 'z') || (arr[i] >= 'A' && arr[i] <= 'Z'))
                {
                    character++;
                }
                else if (arr[i] == ' ')
                {
                    blank++;
                }
                else
                {
                    other++;
                }
            }
            Console.WriteLine("数字个数：" + digital);
            Console.WriteLine("英文字母个数：" + character);
            Console.WriteLine("空格个数：" + blank);
            Console.WriteLine("其他字符个数：" + other);
        }
    }
}
