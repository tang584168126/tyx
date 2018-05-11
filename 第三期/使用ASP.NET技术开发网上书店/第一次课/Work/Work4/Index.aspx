<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Work4.Work4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUser" runat="server" Text="用户名:"></asp:Label>&nbsp;
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="lblAge" runat="server" Text="年龄:"></asp:Label>&nbsp;&nbsp;
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Button ID="btnClick" runat="server" Text="提交" OnClick="btnClick_Click" />
        <br/><br/>
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
