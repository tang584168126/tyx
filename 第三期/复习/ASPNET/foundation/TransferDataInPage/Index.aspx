<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TransferDataInPage.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtSend" runat="server"></asp:TextBox><br/>
        <asp:Button ID="btnClick" runat="server" Text="复制" OnClick="btnClick_Click" /><br/>
        <asp:TextBox ID="txtAccept" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
