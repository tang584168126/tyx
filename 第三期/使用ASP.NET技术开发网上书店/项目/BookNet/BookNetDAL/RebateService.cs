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
    public class RebateService
    {
        /// <summary>
        /// 添加折扣
        /// </summary>
        /// <returns></returns>
        public int AddRebate()
        {
            Rebate rebate = new Rebate();
            string sqlText = "Insert into [Rebates] (BookId,RebateNumber) values ({0},{1})" + rebate.Book.Id + "," + rebate.RebateNumber;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }

        /// <summary>
        /// 删除折扣
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRebate(int id)
        {
            string sqlText = "delete Rebate where Id = " + id;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }
    }
}
