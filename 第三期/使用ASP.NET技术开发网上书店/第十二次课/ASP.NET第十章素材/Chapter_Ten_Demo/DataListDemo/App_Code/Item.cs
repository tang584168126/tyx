using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Item
{
    public int ItemId { get; set; }

    public string ImagePath { get; set; }

    public string ItemName { get; set; }

    /// <summary>
    /// 卖家
    /// </summary>
    public string Saler { get; set; }

    public string Telephone { get; set; }

    public decimal Price { get; set; }

    /// <summary>
    /// 商品类型编号
    /// </summary>
    public int CategoryId { get; set; }
}
