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
    /// 科目业务逻辑类
    /// </summary>
    public class SubjectBLL
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 获取科目列表
        /// </summary>
        /// <param name="objSubEnity">科目实体类对象</param>
        /// <returns>科目信息列表</returns>
        public List<SubjectEntity> GetSubList(SubjectEntity objSubEnity)
        {
            List<SubjectEntity> objSubList = new List<SubjectEntity>();

            try
            {
                objSubList = new SubjectServer().GetSubList(objSubEnity);
            }
            catch(Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
            return objSubList;
        }
        #endregion
    }
}
