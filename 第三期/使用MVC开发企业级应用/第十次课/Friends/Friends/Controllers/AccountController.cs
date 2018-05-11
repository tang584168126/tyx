using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Friends.Model;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Web.Security;

namespace Friends.Controllers
{
    public class AccountController : Controller
    {
        FriendsEntities entities = new FriendsEntities();
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [HandleError(ExceptionType=typeof(System.Exception),View="Error")]
        public ActionResult LogIn(LoginModel loginModel,string autoLogin)
        {
            //验证通过
            if(ModelState.IsValid)
            {
                //根据邮箱获取对应的用户对象
                var user = entities.Users.SingleOrDefault(u => u.Mail.Equals(loginModel.Mail));
                //登录成功
                if(user!=null&&user.Password.Equals(loginModel.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.UserId.ToString(), autoLogin == null ? false : true);
                    Session["CurrentUser"] = user;
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    //登录失败
                    ModelState.AddModelError("", "用户名或密码错误");
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
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Account", "LogIn");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel registerModel)
        {
            if(ModelState.IsValid)
            {
                DateTime birthday;
                //生日的合成
                birthday = new DateTime(registerModel.Year, registerModel.Month, registerModel.Day);

                //验证码是否正确
                if(!registerModel.SecurityCode.Equals(TempData["SecurityCode"].ToString()))
                {
                    ModelState.AddModelError("SecurityCode", "验证码错误");
                    return View(registerModel);
                }

                //邮箱是否已注册
                var tempUser = entities.Users.SingleOrDefault(u => u.Mail.Equals(registerModel.Mail));
                if(tempUser != null)
                {
                    ModelState.AddModelError("Mail", "邮箱已注册，请重新输入");
                    return View(registerModel);
                }

                //验证全部通过，构建一个业务模型对象
                var user = new User()
                {
                    Mail = registerModel.Mail,
                    Password = registerModel.Password,
                    RealName = registerModel.RealName,
                    Birthday = registerModel.Birthday,
                    Gender = registerModel.Gender,
                    Situation = registerModel.SecurityCode,
                    RegisterTime = DateTime.Now
                };

                //注册用户
                entities.Users.Add(user);
                if(entities.SaveChanges() > 0)
                {
                    return Content("<script>alert('注册成功！');window.location='Account/LogIn'</script>");
                }
                else
                {
                    ModelState.AddModelError("", "注册失败");
                    return View(registerModel);
                }
            }
            else
            {
                return View(registerModel);
            }
            
        }
       
        #region  生成验证码图片
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
