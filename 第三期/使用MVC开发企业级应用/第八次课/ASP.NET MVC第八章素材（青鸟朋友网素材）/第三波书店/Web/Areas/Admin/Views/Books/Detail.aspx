<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.Book>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    书籍详细信息
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <fieldset>
        <legend>书籍详细信息</legend>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.Title) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Title) %>
        </div>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.Author) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Author) %>
        </div>
        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.Publisher) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Publisher.Name) %>
        </div>
      
        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.PublishDate) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PublishDate) %>
        </div>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.ISBN) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.ISBN) %>
        </div>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.UnitPrice) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.UnitPrice) %>
        </div>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.ContentDescription) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.ContentDescription,"html") %>
        </div>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.TOC) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.TOC,"html") %>
        </div>

        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.Clicks) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Clicks) %>
        </div>
    </fieldset>
    <p>


        <%: Html.ActionLink("返回图书列表", "Index","Books") %>
    </p>

</asp:Content>
