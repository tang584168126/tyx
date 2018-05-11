<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="BookShop.Models" %>

<div class="status">
<%
    User user = Session["CurrentUser"] as User;
    if (user == null)
    { %>


    <a href="<% =Url.Content("~/Account/Index")%>">【登录】</a>
    <a href="<% =Url.Content("~/Account/Register")%>">【免费注册】</a>



<%}
    else
    { %>

您好，<%= user.Name %>     <a href="<% =Url.Content("~/Account/LogOut")%>">【注销】</a>
<%} %>

</div>