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
    /// 成绩数据交互类
    /// </summary>
    public class ResultServer
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
            List<ResultBusinessEntity> objResBusiList=new List<ResultBusinessEntity>();

            try
            {
                //SQL命令
                string sqlText = " select a.StudentNo,b.StudentName,a.SubjectNo,c.SubjectName,a.ExamDate,a.StudentResult"
                               + " from Result as a"
                               + " left join Student as b on a.StudentNo = b.StudentNo"
                               + " left join Subject as c on a.SubjectNo = c.SubjectNo"
                               + " where 1 = 1";
                if (!string.IsNullOrEmpty(objResBusiEntity.StuName))
                {
                    sqlText += " and b.StudentName like @StuName";
                }
                if (!string.IsNullOrEmpty(objResBusiEntity.SubName))
                {
                    sqlText += " and c.SubjectName like @SubName";
                }
                if (objResBusiEntity.StudentResult >= 0)
                {
                    sqlText += " and a.StudentResult = @StudentResult";
                }

                //SQL参数
                SqlParameter[] paras = new SqlParameter[3];
                paras[0] = new SqlParameter("@StuName", SqlDbType.NVarChar);
                paras[0].Value = "%" + objResBusiEntity.StuName + "%";
                paras[1] = new SqlParameter("@SubName", SqlDbType.NVarChar);
                paras[1].Value = "%" + objResBusiEntity.SubName + "%";
                paras[2] = new SqlParameter("@StudentResult", SqlDbType.Decimal);
                paras[2].Value = objResBusiEntity.StudentResult;

                //获取数据集
                DataSet objDS = Sql_Helper.GetDataSet(sqlText, paras);

                //获取成绩列表
                for (int i = 0; i < objDS.Tables[0].Rows.Count; i++)
                {
                    ResultBusinessEntity objResBusiEntityTemp = new ResultBusinessEntity();

                    objResBusiEntityTemp.StudentNo = int.Parse(objDS.Tables[0].Rows[i]["StudentNo"].ToString());
                    objResBusiEntityTemp.StuName = objDS.Tables[0].Rows[i]["StudentName"].ToString();
                    objResBusiEntityTemp.SubjectNo = int.Parse(objDS.Tables[0].Rows[i]["SubjectNo"].ToString());
                    objResBusiEntityTemp.SubName = objDS.Tables[0].Rows[i]["SubjectName"].ToString();
                    objResBusiEntityTemp.ExamDate = Convert.ToDateTime(objDS.Tables[0].Rows[i]["ExamDate"].ToString());
                    objResBusiEntityTemp.StudentResult = Convert.ToDecimal(objDS.Tables[0].Rows[i]["StudentResult"].ToString());

                    objResBusiList.Add(objResBusiEntityTemp);
                }
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
