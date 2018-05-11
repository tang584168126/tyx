<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Text.aspx.cs" Inherits="BookShop.Text" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <user:FirstCustomControl Text="Hello" runat="server" />
        <user:TextBoxExt ID="TextBoxExt1" runat="server"  ValType="NoZeroInteger"></user:TextBoxExt>
        <user:TextBoxExt ID="TextBoxExt2" runat="server"  ValType="BigChar"></user:TextBoxExt>
    </div>
    </form>
</body>
</html>
