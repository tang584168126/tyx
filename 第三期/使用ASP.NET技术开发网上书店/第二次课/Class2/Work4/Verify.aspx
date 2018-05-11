<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="Work3.Verify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="确认班级信息"></asp:Label>
        <br/><br/>
        <asp:Label ID="Label2" runat="server" Text="班级名称："></asp:Label>
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label4" runat="server" Text="入学年月"></asp:Label>
        <asp:Label ID="lblEnrol" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label6" runat="server" Text="毕业年月:"></asp:Label>
        <asp:Label ID="lblGraduate" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label8" runat="server" Text="所在学校："></asp:Label>
        <asp:Label ID="lblSchool" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="Label10" runat="server" Text="注册时间："></asp:Label>
        <asp:Label ID="lbltxtTime" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Button ID="btnSure" runat="server" Text="确认" />
        <asp:Button ID="btnReturn" runat="server" Text="返回" OnClick="btnReturn_Click" />
    </div>
    </form>
</body>
</html>
