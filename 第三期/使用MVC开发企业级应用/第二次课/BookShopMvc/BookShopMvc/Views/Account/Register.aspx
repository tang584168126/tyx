<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Commom.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%
        if (Session["Success"] != null)
        {
            if ((Boolean)Session["Success"])
            {
    %><h1>注册成功！</h1>
    <%
        }
            else
            {
    %><h1>注册失败！</h1>
    <%
        }
        }      
    %>
</asp:Content>
