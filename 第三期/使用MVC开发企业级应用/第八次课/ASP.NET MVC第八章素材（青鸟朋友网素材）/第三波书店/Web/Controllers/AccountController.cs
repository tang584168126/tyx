using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using BookShop.BLL;
using BookShop.Models;

namespace Web.Controllers
{

    public class AccountController : Controller
    {
      
        const string strErrorUser = "用户名或密码不正确，请重新填写!";
        //
        // GET: /Accout/

        public ActionResult Index()
        {
            return View("Login");
        }
       
        public ActionResult LogIn()
        {
            string userName = Request.Form["userName"];
            string password = Request.Form["password"];
            string returnUrl = Request.QueryString["returnUrl"];
            if (string.IsNullOrEmpty(userName))
            {
                ModelState.AddModelError("userName", "请填写用户名！");
                return View("Login");
            }
            if (string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("password", "请填写密码！");
                return View("Login");
            }

            User user;
            UserManager manager = new UserManager();
            if (manager.LogIn(userName, password, out user))//登录成功
            {
                //记住用户名和密码
                string recordMe = Request.Form["RecordMe"];
                if (!string.IsNullOrEmpty(recordMe))//记住用户名和密码
                {
                    HttpCookie nameCookie = new HttpCookie("userName", userName);
                    Response.Cookies.Add(nameCookie);

                    HttpCookie passwordCookie = new HttpCookie("password", password);
                    Response.Cookies.Add(passwordCookie);
                }
               

                Session["CurrentUser"] = user;//保持用户状态
                if (string.IsNullOrEmpty(returnUrl))
                {
                    //返回首页
                    return Redirect("~/");
                }
                else
                {
                    return Redirect(Server.UrlDecode(returnUrl));
                }
            }
            else
            {
                ModelState.AddModelError("dataValidate", strErrorUser);
                return View("Login");
            }


        }

        public ActionResult LogOut()
        {
            Session["CurrentUser"] = null;
            //返回首页
            return Redirect("~/");
        }

        public ActionResult Register()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Register(User user, string securityCode)
        {

            if (ModelState.IsValid)
            {
                if (String.Compare(TempData["SecurityCode"].ToString(), securityCode, true) != 0)
                {
                    ModelState.AddModelError("SecurityCode", "验证码不正确，请重新输入！");
                    return View(user);
                }

                UserManager manager = new UserManager();
                if (!manager.Register(user))
                {
                    ModelState.AddModelError("", "用户名已使用，请重新输入！");
                    return View(user);
                }
                else
                {
                    return Content("<script>alert('注册成功，请继续购物！');window.location='" + UrlHelper.GenerateContentUrl("~/", this.HttpContext) + "'</script>");
                }
            }
            else
            {
                return View(user);
            }
        }


        #region  生成验证码图片
        //[OutputCache(Location = OutputCacheLocation.None, Duration = 0, NoStore = false)]
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
