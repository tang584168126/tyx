using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        #region 字段
        //学号
        public string stuNO;

        //姓名
        public string stuName;
        #endregion

        #region 属性

        #endregion

        #region 方法
        public void SayHi()
        {
            Console.WriteLine("名称是:" + stuName);
        }
        #endregion
    }
}
