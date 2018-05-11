<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_02_GetMasterValue.Home" %>
<%--<%@ MasterType VirtualPath="~/MainMaster.Master"  %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</asp:Content>
