<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <script src="<%= Url.Content("~/Scripts/jquery-1.7.1.min.js") %>" type="text/javascript"></script>
    <script src="<%= Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%= Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Html.EnableClientValidation(); %>


    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>编辑用户信息</legend>

        <%: Html.HiddenFor(m=>m.Id) %>

        <div class="editor-label">
            <%: Html.LabelFor(m=>m.LoginId) %>
        </div>
        <div class="editor-field">
            <%:Html.TextBoxFor(m=>m.LoginId,  new { disabled="true"})%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(m=>m.Name) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(m=>m.Name) %>
            <%: Html.ValidationMessageFor(m=>m.Name) %>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(m=>m.Address) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(m=>m.Address) %>
            <%: Html.ValidationMessageFor(m=>m.Address) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(m=>m.Phone) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(m=>m.Phone) %>
            <%: Html.ValidationMessageFor(m=>m.Phone) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(m=>m.Mail) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(m=>m.Mail) %>
            <%: Html.ValidationMessageFor(m=>m.Mail) %>
        </div>

        <p>&nbsp;
            <input type="submit" value=" 保 存 " />
        </p>
    </fieldset>
    <% } %>

    <div>
        <%: Html.ActionLink("返回", "List") %>
    </div>

</asp:Content>
