using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.DAL;

namespace BookShop.BLL
{
    public class SearchKeywordManager
    {
        public string[] GetHotKeywords(string keyword, int displayCount)
        {
            return new SearchKeywordService().GetHotKeywords(keyword,displayCount);
        }
    }
}
