/*
 * 题目：输入三个整数x,y,z，请把这三个数由小到大输出。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入三个整数:");
		    int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int m = 0; m < arr.Length; m++)
            {
                for (int n = 0; n < arr.Length - m - 1; n++)
                {
                    if (arr[n + 1] < arr[n])
                    {
                        int temp = 0;
                        temp = arr[n + 1];
                        arr[n + 1] = arr[n];
                        arr[n] = temp;
                    }
                }
            }
            Console.WriteLine("把这三个数由小到大输出:");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }

            Console.ReadLine();
        }
    }
}
