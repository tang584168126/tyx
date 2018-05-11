<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="text.aspx.cs" Inherits="WebDemo.text" %>
<%@ Import Namespace="BookSet.Models" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    欢迎你<% User user = Session["Cuntreuser"] as User; 
          
          %> <%=user.LoginId %>恭喜你登陆成功
    </div>
    </form>
</body>
</html>
