<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatePickerDemo.aspx.cs" Inherits="ChapterDemo.DatePickerDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" lang="javascript" src="My97DatePicker/WdatePicker.js">

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        <asp:TextBox ID="txtDate" runat="server" CssClass="Wdate" onfocus="WdatePicker()"></asp:TextBox>
    </div>
    </form>
</body>
</html>
