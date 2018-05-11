using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text3
{
    class Text4_1
    {
        #region 字段
        private string id;      //输入的字符串
        public int index;       //最后一个#的值
        private string cellphone;       //手机号码      
        private bool isok;      //是否成功
        private int num;        //数字键
        #endregion

        #region 属性
        public string Id 
        {
            set { id = value; }
        }
        public string Cellphone
        {
            get { return cellphone; }
        }
        public bool Isok
        {
            get { return isok; }
        }
        public int Num
        {
            set { num = value; }
        }
        #endregion

        #region 方法
        public bool AddMoney()
        {
            Console.WriteLine("请输入：卡号#密码#手机号码");
            id = Console.ReadLine();
            index = id.LastIndexOf("#");
            cellphone = id.Substring(index + 1 , 11);
            Console.WriteLine("手机号码为：" + cellphone);
            Console.WriteLine("充值请按1，按其他键表示放弃");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                isok = true;
            }
            else 
            {
                isok = false;
            }
            return isok;
        }
        #endregion

        
    }
}
