<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<System.DateTime?>" %>
<%: Html.TextBoxFor(m=>m,"{0:d}", new { @class = "Wdate", onfocus = "$(this).datepicker()" })%>
