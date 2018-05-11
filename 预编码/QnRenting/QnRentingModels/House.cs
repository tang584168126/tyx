using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnRenting.Models
{
    public class House
    {
        public int HouseId { get; set; }

        public string Title { get; set; }

        public HouseType HouseType { get; set; }

        public decimal Floorage { get; set; }

        public decimal Price { get; set; }

        public int StreetId { get; set; }

        public string Contract { get; set; }

        public string Description { get; set; }

        public User User { get; set; }

        public DateTime PublishTime { get; set; }
    }
}
