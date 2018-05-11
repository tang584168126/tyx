using Friends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Friends.Web.Helpers;
using Friends.Business;

namespace Friends.Controllers
{
    public class QuestionController : Controller
    {
        #region "字段"
        FriendsEntities context = new FriendsEntities();
        QuestionService quesService = new QuestionService();
        TagService tagService = new TagService();

        int PageSize = 5;//每页显示的问题个数
        #endregion

        #region "内部方法"
        [NonAction]
        void TransferTag(string tagList, ICollection<Tag> tags)
        {
            var arrTags = tagList.Trim().Split(',').ToArray();

            foreach (var tag in arrTags)
            {
                tags.Add(new Tag() { TagName = tag });
            }

        }
        #endregion

        #region "显示"
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 全部问题
        /// </summary>
        /// <returns></returns>

        public ActionResult AllQuestions(int pageIndex = 1)
        {
            var query = quesService.GetQuestions();
            return PartialView(new PagedList<Question>(query, pageIndex, this.PageSize));
        }

        /// <summary>
        /// 我的问题
        /// </summary>
        /// <returns></returns>
        public ActionResult MyQuestions(int pageIndex = 1)
        {


            if (Request.IsAuthenticated)
            {
                int userId = Int32.Parse(this.User.Identity.Name);
                var query = quesService.GetQuestions(userId);
                return PartialView(new PagedList<Question>(query, pageIndex, this.PageSize));
            }
            else
            {
                return Content("<script>alert('没有权限！');window.location='" + this.Url.Action("Login", "Account") + "'</script>");
            }
        }


        /// <summary>
        /// 我回答的问题
        /// </summary>
        /// <returns></returns>
        public ActionResult MyAnswerQuestions(int pageIndex = 1)
        {
            if (Request.IsAuthenticated)
            {
                int userId = Int32.Parse(this.User.Identity.Name);
                var query = quesService.GetQuestionsByAnswer(userId);
                return PartialView(new PagedList<Question>(query, pageIndex, this.PageSize));
            }
            else
            {
                return Content("<script>alert('没有权限！');window.location='" + this.Url.Action("Login", "Account") + "'</script>");
            }
        }


        /// <summary>
        /// 全部标记
        /// </summary>
        /// <returns></returns>
        public ActionResult TagList(int pageIndex = 1)
        {
            var query = tagService.GetTags();
            return PartialView(new PagedList<Tag>(query, pageIndex, 100));
        }

        /// <summary>
        /// 显示专家列表
        /// </summary>
        /// <returns></returns>
        public ActionResult ListExpert()
        {
            //获取原始数据
            var query = from u in context.Users
                        where u.InitialPrize > 2000
                        orderby u.InitialPrize descending
                        select new ExpertModel { ExpertId = u.UserId, Name = u.RealName, HeaderImage = u.HeaderImage, Prize = u.InitialPrize };

            TagSettingService srv = new TagSettingService();

            var items = from u in query.Take(15).ToList()
                        select new ExpertModel { ExpertId = u.ExpertId, Name = u.Name, HeaderImage = u.HeaderImage, Prize = u.Prize, Title = srv.GetTitle(u.Prize) };
            return PartialView("Expert", items.ToList());

        }

        /// <summary>
        /// 输出标签JSON数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTags()
        {
            var tags = (from t in context.Tags select t.TagName).Take(5).ToList();
            return Json(tags, JsonRequestBehavior.AllowGet);
        }
        #endregion

        /// <summary>
        /// 创建问题
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Create()
        {
            int userId = Int32.Parse(this.User.Identity.Name);
            ViewBag.LimitidBeans = quesService.GetInitialBeans(userId);
            return View("Create");
        }

        /// <summary>
        /// 创建问题
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Question ques)
        {
            int userId = Int32.Parse(this.User.Identity.Name);
            if (ModelState.IsValid)
            {
                ques.CreateUserId = userId;
                ques.CreatedTime = DateTime.Now;
                ques.Tags = new List<Tag>();

                this.TransferTag(ques.TagList, ques.Tags);

                string errorMess = "";

                if (quesService.Create(ques, ref errorMess))//创建成功
                {
                    return Content("<script>alert('创建成功！');window.location='" + this.Url.Action("Index") + "'</script>");
                }
                else
                {

                    return Content("<script>alert('" + errorMess + "');window.location='" + this.Url.Action("Index") + "'</script>");
                }

            }

            ViewBag.LimitidBeans = quesService.GetInitialBeans(userId);

            return View("Create");
        }

        /// <summary>
        /// 浏览问题
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Detail(int? id)
        {
            if (id.HasValue)
            {
                int userId = -1;
                var item = quesService.GetQuestion(id.Value);

                if (Request.IsAuthenticated)
                {
                    userId = Int32.Parse(this.User.Identity.Name);
                }

                //如果已登录，并且是自己创建的问题，则进入操作界面
                if (Request.IsAuthenticated && item.CreateUserId == userId
                    && item.State == Convert.ToByte(QuestionState.Initial)
                    )
                {
                    return RedirectToAction("QuestionsOperation", new { id = id });
                }

                //增加访问次数
                if (item.CreateUserId != userId)
                    quesService.AddVisits(id.Value);

                return View(item);
            }
            return Content("无效的问题编号");
        }

