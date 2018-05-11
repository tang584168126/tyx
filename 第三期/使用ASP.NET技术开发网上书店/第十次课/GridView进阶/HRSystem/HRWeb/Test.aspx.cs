using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRWeb
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    HRDataBind();
                    this.gvHR.DataKeyNames = new string[] { "userId" };
                    this.gvHR.DataBind();
                }
            }
            catch (Exception)
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作失败！')</script>");
            }
        }

        //绑定数据到GridView
        private void HRDataBind()
        {
            string sqlText = "select * from [users]";

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            this.gvHR.DataSource = ds.Tables[0];
            this.gvHR.DataBind();
        }

        //根据PostId获取职务名称
        protected string GetDutyName(string postId)
        {
            string sqlText = "select postName from [post] where postId = @postId";
            SqlParameter para = new SqlParameter("@postId", postId);

            string postName = (string)(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, sqlText, para));
            return postName;
        }

        //选择事件触发
        protected void gvHR_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int index = e.NewSelectedIndex;
            //通过DataKeys获取行为index的userId值
            string userId = this.gvHR.DataKeys[index].Value.ToString();
            Response.Write(userId);
        }

        //编辑事件触发
        protected void gvHR_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                //切换到编辑模式，显示EditItemTemplate中的内容
                this.gvHR.EditIndex = e.NewEditIndex;
                HRDataBind();

                GetEditStateGender(e.NewEditIndex);
                GetEditStatePostName(e.NewEditIndex);
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作失败!')</script>");
            }
        }

        //获取index行的性别
        private void GetEditStateGender(int index)
        {
            HiddenField hfGender = this.gvHR.Rows[index].FindControl("hfGender") as HiddenField;
            DropDownList ddlGender = this.gvHR.Rows[index].FindControl("ddlGender") as DropDownList;
            ddlGender.SelectedValue = hfGender.Value;
        }

        //获取index行的职务
        private void GetEditStatePostName(int index)
        {
            HiddenField hfDuty = this.gvHR.Rows[index].FindControl("hfDuty") as HiddenField;
            DropDownList ddlDuty = this.gvHR.Rows[index].FindControl("ddlDuty") as DropDownList;

            string sqlText = "select * from post";
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            ddlDuty.DataSource = ds.Tables[0];
            ddlDuty.DataValueField = "postId";
            ddlDuty.DataTextField = "postName";
            ddlDuty.DataBind();

            ddlDuty.SelectedValue = hfDuty.Value;
        }

        //撤销事件触发
        protected void gvHR_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                this.gvHR.EditIndex = -1;
                HRDataBind();
            }
            catch (Exception)
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作错误！')</script>");
            }
        }

        //更新事件触发
        protected void gvHR_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                //从编辑模式框中把数据取出来封装成一个User对象
                User user = GetInputData(e.RowIndex);
                //更新User对象
                if (UpdateUsers(user) > 0)
                {
                    this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('修改成功！')</script>");
                }

                this.gvHR.EditIndex = -1;
                HRDataBind();
            }
            catch (Exception)
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作错误！')</script>");
            }
        }

        //从编辑模式框中把数据取出来封装成一个User对象
        private User GetInputData(int index)
        {
            User user = new User();
            user.UserId = this.gvHR.DataKeys[index].Value.ToString();
            user.UserName = (this.gvHR.Rows[index].FindControl("txtName") as TextBox).Text.Trim();
            user.Gender = (this.gvHR.Rows[index].FindControl("ddlGender") as DropDownList).SelectedValue;
            user.PostId = (this.gvHR.Rows[index].FindControl("ddlDuty") as DropDownList).SelectedValue;
            user.Telephone = (this.gvHR.Rows[index].FindControl("txtPhone") as TextBox).Text;
            user.Address = (this.gvHR.Rows[index].FindControl("txtAddress") as TextBox).Text;
            return user;
        }

        //更新User对象
        public int UpdateUsers(User user)
        {
            string sqlText = "update [users] set username = @username,gender = @gender,postId = @postId,telePhone = @telephone, address = @address where userId = @userId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@userId",user.UserId),
                new SqlParameter("@username",user.UserId),
                new SqlParameter("@gender",user.UserId),
                new SqlParameter("@postId",user.UserId),
                new SqlParameter("@telephone",user.UserId),
                new SqlParameter("@address",user.Address)
            };

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }

        //删除事件触发
        protected void gvHR_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                LinkButton lnkbtnDel = gvHR.Rows[e.RowIndex].FindControl("lnkbtnDel") as LinkButton;
                string sqlText = "delete from [users] where userId = @userId";

                SqlParameter[] para = new SqlParameter[] { new SqlParameter("@userId", lnkbtnDel.CommandArgument.ToString()) };
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
                if (result > 0)
                {
                    this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作错误！')</script>");
                }

                this.HRDataBind();

            }
            catch (Exception)
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作错误！')</script>");
            }
        }

        //自定义命令触发事件
        protected void gvHR_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Del")
            {
                try
                {
                    string sqlText = "delete from [users] where userId = @userId";

                    SqlParameter[] para = new SqlParameter[] { new SqlParameter("@userId", e.CommandArgument.ToString()) };
                    int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
                    if (result > 0)
                    {
                        this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作错误！')</script>");
                    }
                }
                catch (Exception)
                {
                    this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "info", "<script>alert('操作错误！')</script>");
                }
            }
            this.HRDataBind();
        }

        //行绑定事件触发
        protected void gvHR_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //截断要显示的字符串
                //Label lblAddress = (Label)e.Row.FindControl("lblAddress");
                //if (lblAddress != null)
                //{
                //    string x = lblAddress.Text;
                //    if (x.Length > 10)
                //    {
                //        lblAddress.Text = x.Substring(0, 10) + "....";
                //        lblAddress.ToolTip = x.Substring(0, 10) + x.Substring(10);
                //    }
                //}

                LinkButton lnkbtnDel = e.Row.FindControl("lnkbtnDel") as LinkButton;
                lnkbtnDel.Attributes.Add("onclick", "return confirm('确认要删除吗？')");
            }
        }
    }
}