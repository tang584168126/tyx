using Friends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Business
{
    public class TagService
    {
        FriendsEntities context = new FriendsEntities();

        /// <summary>
        /// 获取标签
        /// </summary>
        /// <returns></returns>
        public IQueryable<Tag> GetTags()
        {

            var query = from t in context.Tags
                        orderby t.Questions.Count()
                        select t;
            return query;
        }
    }
}
