using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明变量
            double[] price = new double[7];     //一种配件价格
            string[] shops = new string[7] {"CPU","内存","硬盘","显卡","光驱","主机","显示器" };     //电脑配件
            int i = 0 , j = 0, k = 0;      //循环变量
            double temp = 0;      //临时变量
            double max = 0, min = 0;        //最高总价，最低总价
            #endregion

            #region 输入价格
            for (i = 0; i < shops.Length; i++ )
            {
                Console.WriteLine("{0}的价格：",shops[i]);
                for (j = 0; j < price.Length; j++ )
                {
                    price[j] = double.Parse(Console.ReadLine());
                }
            }

            #endregion

            #region 计算总价
            //排序
            for (i = 0; i < shops.Length; i++)
            {
                for (j = 0; j < price.Length - 1; j++)
                {
                    for (k = 0; k < price.Length - 1 - j; k++)
                    {
                        if(price[k] > price[k + 1])
                        {
                            temp = price[k];
                            price[k] = price[k + 1];
                            price[k + 1] = temp;
                        }
                    }
                }
            }
            //排序后
            for (i = 0; i < shops.Length; i++)
            {
                max += price[6];
                min += price[0];
            }
            Console.WriteLine("最高总价{0}，最低总价{1}",max,min);
            #endregion

            Console.ReadLine();
        }
    }
}
