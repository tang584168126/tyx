using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        #region 字段
        //姓名
        private string name;

        //年龄
        private int age;
        #endregion

        #region 属性
        //姓名
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //年龄
        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0 || value >= 30)
                {
                    age = 18;
                }
                else
                {
                    age = value; 
                }
            }
        }
        #endregion

        #region 方法

        #endregion
    }
}
