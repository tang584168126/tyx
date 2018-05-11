using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.filters;
using System.IO;

namespace PB_WhiteForm.Controllers
{
    [Authorize]
    public class PayController : Controller
    {
        // GET: /Pay/
        public ActionResult Index()
        {
            return View();
        }
       
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        //[IsPostFromCurrentSite]
        public ActionResult Index(string Account, double Amount, string desc)
        {
            //付款处理
            if (string.IsNullOrEmpty(Account))
                return View();
            //...

            //写入交易日志，便于测试
            string path=Server.MapPath(@"~\tradelog.txt");
            using (StreamWriter sw = System.IO.File.AppendText(path))
            {
                sw.WriteLine("{0}\t{1}\t{2}", Account, Amount, DateTime.Now);
            }

            return View("PaidSuccess");
        }
    }
}