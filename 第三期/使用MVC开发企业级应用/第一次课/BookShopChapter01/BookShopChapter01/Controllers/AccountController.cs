using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookShopChapter01.Models;

namespace BookShopChapter01.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View("LogIn");
        }

        public ActionResult LogIn()
        {
            string loginId = Request.Form["username"];
            string password = Request.Form["password"];

            if (LogIn(loginId, password))
            {
                //登录成功
                User user = new User() { LoginId = loginId, Password = password };
                Session["CurrentUser"] = user;

                return RedirectToAction("Index","Home");
            }
            else
            {
                //登录失败
                return View("LogIn");
            }
        }

        public ActionResult LogOut()
        {
            Session["CurrentUser"] = null;
            return RedirectToAction("Index", "Account");
        }

        #region 访问数据
        private bool LogIn(string loginId,string password)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=TANG;Initial Catalog=BookShop;Integrated Security=True"))
            {
                string sqlText = "select count(*) from Users where LoginId=@LoginId and LoginPwd=@LoginPwd";
                SqlParameter[] paras = new SqlParameter[] { 
                    new SqlParameter("@LoginId",loginId),
                    new SqlParameter("@LoginPwd",password)
                };
                SqlCommand objComm = new SqlCommand(sqlText, conn);
                objComm.Parameters.AddRange(paras);

                conn.Open();
                object result = objComm.ExecuteScalar();
                if (Convert.ToInt32(result) > 0)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion
    }
}
