using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friends.Models
{
    public static class FriendListItems
    {
        public static List<SelectListItem> Genders;//性别

        public static List<SelectListItem> Situations;//身份 

        public static List<SelectListItem> Years;//年
        public static List<SelectListItem> Months;//月
        public static List<SelectListItem> Days;//日


        static FriendListItems()
        {
            
            Genders = new List<SelectListItem>();
            Genders.Add(new SelectListItem() { Value = "男",Text= "男" });
            Genders.Add(new SelectListItem() { Value = "女", Text = "女" });

            Situations = new List<SelectListItem>();
            Situations.Add(new SelectListItem() { Value = "已工作学员", Text = "已工作学员" });
            Situations.Add(new SelectListItem() { Value = "在读学员", Text = "在读学员" });
            Situations.Add(new SelectListItem() { Value = "教员", Text = "教员" });
            Situations.Add(new SelectListItem() { Value = "其它身份", Text = "其它身份" });

            Years = new List<SelectListItem>();
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                Years.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }

            Months = new List<SelectListItem>();
            for (int i = 1; i <= 12; i++)
            {
                Months.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }

            Days = new List<SelectListItem>();
            for (int i = 1; i <= 31; i++)
            {
                Days.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }
        }

    }
}