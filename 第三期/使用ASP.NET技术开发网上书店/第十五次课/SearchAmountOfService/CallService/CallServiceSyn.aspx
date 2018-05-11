<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallServiceSyn.aspx.cs" Inherits="CallService.CallService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnClick" runat="server" Text="调用WebService" OnClick="btnClick_Click" />
    </div>
        <div>
            <asp:GridView ID="gvBooks" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
