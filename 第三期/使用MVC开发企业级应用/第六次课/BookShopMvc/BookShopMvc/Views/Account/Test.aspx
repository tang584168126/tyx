<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="BookShopMvc.Helpers" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
</head>
<body>
    <div>
        <%= Html.Submit("Login","登录") %>
        <%= Html.Submit("Login", "登录", new { @class="opt_sub",Title="点击提交"})%>
    </div>
</body>
</html>
