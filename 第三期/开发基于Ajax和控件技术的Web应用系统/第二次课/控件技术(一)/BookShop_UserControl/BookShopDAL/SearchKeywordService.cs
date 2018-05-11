using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BookShop.DAL
{
    public class SearchKeywordService
    {
        /// <summary>
        /// 搜索热门关键字
        /// </summary>
        /// <param name="keyword">模糊关键字</param>
        /// <param name="displaycount">搜索数目</param>
        /// <returns>热门关键字字符串集合</returns>
        public string[] GetHotKeywords(string keyword, int displayCount)
        {
            string[] keywords = new string[displayCount];

            string sqlText = "select top 10 * from SearchKeywords where Keyword like '" + keyword + "' order by SearchCount desc";

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                {
                    keywords[i] = ds.Tables[0].Rows[i]["Keyword"].ToString();
                }                
            }
            return keywords;
        }
    }
}
