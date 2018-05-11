using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Friends.Model;

namespace Friends.Controllers
{
    //针对朋友的CROD操作   Create、Retrive、Update、Delete
    public class FriendController : Controller
    {
        FriendsEntities entities = new FriendsEntities();
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取指定用户的指定数量的朋友列表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public ActionResult MyFriends(int? userId,int num)
        {
            //获取朋友列表
            var friends = from u in entities.FriendRelations
                          where u.UserId == userId
                          select new FriendModel()
                          {
                              UserId = u.User.UserId,
                              RealName = u.User.RealName,
                              HeaderImage = u.User.HeaderImage
                          };
            return PartialView("MyFriends", friends.Take(num).ToList());
        }

        /// <summary>
        /// 获取当前用户某个分组下的好友
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public ActionResult FriendList(int? groupId)
        {
            User user = Session["CurrentUser"] as User;
            IQueryable<FriendModel> friends = null;
            //获取所有的好友
            if(groupId == null)
            {
                friends = from f in entities.FriendRelations
                          where f.UserId == user.UserId
                          select new FriendModel()
                          {
                              UserId = f.User.UserId,
                              HeaderImage = f.User.HeaderImage,
                              RealName = f.User.RealName
                          };
            }
            //获取某个分组下好友
            else
            {
                friends = from f in entities.FriendRelations
                          where f.UserId == user.UserId && f.GroupId == groupId
                          select new FriendModel()
                          {
                              UserId = f.User.UserId,
                              HeaderImage = f.User.HeaderImage,
                              RealName = f.User.RealName
                          };
            }


            return PartialView("FriendList",friends.ToList());
        }

    }
}
