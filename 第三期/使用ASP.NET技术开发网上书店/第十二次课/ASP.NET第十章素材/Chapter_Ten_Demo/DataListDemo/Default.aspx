<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataListDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            排序：
            <asp:DropDownList ID="ddlSort" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSort_SelectedIndexChanged">
                <asp:ListItem Value="1">按照类别排序</asp:ListItem>
                <asp:ListItem Value="2">按照价格排序</asp:ListItem>
            </asp:DropDownList>
        </div>
    <div>
        <asp:DataList ID="dlItems" runat="server" DataKeyField="ItemId" OnItemCommand="dlItems_ItemCommand">
            <HeaderTemplate>
                <table class="bold">
                    <tr>
                        <td class="check"><input id="chkAll" type="checkbox" /><br/>全选</td>
                        <td class="img">商品图片</td>
                        <td class="itemName">商品名称/出售者/联系方式</td>
                        <td class="price">价格</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table>
                    <tr>
                        <td rowspan="3" class="check"><input id="chkAll" type="checkbox" /></td>
                        <td rowspan="3" class="img"><img src='<%# Eval("ImagePath") %>' /></td>
                        <td class="itemName"><%# Eval("ItemName") %></td>
                        <td rowspan="3" class="price"><%# Eval("Price") %><br/><br/><br/>
                            <asp:HyperLink ID="hlDelete" runat="server" NavigateUrl="#" Text="删除"></asp:HyperLink> 
                        </td>
                    </tr>
                    <tr>
                        <td><%# Eval("TelePhone") %></td>
                    </tr>
                    <tr>
                        <td><%# Eval("Saler") %></td>
                    </tr>
                </table>
            </ItemTemplate>
            <SeparatorTemplate>
                <hr/>
            </SeparatorTemplate>
        </asp:DataList>
    </div>
        <br/>
    <div>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnPre" runat="server" Text="上一页" OnClick="btnPre_Click" />
        <asp:Button ID="btnNext" runat="server" Text="下一页" OnClick="btnNext_Click" />
    </div>
    </form>
</body>
</html>
