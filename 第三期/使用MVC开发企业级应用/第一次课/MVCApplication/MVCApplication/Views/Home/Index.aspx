<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <h1>Hello,ASP.NET</h1>
        <%
            int count = 0;
            for (int i = 2000; i <= 2013; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i%400 == 0)
                {
                    count++;
                }    
            }
             %>
        2000-2013年中存在<%=count %>个闰年
    </div>
</body>
</html>
