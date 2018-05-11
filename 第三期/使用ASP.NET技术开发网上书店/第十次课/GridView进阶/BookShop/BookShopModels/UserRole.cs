using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    [Serializable]
    public class UserRole
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public enum UserRoles
    { 
        普通用户,
        VIP用户,
        管理员
    }
}