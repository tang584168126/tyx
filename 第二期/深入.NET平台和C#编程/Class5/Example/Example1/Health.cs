using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /// <summary>
    /// 体检套餐类
    /// </summary>
    public class Health
    {
        #region 字段
        //名字
        private string name;

        //体检明细列表
        private List<HealthItem> itemList = new List<HealthItem>();
        #endregion

        #region 属性
        //名字
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //体检明细列表
        public List<HealthItem> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        #endregion

        #region 方法

        #endregion
    }
}
