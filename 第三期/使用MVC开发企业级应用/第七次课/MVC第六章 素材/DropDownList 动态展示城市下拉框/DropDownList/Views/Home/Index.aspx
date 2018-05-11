<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>DropDownList</title>
</head>
<body>
    <div>
        <% var items = new List<SelectListItem>();
           items.Add(new SelectListItem() { Text = "北京", Value = "1" });
           items.Add(new SelectListItem() { Text = "上海", Value = "2",Selected=true});//选中项
           items.Add(new SelectListItem() { Text = "天津", Value = "3" });
           items.Add(new SelectListItem() { Text = "重庆", Value = "4" });
           items.Add(new SelectListItem() { Text = "广州", Value = "5" }); 
        %>
        <%=Html.DropDownList("area",items,"请选择") %>

         <%=Html.DropDownList("area",(SelectList)ViewBag.Cities,"请选择") %>
    </div>
</body>
</html>
