using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using MySchoolModel;

namespace MySchoolDAL.Server
{
    /// <summary>
    /// 科目数据交互类
    /// </summary>
    public class SubjectServer
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 获取科目信息列表
        /// </summary>
        /// <param name="objStuEntity">科目实体类对象</param>
        /// <returns>科目信息列表</returns>
        public List<SubjectEntity> GetSubList(SubjectEntity objSubEntity)
        {
            List<SubjectEntity> objSubList = new List<SubjectEntity>();

            try
            {
                //SQL命令
                string sqlText = " select SubjectNo,SubjectName,ClassHour,GradeId"
                               + " from Subject"
                               + " where 1 = 1";
                if (objSubEntity.GradeId != -1)
                {
                    sqlText += " and GradeId = @GradeId";
                }

                //SQL参数
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@GradeId", SqlDbType.Int);
                paras[0].Value = objSubEntity.GradeId;

                //获取DataSet
                DataSet objDS = Sql_Helper.GetDataSet(sqlText, paras);

                //获取科目信息列表
                for (int i = 0; i < objDS.Tables[0].Rows.Count; i++)
                {
                    //科目实体类对象
                    SubjectEntity objSubEntityTemp = new SubjectEntity();

                    objSubEntityTemp.SubjectNo = int.Parse(objDS.Tables[0].Rows[i]["SubjectNo"].ToString());
                    objSubEntityTemp.SubjectName = objDS.Tables[0].Rows[i]["SubjectName"].ToString();
                    objSubEntityTemp.ClassHour = int.Parse(objDS.Tables[0].Rows[i]["ClassHour"].ToString());
                    objSubEntityTemp.GradeId = int.Parse(objDS.Tables[0].Rows[i]["GradeId"].ToString());

                    //加入科目信息列表
                    objSubList.Add(objSubEntityTemp);
                }
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }

            return objSubList;
        }
        #endregion
    }
}
