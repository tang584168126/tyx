using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnRenting.Models
{
    public class Street
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public District District { get; set; }
    }
}
