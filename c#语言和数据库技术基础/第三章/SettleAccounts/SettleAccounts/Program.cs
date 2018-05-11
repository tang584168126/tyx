using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettleAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            double fen = 0;     //原有积分
            double price = 0;   //购物金额

            Console.Write("原有积分为：");
            fen = double.Parse(Console.ReadLine());
            Console.Write("购物金额为：");
            price = double.Parse(Console.ReadLine());

            Accounts accounts = new Accounts();
            accounts.Update(ref fen, ref price);
            Console.WriteLine("增加积分：" + accounts.AddFen);
            Console.WriteLine("当前积分：" + accounts.XianFen);

            Console.ReadLine();
        }
    }
}
