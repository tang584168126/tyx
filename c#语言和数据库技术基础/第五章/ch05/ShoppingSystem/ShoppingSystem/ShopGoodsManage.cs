using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    /// <summary>
    /// 超市商品管理类
    /// </summary>
    public class ShopGoodsManage
    {
        #region 字段
        //超市商品列表
        private ShopGood[] shopGoodList = new ShopGood[1000];
        #endregion

        #region 属性
        //超市商品列表
        public ShopGood[] ShopGoodList
        {
            get { return shopGoodList; }
            set { shopGoodList = value; }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 新增商品
        /// </summary>
        public void InsertGood()
        {
            #region 设置变量
            //商品编号
            string strGoodNO = string.Empty;

            //商品名称
            string strGoodName = string.Empty;

            //商品单价
            double dbGoodPrice = 0;

            //商品单位
            string strGoodDesc = string.Empty;

            //商品数量
            int intGoodNum = 0;

            //设置可操作的对象数组元素下标，-1不可操作
            int index = -1;

            Console.Write("请输入商品编号:");
            strGoodNO = Console.ReadLine();

            Console.Write("请输入商品名称:");
            strGoodName = Console.ReadLine();

            Console.Write("请输入商品单价:");
            dbGoodPrice = double.Parse(Console.ReadLine());

            Console.Write("请输入商品单位:");
            strGoodDesc = Console.ReadLine();

            Console.Write("请输入商品数量:");
            intGoodNum = int.Parse(Console.ReadLine());
            #endregion

            #region 数据验证
            for (int i = 0; i < this.shopGoodList.Length; i++)
            {
                //数组元素不为空
                if (this.shopGoodList[i] != null)
                {
                    if (this.shopGoodList[i].GoodNO.Equals(strGoodNO) || this.shopGoodList[i].GoodName.Equals(strGoodName))
                    {
                        Console.WriteLine("该商品已存在,无法新增!");

                        return;
                    }
                }
            }
            #endregion

            #region 新增操作
            for (int i = 0; i < this.shopGoodList.Length; i++)
            {
                //判断数组元素是否为空
                if (this.shopGoodList[i] == null)
                {
                    //记录数组下标
                    index = i;

                    //结束操作
                    break;
                }
            }

            //判断数组元素是否可以操作
            if (index != -1)
            {
                //创建信息类对象
                ShopGood objShopGood = new ShopGood();

                //新增操作
                objShopGood.GoodNO = strGoodNO;
                objShopGood.GoodName = strGoodName;
                objShopGood.GoodPrice = dbGoodPrice;
                objShopGood.GoodDesc = strGoodDesc;
                objShopGood.GoodNum = intGoodNum;

                //放入数组元素
                this.shopGoodList[index] = objShopGood;

                Console.WriteLine("新增商品成功!");
            }
            else
            {
                Console.WriteLine("商品已满,无法新增!");
            }
            #endregion
        }

        /// <summary>
        /// 查询全部商品
        /// </summary>
        public void QueryGood()
        {
            //表头
            Console.WriteLine("商品编号\t商品名称\t商品单价\t商品单位\t商品数量");

            for (int i = 0; i < this.shopGoodList.Length; i++)
            {
                //判断数组元素是否为空
                if (this.shopGoodList[i] != null)
                {
                    Console.WriteLine(this.shopGoodList[i].GoodNO + "\t\t" + this.shopGoodList[i].GoodName + "\t\t" + this.shopGoodList[i].GoodPrice + "\t\t" + this.shopGoodList[i].GoodDesc + "\t\t" + this.shopGoodList[i].GoodNum);
                }
            }
        }

        /// <summary>
        /// 按编号查询商品
        /// </summary>
        public void QueryGoodByGoodNO()
        {
            #region 设置变量
            //商品编号
            string strGoodNO = string.Empty;

            Console.Write("请输入需要查询的商品编号:");
            strGoodNO = Console.ReadLine();
            #endregion

            //表头
            Console.WriteLine("商品编号\t商品名称\t商品单价\t商品单位\t商品数量");

            for (int i = 0; i < this.shopGoodList.Length; i++)
            {
                //判断数组元素是否为空
                if (this.shopGoodList[i] != null && this.shopGoodList[i].GoodNO.Equals(strGoodNO))
                {
                    Console.WriteLine(this.shopGoodList[i].GoodNO + "\t\t" + this.shopGoodList[i].GoodName + "\t\t" + this.shopGoodList[i].GoodPrice + "\t\t" + this.shopGoodList[i].GoodDesc + "\t\t" + this.shopGoodList[i].GoodNum);

                    break;
                }
            }
        }

        /// <summary>
        /// 商品入库
        /// </summary>
        public void PutInGood()
        {
            #region 设置变量
            //商品编号
            string strGoodNO = string.Empty;

            //入库数量
            int intGoodNum = 0;

            //设置可操作的对象数组元素下标，-1不可操作
            int index = -1;

            Console.Write("请输入商品编号:");
            strGoodNO = Console.ReadLine();

            Console.Write("请输入入库数量:");
            intGoodNum = int.Parse(Console.ReadLine());
            #endregion

            #region 入库操作
            for (int i = 0; i < this.shopGoodList.Length; i++)
            {
                //判断数组元素是否为空
                if (this.shopGoodList[i] != null && this.shopGoodList[i].GoodNO.Equals(strGoodNO))
                {
                    //记录下标
                    index = i;

                    //结束操作
                    break;
                }
            }

            //判断数组元素是否可以操作
            if (index != -1)
            {
                //修改操作
                this.shopGoodList[index].GoodNum = this.shopGoodList[index].GoodNum + intGoodNum;

                Console.WriteLine("入库成功!");
            }
            else
            {
                Console.WriteLine("未找到此编号商品,请确认后重新输入!");
            }
            #endregion
        }

        /// <summary>
        /// 商品出库
        /// </summary>
        public void OutPutGood()
        {
            #region 设置变量
            //商品编号
            string strGoodNO = string.Empty;

            //出库数量
            int intGoodNum = 0;

            //设置可操作的对象数组元素下标，-1不可操作
            int index = -1;

            Console.Write("请输入商品编号:");
            strGoodNO = Console.ReadLine();

            Console.Write("请输入出库数量:");
            intGoodNum = int.Parse(Console.ReadLine());
            #endregion

            #region 出库操作
            for (int i = 0; i < this.shopGoodList.Length; i++)
            {
                //判断数组元素是否为空
                if (this.shopGoodList[i] != null && this.shopGoodList[i].GoodNO.Equals(strGoodNO))
                {
                    //判断是否有足够数量出库
                    if (this.shopGoodList[i].GoodNum >= intGoodNum)
                    {
                        //记录下标
                        index = i;

                        //结束操作
                        break;
                    }
                    else
                    {
                        Console.WriteLine("库存数量不足,无法出库!");

                        return;
                    }
                }
            }

            //判断数组元素是否可以操作
            if (index != -1)
            {
                //修改操作
                this.shopGoodList[index].GoodNum = this.shopGoodList[index].GoodNum - intGoodNum;

                Console.WriteLine("出库成功!");
            }
            else
            {
                Console.WriteLine("未找到此编号商品,请确认后重新输入!");
            }
            #endregion
        }
        #endregion
    }
}
