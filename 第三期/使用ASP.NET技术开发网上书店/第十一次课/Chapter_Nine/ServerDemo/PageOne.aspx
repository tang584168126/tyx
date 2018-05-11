<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageOne.aspx.cs" Inherits="ServerDemo.PageOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnRedirect" runat="server" Text="Redirect跳转" OnClick="btnRedirect_Click" /><br/><br/>
        <asp:Button ID="btnTranser" runat="server" Text="Transer跳转" OnClick="btnTranser_Click" /><br/><br/>
        <asp:Button ID="btnExecute" runat="server" Text="Execute跳转" OnClick="btnExecute_Click" /><br/><br/>
    </div>
    </form>
</body>
</html>
