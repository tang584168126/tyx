using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Mvc;

namespace Friends.Model
{
    public class FriendsListItems
    {
        public static List<SelectListItem> Genders;     //性别
        public static List<SelectListItem> Situations;  //从事于
        public static List<SelectListItem> Years;       //年
        public static List<SelectListItem> Months;      //月
        public static List<SelectListItem> Days;       //日

        static FriendsListItems()
        {
            Genders = new List<SelectListItem>();
            Genders.Add(new SelectListItem() { Text = "男", Value = "男" });
            Genders.Add(new SelectListItem() { Text = "女", Value = "女" });

            Situations = new List<SelectListItem>();
            Situations.Add(new SelectListItem() { Text = "在工作", Value = "在工作" });
            Situations.Add(new SelectListItem() { Text = "在学习", Value = "在学习" });
            Situations.Add(new SelectListItem() { Text = "其他", Value = "其他" });

            Years = new List<SelectListItem>();
            for(int i = 1985;i <DateTime.Now.Year;i++)
            {
                Years.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }

            Months = new List<SelectListItem>();
            for (int i = 1; i <= 12; i++)
            {
                Months.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }

            Days = new List<SelectListItem>();
            for (int i = 1; i <=31; i++)
            {
                Days.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }
        }
    }
}
