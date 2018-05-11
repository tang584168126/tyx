<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="BookShopWeb.Admin.BookList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <script lang="javascript">
        function GetAllCheckBox(CheckAll)
        {
            var items = document.getElementsByTagName("input");
            for(var i = 0; i < items.length; i++)
            {
                if(items[i].type == "checkbox")
                {                    
                    items[i].checked = CheckAll.checked;
                }
            }           
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="searchCondition">
        检索类别：
        <asp:DropDownList ID="ddlCategories" runat="server">
            <asp:ListItem>书名</asp:ListItem>
            <asp:ListItem>内容简介</asp:ListItem>
            <asp:ListItem>出版社</asp:ListItem>
            <asp:ListItem>作者</asp:ListItem>
        </asp:DropDownList>
        关键字：
        <asp:TextBox ID="txtKeyWord" runat="server"></asp:TextBox>
        <asp:Button ID="btnQuery" runat="server" Text="查询" OnClick="btnQuery_Click" /> 
        <asp:HyperLink ID="hlkAddBook" runat="server" NavigateUrl="#">添加书籍</asp:HyperLink> 
        <asp:Button ID="btnDel" runat="server" Text="删除" OnClick="btnDel_Click" />
    </div>
    <div>
        <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" EmptyDataText="没有可显示的数据记录。" AllowPaging="True" AllowSorting="True" CellPadding="4" OnPageIndexChanging="gvBooks_PageIndexChanging" OnRowDataBound="gvBooks_RowDataBound" Width="780px" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField Visible="False" HeaderText="编号">
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%#Bind("Id") %>'>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFormatString="BookDetail.aspx?id={0}" HeaderText="书名"
                    ControlStyle-Width="180" Text="编辑" DataNavigateUrlFields="id" DataTextField="Title"
                    SortExpression="Title" />
                <asp:BoundField DataField="Author" HeaderText="作者" />
                <asp:TemplateField HeaderText="类别">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Category.Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFormatString="BookEdit.aspx?id={0}" Text="编辑"
                    DataNavigateUrlFields="id" >
                <ControlStyle Width="50px" />
                </asp:HyperLinkField>
                <asp:TemplateField HeaderText="全选">
                    <HeaderTemplate>
                        <input id="cbxHead" type="checkbox" onclick="GetAllCheckBox(this)"/>全选
                    </HeaderTemplate>
                    <ItemTemplate>                        
                        <asp:CheckBox ID="chkSelect" runat="server" />                        
                    </ItemTemplate>
                </asp:TemplateField>
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
    </div>
</asp:Content>
