using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                intArray.SetItem(i, i * 5);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }
            Console.WriteLine();

            MyGenericArray<char> charArrat = new MyGenericArray<char>(5);
            for (int i = 0; i < 5; i++)
            {
                charArrat.SetItem(i, (char)(i + 65));
            }
            intArray.GenericMethod<string>("Hello World!");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(charArrat.GetItem(i) + " ");
            }
            Console.ReadLine();
        }

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

    }

    public class MyGenericArray<T> where T:struct
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }

        public void GenericMethod<x>(x c)
        {
            Console.WriteLine(c.ToString());
        }
    }

    //public class SubClass : MyGenericArray<int>
    //{
 
    //}

    //public class SubGenericArray<T> : MyGenericArray<T> where T : struct
    //{
 
    //}
}