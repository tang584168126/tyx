using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWeb
{
    [Serializable]
    public class User
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Gender { get; set; }

        public string PostId { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }
    }
}