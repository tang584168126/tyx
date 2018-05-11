<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_01_MasterTest.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- 内容页的样式、脚本 --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="提交" />
    <%-- 内容页的私有部分 --%>
</asp:Content>
