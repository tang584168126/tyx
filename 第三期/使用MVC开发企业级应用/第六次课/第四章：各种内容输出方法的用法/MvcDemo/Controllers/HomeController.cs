using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

public class HomeController : Controller
{
   
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult Detail()
    {
        return View();
    }

    public ActionResult RedirectTest()
    {
        return Redirect("/Home/Detail");
    }

    public ActionResult RedirectToRouteTest()
    {
        return RedirectToRoute(new { controller = "Home", action = "Detail", 
            id = 1, cate = "test" });
    }

    public ActionResult RedirectToActionTest()
    {
        return RedirectToAction("Detail", new { id = 1, cate = "test" });
    }

    public ActionResult JsonTest()
    {
        var book = new
        {
            bookid = 1,
            bookName = "精通ASP.NET MVC",
            author = "北大青鸟",
            publishData = DateTime.Now
        };
        return Json(book, JsonRequestBehavior.AllowGet);
    }

    public ActionResult JavaScriptTest()
    {
        string js = "alert('Welecome to ASP.NET MVC!')";
        return JavaScript(js);
    }

    public ActionResult FilePathTest()
    {
        return File("~/Content/rain.mp3", "audio/mp3");
    }

    public ActionResult FileContentTest()
    {
        string content = "Welcome to ASP.NET MVC!";
        byte[] contents = System.Text.Encoding.UTF8.GetBytes(content);

        return File(contents, "text/plain");
    }

    public ActionResult FileStreamTest()
    {
        string content = "Welcome to ASP.NET MVC!";
        byte[] contents = System.Text.Encoding.UTF8.GetBytes(content);

        FileStream fs = new FileStream(
            Server.MapPath("~/Content/Telerik RadControls for ASP.NET AJAX (Custom).pdf"), FileMode.Open);
        return File(fs, "application/pdf");
    }

    public ActionResult ContentTest()
    {
        string content = "<h1>Welcome to ASP.NET MVC!</h1>"; 
        return Content(content);
    }

}

