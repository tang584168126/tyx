<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.User>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="data_table" cellspacing="0" cellpadding="0" rules="all" border="1" id="ctl00_cphAdmin_gvMain" style="border-collapse: collapse;">

        <tr>
            <th scope="col">地址</th>
            <th scope="col">用户名</th>
            <th scope="col">电话</th>
            <th scope="col">姓名</th>
            <th scope="col">Email</th>
            <th scope="col">&nbsp;</th>
            <th scope="col">&nbsp;</th>
        </tr>

        <% if (Model != null && Model.Count > 0)
           {
               for (int i = 0; i < Model.Count; i++)
               {
                   BookShop.Models.User user = Model[i];
        %>

        <tr style="background-color: <%= i % 2 == 0 ? "White" : "#DDF5D9" %>;">
            <td><%= user.Address %></td>
            <td><%=user.LoginId %></td>
            <td><%= user.Phone %></td>
            <td><%=user.Name %></td>
            <td><%=user.Mail %></td>
            <td>
                <%= Html.ActionLink("删除", "Delete", "User", new { id = user.Id }, new {onclick="return confirm('删除用户会将与此用户相关的订单一起删除，确认删除吗？')" })%></td>


            <td><%= Html.ActionLink("详细", "Edit", "User", new  {id=user.Id },null)%></td>
        </tr>


        <% }
           } %>
    </table>

   

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Breadcrumb" runat="server">
    <%= Html.ActionLink("用户管理","List") %>
</asp:Content>
