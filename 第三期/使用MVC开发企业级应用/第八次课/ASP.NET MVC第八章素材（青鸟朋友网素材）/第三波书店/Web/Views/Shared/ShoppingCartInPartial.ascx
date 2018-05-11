<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="BookShop.Models" %>
<%@ Import Namespace="BookShop.BLL" %>

<% 
    if (Session["Cart"] != null && Session["CurrentUser"] != null)
    {
        ShoppingManager manager = new ShoppingManager(Session["Cart"], Session["CurrentUser"]);
        if (manager.ShoppingItems.Count > 0)
        {
           
%>  

     <a href="<%= Url.Content("~/ShoppingCart/Index") %>"  id="A1"><%="您目前共购买了 " +  manager.ShoppingItems.Count + " 本书" %></a>
<%
        }
    }
    else
    {
%>
<a  runat="server" id="hrefShoppinCart">目前您的购物篮是空的</a>
<%
            }

%>