using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnRenting.Models
{
    public class User
    {
        public int LoginId { get; set; }

        public string LoginName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Telephone { get; set; }
    }
}
