using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySchoolDAL;
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
        public List<ResultBusinessEntity> GetResBusiEntity(ResultBusinessEntity objResBusiEntity)
        {
            List<ResultBusinessEntity> objResBusiList = new List<ResultBusinessEntity>();

            try
            {
                objResBusiList = new ResultServer
            }
            catch(Exception Exp)
            {
                throw new Exception(Exp.Message);
            }

            return objResBusiList;
        }
        #endregion
    }
}
