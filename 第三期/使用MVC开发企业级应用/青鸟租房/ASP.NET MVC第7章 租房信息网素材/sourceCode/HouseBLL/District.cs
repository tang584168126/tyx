using System;
using System.Data;
using System.Collections.Generic;
using bdqn.houses.DAL;
using bdqn.houses.Model;
namespace bdqn.houses.BLL
{
	/// <summary>
	/// District
	/// </summary>
	public partial class DistrictManager
	{
        private readonly bdqn.houses.DAL.DistrictService dal = new bdqn.houses.DAL.DistrictService();
        public DistrictManager()
		{}
		#region  Method

        public List<District> GetAll()
        {
            return dal.GetList();
        }

		#endregion  Method
	}
}

