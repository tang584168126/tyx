<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpecialBookList.ascx.cs" Inherits="BookShop.UserControl.SpecialBookList" %>
<%@ Import Namespace="BookShop.BLL" %>

<style type="text/css">
    .ranklist li
    {
        overflow: hidden;
        width: 100%;
        float: left;
        clear: both;
    }
    .num
    {
        display: block;
        background: url(Images/list01.gif) no-repeat left top;
        float: left;
        margin: 7px 8px 0px 0px;
        font: 9px/11px Arial, Helvetica, sans-serif;
        width: 11px;
        color: #853200;
        text-align: center;
    }
    .cover
    {
        border-right: #d3d3d3 1px solid;
        border-top: #d3d3d3 1px solid;
        margin-top: 5px;
        display: block;
        float: left;
        margin-bottom: 10px;
        border-left: #d3d3d3 1px solid;
        width: 54px;
        border-bottom: #d3d3d3 1px solid;
        height: 54px;
        background-color: #ffffff;
        text-align: center;
    }
    .cover img
    {
        width: 50px;
    }
    .content
    {
        padding-right: 0px;
        padding-left: 10px;
        float: left;
        padding-bottom: 0px;
        margin: 0px 0px 10px;
        color: #666;
        line-height: 16px;
        padding-top: 7px;
    }
    .content A
    {
        display: block;
        padding-bottom: 9px;
    }
</style>

<div class="sidedt laster">
    <h1><%= this.Title %></h1>
    <asp:Repeater ID="rptRankings" runat="server">
        <HeaderTemplate>
            <ul class="ranklist">
        </HeaderTemplate>
        <ItemTemplate>
            <div id="div1" runat="server" visible='<%# Container.ItemIndex==0?true:false  %>'>
                <li><span class="num">
                    <%# Container .ItemIndex +1 %>
                </span>
                    <div class="cover">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "~/BookDetail.aspx?bid=" + Eval("Id").ToString() %>'
                            ImageUrl='<%# StringUtility.CoverUrl(Eval("ISBN")) %>'></asp:HyperLink>
                    </div>
                    <div class="content">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/BookDetail.aspx?bid=" + Eval("Id").ToString() %>'>
                <%# Eval("Title") %></asp:HyperLink>
                        出版时间：
                <br />
                        <%# StringUtility.ToShortDate(Eval("PublishDate"))%>
                        <br />
                        出 版 社：
                <br />
                        <%# Eval("Publisher.Name")%>
                    </div>
                </li>
            </div>
            <div id="div2" style="text-align: left" runat="server" visible='<%# Container.ItemIndex==0?false:true  %>'>
                <li><span class="num">
                    <%# Container .ItemIndex +1 %>
                </span>
                    <asp:HyperLink ID="hlkTitle" runat="server" NavigateUrl='<%# "~/BookDetail.aspx?bid=" + Eval("Id").ToString() %>'
                        ToolTip='<%# Eval("Title") %>'><%# StringUtility.CutString(Eval("Title"),15)%></asp:HyperLink>
                </li>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
</div>