using System;
using System.Data;
using System.Collections.Generic;
using bdqn.houses.DAL;
using bdqn.houses.Model;
namespace bdqn.houses.BLL
{
	/// <summary>
	/// HouseType
	/// </summary>
	public partial class HouseTypeManager
	{
        private readonly bdqn.houses.DAL.HouseTypeService dal = new bdqn.houses.DAL.HouseTypeService();
        public HouseTypeManager()
		{}
		#region  Method
        public List<HouseType> GetAll()
        {
            return dal.GetList();
        }

		#endregion  Method
	}
}

