using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BookShop.DAL;
using NewsManagerSystem.Model;

namespace NewsManagerSystem.DAL.Server
{
    public class NewsInfoServer
    {
        //获取数据库连接
        private readonly string CONNST = ConfigurationManager.ConnectionStrings["News"].ConnectionString;

       /// <summary>
       /// 插入新闻
       /// </summary>
       /// <param name="objNewsInfo"></param>
       /// <returns>是否插入成功</returns>
        public bool IsInsert(NewsInfoEntity objNewsInfo)
        {
            bool result = false;
            try
            {
                //sql命令
                string sqlText = "insert into [News] (NewsName,NewsContent) values (@txtTitle,@txtContent)";
                int num = (int)SqlHelper.ExecuteNonQuery("CONNST", System.Data.CommandType.Text, sqlText);
                if(num > 0)
                {
                    result = true;
                }
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            return result;
        }
    }
}
