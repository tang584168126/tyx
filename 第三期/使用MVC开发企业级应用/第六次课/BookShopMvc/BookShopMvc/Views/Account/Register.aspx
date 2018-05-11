<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Commom.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <link href="<%= Url.Content("~/Styles/member.css") %>" rel="stylesheet" />
    <script src="<%: Url.Content("~/Scripts/jquery-1.8.2.min.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="action_area">
        <h2 class="action_type">
            <img src="<%: Url.Content("~/Images/register.gif") %>" alt="会员注册" /></h2>
        <form action="<%: Url.Content("~/Account/Register") %>" method="post" class="member_form">
            <p>
                <%: Html.ValidationSummary() %>
            </p>
            <p>
                <label><span>*</span>用户名</label>
                <%--<input name="LoginId" type="text" class="opt_input" value="<%: Model!=null?Model.LoginId:"" %>" />5-12个字符或数字组成，可用中文名--%>
                <%: Html.TextBox("LoginId", null, new { @class="opt_input"})%>
                <%: Html.ValidationMessage("LoginId") %>
            </p>
            <p>
                <label><span>*</span>密&#160;&#160;&#160;&#160;码</label>
                <%--<input name="LoginPwd" type="password" class="opt_input" />请输入密码--%>
                <%: Html.Password("LoginPwd", null, new { @class="opt_input"})%>
                <%: Html.ValidationMessage("LoginPwd") %>
            </p>
            <p>
                <label><span>*</span>确认密码</label>
                <%--<input name="LoginPwdConfirm" type="password" class="opt_input" />请再次输入密码--%>
                <%: Html.Password("LoginPwdConfirm", null, new { @class="opt_input"})%>
                <%:Html.ValidationMessage("LoginPwdConfirm") %>
            </p>
            <p>
                <label><span>*</span>电子邮件</label>
                <%--<input name="Mail" type="password" class="opt_input" />请输入电子邮件--%>
                <%: Html.TextBox("Mail", null, new { @class="opt_input"})%>
                <%:Html.ValidationMessage("Mail") %>
            </p>
            <p>
                <label><span>*</span>地&#160;&#160;&#160;&#160;址</label>
                <%--<input name="password" type="password" class="opt_input" value="<%: Model!=null?Model.Address:"" %>" />--%>
                <%: Html.TextBox("address", null, new { @class="opt_input"})%>
                <%:Html.ValidationMessage("address") %>
            </p>

            <p>
            <p>
                <label><span>*</span>手&#160;&#160;&#160;&#160;机</label>
                <%--<input name="password" type="password" class="opt_input" value="<%: Model!=null?Model.Phone:"" %>" />--%>
                <%: Html.TextBox("phone", null, new { @class="opt_input"})%>
                <%:Html.ValidationMessage("phone") %>
            </p>

            <p>
                <label><span>*</span>验证码</label>
                <%--<input name="checkno" type="text" class="opt_input" style="width: 60px;" /><img src="<%: Url.Content("~/Images/checkno.gif") %>" />
                请输入验证码--%>
                <%: Html.TextBox("securityCode", null, new { @class="opt_input"})%>
                <%:Html.ValidationMessage("securityCode") %>
                <img src="<%: Url.Action("SecurityCode","Account") %>" />
            </p>
            <p class="form_sub">
                <input type="checkbox" name="" checked="checked" />
                在此计算机上保留我的密码
            </p>
            <p class="form_sub">
                <input type="submit" value="确定了，马上提交" class="opt_sub" />
            </p>
            <p class="form_sub">加<span>*</span>的为必填项目</p>
            <p class="form_sub">
                ><a href="login.html">已经有账号，马上登录</a><br />
                >如果你已经有“第三波书店”社区账号，请<a href="javascript:alert('书店社区暂未开通');">点这里</a>登录升级
            </p>
        </form>
    </div>
</asp:Content>
