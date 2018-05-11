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
        private int GradeId;
    
        //年级名
        private string GradeName;

        #endregion

        #region 属性
        public int GradeId1
        {
            get { return GradeId; }
            set { GradeId = value; }
        }

        public string GradeName1
        {
            get { return GradeName; }
            set { GradeName = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
