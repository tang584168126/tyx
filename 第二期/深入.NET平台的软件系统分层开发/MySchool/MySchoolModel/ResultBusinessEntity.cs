using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 成绩实体扩展类
    /// </summary>
    public class ResultBusinessEntity : ResultEntity
    {
        #region 字段
        //学员姓名
        private string stuName;

        //科目名称
        private string subName;
        #endregion

        #region 属性
        //学员姓名
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        //科目名称
        public string SubName
        {
            get { return subName; }
            set { subName = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
