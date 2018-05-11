using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Friends.Models;
using Friends.Web.Filters;

namespace Friends.Controllers
{
   
    [Authorize]
    [HandleError(View = "Error")]
    [LogExceptionFilter]
    public class HomeController : Controller
    {
        FriendsEntities context = new FriendsEntities();
        //
        // GET: /Home/

        /// <summary>
        /// 访问个人首页
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration=10)]
        public ActionResult Index()
        {
            //模拟错误
           // int i = int.Parse("asdfas");

            int uid = Convert.ToInt32(this.User.Identity.Name);//当前用户登录
            ViewBag.Visitors = (from v in context.Visits
                                where v.UserID == uid
                                orderby v.LastVisitTime descending
                                select new VisitorModel()
                                {
                                    VisitorID = v.VisitorID,
                                    LastVisitTime = v.LastVisitTime,
                                    RealName = v.User1.RealName, //User1 为VisitorId 对应的外键实体
                                    HeaderImage=v.User1.HeaderImage
                                    
                                }).ToList();
            return View();

        }

        /// <summary>
        /// 访问公共首页
        /// </summary>
        /// <returns></returns>
       [OutputCache(Duration = 10)]
        public ActionResult Common()
        {
            return View();
        }

        /// <summary>
        /// 访问他人首页
        /// </summary>
        /// <param name="uid">被访问者Id</param>
        /// <returns></returns>
        public ActionResult VisitUser(int? uid)
        {

            if (uid != null && this.User != null)
            {
                int visitorId = Convert.ToInt32(this.User.Identity.Name);//当前用户登录

                using (FriendsEntities context = new FriendsEntities())
                {
                    //获取访问数据
                    var visit = (from v in context.Visits where v.UserID == uid && v.VisitorID == visitorId select v)
                        .SingleOrDefault();
                    if (visit == null)//第一次访问，添加数据
                    {
                        visit = new Visit()
                        {
                            UserID = uid.Value,
                            VisitorID = visitorId,
                            LastVisitIP = Request.UserHostAddress,
                            LastVisitTime = DateTime.Now,
                            VisitTimes = 1
                        };
                        context.Visits.Add(visit);
                    }
                    else//修改数据
                    {
                        visit.LastVisitTime = DateTime.Now;
                        visit.LastVisitIP = Request.UserHostAddress;
                        visit.VisitTimes = visit.VisitTimes + 1;//增加访问次数
                    }

                    context.SaveChanges();

                    ViewBag.Vistors = (from v in context.Visits
                                       where v.UserID == uid
                                       orderby v.LastVisitTime descending
                                       select new VisitorModel()
                                       {
                                           VisitorID = v.VisitorID,
                                           LastVisitTime = v.LastVisitTime,
                                           RealName = v.User1.RealName, //User1 为VisitorId 对应的外键实体
                                           HeaderImage=v.User1.HeaderImage
                                       }).ToList();
                    return View("User");
                }
            }
            else
            {
                return Content("");
            }
        }



        #region "记录"
        [HttpPost]
        public ActionResult AddRecord(string Content)
        {

            if (!string.IsNullOrEmpty(Content))
            {
                Record record = new Record();
                record.Content = Content;
                record.CreatedTime = DateTime.Now;

                int userId = Convert.ToInt32(this.User.Identity.Name);//当前用户

                record.UserId = userId;
                context.Records.Add(record);

                if (context.SaveChanges() > 0)
                {
                    if (Request.IsAjaxRequest())
                    {
                        return this.Content("记录保存成功！");
                    }
                    else
                    {
                        return this.Content("<script>alert('记录保存成功！');window.location='" + Url.Action("Index", "Home") + "'</script>");

                    }
                }
                else
                {
                    if (Request.IsAjaxRequest())
                    {
                        return this.Content("记录保存失败！");
                    }
                    else
                    {
                        return this.Content("<script>alert('记录保存失败！');window.location='" + Url.Action("Index", "Home") + "'</script>");

                    }
                }
            }
            else
            {
                if (Request.IsAjaxRequest())
                {
                    return this.Content("内容不能为空！");
                }
                else
                {
                    return View("<script>alert('内容不能为空！');window.location='" + Url.Action("Index", "Home") + "'</script>");
                }
            }
        }


        [HttpPost]
        public ActionResult AddMind(MindModel model)
        {

            if (ModelState.IsValid)
            {
                Mind mind = new Mind();
                mind.Content = model.Content;
                mind.MindType = model.MindType;

                mind.CreatedTime = DateTime.Now;

                mind.UserId = Convert.ToInt32(this.User.Identity.Name);
                context.Minds.Add(mind);
                context.SaveChanges();

                if (Request.IsAjaxRequest())
                {
                    return this.Content("心情保存成功！");
                }
                else
                {
                    return this.Content("<script>alert('心情保存成功！');window.location='" + Url.Action("Index", "Home") + "'</script>");

                }
            }
            else
            {

                return View("Index");

            }
        }
        #endregion

    }

}