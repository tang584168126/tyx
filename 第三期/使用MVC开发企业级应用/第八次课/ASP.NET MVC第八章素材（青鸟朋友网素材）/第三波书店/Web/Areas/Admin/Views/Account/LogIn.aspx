<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <meta name="Robots" content="noindex,nofollow" />
    <title>"第三波书店"-网上书店</title>

    <link href="<%=Url.Content("~/Areas/Admin/CSS/login.css") %>" rel="stylesheet" type="text/css" />
    <link href="<%=Url.Content("~/Areas/Admin/CSS/admin.css") %>" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="login">
        <div class="login_t">
        </div>
        <div class="login_m">
        </div>
        <div class="login_b">
            <form action="<% =Url.Content("~/Admin/Account/Login")%>" method="post">
                <p><%=Html.ValidationMessage("dataValidate") %></p>
                <table align="center">
                    <tr>
                        <td>用户名
                        </td>
                        <td>
                            <input name="UserName" type="text" class="login_input" />

                        </td>
                        <td><%=Html.ValidationMessage("UserName") %></td>
                    </tr>
                    <tr>
                        <td>密&nbsp;&nbsp;码
                        </td>
                        <td>
                            <input name="Password" type="password" class="login_input" />
                            <td><%=Html.ValidationMessage("Password") %></td>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <input type="submit" value="提交" class="login_sub" />
                            <input type="submit" value="重置" class="login_sub" />

                        </td>

                    </tr>
                </table>
            </form>
        </div>
    </div>
</body>
</html>
