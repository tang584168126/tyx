using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Math
    {
        public int Sum(int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            else 
            {
                return Sum(x - 1) + Sum(x - 2);
            }
        }
    }
}
