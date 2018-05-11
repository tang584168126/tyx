using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Friends.Models;
namespace Friends.Business
{
    public class QuestionService
    {
        FriendsEntities context = new FriendsEntities();

        #region "业务操作"
        /// <summary>
        /// 创建问题
        /// (1）控制悬赏豆不能超过用户的可用豆数。
        ///（2) 问题发布成功后，用户的可用青鸟豆要减去本次悬赏豆数
        /// </summary>
        /// <param name="ques"></param>
        public bool Create(Question ques, ref string errorMess)
        {
            if (ques.Tags == null || ques.Tags.Count == 0)
            {
                errorMess = "标签必须填写"; return false;
            }


            //获取可用青鸟豆
            var user = context.Users.Find(ques.CreateUserId);
            if (user == null)
            {
                errorMess = "无效的用户"; return false;
            }

            //悬赏豆不能超过用户的可用豆数
            if (user.InitialPrize < ques.Prize)
            {
                errorMess = "悬赏豆不能超过用户的可用豆数"; return false;
            }

            //更新用户可用豆数
            user.InitialPrize = user.InitialPrize - ques.Prize;


            List<Tag> tempTags = ques.Tags as List<Tag>;
            //处理关联关系
            for (int i = 0; i < tempTags.Count; i++)
            {
                //标签在数据库不存在
                var tempTagName = tempTags[i].TagName;
                var existTag = context.Tags.SingleOrDefault(m => m.TagName == tempTagName);
                if (existTag != null)//标签在数据库存在
                {
                    tempTags[i] = existTag;
                }
            }

            //添加问题
            context.Questions.Add(ques);

            if (context.SaveChanges() > 0)
            {
                return true;
            }

            return false;



        }//end method


        /// <summary>
        /// 修改问题
        /// </summary>
        /// <param name="ques"></param>
        /// <returns></returns>
        public bool Update(Question ques)
        {

            context.Configuration.ValidateOnSaveEnabled = false;
            var existQues = context.Questions.Find(ques.QuestionId);
            if (existQues != null)
            {
                existQues.Title = ques.Title;
                existQues.Content = ques.Content;
                return context.SaveChanges() > 0;
            }

            return false;
        }

        /// <summary>
        /// 修改问题的奖励
        ///（1）控制输入的豆数必须大于0，小于用户的可用豆数。
        ///（2）修改青鸟豆完成后要同时更新用户的可用豆数。
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="prize"></param>
        /// <returns></returns>
        public bool UpdatePrize(int questionId, int prize, ref string message)
        {
            //输入的豆数必须大于0
            if (prize < 0)
            {
                message = "输入的豆数必须大于0"; return false;
            }
            var ques = context.Questions.Include("User").SingleOrDefault(q => q.QuestionId == questionId);
            if (ques == null)
            {
                message = "问题不存在"; return false;
            }

            //小于用户的可用豆数,注意这里的判断逻辑
            if (ques.User.InitialPrize + ques.Prize < prize)
            {
                message = "输入的豆数大于用户的可用豆数"; return false;
            }
            //发生了修改
            if (prize != ques.Prize)
            {

                //同时更新用户的可用豆数
                ques.User.InitialPrize += (ques.Prize - prize);

                //修改问题的豆数
                ques.Prize = prize;
            }
            context.Configuration.ValidateOnSaveEnabled = false;
            if (context.SaveChanges() > 0)
            {
                return true;

            }
            return false;
        }


        /// <summary>
        /// 如果问题无解答，修改问题状态为已关闭。
        /// 如果问题有解答，修改问题状态为已关闭，同时返还悬赏青鸟豆的20%，不足整的去余数取整。
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="messgage"></param>
        /// <returns></returns>
        public bool CloseQuestion(int questionId, ref string messgage)
        {
            var ques = context.Questions.Include("Answers").Include("User").SingleOrDefault(m => m.QuestionId == questionId);
            if (ques == null)
            {
                messgage = "问题不存在"; return false;
            }

            if (ques.State == Convert.ToByte(QuestionState.Initial))
            {
                //问题有解答，返还悬赏青鸟豆的20%
                if (ques.Answers.Count() > 0)
                {
                    var backPrize = (ques.Prize - ques.Prize % 5) / 5;
                    ques.User.InitialPrize += backPrize;

                }
                //关闭问题
                ques.State = Convert.ToByte(QuestionState.Closed);
            }
            context.Configuration.ValidateOnSaveEnabled = false;
            if (context.SaveChanges() > 0)
            {
                return true;

            }
            return false;
        }


