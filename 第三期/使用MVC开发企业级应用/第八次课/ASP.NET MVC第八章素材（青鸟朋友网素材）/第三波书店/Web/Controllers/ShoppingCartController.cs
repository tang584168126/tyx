using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.BLL;
using BookShop.Models;


namespace Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {

            User user = Session["CurrentUser"] as User;
            if (user == null)
            {
                return Content("<script>alert('登录超时，请重新登录！');document.location='" + Url.Action("Login", "Account") + "';</script>");
            }


            if (Session["Cart"] != null)
            {
                ShoppingManager manager = new ShoppingManager(Session["Cart"], user);
                ViewData["TotalPrice"] = string.Format("{0:F}", manager.TotalPrice);
                return View("Index",manager.ShoppingItems);
            }

            return View("Index");
        }

        /// <summary>
        /// 将书籍添加到购物车
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        public ActionResult Add(int? bid)
        {
            if (Session["CurrentUser"] == null)
            {
                return Content("<script>alert('请先登录再购买商品！');document.location='" + Url.Action("Login", "Account", new { ReturnUrl = Server.UrlDecode(Request.RawUrl) }) + "';</script>");
            }
            else
            {
                ShoppingManager manager = new ShoppingManager(Session["Cart"]);
                if (bid.HasValue)
                {
                    manager.AddItem(bid.Value);
                    Session["Cart"] = manager.ShoppingItems;
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Detail", "Books", new { bid = bid.Value });
                }
            }


        }

        /// <summary>
        /// 将书籍添加到购物车
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public ActionResult UpdateQuantity(ShoppingItem item)
        {
            if (ModelState.IsValid)
            {
                if (Session["CurrentUser"] == null)
                {
                    return Content("<script>alert('会话已失效，请重新登录！');document.location='" + Url.Action("Login", "Account", new { ReturnUrl = Server.UrlDecode(Request.RawUrl) }) + "';</script>");
                }
                else
                {
                    ShoppingManager manager = new ShoppingManager(Session["Cart"]);
                    manager.UpdateQuantity(item.Book.Id, item.Quantity);
                    Session["Cart"] = manager.ShoppingItems;
                  

                }
            }

           // return RedirectToAction("Index");
            return Index();
        }


        /// <summary>
        /// 将某本书从购物车移出
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public ActionResult Remove(int? bid)
        {
            if (bid.HasValue)
            {
                ShoppingManager manager = new ShoppingManager(Session["Cart"]);
                manager.RemoveItem(bid.Value);
                Session["Cart"] = manager.ShoppingItems;

            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 提交订单
        /// </summary>
        /// <returns></returns>
        public ActionResult Submit()
        {

            ShoppingManager manager = new ShoppingManager(Session["Cart"], Session["CurrentUser"]);
            if (manager.ShoppingItems.Count == 0)
            {
                return Content("<script>alert('您的购物车为空,请先将图书放入购物车!！');document.location='" + Url.Action("Index", "Home") + "';</script>");
               
            }
            if (manager.User == null)
            {
                return Content("<script>alert('登录超时，请重新登录！');document.location='" + Url.Action("Login", "Account") + "';</script>");
          
            }

          

            manager.MakeOrder();
            Session.Remove("Cart");
            return Content("<script>alert('结算成功,请等待审批订单!！');document.location='" + Url.Action("Index", "Home") + "';</script>");
      
        }
    }
}
