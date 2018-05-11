<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.Category>>" %>


<div id="subnav">
    <ul class="black">
        <% foreach(var cate in Model){ %> 
                   
                    <li><%= Html.ActionLink(cate.Name,"List","Books",new {order="PublishDate",categoryId=cate.Id,pageIndex=1},null) %></li>



        <% } %>
    </ul>
</div>
