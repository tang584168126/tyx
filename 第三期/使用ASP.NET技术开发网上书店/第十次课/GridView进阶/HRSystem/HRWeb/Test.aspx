<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="HRWeb.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>员工信息管理</title>
    <script type="text/javascript">
        function GetAllCheckBox(CheckAll) {
            var items = document.getElementsByTagName("input");
            for (i = 0; i < items.length; i++) {
                if (items[i].type == "checkbox") {
                    items[i].checked = CheckAll.checked;
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvHR" runat="server" AutoGenerateColumns="False" OnRowEditing="gvHR_RowEditing" OnSelectedIndexChanging="gvHR_SelectedIndexChanging" OnRowCancelingEdit="gvHR_RowCancelingEdit" OnRowCommand="gvHR_RowCommand" OnRowDataBound="gvHR_RowDataBound" OnRowDeleting="gvHR_RowDeleting" OnRowUpdating="gvHR_RowUpdating">
            <Columns>
                <asp:BoundField DataField="userId" Visible="False" />
                <asp:TemplateField HeaderText="姓名">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("username") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="性别">
                    <EditItemTemplate>
                        <asp:HiddenField ID="hfGender" runat="server" Value='<%# Eval("gender") %>' />
                        <asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem Value="True">男</asp:ListItem>
                            <asp:ListItem Value="False">女</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%# Eval("gender").ToString() == "True" ? "男" : "女" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="职务">
                    <EditItemTemplate>
                        <asp:HiddenField ID="hfDuty" runat="server" Value='<%# Eval("postId") %>' />
                        <asp:DropDownList ID="ddlDuty" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDuty" runat="server" Text='<%# GetDutyName(Eval("postID").ToString()) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="电话">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPhone" runat="server" Text='<%# Bind("telePhone") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPhone" runat="server" Text='<%# Eval("telePhone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="地址">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("address") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="选择" ShowSelectButton="True" />
                <asp:CommandField HeaderText="操作" ShowEditButton="True" />
                <asp:TemplateField HeaderText="删除">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnDel" runat="server" Text="删除" CommandArgument='<%# Eval("userId") %>' CommandName="Del"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="全选">
                    <HeaderTemplate>
                        <input type="checkbox" onclick="GetAllCheckBox(this)"/>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chbSelect" runat="server" />
                    </ItemTemplate>
                    <ControlStyle Width="20px" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
