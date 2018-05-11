using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageBoard.Models;
using MessageBoard.DAL;

namespace MessageBoard.BLL
{
    public class AdminManager
    {
        MessageInfoService mis = new MessageInfoService();
        public bool AddMessage(MessageInfo pMessage)
        {
            pMessage.PostTime = DateTime.Now;

            return mis.AddMessage(pMessage);
        }

        public IList<MessageInfo> ListByPage(int currentPageIndex, int pageSize)
        {
            return mis.ListByPage(currentPageIndex, pageSize);
        }

        public IList<MessageInfo> ListByPage(int currentPageIndex, int pageSize, bool IsHide)
        {
            return mis.ListByPage(currentPageIndex, pageSize, IsHide);
        }

        public bool DeleteMessage(int id)
        {
            return mis.DeleteMessage(id);
        }
    }
}
