using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSet.Models;
using System.Data;
using System.Data.SqlClient;

namespace BookSet.DAL
{
  public class Manager
    {

      private string _connectString = System.Configuration.ConfigurationManager.ConnectionStrings["BookNet"].ConnectionString;
      public IList<Managers> GetManger(int pageSize,int pageindex) 
      {
         IList<Managers> messages = new List<Managers>();
        using (SqlConnection conn = new SqlConnection(_connectString))
        {
            conn.Open();
            int rowBegin = 10 * pageindex;                        // 开始行数，表示每页第一条记录在数据库中的行数

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select top 10 *  from Comments ");
          ///  sql.AppendLine(string.Format("where id not in(select top {0} id from Comments order by id desc) ", rowBegin));
            sql.Append("order by id desc");

            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            cmd.CommandType = CommandType.Text;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Managers mess = new Managers();
                    mess.UserId = dr["UserId"].ToString();
                    mess.Date =Convert.ToDateTime(dr["Date"].ToString());
                    mess.Content = dr["Content"].ToString();
                    mess.Isbn = dr["ISBN"].ToString();
                    mess.HeadPortrait = dr["PicUrl"].ToString();

                    messages.Add(mess);
                }
            }
        }
        return messages;
      }
    }
}
