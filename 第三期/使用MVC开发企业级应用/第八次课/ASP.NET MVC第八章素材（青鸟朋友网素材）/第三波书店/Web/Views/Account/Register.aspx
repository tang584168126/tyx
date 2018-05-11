<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <link href="<%= Url.Content("~/CSS/member.css") %>" rel="stylesheet" type="text/css" />
     <script src="<%= Url.Content("~/Scripts/jquery-1.7.1.min.js") %>" type="text/javascript"></script>
    <script src="<%= Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%= Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Html.EnableClientValidation(); %>
    <div id="action_area">
        <h2 class="action_type">
            <img src="<%= Url.Content("~/Images/register.gif") %>" alt="会员注册" /></h2>
       <%using(Html.BeginForm("Register","Account",FormMethod.Post,new {@class="member_form",id="action_area"})){ %>
       
            <p>
                <label><span>*</span>用户名</label> <%= Html.TextBox("LoginId",null,new {@class="opt_input"})%>5-12个字符或数字组成，可用中文名 <%=Html.ValidationMessage("LoginId") %></p>
         <p>
                <label><span>*</span>真实姓名</label><%= Html.TextBox("Name",null,new {@class="opt_input"})%> <%=Html.ValidationMessage("Name") %></p>
            <p>
                <label><span>*</span>密&#160;&#160;&#160;&#160;码</label><%= Html.Password("LoginPwd",null,new {@class="opt_input"})%> <%=Html.ValidationMessage("LoginPwd") %></p>
            <p>
                <label><span>*</span>确认密码</label><%= Html.Password("PasswordConfirm",null,new {@class="opt_input"})%> <%=Html.ValidationMessage("PasswordConfirm") %></p>
            <p>
                <label><span>*</span>电子邮件</label><%= Html.TextBox("Mail",null,new {@class="opt_input"})%> <%=Html.ValidationMessage("Mail") %></p>
            <p>
                <label><span>*</span>地&#160;&#160;&#160;&#160;址</label><%= Html.TextBox("Address",null,new {@class="opt_input"})%> <%=Html.ValidationMessage("Address") %></p>
          <p>
                <label><span>*</span>手&#160;&#160;&#160;&#160;机</label><%= Html.TextBox("Phone",null,new {@class="opt_input"})%> <%=Html.ValidationMessage("Phone") %></p>
            <p>
                <label><span>*</span>验证码</label><input name="securityCode" type="text" class="opt_input" style="width: 60px;" /> <img alt="验证码图片" id="ImgValidateCode" title="看不清？点击换一个" src="<%=Url.Action("SecurityCode") %>"  onclick="this.src=this.src+'?'" />
                <%=Html.ValidationMessage("securityCode") %></p>
           
            <p class="form_sub">
                <input type="submit" value="确定了，马上提交" class="opt_sub" /></p>
            <p class="form_sub">加<span>*</span>的为必填项目</p>
            <p class="form_sub">><a href="login.html">已经有账号，马上登录</a><br />
                >如果你已经有“第三波书店”社区账号，请   <%= Html.ActionLink("点这里","LogIn","Account") %>登录</p>
       <%} %>
    </div>

</asp:Content>
