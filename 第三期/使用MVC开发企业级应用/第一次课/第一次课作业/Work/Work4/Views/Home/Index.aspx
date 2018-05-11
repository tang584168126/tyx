<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <h1>欢迎访问首页</h1>
        <p>共有<%= Application["count"] %>个访问该页面</p>
    </div>
</body>
</html>
