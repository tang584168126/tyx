<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <form action="<%= Url.Content("~/Home/Sure") %>" method="post">
            <table border="1">
                <tr>
                    <td colspan="2">注册新班级</td>
                    <td></td>
                </tr>
                <tr>
                    <td>班级名：</td>
                    <td><input type="text" name="name" value="数字艺术2007" /></td>
                </tr>
                <tr>
                    <td>入学年月：</td>
                    <td><input type="text" name="one" value="2004年9月" /></td>
                </tr>
                <tr>
                    <td>毕业年月：</td>
                    <td><input type="text" name="two" value="2007年7月" /></td>
                </tr>
                <tr>
                    <td>所在学校：</td>
                    <td><input type="text" name="school" value="北京传媒大学" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type="submit" value="创建新班级" /></td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
