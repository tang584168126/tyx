//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Friends.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mind
    {
        public int MindId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public byte MindType { get; set; }
        public System.DateTime CreatedTime { get; set; }
    
        public virtual User User { get; set; }
    }
}
