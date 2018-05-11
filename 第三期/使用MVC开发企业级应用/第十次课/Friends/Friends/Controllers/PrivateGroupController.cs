using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Friends.Model;

namespace Friends.Controllers
{
    //针对操作朋友CROD的操作   Create、Retrive、Update、Delete
    public class PrivateGroupController : Controller
    {
        FriendsEntities entities = new FriendsEntities();
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 当前用户的好友分组列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GroupList()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                int userId = Convert.ToInt32(this.User.Identity.Name);
                //User user = Session["CurrentUser"] as User;
                //好友总数
                var totalCount = (entities.FriendRelations.Where(f => f.UserId == userId)).Count();
                //未分组好友数
                var unGroupCount = (from u in entities.FriendRelations
                                    where u.UserId == userId && u.GroupId.HasValue == false
                                    select u).Count();
                //好友分组列表
                var groupList = (entities.PrivateGroups.Where(g => g.OwnerId == userId)).ToList();

                ViewBag.TotalCount = totalCount;
                ViewBag.UnGroupCount = unGroupCount;
                ViewBag.GroupList = groupList;                
            }

            return PartialView("GroupList");
        }

    }
}
