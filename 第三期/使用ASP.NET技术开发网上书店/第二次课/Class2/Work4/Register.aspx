<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Work3.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="班级名："></asp:Label>&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label2" runat="server" Text="入学年月："></asp:Label>&nbsp;
        <asp:TextBox ID="txtEnrol" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label3" runat="server" Text="毕业年月："></asp:Label>&nbsp;
        <asp:TextBox ID="txtGraduate" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label5" runat="server" Text="所在学校："></asp:Label>&nbsp;
        <asp:TextBox ID="txtSchool" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Label6" runat="server" Text="创建时间："></asp:Label>&nbsp;
        <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Button ID="btnRegister" runat="server" Text="创建新班级" OnClick="btnRegister_Click" />
    </div>
    </form>
</body>
</html>
