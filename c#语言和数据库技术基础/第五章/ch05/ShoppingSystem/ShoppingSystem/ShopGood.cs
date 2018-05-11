using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    /// <summary>
    /// 超市商品信息类
    /// </summary>
    public class ShopGood
    {
        #region 字段
        //编号
        private string goodNO;

        //商品名称
        private string goodName;

        //商品单价
        private double goodPrice;

        //商品单位
        private string goodDesc;

        //商品数量
        private int goodNum;
        #endregion

        #region 属性
        public string GoodNO
        {
            get { return goodNO; }
            set { goodNO = value; }
        }

        public string GoodName
        {
            get { return goodName; }
            set { goodName = value; }
        }

        public double GoodPrice
        {
            get { return goodPrice; }
            set { goodPrice = value; }
        }

        public string GoodDesc
        {
            get { return goodDesc; }
            set { goodDesc = value; }
        }

        public int GoodNum
        {
            get { return goodNum; }
            set { goodNum = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
