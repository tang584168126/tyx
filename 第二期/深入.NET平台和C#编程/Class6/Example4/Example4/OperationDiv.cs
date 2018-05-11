using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class OperationDiv:Operation
    {
        
        #region 方法
        public override double GetResult(ref string num)
        {
            if (NumberB1 == 0)
            {
                num = "除数不能为0！";
            }
            double result = NumberA1 / NumberB1;

            return result;
        }
        #endregion
    }
}
