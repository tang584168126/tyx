using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class ItemService
{
    private const string sqlStr = "select * from item";

    public IList<Item> GetItems()
    {
        IList<Item> items = new List<Item>();

        string sqlText = "select * from item order by itemId";
        SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, null);
        while (dr.Read())
        {
            Item item = new Item();
            item.ItemId = Int32.Parse(dr["itemID"].ToString());
            item.ImagePath = dr["imagePath"].ToString().Replace("~/", "");
            item.ItemName = dr["itemName"].ToString();
            item.Saler = dr["saler"].ToString();
            item.Telephone = dr["telephone"].ToString();
            item.Price = Convert.ToDecimal(dr["price"]);
            items.Add(item);
        }
        dr.Close();

        return items;
    }

    public IList<Item> GetItems(string sortField)
    {
        IList<Item> items = new List<Item>();

        string sqlText = "select * from item order by " + sortField;
        SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        while (dr.Read())
        {
            Item item = new Item();
            item.ItemId = Int32.Parse(dr["itemID"].ToString());
            item.ImagePath = dr["imagePath"].ToString().Replace("~/", "");
            item.ItemName = dr["itemName"].ToString();
            item.Saler = dr["saler"].ToString();
            item.Telephone = dr["telephone"].ToString();
            item.Price = Convert.ToDecimal(dr["price"]);
            items.Add(item);
        }
        dr.Close();

        return items;
    }

    public IList<Item> GetItems(int pageSize, int pageIndex)
    {
        IList<Item> items = new List<Item>();
        string key = "itemId";
        string sortField = "itemId";

        SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, "proc_divPage", sqlStr, pageSize, pageIndex, key, sortField);

        while (dr.Read())
        {
            Item item = new Item();
            item.ItemId = Int32.Parse(dr["itemId"].ToString());
            item.ImagePath = dr["imagePath"].ToString().Replace("~/", "");
            item.ItemName = dr["itemName"].ToString();
            item.Saler = dr["saler"].ToString();
            item.Telephone = dr["telephone"].ToString();
            item.Price = Convert.ToDecimal(dr["price"]);
            items.Add(item);
        }
        dr.Close();

        return items;
    }

    public IList<Item> GetItems(int pageSize, int pageIndex, string sortField)
    {
        IList<Item> items = new List<Item>();
        string key = "itemId";

        SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, "proc_divPage", sqlStr, pageSize, pageIndex, key, sortField);        

        while(dr.Read())
        {
            Item item = new Item();
            item.ItemId = Int32.Parse(dr["itemId"].ToString());
            item.ImagePath = dr["imagePath"].ToString().Replace("~/", "");
            item.ItemName = dr["itemName"].ToString();
            item.Saler = dr["saler"].ToString();
            item.Telephone = dr["telephone"].ToString();
            item.Price = Convert.ToDecimal(dr["price"]);
            items.Add(item);
        }
        dr.Close();

        return items;
    }

    //获取总记录数
    public int GetItemCount()
    {
        string sqlText = "select count(1) from item";

        try
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, sqlText));
        }
        catch
        {

            return -1;
        }
    }

    public void DeleteItem(int itemId)
    {
        string sqlText = "delete from [item] where itemId=@itemId";
        SqlParameter para = new SqlParameter("@itemId",itemId);

        try
        {
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText, para);
        }
        catch
        {            
            throw;
        }
    }
}
