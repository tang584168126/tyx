//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FocusAcademy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EBookInfo
    {
        public EBookInfo()
        {
            this.BookBasicInfoes = new HashSet<BookBasicInfo>();
            this.ChapterUrls = new HashSet<ChapterUrl>();
            this.EAuthors = new HashSet<EAuthor>();
            this.EProfits = new HashSet<EProfit>();
            this.PlayManages = new HashSet<PlayManage>();
            this.UserComments = new HashSet<UserComment>();
            this.UserHouses = new HashSet<UserHouse>();
            this.UserScores = new HashSet<UserScore>();
        }
    
        public int EBookId { get; set; }
        public int AuthorId { get; set; }
        public int Price { get; set; }
        public decimal Count { get; set; }
        public System.DateTime UpDateTime { get; set; }
        public string State { get; set; }
        public bool IsFree { get; set; }
        public int CollectionCount { get; set; }
        public int BasicId { get; set; }
        public Nullable<int> Ticket { get; set; }
    
        public virtual ICollection<BookBasicInfo> BookBasicInfoes { get; set; }
        public virtual BookBasicInfo BookBasicInfo { get; set; }
        public virtual ICollection<ChapterUrl> ChapterUrls { get; set; }
        public virtual ICollection<EAuthor> EAuthors { get; set; }
        public virtual UsersInfo UsersInfo { get; set; }
        public virtual ICollection<EProfit> EProfits { get; set; }
        public virtual ICollection<PlayManage> PlayManages { get; set; }
        public virtual ICollection<UserComment> UserComments { get; set; }
        public virtual ICollection<UserHouse> UserHouses { get; set; }
        public virtual ICollection<UserScore> UserScores { get; set; }
    }
}
