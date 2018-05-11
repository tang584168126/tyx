using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRent.Model
{
    public class House
    {
        /// <summary>
        /// 房子编号
        /// </summary>
        public int HouseId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 房子类型
        /// </summary>
        public HouseType HouseType { get; set; }

        /// <summary>
        /// 楼层岁月
        /// </summary>
        public decimal Floorage { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        public Street Street { get; set; }

        /// <summary>
        /// 订约电话
        /// </summary>
        public string Contract { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User Users { get; set; }

        /// <summary>
        /// 公布时间
        /// </summary>
        public DateTime PublishTime { get; set; }
    }
}
