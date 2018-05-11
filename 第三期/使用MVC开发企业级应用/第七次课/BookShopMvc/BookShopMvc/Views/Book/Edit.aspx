<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Commom.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.Book>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <script src="<%= Url.Content("~/My97DatePicker/My97DatePicker/WdatePicker.js") %>"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%: Html.EditorFor(m=>m.PublishDate) %>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Book</legend>

        <%: Html.HiddenFor(model => model.Id) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Title) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Title) %>
            <%: Html.ValidationMessageFor(model => model.Title) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Author) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Author) %>
            <%: Html.ValidationMessageFor(model => model.Author) %>
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
            <%: Html.EditorFor(model => model.ContentDescription) %>
            <%: Html.ValidationMessageFor(model => model.ContentDescription) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TOC) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TOC) %>
            <%: Html.ValidationMessageFor(model => model.TOC) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Clicks) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Clicks) %>
            <%: Html.ValidationMessageFor(model => model.Clicks) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
