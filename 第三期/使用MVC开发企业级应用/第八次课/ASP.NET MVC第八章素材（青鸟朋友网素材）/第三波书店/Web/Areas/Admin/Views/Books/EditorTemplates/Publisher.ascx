<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<BookShop.Models.Publisher>" %>
  <%:Html.DropDownListFor(m=>m.Id,(SelectList)ViewData["publishers"],"--请选择--") %>
