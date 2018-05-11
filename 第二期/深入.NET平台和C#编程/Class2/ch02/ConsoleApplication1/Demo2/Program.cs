using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //张浩的身高和体重
            int[] infoZhang = new int[] { 170, 60 };

            //李明的身高和体重
            int[] infoLi = infoZhang;

            Console.WriteLine("去年—张浩的身高是{0}cm,体重是{1}kg;李明的身高是{2}cm,体重是{3}kg!", infoZhang[0], infoZhang[1], infoLi[0], infoLi[1]);

            infoLi[0] = 180;
            infoLi[1] = 70;

            Console.WriteLine("今年—张浩的身高是{0}cm,体重是{1}kg;李明的身高是{2}cm,体重是{3}kg!", infoZhang[0], infoZhang[1], infoLi[0], infoLi[1]);

            Console.ReadLine();
        }
    }
}
