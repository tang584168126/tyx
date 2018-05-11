using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class Math
    {
        public bool Number(int num)
        {
            int a , b , c ;
            a = num / 100;
            b = (num % 100) / 10;
            c = num % 10;
            if (num == (a * a * a + b * b * b + c * c * c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
