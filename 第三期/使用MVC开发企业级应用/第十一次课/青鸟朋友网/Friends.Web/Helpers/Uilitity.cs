using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;
using Friends.Models;

namespace Friends.Web.Helpers
{
    public class Uilitity
    {
        /// <summary>
        /// 初始化指定个数的用户
        /// </summary>
        /// <param name="num"></param>
        public static void GenerateUsers(int num)
        {
            using (FriendsEntities context = new FriendsEntities())
            {
                context.Configuration.AutoDetectChangesEnabled = false;

                Random ran = new Random();


                string[] lastname;//姓
                string[] firstname_male;//男性的名字
                string[] firstname_female;//女性的名字
                

                lastname = File.ReadAllLines(HttpContext.Current.Server.MapPath(@"initial\lastname.txt"),System.Text.Encoding.Default);
                firstname_male = File.ReadAllLines(HttpContext.Current.Server.MapPath(@"initial\firstname_male.txt"), System.Text.Encoding.Default);
                firstname_female = File.ReadAllLines(HttpContext.Current.Server.MapPath(@"initial\firstname_female.txt"), System.Text.Encoding.Default);

                string[] mails = new string[] { "163.com", "gmail.com", "qq.com", "126.com", "hotmail.com", "sina.com.cn" };

                int count = 0;
                while (count++ <= num)//产生用户数
                {
                    User user = new User();
                    //随机身份
                    user.Situation = FriendListItems.Situations[ran.Next(0, FriendListItems.Situations.Count())].Value;
                    //随即产生生日
                    user.Birthday = DateTime.Now.AddYears(-15).AddDays(-ran.Next(0, 365 * 30));
                    //注册时间
                    user.RegisterTime = DateTime.Now;
                    //随即性别
                    user.Gender = ran.Next(0, 2) == 0 ? "男" : "女";

                    //随即产生姓名
                    string last, first;
                    last = lastname[ran.Next(0, lastname.Count())];//姓
                    if (user.Gender == "男")
                    {
                        if (ran.Next(0, 2) == 0)//名为2个字
                        {
                            first = firstname_male[ran.Next(0, firstname_male.Count())];
                        }
                        else
                        {
                            first = firstname_male[ran.Next(0, firstname_male.Count())] + firstname_male[ran.Next(0, firstname_male.Count())];
                        }
                    }
                    else//女性
                    {
                        if (ran.Next(0, 2) == 0)//名为2个字
                        {
                            first = firstname_female[ran.Next(0, firstname_female.Count())];
                        }
                        else
                        {
                            first = firstname_female[ran.Next(0, firstname_female.Count())] + firstname_female[ran.Next(0, firstname_female.Count())];
                        }
                    }
                    user.RealName = last + first;



                    //随即产生密码
                    user.Password = GenRandomString(ran.Next(6, 10));

                    //随即产生邮箱
                    user.Mail = GenRandomString(ran.Next(5, 8)) + "." + mails[ran.Next(0, mails.Count())];

                    //邮箱不重复
                    if (context.Users.SingleOrDefault(t => t.Mail == user.Mail) == null)
                    {
                        context.Users.Add(user);
                    }
                }
                context.SaveChanges();
                context.Configuration.AutoDetectChangesEnabled = true;
            }



        }

        /// <summary>
        /// 生成随机字符串
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenRandomString(int length)
        {
            List<char> chars = new List<char>();
            Random ran = new Random();
            char[] abc = "abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();

            while (chars.Count() < length)
            {
                chars.Add(abc[ran.Next(0, abc.Length)]);
            }
            return new string(chars.ToArray());

        }
    }
}