        /// <summary>
        /// 分配奖励
        /// （1）每个答案分配的青鸟豆不小于0，分配青鸟豆总和等于悬赏青鸟豆；
        /// （2）结帖成功后，每个回答问题用户的可用青鸟豆相应增加；
        /// （3）结帖成功后，该问题变为已解决状态；
        /// （4）结帖成功后，为用户返还悬赏额50%的青鸟豆，不足整的去小数取整
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public bool AllotPrize(IList<Answer> answers, int questionId, ref string message)
        {
            var ques = context.Questions.Include("Answers").Include("User")
                .SingleOrDefault(m => m.QuestionId == questionId);
            if (ques == null)
            {
                message = "无效的问题"; return false;
            }

            int total = 0;//分配奖励和
            foreach (var item in answers)
            {
                if (item.Prize < 0)
                {
                    message = "每个答案分配的青鸟豆不小于0"; return false;
                }
                total += (item.Prize.HasValue?item.Prize.Value:0);
            }

            //分配青鸟豆总和等于悬赏青鸟豆
            if (ques.Prize != total)
            {
                message = "分配青鸟豆总和不等于悬赏青鸟豆"; return false;
            }

            //更新答案奖励
            foreach (var item in ques.Answers)
            {
                var getItem = (from a in answers where a.AnswerId == item.AnswerId select a).SingleOrDefault();
                if (getItem == null)
                {
                    message = "答案不匹配"; return false;
                }
                //修改答案设置
                item.Prize = getItem.Prize;
                item.IsBest = getItem.IsBest;

                //每个回答问题用户的可用青鸟豆相应增加
                if (getItem.Prize > 0)
                {
                    var answerUser = context.Users.Find(item.CreateUserId);
                    if (answerUser == null)
                    {
                        message = "问题回答者无效"; return false;
                    }
                    answerUser.InitialPrize += getItem.Prize.Value;
                }
            }

            //问题变为已解决状态
            ques.State = Convert.ToByte(QuestionState.Finished);

            //为用户返还悬赏额50%的青鸟豆，不足整的去小数取整
            var prize = ques.Prize;
            if (ques.Prize % 2 != 0)//是奇数
            {
                prize = ques.Prize - 1;
            }
            ques.User.InitialPrize += (prize / 2);

            context.Configuration.ValidateOnSaveEnabled = false;
            if (context.SaveChanges() > 0)
            {
                return true;

            }
            return false;
        }


        /// <summary>
        /// 增加问题访问量
        /// </summary>
        /// <param name="questionId"></param>
        public void AddVisits(int questionId)
        {

            context.Configuration.ValidateOnSaveEnabled = false;
            var question = context.Questions.Find(questionId);

            question.VisitCount += 1;

            context.SaveChanges();

        }


        /// <summary>
        /// 添加问题的答案
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="errorMess"></param>
        /// <returns></returns>
        public bool AddAnswer(Answer answer, ref string errorMess)
        {
            if (answer.CreateUserId <= 0)
            {
                errorMess = "无效的用户"; return false;
            }

            context.Answers.Add(answer);
            return context.SaveChanges() > 0;

        }
        #endregion


        #region "查询问题"
        /// <summary>
        /// 获取全部问题
        /// </summary>
        /// <returns></returns>
        public IQueryable<Question> GetQuestions()
        {
            var query = from q in context.Questions
                        orderby q.CreatedTime descending //按创建时间排序
                        select q;
            return query;
        }

        /// <summary>
        /// 获取单个问题
        /// </summary>
        /// <returns></returns>
        public Question GetQuestion(int questionId)
        {
            var query = from q in context.Questions.AsNoTracking()
                        where q.QuestionId == questionId
                        select q;
            return query.SingleOrDefault();

        }


        /// <summary>
        /// 按创建者获取问题
        /// </summary>
        /// <returns></returns>
        public IQueryable<Question> GetQuestions(int createUserId)
        {
            var query = from q in context.Questions
                        where q.CreateUserId == createUserId
                        orderby q.CreatedTime descending  //按创建时间排序
                        select q;
            return query;
        }

        /// <summary>
        /// 按回答者获取问题
        /// </summary>
        /// <param name="answerUserId"></param>
        /// <returns></returns>
        public IQueryable<Question> GetQuestionsByAnswer(int answerUserId)
        {
            var query = from q in context.Answers
                        where q.CreateUserId == answerUserId
                        select q.Question;


            return query.Distinct().OrderBy(m => m.CreatedTime);
        }

        /// <summary>
        /// 获取用户的可用豆数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        ///
        public int GetInitialBeans(int userId)
        {
            return context.Users.Find(userId).InitialPrize;
        }

        /// <summary>
        /// 根据问题得到回答
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public IQueryable<Answer> GetAnswers(int questionId)
        {
            var query = from q in context.Answers
                        where q.QuestionId == questionId
                        select q;
            return query;

        }

        /// <summary>
        /// 根据答案编号得到回答
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        public Answer GetAnswer(int answerId)
        {
            var query = from q in context.Answers.Include("User")
                        where q.AnswerId == answerId
                        select q;
            return query.SingleOrDefault();

        }
        #endregion

    }
}
