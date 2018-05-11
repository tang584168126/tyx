<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Work5.Login" %>

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
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br/><br />
        <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>&nbsp;
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <br/><br />
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />&nbsp;
        <asp:Button ID="Button2" runat="server" Text="注册" />
    </div>
    </form>
</body>
</html>
