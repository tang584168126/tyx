using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 结果实体类
    /// </summary>
    public class ResultEntity
    {
        #region 字段
        //学号
        private int StudentNo;

        //课程编号
        private int SubjectNo;

        //考试时间
        private DateTime ExamDate;

        //考试结果
        private decimal StudentResult;
        #endregion

        #region 属性
        public int StudentNo1
        {
            get { return StudentNo; }
            set { StudentNo = value; }
        }

        public int SubjectNo1
        {
            get { return SubjectNo; }
            set { SubjectNo = value; }
        }

        public DateTime ExamDate1
        {
            get { return ExamDate; }
            set { ExamDate = value; }
        }

        public decimal StudentResult1
        {
            get { return StudentResult; }
            set { StudentResult = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
