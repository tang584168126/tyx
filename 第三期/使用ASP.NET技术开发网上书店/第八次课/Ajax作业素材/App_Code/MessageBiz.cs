using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

/// <summary>
///MessageBiz 的摘要说明
/// </summary>
public class MessageBiz
{
    public MessageBiz()
    {

    }

    public bool AddMessage(MessageInfo pMessage)
    {
        pMessage.PostTime = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
        MessageDAO dao = new MessageDAO();
        return dao.AddMessage(pMessage);
    }

    public IList<MessageInfo> ListByPage(int currentPageIndex, int pageSize)
    {
        MessageDAO dao = new MessageDAO();
        return dao.ListByPage(currentPageIndex, pageSize);
    }

    public IList<MessageInfo> ListByPage(int currentPageIndex, int pageSize, bool IsHide)
    {
        MessageDAO dao = new MessageDAO();
        return dao.ListByPage(currentPageIndex, pageSize, IsHide);
    }

    public bool AdminLogin(string adminName, string password)
    {
        MessageDAO dao = new MessageDAO();
        return dao.AdminLogin(adminName, password);
    }

    public bool DeleteMessage(int id)
    {
        MessageDAO dao = new MessageDAO();
        return dao.DeleteMessage(id);
    }


}
