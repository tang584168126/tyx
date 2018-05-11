<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Commom.Master" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.Book>>" %>
<%@ Import Namespace="BookShopMvc.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <link href="<%= Url.Content("~/Styles/channel.css") %>" rel="stylesheet" type="text/css" />
    <script>
        function toBookList(){
            var list_type = document.getElementById("list_type");
            if(list_type.value == "PublishDate"){
                location.href="<%= Url.Action("List", "Book", new { order="PublishDate",categoryId=Convert.ToInt32(ViewData["categoryId"])})%>"
            }else{
                location.href = "<%= Url.Action("List", "Book", new { order="UnitPrice",categoryId=Convert.ToInt32(ViewData["categoryId"])})%>"
            }
        }

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main">
        <div class="list_asc">
            <div class="type_choice f_left">
                排序方式
                <select name="list_type" id="list_type" onchange="toBookList()">
                    <option value="PublishDate" <%: ViewData["order"].ToString()== "PublishDate"? "selected": "" %>>按出版日期排序</option>
                    <option value="UnitPrice" <%: ViewData["order"].ToString()== "UnitPrice"? "selected": "" %>>按价格排序</option>
                </select>
            </div>
        </div>

        <%
            foreach (var book in Model)
            {
        %>
        <dl class="list_area">
            <dt><a href="#">
                <img src="<%: Url.Content("~/Images/BookCovers/" + book.ISBN.ToString() + ".jpg") %>" width="100" height="100" onload="set_pic_size(this,100,100);" alt="<%: book.Title %>" /></a></dt>
            <dd>
                <h2 class="b_title"><%: Html.ActionLink(book.Title, "Detail", "Book", new { Id=book.Id},null)%></h2>
                <div class="b_property">
                    作者：<%: book.Author %><br />
                    出版社：<%: book.Publisher.Name %><br />
                    出版时间：<%: book.PublishDate.ToString("yyyy年MM月") %>
                </div>
                <h4 class="b_intro"><%--<%: StringUtility.CutString(book.ContentDescription,150) %>--%>
                    <%: book.ContentDescription.CutString(150) %>
                </h4>
                <div class="b_buy">
                    <span class="gray del"><%: StringUtility.ToMoney(book.UnitPrice) %></span>
                </div>
            </dd>
        </dl>
        <% 
            }    
        %>

        <%
            int pageIndex = Convert.ToInt32(ViewData["pageIndex"]);
            int pageCount = Convert.ToInt32(ViewData["pageCount"]);
            int categoryId = Convert.ToInt32(ViewData["categoryId"]);
            string order = Convert.ToString(ViewData["order"]);
            
            //上一页按钮禁用状态(判定pageIndex值是否为1)
            string privousEnabled = pageIndex == 1 ? "disabled" : "";
            //下一页按钮禁用状态(判定pageIndex值是否等于pageCount)
            string nextEnabled = pageIndex == pageCount ? "disabled" : "";
            
            //上一页链接
            string privousLink = Url.Action("List", "Book", new { categoryId = categoryId, pageIndex = pageIndex - 1, order = order });
            //下一页链接
            string nextLink = Url.Action("List", "Book", new { categoryId = categoryId, pageIndex = pageIndex + 1, order = order });
        %>
        <div class="pages">
            第<%: pageIndex %>页，共<%: pageCount %>页
            <input type="button" value="上一页" <%: privousEnabled %> onclick="location.href='<%: privousLink %>'" />

            <input type="button" value="下一页" <%: nextEnabled %> onclick="location.href='<%: nextLink %>'" />
        </div>
    </div>
</asp:Content>
