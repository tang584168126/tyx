<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <%
            var html = "";
            foreach(System.Collections.Generic.KeyValuePair<string, object> d in RouteData.Values)
            {
                html += d.Key + "=" + d.Value + "<br/>";
            }
            Response.Write(html);
        %>
        <%= Url.Action("Index", "Controller", new { id=1,name="test"})%>

        <%= Html.ActionLink("C#高级", "Details", "Book", new { id = 4349 }, new { @class="link",title="书籍名称"})%>
        <br />
        <%= Html.ActionLink("C#高级", "books/Details", "Book", new { id = 4349 }, new { @class="link",title="书籍名称"})%>
        <%--<%= ViewData["Test"] %>--%>
        <%--<%= ViewBag.Data %>--%>
    </div>
</body>
</html>
