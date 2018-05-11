using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySchoolDAL.Server;
using MySchoolModel;

namespace MySchoolBLL
{
    /// <summary>
    /// 成绩业务类
    /// </summary>
    public class ResultBLL
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 获取成绩列表
        /// </summary>
        /// <param name="objResBusiEntity">成绩实体扩展类对象</param>
        /// <returns>成绩列表</returns>
        public List<ResultBusinessEntity> GetResBusiEntity(ResultBusinessEntity objResBusiEntity)
        {
            List<ResultBusinessEntity> objResBusiList = new List<ResultBusinessEntity>();

            try
            {
                objResBusiList = new ResultServer().GetResBusiEntity(objResBusiEntity);
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }

            return objResBusiList;
        }
        #endregion
    }
}
