<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebConfig.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblConnStr" runat="server" Text=""></asp:Label><br/><br/>
        <asp:Button ID="btnClick" runat="server" Text="获取连接字符串" OnClick="btnClick_Click" />
    </div>
    </form>
</body>
</html>
