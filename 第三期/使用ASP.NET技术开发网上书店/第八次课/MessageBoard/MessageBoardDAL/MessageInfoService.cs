using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageBoard.Models;
using System.Data.SqlClient;

namespace MessageBoard.DAL
{
    public class MessageInfoService
    {
        public bool AddMessage(MessageInfo messageInfo)
        {
            string sqlText = "insert into TBL_MESSAGE(message,author,postTime,email,webSite,userIp,faceUrl,picUrl,isHide) values"
                +" ('"+ messageInfo.Message +"','"+ messageInfo.Author +"','"+ messageInfo.PostTime +"','"+ messageInfo.Email +"','"+messageInfo.WebSite+"','"+ messageInfo.UserIp +"','"+messageInfo.FaceUrl+"','"+messageInfo.PicUrl+"','"+messageInfo.IsHide+"')";

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, sqlText) > 0;
        }

        /// <summary>
        /// 获取分页列表
        /// </summary>
        /// <param name="currentPageIndex">当前页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <returns>集合</returns>
        public List<MessageInfo> ListByPage(int currentPageIndex, int pageSize)
        {
            List<MessageInfo> messages = new List<MessageInfo>();
            
            int rowBegin = 10 * currentPageIndex;                        // 开始行数，表示每页第一条记录在数据库中的行数

            StringBuilder sqlText = new StringBuilder();
            sqlText.AppendLine("select top 10 *  from TBL_MESSAGE ");
            sqlText.AppendLine(string.Format("where id not in(select top {0} id from TBL_MESSAGE order by id desc) ", rowBegin));
            sqlText.Append("order by id desc");

            SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, sqlText);
            while (dr.Read())
            {
                MessageInfo mess = new MessageInfo();
                mess.Id = Convert.ToInt32(dr["id"]);
                mess.Message = Convert.ToString(dr["message"]);
                mess.Author = Convert.ToString(dr["author"]);
                mess.PostTime = Convert.ToDateTime(dr["postTime"]);
                mess.Email = dr["email"] == DBNull.Value ? string.Empty : dr["email"].ToString();
                mess.WebSite = dr["webSite"] == DBNull.Value ? string.Empty : dr["webSite"].ToString();
                mess.UserIp = dr["userIp"] == DBNull.Value ? string.Empty : dr["userIp"].ToString();
                mess.FaceUrl = dr["faceUrl"] == DBNull.Value ? string.Empty : dr["faceUrl"].ToString();
                mess.PicUrl = dr["picUrl"] == DBNull.Value ? string.Empty : dr["picUrl"].ToString();
                mess.IsHide = dr["isHide"] == DBNull.Value ? false : Convert.ToBoolean(dr["isHide"]);

                messages.Add(mess);
              }
            return messages;
        }

        /// <summary>
        /// 获取分页列表
        /// </summary>
        /// <param name="currentPageIndex">当前页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="IsHide">是否悄悄话</param>
        /// <returns>集合</returns>
        public IList<MessageInfo> ListByPage(int currentPageIndex, int pageSize, bool IsHide)
        {
            IList<MessageInfo> messages = new List<MessageInfo>();
            
                int rowBegin = 10 * currentPageIndex;                        // 开始行数，表示每页第一条记录在数据库中的行数

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select top 10 *  from TBL_MESSAGE ");
                sql.AppendLine(string.Format("where id not in(select top {0} id from TBL_MESSAGE where isHide=" + Convert.ToInt32(IsHide) + " order by id desc) ", rowBegin));
                sql.Append("and isHide=" + Convert.ToInt32(IsHide) + " order by id desc");

                SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,sql);
                
                while (dr.Read())
                {
                    MessageInfo mess = new MessageInfo();
                    mess.Id = Convert.ToInt32(dr["id"]);
                    mess.Message = Convert.ToString(dr["message"]);
                    mess.Author = Convert.ToString(dr["author"]);
                    mess.PostTime = Convert.ToDateTime(dr["postTime"]);
                    mess.Email = dr["email"] == DBNull.Value ? string.Empty : dr["email"].ToString();
                    mess.WebSite = dr["webSite"] == DBNull.Value ? string.Empty : dr["webSite"].ToString();
                    mess.UserIp = dr["userIp"] == DBNull.Value ? string.Empty : dr["userIp"].ToString();
                    mess.FaceUrl = dr["faceUrl"] == DBNull.Value ? string.Empty : dr["faceUrl"].ToString();
                    mess.PicUrl = dr["picUrl"] == DBNull.Value ? string.Empty : dr["picUrl"].ToString();
                    mess.IsHide = dr["isHide"] == DBNull.Value ? false : Convert.ToBoolean(dr["isHide"]);

                    messages.Add(mess);
                }
                return messages;
            }
            

        /// <summary>
        /// 删除留言
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteMessage(int id)
        {
            string sql = "DELETE FROM TBL_MESSAGE WHERE id=" + id;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, sql) > 0;
            
        }
    }
}
