<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KeepState.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="lblPassword" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
    </div>
    </form>
</body>
</html>
