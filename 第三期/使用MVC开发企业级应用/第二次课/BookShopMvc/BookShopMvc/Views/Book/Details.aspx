<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Commom.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="BookShop.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%
        Book book = Session["Book"] as Book;
        if (book != null)
        {
            %><h1><%= book.Title %></h1><% 
        }
     %>
</asp:Content>
