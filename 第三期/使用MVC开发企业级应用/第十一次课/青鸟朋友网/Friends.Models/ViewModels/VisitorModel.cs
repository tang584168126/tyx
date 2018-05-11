using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class VisitorModel
    {
        public int VisitorID { get; set; }

        public DateTime LastVisitTime { get; set; }

        public string RealName { get; set; }

        public string HeaderImage { get; set; }

    }
}
