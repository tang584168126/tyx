<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NewsManagerSystem.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>文章管理系统</title>
    <link href="css/css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <table>
            <tr>
                <td></td>
                <td><asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label></td>
            </tr>
            <tr>
                <td style="width:100px; color:blue;">标题：</td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="color:blue;">内容：</td>
                <td>
                    <asp:TextBox ID="txtContent" runat="server" Rows="10" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnInsert" runat="server" Text="插入" OnClick="btnInsert_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
