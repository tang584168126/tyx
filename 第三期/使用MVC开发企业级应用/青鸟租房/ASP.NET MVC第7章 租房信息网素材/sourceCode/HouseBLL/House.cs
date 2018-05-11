using System;
using System.Data;
using System.Collections.Generic;
using bdqn.houses.DAL;
using bdqn.houses.Model;
namespace bdqn.houses.BLL
{
    /// <summary>
    /// House
    /// </summary>
    public partial class HouseManager
    {
        private readonly bdqn.houses.DAL.HouseService dal = new bdqn.houses.DAL.HouseService();
        public HouseManager()
        { }
        #region  Method

        public List<House> GetAll()
        {
            return dal.GetList();
        }

        public House GetHouse(int houseId)
        {
            return dal.GetModel(houseId);
            
        }

        public bool Add(House house)
        {
            return dal.Add(house) > 0;
        }

        public bool Update(House house)
        {
            return dal.Update(house);
        }

        public bool Delete(int houseId)
        {
            return dal.Delete(houseId);
        }
        #endregion
    }
}