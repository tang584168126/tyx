<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<script type="text/javascript">
    alert('请输入分类名称！');
    location.href = '<%=Url.Action("List","Category")%>'

</script>