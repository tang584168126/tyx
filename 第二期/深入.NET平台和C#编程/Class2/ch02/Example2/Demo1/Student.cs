using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    /// <summary>
    /// 学生结构
    /// </summary>
    public struct Student
    {
        #region 字段
        //id
        public string id;

        //年龄
        public int age;
        #endregion

        #region 属性
        
        #endregion

        #region 方法
        public void showStu()
        {
            Console.WriteLine("ID是:" + id);
            Console.WriteLine("年龄是:" + age);
        }
        #endregion
    }
}
