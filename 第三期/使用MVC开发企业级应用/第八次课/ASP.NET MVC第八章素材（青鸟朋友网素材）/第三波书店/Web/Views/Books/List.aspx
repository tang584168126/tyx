<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.Book>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <link href="<%= Url.Content("~/Css/channel.css") %>" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function toBookList() {
            var list_type = document.getElementById("list_type");
            if (list_type.value == "PublishDate") {
                location.href = "<%= Url.Action("List","Books",new {order="PublishDate",categoryId=ViewData["categoryId"],},null) %>";
            }
            else {
                location.href = "<%= Url.Action("List","Books",new {order="UnitPrice",categoryId=ViewData["categoryId"],},null) %>";
            }
        }

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main">
        <div class="list_asc">
            <!--choice order type-->
            <div class="type_choice f_left">
                排序方式
                 <select name="list_type" id="list_type" onchange="toBookList()">
                     <option value="PublishDate" <%= ViewData["order"].ToString()=="PublishDate"?"selected":"" %>>按出版日期排序</option>
                     <option value="UnitPrice" <%= ViewData["order"].ToString()=="UnitPrice"?"selected":"" %>>按价格排序</option>
                 </select>

            </div>
        </div>

        <% foreach (var book in Model)
           { %>
        <dl class="list_area">
            <dt><a href="#">
                <img src="<%= Url.Content("~/Images/BookCovers/" + book.ISBN.ToString() + ".jpg") %>" width="100" height="100" alt="<%= book.Title %>" /></a></dt>
            <dd>
                <h2 class="b_title"><%: Html.ActionLink(book.Title, "Detail","Books",new { bid=book.Id },null) %></h2>


                <div class="b_property">
                    作者：<%=book.Author %> 编著<br />
                    出版社：<%=book.Publisher.Name %><br />
                    出版时间：<%=book.PublishDate.ToString("yyyy年MM月") %>
                </div>
                <h4 class="b_intro"><%= StringUtility.CutString(book.ContentDescription, 150)%></h4>
                <div class="b_buy">
                    <span class="gray del"><%= StringUtility.ToMoney(book.UnitPrice)%></span>
                   <%-- <img src="<%= Url.Content("~/Images/btn_goumai.gif") %>" onmouseover="this.src='<%= Url.Content("~/Images/btn_goumai_click.gif") %>'" onmouseout="this.src='<%= Url.Content("~/Images/btn_goumai.gif") %>'" />
                    <img src="<%= Url.Content("~/Images/btn_zancun.gif") %>" onmouseover="this.src='<%= Url.Content("~/Images/btn_zancun_click.gif") %>'" onmouseout="this.src='<%= Url.Content("~/Images/btn_zancun.gif") %>'" />
                --%></div>
            </dd>
        </dl>

        <% } %>
        <div class="pages">
            <asp:Label runat="server" ID="lblCurrentPage"></asp:Label>
            <% 
                int categoryId = (int)ViewData["categoryId"];
                int pageIndex = (int)ViewData["pageIndex"];
                string order = (string)ViewData["order"];
                int pageCount = (int)ViewData["pageCount"];

                string privousEnabled = pageIndex == 1 ? "disabled" : "";
                string nextEnabled = pageCount == pageIndex ? "disabled" : "";
                string privousLink = Url.Action("List", "Books", new { order = order, categoryId = categoryId, pageIndex = pageIndex-1 }, null);
                string nextLink = Url.Action("List", "Books", new { order = order, categoryId = categoryId, pageIndex = pageIndex + 1 }, null);
                
            %>
            第<%= pageIndex %>页 共<%= pageCount %>页

          
            <input type="button" value="上一页" onclick="location.href='<%= privousLink %>'"  <%=privousEnabled %>/>
            <input type="button" value="下一页" onclick="location.href='<%= nextLink %>'"    <%=nextEnabled %>/>

        </div>
    </div>

</asp:Content>
