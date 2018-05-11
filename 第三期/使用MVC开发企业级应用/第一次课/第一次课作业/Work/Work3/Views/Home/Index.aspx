<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div runat="server">
        <form action="<%= Url.Content("~/Home/Index") %>" method="post">
            <label>用户名：</label><input name="user" type="text" /><br />
            <br />
            <label>年龄：</label><input name="age" type="text" /><br />
            <br />
            <input type="submit" value="提交" /><br />
            <br />
        </form>
        <%
            string user = Session["user"] as string;
            if (user != null)
            {
        %>
        <%= user %>,北大青鸟欢迎你！
        <% 
            }   
        %>
    </div>
</body>
</html>
