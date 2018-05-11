<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.Book>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <script type="text/javascript" src="<%=Url.Content("~/ckeditor/ckeditor.js") %>"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <% using (Html.BeginForm("Edit", "Books", FormMethod.Post, new { enctype = "multipart/form-data" }))
       { %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>维护书籍</legend>

        <%--   <%: Html.HiddenFor(model => model.Id) %>--%>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Title) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Title) %>
            <%: Html.ValidationMessageFor(model => model.Title) %>
        </div>

        <div class="editor-label">
            封面
        </div>
        <div class="editor-field">
            <% if (Model != null && !string.IsNullOrEmpty(Model.ISBN))
               { %>
            <img id="imgBook" src="<%= Url.Content("~/Images/BookCovers/" + Model.ISBN + ".jpg")%>" />
            <% } %>
            <input type="file" name="imgISBN" />
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Author) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Author) %>
            <%: Html.ValidationMessageFor(model => model.Author) %>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.Publisher) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Publisher)%>
            <%: Html.ValidationMessageFor(model => model.Publisher) %>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.Category) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Category) %>
            <%: Html.ValidationMessageFor(model => model.Category) %>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.PublishDate) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PublishDate) %>
            <%: Html.ValidationMessageFor(model => model.PublishDate) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ISBN) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ISBN) %>
            <%: Html.ValidationMessageFor(model => model.ISBN) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.UnitPrice) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.UnitPrice) %>
            <%: Html.ValidationMessageFor(model => model.UnitPrice) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ContentDescription) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ContentDescription,"CkEditor") %>
            <%: Html.ValidationMessageFor(model => model.ContentDescription) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TOC) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TOC,"CkEditor") %>
            <%: Html.ValidationMessageFor(model => model.TOC) %>
        </div>



        <p>
            <input type="submit" value=" 保 存 " />
        </p>
    </fieldset>
    <% } %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Breadcrumb" runat="server">
    <%= Html.ActionLink("图书管理","List") %>
</asp:Content>
