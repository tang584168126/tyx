using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Friends.Model;

namespace Friends.Controllers
{
    public class HomeController : Controller
    {
        FriendsEntities entities = new FriendsEntities();
        //个人主页
        public ActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                User user = Session["CurrentUser"] as User;
                //获取最近访问的3个用户
                var visitors = (from v in entities.Visits
                                where v.UserID == user.UserId
                                orderby v.LastVisitTime descending
                                select new VisitorModel()
                                {
                                    UserId = v.User1.UserId,
                                    RealName = v.User1.RealName,
                                    HeaderImage = v.User1.HeaderImage,
                                    LastVisitTime = v.LastVisitTime
                                }).Take(3).ToList();
                ViewBag.Visitors = visitors;
            }
            return View();
        }

        //公共主页
        public ActionResult Common()
        {
            return View();
        }

        public ActionResult AddRecord(string note)
        {
            if (!string.IsNullOrEmpty(note))
            {
                Record record = new Record();
                record.Content = note;
                record.CreatedTime = DateTime.Now;
                record.UserId = ((User)Session["CurrentUser"]).UserId;

                entities.Records.Add(record);

                if (entities.SaveChanges() > 0)
                {
                    if(Request.IsAjaxRequest())
                    {
                        return Content("保存成功！");
                    }
                    else
                    {
                        return Content("<script type='text/javascript'>alert('保存成功！')</script>");
                    }
                }
                else
                {
                    return Content("保存失败！");
                }
            }
            else
            {
                return Content("评论不可为空！");
            }
        }

    }
}
