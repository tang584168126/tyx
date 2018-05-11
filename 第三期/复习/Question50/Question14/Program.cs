/*
 * 
 * 题目：输入某年某月某日，判断这一天是这一年的第几天？
 * */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            int year,month,day,sum=0;
		    Console.WriteLine("输入年：");
		    year=int.Parse(Console.ReadLine());
		    Console.WriteLine("输入月：");
		    month=int.Parse(Console.ReadLine());
		    Console.WriteLine("输入日：");
		    day=int.Parse(Console.ReadLine());
		
		    switch(month){
		    case 1:
			    sum=0;
			    break;
		    case 2:
			    sum=31;
			    break;
		    case 3:
			    sum=59;
			    break;
		    case 4:
			    sum=90;
			    break;
		    case 5:
			    sum=120;
			    break;
		    case 6:
			    sum=151;
			    break;
		    case 7:
			    sum=181;
			    break;
		    case 8:
			    sum=212;
			    break;
		    case 9:
			    sum=243;
			    break;
		    case 10:
			    sum=273;
			    break;
		    case 11:
			    sum=304;
			    break;
		    case 12:
			    sum=334;
			    break;
			default:
				Console.WriteLine("wrong input!");
				return;
		    }
		
		    sum=sum+day;
		    bool leap;
		    if(year%400==0||(year%4==0&&year%100==0)){
			    leap=true;
		    }else {
			    leap=false;
		    }
		    if(leap&&month>2){
			    sum++;
		    }
		
		    Console.WriteLine("It is the "+sum+"th day.");

            Console.ReadLine();
        }
    }
}
