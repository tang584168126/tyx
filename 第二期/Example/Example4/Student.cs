using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public enum Sex
    {
        男,女
    }

    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        #region 字段
        //学号
        private string stuNO;

        //姓名
        private string stuName;

        //性别
        private Sex stuSex;

        //年龄
        private int stuAge;

        //地址
        private string stuAddress;
        #endregion

        #region 属性
        //学号
        public string StuNO
        {
            get { return stuNO; }
            set { stuNO = value; }
        }

        //姓名
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        //性别
        public Sex StuSex
        {
            get { return stuSex; }
            set { stuSex = value; }
        }

        //年龄
        public int StuAge
        {
            get { return stuAge; }
            set { stuAge = value; }
        }

        //地址
        public string StuAddress
        {
            get { return stuAddress; }
            set { stuAddress = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
