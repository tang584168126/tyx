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
    
    public partial class User
    {
        public User()
        {
            this.Answers = new HashSet<Answer>();
            this.CommentReplies = new HashSet<CommentReply>();
            this.FriendRelations = new HashSet<FriendRelation>();
            this.FriendRelations1 = new HashSet<FriendRelation>();
            this.Groups = new HashSet<Group>();
            this.GroupFriends = new HashSet<GroupFriend>();
            this.Invitations = new HashSet<Invitation>();
            this.Invitations1 = new HashSet<Invitation>();
            this.Messages = new HashSet<Message>();
            this.Minds = new HashSet<Mind>();
            this.PrivateGroups = new HashSet<PrivateGroup>();
            this.Questions = new HashSet<Question>();
            this.Records = new HashSet<Record>();
            this.Visits = new HashSet<Visit>();
            this.Visits1 = new HashSet<Visit>();
            this.Messages1 = new HashSet<Message>();
        }
    
        public int UserId { get; set; }
        public string Mail { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public System.DateTime Birthday { get; set; }
        public string City { get; set; }
        public string HomeCity { get; set; }
        public string Situation { get; set; }
        public string HeaderImage { get; set; }
        public string BloodStyle { get; set; }
        public System.DateTime RegisterTime { get; set; }
        public Nullable<byte> GenderPrivate { get; set; }
        public Nullable<byte> BirthdayPrivate { get; set; }
        public Nullable<byte> CityPrivate { get; set; }
        public Nullable<byte> HomeCityPrivate { get; set; }
        public Nullable<byte> SituationPrivate { get; set; }
        public Nullable<byte> BloodStylePrivate { get; set; }
        public int InitialPrize { get; set; }
    
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<CommentReply> CommentReplies { get; set; }
        public virtual ICollection<FriendRelation> FriendRelations { get; set; }
        public virtual ICollection<FriendRelation> FriendRelations1 { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<GroupFriend> GroupFriends { get; set; }
        public virtual ICollection<Invitation> Invitations { get; set; }
        public virtual ICollection<Invitation> Invitations1 { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Mind> Minds { get; set; }
        public virtual ICollection<PrivateGroup> PrivateGroups { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<Visit> Visits1 { get; set; }
        public virtual ICollection<Message> Messages1 { get; set; }
    }
}
