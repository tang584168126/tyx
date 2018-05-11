using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class MyArrayList1
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="length">容器长度</param>
        public MyArrayList1(int length)
        {
            this.length = length;

            //初始化容器
            strList = new string[length];
        }

        #region 字段
        //容器
        private string[] strList;

        //容器长度
        private int length;

        //容器索引
        private int index;

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="strValue">元素</param>
        public void Add(string strValue)
        {
            //判断是否添满
            if (this.length == this.index)
            {
                Console.WriteLine("无法添加!");
            }
            else
            {
                strList[index] = strValue;

                //索引加1
                index++;
            }
        }

        /// <summary>
        /// 显示元素
        /// </summary>
        /// <returns>元素</returns>
        public string Show()
        {
            if (this.index == 0)
            {
                Console.WriteLine("没有元素!");

                return null;
            }
            else
            {
                //索引减1
                index--;

                return strList[index];
            }
        }
        #endregion
    }
}
