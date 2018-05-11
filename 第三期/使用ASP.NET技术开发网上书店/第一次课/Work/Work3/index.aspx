<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Work3.Work3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%
            DateTime dt = DateTime.Now;    
         %>
    <div>
        <asp:Button ID="btnInline" runat="server" Text="内嵌" OnClick="btnInline_Click" />
        <asp:Label ID="lblInline" runat="server" Text="<%= dt %>" Visible="false"></asp:Label>
        <br/>
        <asp:Button ID="btnBehind" runat="server" Text="后置" OnClick="btnBehind_Click" />
        <asp:Label ID="lblBehind" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
