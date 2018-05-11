<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Detail</title>
</head>
<body>
    <div>
        <% foreach(KeyValuePair<string,object> data in this.RouteData.Values){ %>
          <p><%= data.Key %>:<%= data.Value %></p>
        <%} %>
    </div>
</body>
</html>
