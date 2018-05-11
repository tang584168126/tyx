using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsManagerSystem.Model;
using NewsManagerSystem.DAL;
using NewsManagerSystem.DAL.Server;

namespace NewsManagerSystem.BLL
{
    public class NewsInfoBLL
    {
        public bool IsInsert(NewsInfoEntity objNewsInfo)
        {
            NewsInfoServer nis = new NewsInfoServer();
            if (nis.IsInsert(objNewsInfo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
