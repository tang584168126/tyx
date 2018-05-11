using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Friends.Models;
using Friends.Web.Helpers;
namespace Friends.Controllers
{
    [Authorize]
    public class FriendController : Controller
    {
        FriendsEntities context = new FriendsEntities();      

        public ActionResult Index(int? groupId)
        {
            return View();
        }

        #region "好友管理"
        /// <summary>
        /// 获取某个分组下的好友
        /// </summary>
        /// <param name="groupId">如果groupId=-1 表示未分组好友，groupId=null,表示获取全部好友</param>
        /// <returns></returns>
        public ActionResult ListFriends(int? groupId)
        {

            int userId = Convert.ToInt32(this.User.Identity.Name);
           
            //当前用户的分组
            var groups = context.PrivateGroups.Where(a => a.OwnerId == userId);

            IQueryable<FriendViewModel> friends = null;
            if (groupId!= -1)//获取全部好友或某个分组下的好友
            {
                friends = from item in context.FriendRelations.Where(p => (groupId.HasValue ? p.GroupId == groupId.Value : true)
                     && (p.UserId == userId))
                          select new FriendViewModel()
                          {
                              UserId = item.User.UserId,
                              RealName = item.User.RealName,
                              GroupId = item.GroupId,
                              HeaderImage=item.User.HeaderImage
                          };

            }
            else//获取未分组的好友
            {
                friends = from item in context.FriendRelations.Where(p => (!p.GroupId.HasValue)
                     && (p.UserId == userId))
                          select new FriendViewModel()
                          {
                              UserId = item.User.UserId,
                              RealName = item.User.RealName,
                              GroupId = item.GroupId,
                              HeaderImage=item.User.HeaderImage
                          };
            }

            IEnumerable<FriendViewModel> items = friends.ToList();
            foreach (FriendViewModel m in items)
            {
                m.Groups = new SelectList(groups, "GroupId", "GroupName", m.GroupId);
            }

            ViewBag.Friends = items;

            return PartialView("FriendList", items);

        }

        /// <summary>
        /// 获取指定数量的好友
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public ActionResult MyFriends(int? userId, int num)
        {
            
            //当前用户的分组
            var groups = context.PrivateGroups.Where(a => a.OwnerId == userId);

            IQueryable<FriendViewModel> friends = null;
            if (userId != null && num>0)//获取全部好友
            {
                friends = from item in context.FriendRelations.Where(p => (p.UserId == userId))
                          select new FriendViewModel()
                          {
                              UserId = item.User.UserId,
                              RealName = item.User.RealName,
                              HeaderImage=item.User.HeaderImage
                          };
                return PartialView("MyFriend", friends.Take(num));
            }
            return Content("");//返回空视图
        }

        /// <summary>
        /// 搜索好友
        /// </summary>
        /// <param name="RealName"></param>
        /// <param name="Gender"></param>
        /// <param name="City"></param>
        /// <param name="HomeCity"></param>
        /// <returns></returns>
        public ActionResult SearchFriend(string RealName, string Gender, string City, string HomeCity, int pageIndex = 1)
        {
            //获取当前用户
            int userId = Convert.ToInt32(this.User.Identity.Name);
            //定义组合条件表达式
            Expression<Func<User, bool>> predicate = p =>
                (string.IsNullOrEmpty(RealName) ? true : p.RealName.Contains(RealName))
                && (string.IsNullOrEmpty(Gender) ? true : p.Gender.Contains(Gender))
                && (string.IsNullOrEmpty(City) ? true : p.City.Contains(City))
                && (string.IsNullOrEmpty(HomeCity) ? true : p.HomeCity.Contains(HomeCity))
                && (p.UserId != userId);//不包含自己

            //获取好友
            var friends = from item in context.Users.Where(predicate).OrderBy(u=>u.UserId)
                          
                          select new FriendViewModel()
                              {
                                  UserId = item.UserId,
                                  RealName = item.RealName,
                                  IsFriend = item.FriendRelations.Where(r => r.UserId == userId).Count() > 0,//存在好友关系
                                  HeaderImage=item.HeaderImage
                              };


            PagedList<FriendViewModel> items = new PagedList<FriendViewModel>(friends, pageIndex, 5);

            return PartialView("FriendSearchResult", items);

        }

        /// <summary>
        /// 按用户名搜索当前用户的好友
        /// </summary>
        /// <param name="RealName"></param>
        /// <returns></returns>
        [ActionName("GetFriendsByName")]
        public ActionResult SearchFriend(string RealName)
        {
            int userId = Convert.ToInt32(this.User.Identity.Name);

            //当前用户的分组
            var groups = context.PrivateGroups.Where(a => a.OwnerId == userId);


            var friends = from item in context.FriendRelations.Where(p => (p.UserId == userId) && p.User.RealName.Contains(RealName))
                          select new FriendViewModel()
                          {
                              UserId = item.User.UserId,
                              RealName = item.User.RealName,
                              GroupId = item.GroupId,
                              HeaderImage=item.User.HeaderImage
                          };

            IEnumerable<FriendViewModel> items = friends.ToList();
            foreach (FriendViewModel m in items)
            {
                m.Groups = new SelectList(groups, "GroupId", "GroupName", m.GroupId);
            }

            ViewBag.Friends = items;

            return PartialView("FriendList", items);
        }

        /// <summary>
        /// 建立好友关系
        /// </summary>
        /// <param name="friendId"></param>
        /// <returns></returns>
        public ActionResult AddFriendRelation(int? friendId)
        {
            if (friendId.HasValue)
            {
                ViewBag.FriendId = friendId.Value;
                return PartialView("AddFriendRelation");
            }
            throw new Exception();
        }

        /// <summary>
        ///  创建好友关系
        /// </summary>
        /// <param name="message"></param>
        /// <param name="friendId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddFriendRelation(string message, int? friendId)
        {
            if (!string.IsNullOrEmpty(message) && friendId.HasValue)
            {
                int userId = Convert.ToInt32(this.User.Identity.Name);
                var relation = context.FriendRelations.SingleOrDefault(r => r.UserId == userId && r.FriendId == friendId.Value);
                if (relation == null)//关系不存在
                {
                    //一个关系两条数据,互相出现在对方的好友列表中
                    context.FriendRelations.Add(new FriendRelation() { UserId = userId, FriendId = friendId.Value });

                    context.FriendRelations.Add(new FriendRelation() { UserId = friendId.Value, FriendId = userId });
                }


                if (context.SaveChanges() > 0)
                {
                    return Content("1");//保存成功
                }
                else
                {
                    return Content("0");//保存失败
                }
            }
            else
            {
                return Content("");
            }
        }

        /// <summary>
        /// 解除好友关系
        /// </summary>
        /// <param name="friendId"></param>
        /// <returns></returns>
        public ActionResult RemoveFriendRelation(int? friendId)
        {
            int userId = Convert.ToInt32(this.User.Identity.Name);
            if (friendId.HasValue)
            {

                //一条关系对应的是2条数据
                var relation = context.FriendRelations.Where(r => (r.UserId == userId && r.FriendId == friendId.Value)
                    || (r.UserId == friendId.Value && r.FriendId == userId)
                    ).ToList();

                int count = relation.Count();

                if (count > 0)//关系存在
                {
                    //一次修改多行数据
                    for (int i = 0; i < count; i++)
                    {
                        context.FriendRelations.Remove(relation[i]);
                    }

                    if (context.SaveChanges() > 0)
                    {
                        return Content("1");//保存成功
                    }
                    else
                    {
                        return Content("0");//保存失败
                    }
                }
            }
            return Content("");

        }

        #endregion



    }
}
