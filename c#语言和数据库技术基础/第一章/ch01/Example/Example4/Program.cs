using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    /// <summary>
    /// switch选择结构
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 设置变量
            //银行简称
            string strBankShotName = string.Empty;

            //银行全称
            string strBankFullName = string.Empty;
            #endregion

            #region 银行简称与全称的对比
            Console.Write("请输入银行简称:");
            strBankShotName = Console.ReadLine();

            switch (strBankShotName)
            {
                case "ICBC":
                    strBankFullName = "中国工商银行";
                    break;
                case "CBC":
                    strBankFullName = "中国建设银行";
                    break;
                case "ABC":
                    strBankFullName = "中国农业银行";
                    break;
                default:
                    break;
            }
            #endregion

            #region 输出结果
            if (!string.IsNullOrEmpty(strBankFullName))
            {
                Console.WriteLine("银行全称是:" + strBankFullName);
            }
            else
            {
                Console.WriteLine("请输入正确的银行简称!");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
