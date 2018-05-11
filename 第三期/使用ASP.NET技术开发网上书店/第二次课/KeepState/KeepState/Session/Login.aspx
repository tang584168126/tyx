<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KeepState.Session.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>&nbsp;
        <asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox>
        <br/><br />
        <asp:Label ID="Label2" runat="server" Text="密  码："></asp:Label>&nbsp;
        <asp:TextBox ID="txtLoginPwd" runat="server"></asp:TextBox>&nbsp;
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
    </div>
    </form>
</body>
</html>
