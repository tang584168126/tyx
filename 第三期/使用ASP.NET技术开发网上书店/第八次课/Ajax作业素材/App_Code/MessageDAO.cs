using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

/// <summary>
///MessageDAO 的摘要说明
/// </summary>
public class MessageDAO
{
    private string _connectString = System.Configuration.ConfigurationManager.ConnectionStrings["messageBoardConnectionString"].ConnectionString;
    public MessageDAO()
    {

    }
    public bool AddMessage(MessageInfo mess)
    {
        string sql =
                 "INSERT TBL_MESSAGE (message, author, postTime, email, webSite, userIp, faceUrl, picUrl, isHide)" +
                 "VALUES (@message, @author, @postTime, @email, @webSite, @userIp, @faceUrl, @picUrl, @isHide)";
        SqlParameter[] values = new SqlParameter[]
				{
					new SqlParameter("@message", mess.Message ), 
					new SqlParameter("@author", mess.Author ), 
					new SqlParameter("@postTime", mess.PostTime ),
					new SqlParameter("@email", mess.Email ),
					new SqlParameter("@webSite", mess.WebSite ),
					new SqlParameter("@userIp", mess.UserIp ),
					new SqlParameter("@faceUrl", mess.FaceUrl ),
					new SqlParameter("@picUrl", mess.PicUrl ),
					new SqlParameter("@isHide", mess.IsHide )
				};
        using (SqlConnection conn = new SqlConnection(_connectString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery() > 0;
        }
    }


    /// <summary>
    /// 获取分页列表
    /// </summary>
    /// <param name="currentPageIndex">当前页索引</param>
    /// <param name="pageSize">页大小</param>
    /// <returns>集合</returns>
    public IList<MessageInfo> ListByPage(int currentPageIndex, int pageSize)
    {
        IList<MessageInfo> messages = new List<MessageInfo>();
        using (SqlConnection conn = new SqlConnection(_connectString))
        {
            conn.Open();
            int rowBegin = 10 * currentPageIndex;                        // 开始行数，表示每页第一条记录在数据库中的行数

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select top 10 *  from TBL_MESSAGE ");
            sql.AppendLine(string.Format("where id not in(select top {0} id from TBL_MESSAGE order by id desc) ", rowBegin));
            sql.Append("order by id desc");

            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.CommandType = CommandType.Text;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    MessageInfo mess = new MessageInfo();
                    mess.Id = Convert.ToInt32(dr["id"]);
                    mess.Message = Convert.ToString(dr["message"]);
                    mess.Author = Convert.ToString(dr["author"]);
                    mess.PostTime = Convert.ToString(dr["postTime"]);
                    mess.Email = dr["email"] == DBNull.Value ? string.Empty : dr["email"].ToString();
                    mess.WebSite = dr["webSite"] == DBNull.Value ? string.Empty : dr["webSite"].ToString();
                    mess.UserIp = dr["userIp"] == DBNull.Value ? string.Empty : dr["userIp"].ToString();
                    mess.FaceUrl = dr["faceUrl"] == DBNull.Value ? string.Empty : dr["faceUrl"].ToString();
                    mess.PicUrl = dr["picUrl"] == DBNull.Value ? string.Empty : dr["picUrl"].ToString();
                    mess.IsHide = dr["isHide"] == DBNull.Value ? false : Convert.ToBoolean(dr["isHide"]);

                    messages.Add(mess);
                }
            }
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
        using (SqlConnection conn = new SqlConnection(_connectString))
        {
            conn.Open();
            int rowBegin = 10 * currentPageIndex;                        // 开始行数，表示每页第一条记录在数据库中的行数

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select top 10 *  from TBL_MESSAGE ");
            sql.AppendLine(string.Format("where id not in(select top {0} id from TBL_MESSAGE where isHide=" + Convert.ToInt32(IsHide) + " order by id desc) ", rowBegin));
            sql.Append("and isHide=" + Convert.ToInt32(IsHide) + " order by id desc");

            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.CommandType = CommandType.Text;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    MessageInfo mess = new MessageInfo();
                    mess.Id = Convert.ToInt32(dr["id"]);
                    mess.Message = Convert.ToString(dr["message"]);
                    mess.Author = Convert.ToString(dr["author"]);
                    mess.PostTime = Convert.ToString(dr["postTime"]);
                    mess.Email = dr["email"] == DBNull.Value ? string.Empty : dr["email"].ToString();
                    mess.WebSite = dr["webSite"] == DBNull.Value ? string.Empty : dr["webSite"].ToString();
                    mess.UserIp = dr["userIp"] == DBNull.Value ? string.Empty : dr["userIp"].ToString();
                    mess.FaceUrl = dr["faceUrl"] == DBNull.Value ? string.Empty : dr["faceUrl"].ToString();
                    mess.PicUrl = dr["picUrl"] == DBNull.Value ? string.Empty : dr["picUrl"].ToString();
                    mess.IsHide = dr["isHide"] == DBNull.Value ? false : Convert.ToBoolean(dr["isHide"]);

                    messages.Add(mess);
                }
            }
        }
        return messages;
    }


    /// <summary>
    /// 验证登录
    /// </summary>
    /// <param name="adminName">用户名</param>
    /// <param name="password">密码</param>
    /// <returns>true 登录成功；false,登录失败</returns>
    public bool AdminLogin(string adminName, string password)
    {
        string sql = "SELECT COUNT(0) FROM TBL_ADMIN WHERE adminName=@adminName AND password=@password";
        SqlParameter[] values = new SqlParameter[]
				{
					new SqlParameter("@adminName", adminName), 
					new SqlParameter("@password", password)
                };
        using (SqlConnection conn = new SqlConnection(_connectString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(values);
            object result = cmd.ExecuteScalar();
            if (Convert.ToInt32(result) == 1)
                return true;
        }
        return false;
    }

    /// <summary>
    /// 删除留言
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool DeleteMessage(int id)
    {
        string sql = "DELETE FROM TBL_MESSAGE WHERE id=" + id;
        using (SqlConnection conn = new SqlConnection(_connectString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery() > 0;

        }
    }
}
