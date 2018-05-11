using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// 体检明细类
    /// </summary>
    public class HealthItem
    {
        #region 字段
        //名称
        private string itemName;

        //描述
        private string itemDetail;

        //价格
        private double itemPrice;
        #endregion

        #region 属性
        //名称
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        //描述
        public string ItemDetail
        {
            get { return itemDetail; }
            set { itemDetail = value; }
        }

        //价格
        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
