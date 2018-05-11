using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 年级实体类
    /// </summary>
    public class GradeEntity
    {
        #region 字段
        //年级编号
        private int gradeId;

        //年级名称
        private string gradeName;
        #endregion

        #region 属性
        //年级编号
        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value; }
        }

        //年级名称
        public string GradeName
        {
            get { return gradeName; }
            set { gradeName = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
