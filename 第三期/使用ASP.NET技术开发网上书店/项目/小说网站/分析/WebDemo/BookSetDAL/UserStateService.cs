using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BookSet.Models;

namespace BookSet.DAL
{
   public class UserStateService
    {

       public UserState GetUserStateById(int id) 
       {
           string sqltext = "select * from UserStates where Id = @Id";
           SqlParameter para = new SqlParameter("@Id",id);

           UserState userState = null;
           return null;
       }
    }
}
