<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Home</title>
</head>
<body>
    <%
        var count = 0;
        for (var i = 2000; i <= 2013; i++)
        {
            if (i % 100 == 0 || i % 4 == 0)
            {
                count++; 
            } 
        }
        
         %>
    <div>
        <h3>从2000-2013，共有<%= count %>个闰年</h3>
    </div>
</body>
</html>
