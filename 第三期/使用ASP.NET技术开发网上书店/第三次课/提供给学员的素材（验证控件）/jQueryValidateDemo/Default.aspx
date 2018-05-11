<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jQueryValidateDemo.Default" %>

<!DOCTYPE html>


<%--  jQuery验证插件  http://jqueryvalidation.org/--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" src="js/jquery-1.8.2.js"></script>
    <script type="text/javascript" src="js/jquery.validate.js"></script>

    <script type="text/javascript" src="js/customValidate.js"></script>
</head>
<body>
    <form id="signupForm" method="post">
        <p>邮箱:<input type="text" id="txtEmail" name="txtEmail" /></p>
        <p>密码:<input type="password" id="txtPassword1" name="txtPassword1" /></p>
        <p>重输密码:<input type="password" id="txtPassword2" name="txtPassword2" /></p>
        <p><input type="submit" value="注册" /></p>
    </form>

</body>
</html>
