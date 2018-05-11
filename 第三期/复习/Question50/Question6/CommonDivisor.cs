using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class CommonDivisor
    {
        public int GetResult(int x,int y)
        {
            if(x < y)
            {
                int t = x;
                x = y;
                y = t;
            }
            while(y!=0)
            {
                if (x == y)
                {
                    return x;
                }
                else 
                {
                    int k = x % y;
                    x = y;
                    y = k;
                }
            }
            return x;
        }
    }
}
