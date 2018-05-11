<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.Book>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <script type="text/javascript" src="<%=Url.Content("~/ckeditor/ckeditor.js") %>"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <% using (Html.BeginForm("Edit1", "Books", FormMethod.Post, new { enctype = "multipart/form-data" }))
       { %>
    <table class="table_detail" cellspacing="1" cellpadding="3">

        <tr>
            <th>标题
            </th>
            <td>
                <%: Html.TextBoxFor(m=>m.Title,new { style = "width:80%" })%>
                <%: Html.ValidationMessageFor(m=>m.Title)%>

              
            </td>
        </tr>

        <tr>
            <th>封面
            </th>
            <td>
                <% if (Model != null && !string.IsNullOrEmpty(Model.ISBN))
                   { %>
                <img id="imgBook" src="<%= Url.Content("~/Images/BookCovers/" + Model.ISBN + ".jpg")%>" style="border-width: 0px;" />
                <% } %>
                <input type="file" name="imgISBN" />

            </td>
        </tr>
        <tr>

            <th>定价
            </th>
            <td>
                <%: Html.TextBoxFor(m=>m.UnitPrice)%>
                <%: Html.ValidationMessageFor(m=>m.UnitPrice)%>
            </td>
        </tr>
        <tr>
            <th>出版社
            </th>
            <td>
                <%:Html.DropDownListFor(m=>m.Publisher.Id,(SelectList)ViewData["publishers"],"--请选择--") %>
                <%: Html.ValidationMessageFor(m=>m.Publisher.Id)%>
            </td>
        </tr>
        <tr>
            <th>分类
            </th>
            <td>
                <%:Html.DropDownListFor(m=>m.Category.Id,(IEnumerable<SelectListItem>)ViewData["categories"],"--请选择--") %>
                <%: Html.ValidationMessageFor(m=>m.Category.Id)%>
              
               
            </td>
        </tr>
        <tr>
            <th>作者
            </th>

            <td>
                <%: Html.TextBoxFor(m=>m.Author)%>
                <%: Html.ValidationMessageFor(m=>m.Author)%>
            </td>
        </tr>
        <tr>
            <th>ISBN
            </th>
            <td>
                <%: Html.TextBoxFor(m=>m.ISBN)%>
                <%: Html.ValidationMessageFor(m=>m.ISBN)%>
            </td>

        </tr>
        <tr>
            <th>出版日期
            </th>
            <td>
                <%: Html.TextBoxFor(m=>m.PublishDate,"{0:d}", new { @class = "Wdate",  onfocus = "$(this).datepicker()" })%>
                <%: Html.ValidationMessageFor(m=>m.PublishDate)%>
            </td>
        </tr>
        <tr>
            <th>目录
            </th>
            <td>
                <%: Html.TextAreaFor(m=>m.TOC,new { style = "width:80%" })%>

            </td>
        </tr>
        <tr>
            <th>内容摘要
            </th>
            <td>
                <%: Html.TextAreaFor(m=>m.ContentDescription,new { style = "width:80%" })%>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p>
                    &nbsp;&nbsp;
                    <input type="submit" value=" 保 存 " />
                </p>
            </td>
        </tr>

    </table>
    <% } %>

    <script type="text/javascript">
        CKEDITOR.replace('TOC');

        CKEDITOR.replace('ContentDescription');
        // CKEDITOR.replace('ContentDescription', { extraPlugins: 'uicolor', uiColor: '#14B8C4', toolbar: [['Bold', 'Italic', '-', 'NumberedList', 'BulletedList', '-', 'Link', 'Unlink'], ['UIColor']] });
    </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Breadcrumb" runat="server">
    <%= Html.ActionLink("图书管理","List") %>
</asp:Content>
