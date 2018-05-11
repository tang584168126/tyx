using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 科目实体类
    /// </summary>
    public class SubjectEntity
    {
        #region 字段
        //课程编号
        private int subjectNo;

        //课程名称
        private string subjectName;

        //课时
        private int classHour;

        //年级编号
        private int gradeId;
        #endregion

        #region 属性
        //课程编号
        public int SubjectNo
        {
            get { return subjectNo; }
            set { subjectNo = value; }
        }

        //课程名称
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        //课时
        public int ClassHour
        {
            get { return classHour; }
            set { classHour = value; }
        }

        //年级编号
        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
