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
    
    public partial class Message
    {
        public Message()
        {
            this.Users = new HashSet<User>();
        }
    
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; }
        public string Attachment { get; set; }
        public System.DateTime SentTime { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
