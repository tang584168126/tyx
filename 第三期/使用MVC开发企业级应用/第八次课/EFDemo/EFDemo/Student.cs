//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Results = new HashSet<Result>();
        }
    
        public int StudentNo { get; set; }
        public string LoginPwd { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public int GradeId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Email { get; set; }
    
        public virtual Grade Grade { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
