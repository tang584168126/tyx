<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.Category>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%using(Html.BeginForm("Add","Category")){ %>
        <input name="categoryName" type="text"  class="opt_action"/>
        <input type="submit" name="btnAdd" value="增加分类" />
    <%} %>
   
  
    <br />
    <div>
        <table class="data_table" cellspacing="0" cellpadding="0" rules="all" border="1" id="tbCategory" style="border-collapse: collapse;">
            <tr>
                <th scope="col">Id</th>
                <th scope="col">分类名称</th>
            </tr>
            <% if (Model != null && Model.Count > 0)
               {
                   for (int i = 0; i < Model.Count; i++)
                   {
                       BookShop.Models.Category cate = Model[i];
            %>


            <tr style="background-color: <%= i % 2 == 0 ? "White" : "#DDF5D9" %>;">
                <td><%= cate.Id %></td>
                <td><%= cate.Name %></td>
            </tr>

            <% }
               } %>
        </table>
    </div>



</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Breadcrumb" runat="server">
     <%= Html.ActionLink("图书分类管理","List") %>
</asp:Content>
