<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="My97DatePicker.aspx.cs" Inherits="ControlsDemo.My97DatePicker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtDate" runat="server" CssClass="WDate" onfocus="WdatePicker()"></asp:TextBox>
    </div>
    </form>
</body>
</html>
