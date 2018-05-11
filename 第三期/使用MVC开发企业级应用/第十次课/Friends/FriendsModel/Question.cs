//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Friends.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Prize { get; set; }
        public int CreateUserId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int VisitCount { get; set; }
        public byte State { get; set; }
    
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
