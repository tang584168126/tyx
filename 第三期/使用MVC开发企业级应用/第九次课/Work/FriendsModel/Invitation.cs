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
    
    public partial class Invitation
    {
        public long InvitationId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Recipient { get; set; }
        public System.DateTime DateSent { get; set; }
        public byte Status { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
