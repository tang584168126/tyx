using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_TreeViewByRecursion.App_Code
{
    public class SysFunction
    {
        public long NodeId { get; set; }

        public string DisplayName { get; set; }

        public string NavigateURL { get; set; }

        public int DisplayOrder { get; set; }

        public long ParentNodeId { get; set; }
    }
}