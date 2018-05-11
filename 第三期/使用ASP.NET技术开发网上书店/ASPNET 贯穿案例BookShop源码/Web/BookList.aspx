<%@ Page Title="" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true"
    CodeFile="BookList.aspx.cs" Inherits="BookList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHeader" runat="Server">
    <link href="Css/channel.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="main">
        <div class="list_asc">
            <!--choice order type-->
            <div class="type_choice f_left">
                排序方式
                <asp:DropDownList ID="ddlOrder" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged">
                    <asp:ListItem Value="1">按出版日期排序</asp:ListItem>
                    <asp:ListItem Value="2">按价格排序</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        <h3 class="progress_bar">正在数据加载中,请稍后......</h3>
                    </ProgressTemplate>
                </asp:UpdateProgress>

                <asp:DataList ID="dlBooks" runat="server">
                    <ItemTemplate>
                        <table id="tbBooks" class="list_area">
                            <tr>
                                <td rowspan="2" class="td_left">
                                    <a href="BookDetail.aspx?bid=<%# Eval("Id")%>">
                                        <img alt="" src="<%# GetUrl(Eval("ISBN").ToString()) %>" />
                                    </a>
                                </td>
                                <td class="td_right">
                                    <a href="BookDetail.aspx?bid=<%# Eval("Id")%>" name="link_prd_name" target="_blank"
                                        class="b_title" id="link_prd_name">
                                        <%# Eval("Title") %></a>
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <span>
                                        <%# Eval("Author") %></span><br />
                                    <br />
                                    <span>
                                        <%# StringUtility.CutString(Eval("ContentDescription"), 150)%></span>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    价格： <span class="red">
                                        <%# StringUtility.ToMoney(Eval("UnitPrice"))%></span>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                    </SeparatorTemplate>
                </asp:DataList>
                <div class="pages">
                    <asp:Label runat="server" ID="lblCurrentPage"></asp:Label>
                    <asp:Button ID="btnPrev" runat="server" Text="上一页" OnClick="btnPrev_Click" />
                    <asp:Button ID="btnNext" runat="server" Text="下一页" OnClick="btnNext_Click" />
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlOrder" EventName="SelectedIndexChanged"/>
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>
