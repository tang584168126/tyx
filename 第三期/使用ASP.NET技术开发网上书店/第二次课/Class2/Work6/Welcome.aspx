﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Work6.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="班级在线留言"></asp:Label>
        <br/><br/>
        <asp:Label ID="Label2" runat="server" Text="留言主题："></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label3" runat="server" Text="留言内容："></asp:Label>
        <asp:TextBox ID="txtContent" runat="server" AutoPostBack="True" Height="109px" Width="364px"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label4" runat="server" Text="留言时间："></asp:Label>
        <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click" />
    </div>
    </form>
</body>
</html>
