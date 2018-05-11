<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Helpers.PagedList<BookShop.Models.Book>>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <script src="<%= Url.Content("~/Scripts/jquery-1.7.1.min.js") %>" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%using(Html.BeginForm("List","Books")){ %>
    <table>
        <tr>
            <td>&nbsp;&nbsp; 检索类别：
                 <%:Html.DropDownList("category", (IEnumerable<SelectListItem>)ViewData["category"], " ")%>

                关键字：<input name="keyword" type="text" id="keyword" value="<%= ViewData["keyword"]??"" %>"/>

                <input type="submit" name="query" value="查询" id="query" />

            </td>
            <td style="width: 100px;">&nbsp; &nbsp;
               <%=Html.ActionLink("添加书籍","Edit","Books") %>

            </td>
        </tr>
    </table>
  

    <br />

    <table class="data_table" cellspacing="0" cellpadding="0" rules="all" border="1" id="ctl00_cphAdmin_gvMain" style="border-collapse: collapse;">

        <tr>
            <th scope="col">书名</th>
            <th scope="col">作者</th>
            <th scope="col">类别</th>
           
            <th scope="col">&nbsp;</th>
            <th scope="col">&nbsp;</th>
        </tr>

        <% if (Model != null && Model.Count > 0)
           {
               for (int i = 0; i < Model.Count; i++)
               {
                   BookShop.Models.Book book = Model[i];
        %>

        <tr style="background-color: <%= i % 2 == 0 ? "White" : "#DDF5D9" %>;" 
            onmouseover="currentcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'" 
            onmouseout="this.style.backgroundColor=currentcolor">
            <td><%= Html.ActionLink(book.Title, "Detail", new { id=book.Id })%></td>
            <td><%= book.Author %></td>
            <td><%= book.Category.Name %></td>
           
            <td>
                <%= Html.ActionLink("删除", "Delete", "Books", new { id = book.Id }, new {onclick="return confirm('确认要删除吗？')" })%></td>


            <td><%= Html.ActionLink("编辑", "Edit", "Books", new  {id=book.Id },null)%></td>
        </tr>


        <% }
           } %>
    </table>

<%--    <div class="pages">

        <% if (Model.HasPreviousPage)
           { %>

        <%: Html.ActionLink("<<< 上一页", 
                               "List","Books" ,
                               new { pageIndex=(Model.PageIndex-1),category=ViewData["category"],keyword=ViewData["keyword"] },null) %>

        <% } %>

        <% if (Model.HasNextPage)
           { %>

        <%: Html.ActionLink("下一页 >>>", 
                                "List","Books" ,
                               new { pageIndex = (Model.PageIndex + 1),category=ViewData["category"],keyword=ViewData["keyword"] },null)%>

        <% } %>
    </div>--%>

   <%=Html.Pager(Model) %>

      <%} %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Breadcrumb" runat="server">
     <%= Html.ActionLink("图书管理","List") %>
</asp:Content>
