using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

using MySchoolDAL;

namespace MySchoolTool
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Public_Helper
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法

        #region 绑定下拉菜单
        /// <summary>
        /// 绑定下拉菜单
        /// </summary>
        /// <param name="cmbBox">下拉菜单列表</param>
        /// <param name="strValue">值列</param>
        /// <param name="strText">文本列</param>
        /// <param name="strTable">表名</param>
        public static void BindDropDownList(ComboBox cmbBox, string strValue, string strText, string strTable)
        {
            try
            {
                //创建SQL命令
                StringBuilder objBuilder = new StringBuilder();
                objBuilder.AppendFormat(" select {0} as Value,{1} as Text", strValue, strText);
                objBuilder.AppendFormat(" from {0}", strTable);

                //获取DataSet
                DataSet objDS = Sql_Helper.GetDataSet(objBuilder.ToString());

                //绑定下拉菜单
                cmbBox.DataSource = objDS.Tables[0];
                cmbBox.ValueMember = "Value";
                cmbBox.DisplayMember = "Text";
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
        }

        /// <summary>
        /// 绑定下拉菜单
        /// </summary>
        /// <param name="cmbBox">下拉菜单列表</param>
        /// <param name="strValue">值列</param>
        /// <param name="strText">文本列</param>
        /// <param name="strTable">表名</param>
        /// <param name="strChoose">请选择</param>
        public static void BindDropDownList(ComboBox cmbBox, string strValue, string strText, string strTable, string strChoose)
        {
            try
            {
                //创建SQL命令
                StringBuilder objBuilder = new StringBuilder();
                objBuilder.AppendFormat(" select {0} as Value,{1} as Text", strValue, strText);
                objBuilder.AppendFormat(" from {0}", strTable);

                //获取DataSet
                DataSet objDS = Sql_Helper.GetDataSet(objBuilder.ToString());

                if (!string.IsNullOrEmpty(strChoose))
                {
                    DataRow objDR = objDS.Tables[0].NewRow();
                    objDR["Value"] = "-1";
                    objDR["Text"] = strChoose;

                    objDS.Tables[0].Rows.InsertAt(objDR, 0);
                }

                //绑定下拉菜单
                cmbBox.DataSource = objDS.Tables[0];
                cmbBox.ValueMember = "Value";
                cmbBox.DisplayMember = "Text";
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
        }

        /// <summary>
        /// 绑定下拉菜单
        /// </summary>
        /// <param name="cmbBox">下拉菜单列表</param>
        /// <param name="strValue">值列</param>
        /// <param name="strText">文本列</param>
        /// <param name="strTable">表名</param>
        /// <param name="strCondition">查询条件</param>
        /// <param name="strChoose">请选择</param>
        public static void BindDropDownList(ComboBox cmbBox, string strValue, string strText, string strTable, string strCondition, string strChoose)
        {
            try
            {
                //创建SQL命令
                StringBuilder objBuilder = new StringBuilder();
                objBuilder.AppendFormat(" select {0} as Value,{1} as Text", strValue, strText);
                objBuilder.AppendFormat(" from {0}", strTable);

                if (!string.IsNullOrEmpty(strCondition))
                {
                    objBuilder.AppendFormat(strCondition);
                }

                //获取DataSet
                DataSet objDS = Sql_Helper.GetDataSet(objBuilder.ToString());

                if (!string.IsNullOrEmpty(strChoose))
                {
                    DataRow objDR = objDS.Tables[0].NewRow();
                    objDR["Value"] = "-1";
                    objDR["Text"] = strChoose;

                    objDS.Tables[0].Rows.InsertAt(objDR, 0);
                }

                //绑定下拉菜单
                cmbBox.DataSource = objDS.Tables[0];
                cmbBox.ValueMember = "Value";
                cmbBox.DisplayMember = "Text";
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
        }
        #endregion

        #region 检查数据是否已存在
        /// <summary>
        /// 检查数据是否已存在
        /// </summary>
        /// <param name="strColumn">列名</param>
        /// <param name="strTable">表名</param>
        /// <param name="strValue">值</param>
        /// <returns>数据是否已存在(true:已存在 false:未存在)</returns>
        public static bool CheckData(string strColumn, string strTable, string strValue)
        {
            bool result = false;

            try
            {
                //SQL命令
                string sqlText = string.Format(" select * from {0} where {1} = '{2}'", strTable, strColumn, strValue);

                //获取DataSet
                DataSet objDS = Sql_Helper.GetDataSet(sqlText);

                //判断DataSet中是否有值
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    //有值
                    result = true;
                }
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }

            return result;
        }
        #endregion

        #region 使用ID值查询Name值

        #endregion

        #endregion
    }
}
