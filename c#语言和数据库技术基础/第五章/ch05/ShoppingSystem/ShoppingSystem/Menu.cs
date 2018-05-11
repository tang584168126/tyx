using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    /// <summary>
    /// 操作界面类
    /// </summary>
    public class Menu
    {
        #region 字段
        //超市商品管理类对象
        private ShopGoodsManage objGoodsManage = new ShopGoodsManage();
        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 主界面
        /// </summary>
        public void ShowMenu()
        {
            #region 设置变量
            //操作选项
            string choose = string.Empty;

            //操作选项是否正确(true为正确,false为错误)
            bool isRight = true;
            #endregion

            #region 界面展示
            Console.WriteLine("********欢迎使用青鸟超市系统********");
            Console.WriteLine("1.登录");
            Console.WriteLine("2.退出");
            Console.Write("请选择你的操作:");

            do
            {
                //设置默认值为true
                isRight = true;

                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        //创建登录操作类对象
                        LoginServer objLogin = new LoginServer();

                        //初始化用户
                        objLogin.InitialUser();

                        //登录操作
                        string strType = objLogin.LoginSys();

                        if (strType.Equals("1"))
                        {
                            //库存管理界面
                            this.ShowStoreMenu();
                        }
                        else if (strType.Equals("2"))
                        {
                            //收银管理界面
                            this.ShowMoneyMenu();
                        }

                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("退出此系统,谢谢使用!");
                        break;
                    default:
                        //更改操作选项是否正确状态
                        isRight = false;

                        Console.Write("你的输入有错误，请重新输入:");
                        break;
                }

            } while (!isRight);

            
            #endregion
        }

        /// <summary>
        /// 库存管理界面
        /// </summary>
        private void ShowStoreMenu()
        {
            #region 设置变量
            //操作选项
            string choose = string.Empty;

            //操作选项是否正确
            bool isRight = true;

            //是否继续(y为继续，n为不继续)
            string answer = "y";
            #endregion

            while (answer.Equals("y"))
            {
                #region 库存界面
                Console.WriteLine();
                Console.WriteLine("********欢迎使用青鸟超市库存系统********");
                Console.WriteLine("1.新增商品");
                Console.WriteLine("2.查询全部商品\t\t3.按编号查询商品");
                Console.WriteLine("4.商品入库\t\t5.商品出库");
                Console.WriteLine("6.返回");
                Console.Write("请输入你的选择:");

                do
                {
                    //设置默认值
                    isRight = true;

                    choose = Console.ReadLine();

                    switch (choose)
                    {
                        case "1":
                            Console.WriteLine("青鸟超市库存系统 >> 新增商品");

                            this.objGoodsManage.InsertGood();
                            break;
                        case "2":
                            Console.WriteLine("青鸟超市库存系统 >> 查询全部商品");

                            this.objGoodsManage.QueryGood();
                            break;
                        case "3":
                            Console.WriteLine("青鸟超市库存系统 >> 按编号查询商品");

                            this.objGoodsManage.QueryGoodByGoodNO();
                            break;
                        case "4":
                            Console.WriteLine("青鸟超市库存系统 >> 商品入库");

                            this.objGoodsManage.PutInGood();
                            break;
                        case "5":
                            Console.WriteLine("青鸟超市库存系统 >> 商品出库");

                            this.objGoodsManage.OutPutGood();
                            break;
                        case "6":
                            answer = "n";

                            this.ShowMenu();

                            break;
                        default:
                            //更改操作选项是否正确
                            isRight = false;

                            Console.Write("你的输入有错误，请重新输入:");
                            break;
                    }

                } while (!isRight);
                #endregion
            }
        }

        /// <summary>
        /// 收银管理界面
        /// </summary>
        private void ShowMoneyMenu()
        {
            #region 设置变量
            //操作选项
            string choose = string.Empty;

            //操作选项是否正确
            bool isRight = true;

            //是否继续(y为继续，n为不继续)
            string answer = "y";
            #endregion

            while (answer.Equals("y"))
            {
                #region 收银界面
                Console.WriteLine();
                Console.WriteLine("********欢迎使用青鸟超市收银系统********");
                Console.WriteLine("1.扫描商品");
                Console.WriteLine("2.修改数量");
                Console.WriteLine("3.结账");
                Console.WriteLine("4.返回");
                Console.Write("请输入你的选择:");

                do
                {
                    //设置默认值
                    isRight = true;

                    choose = Console.ReadLine();

                    switch (choose)
                    {
                        case "1":
                            Console.WriteLine("青鸟超市收银系统 >> 扫描商品");
                            break;
                        case "2":
                            Console.WriteLine("青鸟超市收银系统 >> 修改数量");
                            break;
                        case "3":
                            Console.WriteLine("青鸟超市收银系统 >> 结账");
                            break;
                        case "4":
                            answer = "n";

                            this.ShowMenu();

                            break;
                        default:
                            //更改操作选项是否正确
                            isRight = false;

                            Console.Write("你的输入有错误，请重新输入:");
                            break;
                    }
                } while (!isRight);
                #endregion
            }
        }
        #endregion
    }
}
