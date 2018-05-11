<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="Work3.Verify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="确认用户信息"></asp:Label>
        <br/><br/>
        <asp:Label ID="Label2" runat="server" Text="姓名："></asp:Label>
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label4" runat="server" Text="密码"></asp:Label>
        <asp:Label ID="lblPwd" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label6" runat="server" Text="Eamil:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label8" runat="server" Text="密码问题："></asp:Label>
        <asp:Label ID="lblQuestion" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label10" runat="server" Text="密码答案："></asp:Label>
        <asp:Label ID="lblAnswer" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Button ID="btnSure" runat="server" Text="确认" />
        <asp:Button ID="btnReturn" runat="server" Text="返回" OnClick="btnReturn_Click" />
    </div>
    </form>
</body>
</html>
