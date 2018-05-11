using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSet.Models;
using BookSet.DAL;

namespace BookSet.BLL
{
    /// <summary>
    /// 消息管理
    /// </summary>
public  class GetMangaer
    {
    /// <summary>
    /// 获取消息列表
    /// </summary>
    /// <param name="pageSize">表的长度</param>
    /// <param name="pageIndex">表的下表</param>
    /// <returns></returns>
    public IList<Managers> GetUserManger(int pageSize,int pageIndex )
    {
        return new Manager().GetManger(pageSize, pageIndex);
    }

    }
}
