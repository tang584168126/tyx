using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.BLL;
using BookShop.Models;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{


    

    [Authorize]
    public class UserController : Controller
    {
        

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            List<User> users = new UserManager().GetNormalUsers();
            return View(users);
        }

        /// <summary>
        /// 用户状态列表
        /// </summary>
        /// <returns></returns>
        public ActionResult StateList()
        {
            List<User> users = new UserManager().GetUsers();

            return View(users);
        }

        /// <summary>
        /// 启用用户
        /// </summary>

        public ActionResult Enabled(List<CheckedUser> checkedUsers)
        {
            ChangeState(checkedUsers, UserStates.正常);
            return RedirectToAction("StateList");
        }

        /// <summary>
        /// 禁用用户
        /// </summary>

        public ActionResult Disabled(List<CheckedUser> checkedUsers)
        {
            ChangeState(checkedUsers, UserStates.无效);
            return RedirectToAction("StateList");
        }

        private static void ChangeState(List<CheckedUser> checkedUsers, UserStates state)
        {
            UserManager manager = new UserManager();
            foreach (CheckedUser cUser in checkedUsers)
            {
                if (cUser.Checked == true)
                {
                    manager.ModifyUserState(cUser.Id, state);
                }
            }
        }

       

        public ActionResult Edit(int? id)
        {
            UserManager manager = new UserManager();
            User user = null;
          
            if (id.HasValue)
            {
                user = manager.GetUserById(id.Value);
            }

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(EditUser user)
        {
            UserManager manager = new UserManager();
            
            if (ModelState.IsValid)
            {
                User oldUser  = manager.GetUserById(user.Id);
                oldUser.Name = user.Name;
                oldUser.Address = user.Address;
                oldUser.Phone = user.Phone;
                oldUser.Mail = user.Mail;
                manager.ModifyUser(oldUser);
            }
            else
            {
                return RedirectToAction("Edit", "User", new { id = user.Id });
            }
            return RedirectToAction("List");
        }


        public ActionResult Delete(int? id)
        {
            UserManager manager = new UserManager();
           
            if (id.HasValue)
            {
                manager.DeleteUserById(id.Value);

            }
            return RedirectToAction("List");
        }


      
    }
}
