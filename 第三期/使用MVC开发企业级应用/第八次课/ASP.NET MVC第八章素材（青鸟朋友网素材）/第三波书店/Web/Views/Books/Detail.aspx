<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.Book>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <link href="<%= Url.Content("~/CSS/channel.css") %>" rel="stylesheet" type="text/css" />
    <link href="<%= Url.Content("~/CSS/answer.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% if(Model!=null){ %>
    <div class="book_view">
        <h1 class="b_title">
            <asp:Label runat="server" ID="lblBookName"></asp:Label></h1>
        <div class="b_exa">
            <span class="book_group">书籍分类：<%= Model.Category.Name %></span> <span class="book_status">正在阅读（150 人），已经阅读（4521
                人） <span><a href="#">放入书架</a></span> <a href="#">什么是书架？</a></span>
        </div>
        <!--book basic start-->
        <dl class="put_book">
            <dt>
                <img src="<%= Url.Content("~/Images/BookCovers/" + Model.ISBN.ToString() + ".jpg") %>" />
                <div class="chakan">
                    <img src="<%= Url.Content("~/Images/zoom.gif") %>" />
                    <a class="gray878787a" href="#" name="bigpicture">点击查看大图</a>
                </div>
            </dt>
            <dd>
                <div id="book_editor">
                    作 者：
                   <%=Model.Author %>
                    著<br />
                    出 版 社：<%= Model.Publisher.Name %>
                </div>
                <ul id="book_attribute">
                    <li>出版时间：
                       <%=Model.PublishDate %></li>
                    <li>字 数： </li>
                    <li>版 次： </li>
                    <li>页 数：</li>
                    <li>印刷时间： </li>
                    <li>开 本： </li>
                    <li>印 次： </li>
                    <li>纸 张： </li>
                    <li>I S B N ：
                        <%= Model.ISBN %></li>
                    <li>包 装： 平装</li>
                </ul>
                <div id="book_price">
                    定价：<%=Model.UnitPrice %>
                </div>
                <div id="book_point">
                    <span>送积分：<span id="pointsTag">354</span></span> <a target="_blank" href="#2">积分说明</a>
                    <br />
                    <br />
                    <a href="<%= Url.Action("Add", "ShoppingCart", new {bid=Model.Id })%>">
                       <img id="ibtnBuy" src="<%= Url.Content("~/Images/btn_goumai.gif") %>" 
                            onmouseover="this.src='<%= Url.Content("~/Images/btn_goumai_click.gif") %>'"
                              onmouseout="this.src='<%= Url.Content("~/Images/btn_goumai.gif") %>'"/>
                       
                    </a>
                </div>

            </dd>
        </dl>
        <!--book basic end-->
        <!--book intro start-->
        <dl class="book_intro">
            <dt>内容提要</dt>
            <dd>
                <%= Model.ContentDescription %></dd>
        </dl>
        <dl class="book_intro">
            <dt>目录</dt>
            <dd>
                <%= Model.TOC %></dd>
        </dl>
        <!--book intro end-->

    </div>
    <%} %>
</asp:Content>
