/*
 * 题目：两个乒乓球队进行比赛，各出三人。甲队为a,b,c三人，乙队为x,y,z三人。已抽签决定比赛名单。
 * 有人向队员打听比赛的名单。a说他不和x比，c说他不和x,z比，请编程序找出三队赛手的名单。
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] m = { 'a', 'b', 'c' };
            char[] n = { 'x', 'y', 'z' };
            for (int i = 0; i < m.Length; i++) 
            { 
			    for (int j = 0; j < n.Length; j++) 
                {
				    if (m[i] == 'a' && n[j] == 'x') 
                    {
					    continue;
				    } else if (m[i] == 'a' && n[j] == 'y') 
                    {
					    continue;
				    } else if ((m[i] == 'c' && n[j] == 'x')|| (m[i] == 'c' && n[j] == 'z')) 
                    {
					    continue;
				    } else if ((m[i] == 'b' && n[j] == 'z') || (m[i] == 'b' && n[j] == 'y')) 
                    {
					    continue;
				    } else
					    Console.WriteLine(m[i] + " vs " + n[j]);
			    }
		    }

            Console.ReadLine();
        }
    }
}
