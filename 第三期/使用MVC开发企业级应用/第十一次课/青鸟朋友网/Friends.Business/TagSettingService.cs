using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Friends.Models;
namespace Friends.Business
{
    public class TagSettingService
    {
        FriendsEntities context = new FriendsEntities();
        /// <summary>
        /// 获取头衔配置数据
        /// </summary>
        public List<TitleSetting> GetTitleSettings()
        {
            List<TitleSetting> setting = HttpContext.Current.Cache["TitleSettings"] as List<TitleSetting>;
            if (setting == null)//cache 无数据
            {
                setting = (from s in context.TitleSettings select s).ToList();
                HttpContext.Current.Cache["TitleSettings"] = setting;
            }
            return setting;
        }

        /// <summary>
        /// 由豆数获取头衔
        /// </summary>
        /// <param name="prize"></param>
        /// <returns></returns>
        public string GetTitle(int prize)
        {
            List<TitleSetting> setting = GetTitleSettings();
            var title = from s in setting
                        where s.MinValue <= prize && s.MaxValue >= prize
                        select s.Title;
            return title.ToList()[0];
        }

    }
}
