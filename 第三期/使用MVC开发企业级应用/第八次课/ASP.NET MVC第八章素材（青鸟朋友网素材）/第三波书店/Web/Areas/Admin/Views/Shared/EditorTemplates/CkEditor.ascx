<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
  <%: Html.TextAreaFor(m=>m,new { style = "width:80%" })%>
  <script type="text/javascript">
      CKEDITOR.replace('<%= ViewData.ModelMetadata.PropertyName %>');
 </script>

