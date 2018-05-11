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
  public  class UserRoleService
    {
      public UserRole GetRoleId(int id) 
      {
          string sqltext = "select * from UserRoles where Id = @Id";
          UserRole role = null;
          using(SqlDataReader reder=SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text,sqltext,new SqlParameter("@Id",id)))
          {
          if(reder.Read())
          {
              role = new UserRole();
              role.Id =(int)reder["Id"];
              role.Name = (string)reder["Name"];
          }
          }
          return role;
      }
    }
}
