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
        //姓名
        private string name;

        //年龄
        private int age;
        #endregion

        #region 属性
        
        #endregion

        #region 方法
        /// <summary>
        /// 获取姓名
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// 设置名字
        /// </summary>
        /// <param name="name">姓名</param>
        public void SetName(string name)
        {
            this.name = name;
        }
        #endregion
    }
}