        /// <summary>
        /// 操作未关闭问题
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public ActionResult QuestionsOperation(int? id)
        {
            if (id.HasValue)
            {
                var item = quesService.GetQuestion(id.Value);

                var userId = Int32.Parse(this.User.Identity.Name);

                //如果已登录，并且不是自己创建的问题，则进入详细信息界面
                //如果已经关闭和结贴，则不能操作
                if (item.CreateUserId != userId  || item.State!=Convert.ToByte(QuestionState.Initial))
                {
                    return RedirectToAction("Detail", new { id = id });
                }

                return View(item);
            }
            return Content("无效的问题编号");
        }

        /// <summary>
        /// 回答问题
        /// </summary>
        [Authorize]
        [ValidateInput(false)]
        public ActionResult Answer(Answer answer)
        {
            if (ModelState.IsValid)
            {
                string message = "";
                answer.CreatedTime = DateTime.Now;
                answer.CreateUserId = int.Parse(this.User.Identity.Name);


                if (quesService.AddAnswer(answer, ref message))
                {
                    var newAnswer = quesService.GetAnswer(answer.AnswerId);
                    return PartialView("AnswerItem", newAnswer);
                }
            }
            return Content("操作失败！");
        }

        /// <summary>
        /// 编辑问题
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                int userId = Int32.Parse(this.User.Identity.Name);
                var item = quesService.GetQuestion(id.Value);

                //只能修改自己创建的问题
                if (item.CreateUserId != userId)
                {
                    return Content("只能修改自己创建的问题！");
                }
                //已解决和已关闭的问题不能修改
                if (item.State != 0)
                {
                    return Content("已解决和已关闭的问题不能修改！");
                }
                return View(item);
            }
            return Content("无效的问题");
        }

        /// <summary>
        /// 修改问题
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Question ques)
        {
            //消除该字段自动验证的影响
            ModelState.Remove("TagList");

            if (ModelState.IsValid)
            {
                int userId = Int32.Parse(this.User.Identity.Name);
                var item = quesService.GetQuestion(ques.QuestionId);

                //只能修改自己创建的问题
                if (item.CreateUserId != userId)
                {
                    return Content("只能修改自己创建的问题！");
                }
                //已解决和已关闭的问题不能修改
                if (item.State != Convert.ToByte(QuestionState.Initial))
                {
                    return Content("已解决和已关闭的问题不能修改！");
                }
                if (quesService.Update(ques))
                    return Content("1");//用于客户端Ajax 处理
            }
            return Content("操作失败！");
        }

        /// <summary>
        /// 结贴操作
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public ActionResult AllotPrize(IList<Answer> answers, int? questionId)
        {
            string message = "操作失败!";

            if (answers != null && answers.Count() > 0 && questionId.HasValue)
            {
                foreach (Answer it in answers)
                {
                    //验证
                    if (!it.Prize.HasValue)
                    {
                        return Content("分配的青鸟豆无效！");
                    }
                    if (answers.Where(m => m.IsBest == true).Count() != 1)
                    {
                        return Content("必须设置一个最佳答案！");
                    }
                }


                int userId = Int32.Parse(this.User.Identity.Name);
                var item = quesService.GetQuestion(questionId.Value);

                //只能修改自己创建的问题
                if (item.CreateUserId != userId)
                {
                    return Content("只能对本人创建的问题结帖！");
                }
                //已解决和已关闭的问题不能修改
                if (item.State != Convert.ToByte(QuestionState.Initial))
                {
                    return Content("已解决和已关闭的问题不能结帖！");
                }

                if (quesService.AllotPrize(answers, questionId.Value, ref message))
                {
                    return Content("1");
                }

            }

            return Content(message);
        }

        /// <summary>
        /// 关闭问题
        /// </summary>
        [Authorize]
        [HttpPost]
        public ActionResult CloseQuestion(int questionId = 0)
        {
            string message = "操作失败！";

            if (questionId <= 0)
            {
                return Content("无效的问题！");
            }

            int userId = Int32.Parse(this.User.Identity.Name);
            var item = quesService.GetQuestion(questionId);

            //只能修改自己创建的问题
            if (item.CreateUserId != userId)
            {
                return Content("只能关闭自己创建的问题！");
            }
            //已解决和已关闭的问题不能修改
            if (item.State != Convert.ToByte(QuestionState.Initial))
            {
                return Content("已解决和已关闭的问题不能再次关闭！");
            }

            //关闭问题
            if (quesService.CloseQuestion(questionId, ref message))
            {
                return Content("1");
            }

            return Content(message);

        }

        /// <summary>
        /// 修改奖励
        /// </summary>
        [Authorize]
        [HttpPost]
        public ActionResult UpdatePrize(int questionId = 0, int prize = 0)
        {
            string message = "操作失败！";

            if (questionId <= 0)
            {
                return Content("无效的问题！");
            }

            if (prize <= 0)
            {
                return Content("无效的奖励！");
            }

            int userId = Int32.Parse(this.User.Identity.Name);
            var item = quesService.GetQuestion(questionId);

            //只能修改自己创建的问题
            if (item.CreateUserId != userId)
            {
                return Content("只能修改自己创建问题的奖励！");
            }
            //已解决和已关闭的问题不能修改
            if (item.State != Convert.ToByte(QuestionState.Initial))
            {
                return Content("已解决和已关闭的问题不能修改奖励！");
            }

            //修改奖励
            if (quesService.UpdatePrize(questionId, prize, ref message))
            {
                return Content("1");
            }

            return Content(message);

        }
    }
}
