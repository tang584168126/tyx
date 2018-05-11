using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    /// <summary>
    /// 泛型类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 栈结构模拟1
            //MyArrayList1 objArrList1 = new MyArrayList1(10);

            //objArrList1.Add("Test1");
            //objArrList1.Add("Test2");
            //objArrList1.Add("Test3");

            //Console.WriteLine(objArrList1.Show());
            //Console.WriteLine(objArrList1.Show());
            //Console.WriteLine(objArrList1.Show());

            //objArrList1.Add("1111");
            //objArrList1.Add("2222");
            //objArrList1.Add("3333");

            //Console.WriteLine(objArrList1.Show());
            //Console.WriteLine(objArrList1.Show());
            //Console.WriteLine(objArrList1.Show());
            #endregion

            #region 栈结构模拟2
            MyArrayList2<int> objArrList2 = new MyArrayList2<int>(10);

            objArrList2.Add(1);
            objArrList2.Add(2);
            objArrList2.Add(3);

            Console.WriteLine(objArrList2.Show());
            Console.WriteLine(objArrList2.Show());
            Console.WriteLine(objArrList2.Show());

            objArrList2.Add(1000);
            objArrList2.Add(2000);
            objArrList2.Add(3000);

            Console.WriteLine(objArrList2.Show());
            Console.WriteLine(objArrList2.Show());
            Console.WriteLine(objArrList2.Show());
            #endregion

            Console.ReadLine();
        }
    }
}
