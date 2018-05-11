<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Admin/Views/Shared/Admin.Master" Inherits="System.Web.Mvc.ViewPage<List<BookShop.Models.User>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <script type="text/javascript">
        function selectAll(parentItem) {
            var items = document.getElementsByTagName("input");
            for (i = 0; i < items.length; i++) {
                if (parentItem.checked) {
                    if (items[i].type == "checkbox") {
                        items[i].checked = true;
                    }
                }
                else {
                    if (items[i].type == "checkbox") {
                        items[i].checked = false;
                    }
                }
            }
        }
        function setCheckBoxValue()
        {
            var items = document.getElementsByTagName("input");
            for (i = 0; i < items.length; i++) {
                if (items[i].type == "checkbox") {
                    items[i].value = items[i].checked;
                }
               
            }
        }

    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% using (Html.BeginForm())
       { %>
    <p>
        <input type="button" name="btnEnable" value=" 启用用户 "
            onclick='this.form.action="<%= Url.Action("Enabled", "User")%>    ";setCheckBoxValue();this.form.submit();' />
        <input type="button" name="btnDisable" value=" 禁止用户 "
            onclick='this.form.action="<%= Url.Action("Disabled", "User")%>    ";setCheckBoxValue();this.form.submit();' />
    </p>
    <br />

    <table class="data_table" cellspacing="0" cellpadding="0" rules="all" border="1" id="ctl00_cphAdmin_gvMain" style="border-collapse: collapse;">

        <tr>
            <th scope="col">
                <input id="cbAll" type="checkbox" onclick="selectAll(this)" />
            </th>
            <th scope="col">地址</th>
            <th scope="col">用户名</th>
            <th scope="col">电话</th>
            <th scope="col">姓名</th>
            <th scope="col">Email</th>
            <th scope="col">角色</th>
            <th scope="col">状态</th>
        </tr>

        <% if (Model != null && Model.Count > 0)
           {
               for (int i = 0; i < Model.Count; i++)
               {
                   BookShop.Models.User user = Model[i];
        %>

        <tr style="background-color: <%= i % 2 == 0 ? "White" : "#DDF5D9" %>;">
            <td align="center">
                <input id="chkSelect" type="checkbox" name="checkedUsers[<%=i %>].Checked" >

                <input type="hidden" name="checkedUsers.index" value="<%= i %>" />
                <input type="hidden" name="checkedUsers[<%=i %>].Id" value="<%= user.Id %>" />

            </td>
            <td><%= user.Address %></td>
            <td><%=user.LoginId %></td>
            <td><%= user.Phone %></td>
            <td><%=user.Name %></td>
            <td><%=user.Mail %></td>


            <td><%=user.UserRole.Name %></td>
            <td><%=user.UserState.Name %></td>
        </tr>


        <% }
           } %>
    </table>

    <%} %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Breadcrumb" runat="server">
     <%= Html.ActionLink("用户状态管理","StateList") %>
</asp:Content>