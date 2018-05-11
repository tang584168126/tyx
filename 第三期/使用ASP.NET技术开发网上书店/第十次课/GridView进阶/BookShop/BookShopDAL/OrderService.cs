using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookShop.DAL
{
    public class OrderService
    {
        //根据编号删除书籍订单信息
        public bool DeleteOrderBookById(int id)
        {
            string sql = "delete OrderBook where BookID = @BookID";
            SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@BookID", id)
				};

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) > 0;
        }
    }
}