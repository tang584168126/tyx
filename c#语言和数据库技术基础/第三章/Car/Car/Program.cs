using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Car
    {
        private string color;       //颜色
        private string name;        //车名
        private string productPlace;    //产地

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductPlace
        {
            get { return productPlace; }
            set { productPlace = value; }
        }

        public void Run()
        {
            Console.WriteLine("我是一辆{0}车，{1}颜色，产地是{2}", name, color, productPlace);
        }
    }
}
