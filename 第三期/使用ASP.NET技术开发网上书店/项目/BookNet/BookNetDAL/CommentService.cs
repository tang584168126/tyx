using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using BookNet.Models;

namespace BookNet.DAL
{
    public class CommentService
    {
        /// <summary>
        /// 新增评论
        /// </summary>
        /// <param name="comment">评论</param>
        /// <returns></returns>
        public int AddComment(Comment comment)
        {
            string sqlText = "Insert into [Comments] (Date,UserId,[Content]) values ('{0}',{1},{2})" + comment.Date + "," + comment.User.Id + "," + comment.Content;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }

        /// <summary>
        /// 根据评论编号获取评论对象
        /// </summary>
        /// <param name="id">评论编号</param>
        /// <returns>评论对象</returns>
        public Comment getCommentById(int id)
        {
            string sqlText = "select * from [Comments] where Id = " + id;

            Comment comment = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    comment = new Comment();
                    comment.Id = Convert.ToInt32(reader["Id"]);
                    comment.Date = Convert.ToDateTime(reader["Date"]);
                    comment.Content = reader["Content"].ToString();

                    comment.User.Id = Convert.ToInt32(reader["UserId"]);
                }
            }
            return comment;
        }
    }
}
