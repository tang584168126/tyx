<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Work3.Register" %>

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
        <br/><br/>
        <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>&nbsp;
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label3" runat="server" Text="确认密码："></asp:Label>&nbsp;
        <asp:TextBox ID="txtSurePwd" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label5" runat="server" Text="密码问题："></asp:Label>&nbsp;
        <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label6" runat="server" Text="问题答案："></asp:Label>&nbsp;
        <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Button ID="btnRegister" runat="server" Text="创建新用户" OnClick="btnRegister_Click" />
    </div>
    </form>
</body>
</html>
