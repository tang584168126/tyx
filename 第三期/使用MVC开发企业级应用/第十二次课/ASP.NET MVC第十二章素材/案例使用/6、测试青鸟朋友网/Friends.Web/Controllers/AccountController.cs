using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using Friends.Models;

namespace Friends.Controllers
{

    public class AccountController : Controller
    {

        FriendsEntities context = new FriendsEntities();


        public ActionResult Index()
        {
            return View();
        }


        public ActionResult LogIn()
        {

            return View();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        [HttpPost]
        public ActionResult LogIn(LoginModel loginModel, string autoLogin, string returnUrl)
        {

            if (ModelState.IsValid)
            {

                var user = this.CachedUserItems.SingleOrDefault(u => u.Mail.Equals(loginModel.Mail));

                if (user != null && user.Password == loginModel.Password)//登录成功
                {

                    FormsAuthentication.SetAuthCookie(user.UserId.ToString(), autoLogin == null ? false : true);
                    Session["CurrentUser"] = user;//保持用户状态

                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        //返回首页
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return Redirect(Server.UrlDecode(returnUrl));
                    }
                }
                else
                {
                    ModelState.AddModelError("", "用户名或密码不正确!");
                    return View(loginModel);
                }
            }
            else
            {
                return View(loginModel);
            }


        }

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["CurrentUser"] = null;
            //返回登录页面
            return RedirectToAction("Login", "Account");
        }


        public ActionResult Register()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Register(RegisterModel regUser, string securityCode)
        {

            if (ModelState.IsValid)
            {
                DateTime birthDay;
                try
                {
                    birthDay = new DateTime(regUser.Year, regUser.Month, regUser.Day);//可能出错
                }
                catch
                {
                    ModelState.AddModelError("", "年月日不正确！");
                    return View(regUser);
                }

                if (String.Compare(TempData["SecurityCode"].ToString(), regUser.SecurityCode, true) != 0)
                {
                    ModelState.AddModelError("SecurityCode", "验证码不正确！");
                    return View(regUser);
                }

                //验证Email 是否已使用

                var cachedUser = this.CachedUserItems.SingleOrDefault(u => u.Mail.Equals(regUser.Mail));
                if (cachedUser != null)
                {
                    ModelState.AddModelError("Mail", "该邮箱已经被注册，请重新输入！");
                    return View(regUser);
                }

                var user = new User()
                 {
                     Mail = regUser.Mail,
                     Password = regUser.Password,
                     RealName = regUser.RealName,
                     Gender = regUser.Gender,
                     Birthday = birthDay,
                     Situation = regUser.Situation,
                     RegisterTime = DateTime.Now

                 };

                context.Users.Add(user);
                if (context.SaveChanges() > 0)
                {
                    this.CachedUserItems.Add(user);
                    this.CachedUserItems = this.CachedUserItems;

                    return Content("<script>alert('注册成功！');window.location='" + this.Url.Content("~/") + "'</script>");
                }

            }

            return View(regUser);


        }


        const string CACHEDUSERS = "Friends_RegisterUsers";
    


        IList<User> CachedUserItems
        {
            get
            {
                IList<User> items = HttpContext.Cache[CACHEDUSERS] as IList<User>;
                if (items == null)
                {
                    using (context)
                    {
                        items = context.Users.ToList();

                    }
                }
                HttpContext.Cache[CACHEDUSERS] = items;
                return items;
            }
            set
            {
                HttpContext.Cache[CACHEDUSERS] = value;
            }
        }

        #region  生成验证码图片
        // [OutputCache(Location = OutputCacheLocation.None, Duration = 0, NoStore = false)]
        public ActionResult SecurityCode()
        {

            string oldcode = TempData["SecurityCode"] as string;
            string code = CreateRandomCode(5);
            TempData["SecurityCode"] = code;
            return File(CreateValidateGraphic(code), "image/Jpeg");
        }


        private byte[] CreateImage(string checkCode)
        {
            int iwidth = (int)(checkCode.Length * 12);
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(iwidth, 20);
            Graphics g = Graphics.FromImage(image);
            Font f = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            Brush b = new System.Drawing.SolidBrush(Color.White);
            g.Clear(Color.Blue);
            g.DrawString(checkCode, f, b, 3, 3);
            Pen blackPen = new Pen(Color.Black, 0);
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x1 = rand.Next(image.Width);
                int x2 = rand.Next(image.Width);
                int y1 = rand.Next(image.Height);
                int y2 = rand.Next(image.Height);
                g.DrawLine(new Pen(Color.Silver, 1), x1, y1, x2, y2);
            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(35);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }
        /// <summary>
        /// 创建验证码的图片
        /// </summary>
        public byte[] CreateValidateGraphic(string validateCode)
        {
            Bitmap image = new Bitmap((int)Math.Ceiling(validateCode.Length * 16.0), 27);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器
                Random random = new Random();
                //清空图片背景色
                g.Clear(Color.White);
                //画图片的干扰线
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }
                Font font = new Font("Arial", 13, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                 Color.Blue, Color.DarkRed, 1.2f, true);
                g.DrawString(validateCode, font, brush, 3, 2);
                //画图片的前景干扰点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                //输出图片流
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
        #endregion
    }

}
