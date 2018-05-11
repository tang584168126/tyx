<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.ShoppingItem>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <link href="<%= Url.Content("~/Css/member.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="action_area">

        <h2 class="action_type backet">
            <p class="imp_link">
                全场运费一律2元 <a href="#"><strong>简易计算器</strong></a><br />
                <p class="mark">
                    确认商品价格与交易条件
                </p>
        </h2>
        <div>

            <table class="data_table" cellspacing="3" cellpadding="0" rules="all" border="0" id="ctl00_cphContent_gvCart" style="border-width: 0px; width: 96%;">
                <tr>
                    <th scope="col">图示</th>
                    <th scope="col">书名</th>
                    <th scope="col">数量</th>
                    <th scope="col">单价</th>

                    <th scope="col">&nbsp;</th>
                </tr>

                <% if (Model != null && Model.Count > 0)
                   {
                       for (int i = 0; i < Model.Count; i++)
                       {
                           BookShop.Models.ShoppingItem item = Model[i];
                %>


                <tr style="background-color: <%= i % 2 == 0 ? "#FEF7DB" : "#E2E2E2" %>;">
                    <td>
                        <img src="<%= Url.Content("~/Images/BookCovers/"+item.Book.ISBN+".jpg") %>" id="imgbook" width="49" height="56" />
                    </td>
                    <td>


                        <span id="BookName"><%= item.Book.Title %></span>
                    </td>
                    <td>
                        <% using (Html.BeginForm("UpdateQuantity", "ShoppingCart"))
                           { %>
                        <input type="hidden" name="item.Book.Id" value="<%= item.Book.Id %>" />
                        <input type="text" name="item.Quantity" value="<%=item.Quantity %>"  onchange="this.form.submit()"/>
                        <br />
                        <%=Html.ValidationMessage("item.Quantity") %>
                        <%} %>
                    </td>
                    <td>
                        <span id="UnitPrice"><%= StringUtility.ToMoney(item.Book.UnitPrice) %></span>
                    </td>

                    <td style="width: 50px;">

                        <a onclick="return confirm(&#39;确定删除吗?&#39;);" id="btnDelete" href="<%= Url.Action("Remove","ShoppingCart",new {bid=item.Book.Id}) %>">删除</a>

                    </td>
                </tr>

                <% }
                   } %>
            </table>

        </div>
        <br />
        <table width="96%">
            <tr>
                <td width="68%" align="right">
                    <a href="<%= Url.Action("Index") %>">继续挑选商品</a>&nbsp;&nbsp;&nbsp;&nbsp; 商品金额总计：￥<em><strong><%= StringUtility.ToMoney(ViewData["TotalPrice"]) %></strong></em>

                </td>
                <td align="center">
                    <% using (Html.BeginForm("Submit", "ShoppingCart"))
                       { %>
                    <input type="submit" name="CheckOut" value="" id="ctl00_cphContent_btnCheckOut" class="basker_ok" />
                    <%} %>
                </td>
            </tr>
        </table>

    </div>


</asp:Content>
