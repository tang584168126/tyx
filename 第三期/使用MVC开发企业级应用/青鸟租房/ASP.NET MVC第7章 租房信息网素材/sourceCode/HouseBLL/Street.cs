using System;
using System.Data;
using System.Collections.Generic;
using bdqn.houses.DAL;
using bdqn.houses.Model;
namespace bdqn.houses.BLL
{
	/// <summary>
	/// Street
	/// </summary>
	public partial class StreetManager
	{
        private readonly bdqn.houses.DAL.StreetService dal = new bdqn.houses.DAL.StreetService();
        public StreetManager()
		{}
		#region  Method
        public List<Street> GetAll()
        {
            return dal.GetList();
        }

        public List<Street> GetList(int distinctId)
        {
            return dal.GetList(distinctId);
        }

		#endregion  Method
	}
}

