using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageBoard.Models;
using MessageBoard.DAL;

namespace MessageBoard.BLL
{
    public class MessageManager
    {
        AdminService as = new AdminService();
        public bool AdminLogin(string adminName, string password)
        {
            
            return as.AdminLogin(adminName, password);
        }
    }
}
