
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
    
   public class UserSevice
    {
       /// <summary>
       /// 根据用户ID获取用户数据
       /// </summary>
       /// <returns></returns>
       public User CheckLogin(string UserId) 
       {
           string sqltext = "select * from Users where UserId=@UserId";
           User users = null;
           int UserRolet;
           using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text,sqltext, new SqlParameter("@UserId",UserId)))
           {
           if(reader.Read())
           {
               users = new User();
               users.Id=(int)reader["Id"];
               users.UserId = (string)reader["UserId"];
               users.Password = (string)reader["Password"];
               users.Name = (string)reader["Name"];
               users.Date = (DateTime)reader["Date"];
               users.Phone = (string)reader["Phone"];
               users.Address = (string)reader["Address"];
               users.Email = (string)reader["Email"];
               users.Integral = (int)reader["Integral"];
               UserRolet = (int)reader["UserRoleId"];
               users.HeadPortrait = (string)reader["HeadPortrait"];
              users.UserRole = new UserRoles().GetRoleId(UserRolet);
            }
           }
           return users;
       }
       /// <summary>
       /// 注册用户
       /// </summary>
       /// <param name="user">用户对象</param>
       /// <returns>true 添加成功！</returns>
       public bool AddUsr(User user) 
       {
           UserRole role=new UserRole();
           role.Id = 1;
           string sql = "INSERT Users(UserId, Password,Name,Date,Phone,Address,Email,Integral,UserRoleId,HeadPortrait)"+
               " VALUES(@UserId, @Password,@Name,@Date,@Phone,@Address,@Email,@Integral,@UserRoleId,@HeadPortrait)";
           sql += " ; SELECT @@IDENTITY";
           SqlParameter[] pares = new SqlParameter[]{
           new SqlParameter("@UserId",user.UserId),
           new SqlParameter("@Password",user.Password),
           new SqlParameter("@Name",user.Name),
           new SqlParameter("@Date",user.Date),
           new SqlParameter("@Phone",user.Phone),
           new SqlParameter("@Address",user.Address),
           new SqlParameter("@Email",user.Email),
           new SqlParameter("@Integral",user.Integral),
           new SqlParameter("@UserRoleId",role.Id),
           new SqlParameter("@HeadPortrait",user.HeadPortrait),
       };
           int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, pares);
           return result>0;
       }


    }
}
