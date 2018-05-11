using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShopMvc.Helpers
{
    public class UserBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContex,ModelBindingContext bindingContext)
        {
            var user = (User)bindingContext.Model ?? new User();

            user.Name = GetValue<string>(bindingContext, "LoginId");
            user.LoginPwd = GetValue<string>(bindingContext, "LoginPwd");

            user.Mail = user.Name + "163.com";

            return user;
        }
        private T GetValue<T>(ModelBindingContext bindingContext,string key)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(key);
            return (T)valueResult.ConvertTo(typeof(T));
        }
    }
}