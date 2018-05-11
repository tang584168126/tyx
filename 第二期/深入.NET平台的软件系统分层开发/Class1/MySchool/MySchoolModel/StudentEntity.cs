using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolModel
{
    /// <summary>
    /// 学生实体类
    /// </summary>
    public class StudentEntity
    {
        #region 字段
        //学号
        private int studentNo;

        //密码
        private string loginPwd;

        //姓名
        private string studentName;

        //性别
        private bool sex;

        //年级
        private int gradeId;

        //电话
        private string phone;

        //生日
        private DateTime bornDate;

        //地址
        private string adress;

        //Email
        private string email;

        //身份证
        private string indentityCard;
        #endregion

        #region 属性
        public int StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
        }

        public string LoginPwd
        {
            get { return loginPwd; }
            set { loginPwd = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime BornDate
        {
            get { return bornDate; }
            set { bornDate = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string IndentityCard
        {
            get { return indentityCard; }
            set { indentityCard = value; }
        }
        #endregion

        #region 方法

        #endregion
    

}
}
