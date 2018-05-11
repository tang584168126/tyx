using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Operation
    {
        #region 字段
        private double NumberA;

        private double NumberB;
        #endregion

        #region 属性
        public double NumberA1
        {
            get { return NumberA; }
            set { NumberA = value; }
        }

        public double NumberB1
        {
            get { return NumberB; }
            set { NumberB = value; }
        }

        #endregion

        #region 方法
        public virtual double GetResult(ref string num)
        {
            double result = 0;

            return result;
        }
        #endregion
    }
}
