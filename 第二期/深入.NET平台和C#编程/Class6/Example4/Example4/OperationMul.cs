using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class OperationMul:Operation
    {
        
        #region 方法
        public override double GetResult(ref string num)
        {
            double result = NumberA1 * NumberB1;

            return result;
        }
        #endregion
    }
}
