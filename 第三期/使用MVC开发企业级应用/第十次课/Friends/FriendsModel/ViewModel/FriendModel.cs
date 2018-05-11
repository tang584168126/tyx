using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Model
{
    public class FriendModel
    {
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
    }
}
