<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<BookShop.Models.User>" %>

<%@ Import Namespace="BookShopMvc.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<%
        using (Html.BeginForm("Edit", "Account", FormMethod.Post))
        {
    %>
    <%: Html.LabelFor(m=>m.LoginId,"账号") %>
    <%: Html.TextBoxFor(m=>m.LoginId) %>
    <%: Html.LabelFor(m=>m.Name,"姓名") %>
    <%: Html.TextBoxFor(m=>m.Name) %>
    <%: Html.LabelFor(m=>m.Mail,"邮箱") %>
    <%: Html.TextBoxFor(m=>m.Mail) %>

    <%= Html.Submit("Submit","提交") %>
    <%
        }<script src="../../../../ckeditor/ckeditor.js"></script>
    %>--%>
    <script src="<%= Url.Content("../../../../ckeditor/ckeditor.js") %>"></script>
    <%
        using (Html.BeginForm())
        {
    %>
    <%: Html.TextArea("content", new { style="width:80%"})%>
    <script>
        CKEDITOR.replace('content');
    </script>
    <p>
        <input type="submit" name="upload" value="提交" />
    </p>
    <%
    }
    %>
</asp:Content>
