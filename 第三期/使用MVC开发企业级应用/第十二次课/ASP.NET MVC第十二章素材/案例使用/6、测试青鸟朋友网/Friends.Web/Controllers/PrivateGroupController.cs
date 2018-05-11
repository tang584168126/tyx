using Friends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends.Web.Controllers
{
    [Authorize]
    public class PrivateGroupController : Controller
    {
        FriendsEntities context = new FriendsEntities();

        #region "好友分组管理"
        /// <summary>
        /// 修改好友分组
        /// </summary>
        /// <param name="friendId"></param>
        /// <returns></returns>
        public ActionResult ChangeGroup(int? friendId, int? newGroupId)
        {
            if (friendId.HasValue && newGroupId.HasValue)
            {
                int userId = Convert.ToInt32(this.User.Identity.Name);
                var relation = context.FriendRelations.SingleOrDefault(r => r.UserId == userId && r.FriendId == friendId.Value);
                if (relation != null)//关系不存在
                {
                    relation.GroupId = newGroupId;

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

        /// <summary>
        /// 删除好友分组数据
        /// </summary>
        /// <param name="id">分组编号</param>
        /// <returns>1-操作成功，0-操作失败</returns>
        [HttpPost]
        public ActionResult DeleteGroup(int? id)
        {
            if (id.HasValue)
            {
                //将关联的该分组下的朋友设置为未分组
                var relations = context.FriendRelations.Where(f => f.GroupId == id);
                foreach (var item in relations)
                {
                    item.GroupId = null;
                }
                //删除分组数据
                var removedItem = context.PrivateGroups.SingleOrDefault(g => g.GroupId == id.Value);
                context.PrivateGroups.Remove(removedItem);

                if (context.SaveChanges() > 0)
                {
                    return Content("1");//操作成功
                }
            }
            return Content("0");
        }

        public ActionResult EditGroup(int? id)
        {
            PrivateGroup group = null;
            if (id.HasValue)
            {
                group = context.PrivateGroups.SingleOrDefault(g => g.GroupId == id.Value);
                ViewBag.GroupId = group.GroupId;
                ViewBag.GroupName = group.GroupName;
                return PartialView("GroupEdit");
            }
            return PartialView("GroupEdit");
        }


        [HttpPost]
        public ActionResult EditGroup(string groupName, int? groupId)
        {

            if (!string.IsNullOrEmpty(groupName))
            {
                PrivateGroup group = null;
                if (groupId.HasValue)//修改
                {
                    group = context.PrivateGroups.SingleOrDefault(g => g.GroupId == groupId.Value);
                    group.GroupName = groupName;//新的名称

                }
                else//添加
                {
                    group = new PrivateGroup();
                    group.GroupName = groupName;
                    group.OwnerId = Convert.ToInt32(this.User.Identity.Name);
                    context.PrivateGroups.Add(group);

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
        /// 获取当前用户的所有分组信息
        /// </summary>
        /// <returns>分组信息列表</returns>
        public ActionResult ListGroups()
        {

            int userId = Convert.ToInt32(this.User.Identity.Name);
            //分组列表数据
            var groups = context.PrivateGroups.Where(a => a.OwnerId == userId).ToList();
            //未分组好友个数
            var unGroupCount = context.FriendRelations.Where(a => a.UserId == userId && a.GroupId.HasValue == false).Count();
            //好友总数
            var totalCount = context.FriendRelations.Where(a => a.UserId == userId).Count();

            ViewBag.Groups = groups;
            ViewBag.UnGroupCount = unGroupCount;
            ViewBag.TotalCount = totalCount;
            //返回分部视图
            return PartialView("GroupList");
        }


        /// <summary>
        /// 获取当前用户的所有分组信息
        /// </summary>
        /// <returns>分组信息列表</returns>
        public ActionResult ListGroupsToJson()
        {
            //context.Configuration.ProxyCreationEnabled = false;
         

            int userId = Convert.ToInt32(this.User.Identity.Name);
            //分组列表数据
            var groups = (from g in context.PrivateGroups 
                          where g.OwnerId == userId 
                          select g
                          ).ToList();
            return Json(groups,JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}
