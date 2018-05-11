using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _06_TreeViewByRecursion
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        DataSet ds = null;
        List<SysFunction> list = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            ////从数据库提取数据
            //this.GetDataByTable();
            ////将提取的数据来创建节点，然后将节点添加到TreeView中
            //InitTreeByTable(this.tvNav.Nodes, "0");

            GetDataByList();
            InitTreeByList(this.tvNav.Nodes, "0");
        }

        #region 通过DataSet为TreeView绑定数据
        /// <summary>
        /// 从数据库提取数据
        /// </summary>
        public void GetDataByTable()
        {
            string sqlText = "select * from SysFunction";
            ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }

        /// <summary>
        /// 为节点ParentNode添加子节点
        /// </summary>
        /// <param name="tnc"></param>
        /// <param name="parentId"></param>
        public void InitTreeByTable(TreeNodeCollection tnc, string parentId)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = "ParentNodeId = " + parentId;

            TreeNode tnNode = null;

            foreach (DataRowView drv in dv)
            {
                tnNode = new TreeNode();
                tnNode.Value = drv["NodeId"].ToString();
                tnNode.Text = drv["DisplayName"].ToString();
                tnNode.NavigateUrl = drv["NavigateURL"].ToString();

                tnc.Add(tnNode);

                InitTreeByTable(tnNode.ChildNodes, tnNode.Value);
            }
        }
        #endregion

        #region 通过List为TreeView绑定数据
        public void GetDataByList()
        {
            list = new List<SysFunction>();

            string sqlText = "select * from SysFunction";
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                SysFunction item = new SysFunction();
                item.NodeId = Convert.ToInt64(row["NodeId"]);
                item.DisplayName = row["DisplayName"].ToString();
                item.NavigateURL = row["NavigateURL"].ToString();
                item.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                item.ParentNodeId = Convert.ToInt64(row["ParentNodeId"]);

                list.Add(item);
            }
        }

        public void InitTreeByList(TreeNodeCollection tnc, string parentId)
        {
            TreeNode tnNode = null;
            foreach (SysFunction item in list)
            {
                if (item.ParentNodeId.ToString().Equals(parentId))
                {
                    tnNode = new TreeNode();
                    tnNode.Value = item.NodeId.ToString();
                    tnNode.Text = item.DisplayName;
                    tnNode.NavigateUrl = item.NavigateURL;

                    tnc.Add(tnNode);

                    InitTreeByList(tnNode.ChildNodes, tnNode.Value);
                }
            }
        }
        #endregion
    }
}