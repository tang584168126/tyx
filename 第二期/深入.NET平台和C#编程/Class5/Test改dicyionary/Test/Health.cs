using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    /// <summary>
    /// 体检套餐类
    /// </summary>
    public partial class Health
    {

        #region 字段
        //名字
        private string name;

        //体检项目列表
        private Dictionary<string, HealthItem> itemDic = new Dictionary<string, HealthItem>();

        #endregion

        #region 属性
        //名称
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //检查项目列表
        public Dictionary<string, HealthItem> ItemDic
        {
            get { return itemDic; }
            set { itemDic = value; }
        }
        #endregion

        #region 方法

        #endregion

    }
}
