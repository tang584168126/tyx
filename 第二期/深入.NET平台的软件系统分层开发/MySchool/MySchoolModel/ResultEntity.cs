using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 成绩实体类
    /// </summary>
    public class ResultEntity
    {
        #region 字段
        //学号
        private int studentNo;

        //课程编号
        private int subjectNo;

        //考试时间
        private DateTime examDate;

        //成绩
        private decimal studentResult;
        #endregion

        #region 属性
        //学号
        public int StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
        }

        //课程编号
        public int SubjectNo
        {
            get { return subjectNo; }
            set { subjectNo = value; }
        }

        //考试时间
        public DateTime ExamDate
        {
            get { return examDate; }
            set { examDate = value; }
        }

        //成绩
        public decimal StudentResult
        {
            get { return studentResult; }
            set { studentResult = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
