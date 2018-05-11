<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        1 输出JavaScript
     <%--   <script src='<%=Url.RouteUrl(new {action="javascriptTest"})   %>' type="text/javascript"></script>--%>
        <p>
            <%= Html.ActionLink("生成JavaScript","javascriptTest") %>
        </p>
        2 输出Json
        <p>
            <%= Html.ActionLink("生成JSON","jsonTest") %>
        </p>
        3 链接文件
        <p>
            <%= Html.ActionLink("播放MP3", "FilePathTest")%>
        </p>
        4 链接文件内容
        <p>
            <%= Html.ActionLink("查看文本文件", "FileContentTest")%>
        </p>

        5 链接文件流
        <p>
            <%= Html.ActionLink("访问PDF", "FileStreamTest")%>
        </p>

        6 输出文本
         <p>
             <%= Html.ActionLink("输出文本", "ContentTest")%>
         </p>

        7 跳转（Redirect）
         <p>
             <%= Html.ActionLink("Redirect跳转", "RedirectTest")%>
         </p>

        <p>
            <%= Html.ActionLink("RedirectToRoute跳转", "RedirectToRouteTest")%>
        </p>

        <p>
            <%= Html.ActionLink("RedirectToAction跳转", "RedirectToActionTest")%>
        </p>
    </div>
</body>
</html>
