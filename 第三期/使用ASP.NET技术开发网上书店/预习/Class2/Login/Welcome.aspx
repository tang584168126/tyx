<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Login.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblWelcome" runat="server" Text="欢迎"></asp:Label>
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="lblEdition" runat="server" Text="版本："></asp:Label>
        <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="lblLanguage" runat="server" Text="语言："></asp:Label>
        <asp:Label ID="lblLan" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
