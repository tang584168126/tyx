using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace SearchAmountOfService
{
    /// <summary>
    /// ProductsAmountService 的摘要说明
    /// </summary> 特性
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class ProductsAmountService : System.Web.Services.WebService
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["BooksInformation"].ConnectionString;

        /// <summary>
        /// 通过书籍名称模糊查询书籍信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet ExecuteDatasetByID(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                string sql = @" SELECT  ProductAmount.Amount AS '库存（本）',";
                sql += @" Product.Name AS '书名', Product.Category AS '类别',";
                sql += @" Product.Price AS '价格', Product.PublishDate AS '出版日期',";
                sql += @" Product.PublishHouse AS '出版社', Product.Author AS '作者'";
                sql += @" FROM  Product  INNER JOIN  ProductAmount  ON";
                sql += @" Product.ID = ProductAmount.ID";
                //如果参数 name 不为空则以此为条件查询，如果为空则查询全部
                if (!string.IsNullOrEmpty(name))
                {
                    //模糊查询
                    sql += @" WHERE (Product.Name LIKE @Name )";
                    SqlParameter[] para = new SqlParameter[]
                    {
                        new SqlParameter("@Name", "%" +name +"%")
                    };
                    cmd.Parameters.Add(para[0]);
                }
                cmd.CommandText = sql;
                cmd.Connection = connection;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }
    }
}
