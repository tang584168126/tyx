using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 课程实体类
    /// </summary>
    public class SubjectEntity
    {
        #region 字段
        //课程编号
        private int SubjectNo;

        //课程名
        private string SubjectName;

        //课时
        private int ClassHour;

        //年级编号
        private int GradeId;
        #endregion

        #region 属性
        public int SubjectNo1
        {
            get { return SubjectNo; }
            set { SubjectNo = value; }
        }

        public string SubjectName1
        {
            get { return SubjectName; }
            set { SubjectName = value; }
        }

        public int ClassHour1
        {
            get { return ClassHour; }
            set { ClassHour = value; }
        }

        public int GradeId1
        {
            get { return GradeId; }
            set { GradeId = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
