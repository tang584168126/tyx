<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<BookShop.Models.Category>" %>
  <%:Html.DropDownListFor(m=>m.Id,(IEnumerable<SelectListItem>)ViewData["categories"],"--请选择--") %>
