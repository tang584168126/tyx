using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using BookSet.Models;
using BookSet.DAL;
namespace BookSet.DAL
{
  public  class UserService
    {
      public User GetUserByLoginId(string loginId) 
      {
          string sqlText = "select * from Users where LoginId = @LoginId";
          SqlParameter para = new SqlParameter("@LoginId",loginId);

          User user = null;
          int userRoleId = 1;
          int userStateId = 1;
          using (SqlDataReader rader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text,sqlText,para))
          {
          if(rader.Read())
          {
              user = new User();
              user.LoginId = rader["LoginId"].ToString();
              user.LoginPwd = rader["LoginPwd"].ToString();
              user.Name = rader["Name"].ToString();
              user.Address = rader["Address"].ToString();
              user.Mail = rader["Mail"].ToString();
              user.Phone = rader["Phone"].ToString();

              userRoleId = Convert.ToInt32(rader["UserRoleId"]);
              userStateId = Convert.ToInt32(rader["UserStateId"]);

                
          }
          return user;
          }
      }
    }
}
