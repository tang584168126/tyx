using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettleAccounts
{
    class Accounts
    {
        private double addFen = 0;      //增加积分
        private double xianFen = 0;     //总共积分

        public double AddFen
        {
            get {return addFen ;}
            set { addFen = value; }
        }

        public double XianFen
        {
            get { return xianFen; }
            set { xianFen = value; }
        }

        public void Update (ref double jiFen , ref double money)
        {
            addFen = money / 10;
            xianFen = jiFen + addFen;
        }
    }
}
