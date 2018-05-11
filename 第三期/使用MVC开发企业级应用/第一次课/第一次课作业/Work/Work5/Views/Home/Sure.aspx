<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<<%@ Import Namespace="Work5.Models" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Sure</title>
</head>
<body>
    <div>
        <%
            Globle sc = Session["sc"] as Globle;
         %>
        班级名称：<%= sc.Name %><br />
        入学年月：<%= sc.One %><br />
        毕业年月：<%= sc.Two %><br />
        所在学校：<%= sc.School %>
    </div>
</body>
</html>
