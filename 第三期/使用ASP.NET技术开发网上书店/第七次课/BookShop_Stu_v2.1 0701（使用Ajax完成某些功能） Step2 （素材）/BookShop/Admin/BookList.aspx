<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="BookShop.Admin.BookList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphAdmin" runat="server">
    角色：<asp:DropDownList ID="ddlRole" runat="server" Width="120px" AutoPostBack="true" OnSelectedIndexChanged="ddlRole_SelectedIndexChanged"></asp:DropDownList>
    用户：<asp:DropDownList ID="ddlUser" runat="server" Width="120px"></asp:DropDownList>

    <asp:GridView ID="gvBooks" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnPageIndexChanging="gvBooks_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="书名">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="300px" />
            </asp:BoundField>
            <asp:BoundField DataField="Author" HeaderText="作者">
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField DataField="Category.Name" HeaderText="类别">
            <ItemStyle Width="200px" />
            </asp:BoundField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
