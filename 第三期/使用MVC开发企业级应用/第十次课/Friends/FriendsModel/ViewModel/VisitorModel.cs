using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Model
{
    public class VisitorModel
    {
        public int UserId { get; set; }
        public string RealName { get; set; }
        public string HeaderImage { get; set; }
        public DateTime LastVisitTime { get; set; }
    }
}
