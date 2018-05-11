﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.User>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>User</title>
</head>
<body>
    <script src="<%: Url.Content("~/Scripts/jquery-1.7.1.min.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"></script>

    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>User</legend>

        <%: Html.HiddenFor(model => model.Id) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.LoginId) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.LoginId) %>
            <%: Html.ValidationMessageFor(model => model.LoginId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.LoginPwd) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.LoginPwd) %>
            <%: Html.ValidationMessageFor(model => model.LoginPwd) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PasswordConfirm) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PasswordConfirm) %>
            <%: Html.ValidationMessageFor(model => model.PasswordConfirm) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Name) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Name) %>
            <%: Html.ValidationMessageFor(model => model.Name) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Address) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Address) %>
            <%: Html.ValidationMessageFor(model => model.Address) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Phone) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Phone) %>
            <%: Html.ValidationMessageFor(model => model.Phone) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Mail) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Mail) %>
            <%: Html.ValidationMessageFor(model => model.Mail) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</body>
</html>
