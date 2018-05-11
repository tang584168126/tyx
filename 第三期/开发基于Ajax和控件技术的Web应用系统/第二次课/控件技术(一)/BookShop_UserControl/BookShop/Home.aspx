<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BookShop.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Index.css" rel="stylesheet" type="text/css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <!--sidebar content-->
    <div id="sidebar">
        <ul id="notice">
            <li><a href="#">国庆期间货物延期配送公告</a></li>
            <li><a href="#">北京货到付款订单取... </a></li>
            <li><a href="#">第三波免费服务开通... </a></li>
            <li><a href="#">第三波读书月精彩荟萃</a></li>
        </ul>
        <div id="order_find">
            <label>订单号：</label><input type="text" id="keyword" class="order_key" />
            <input type="submit" id="s_submit" class="order_sub" value="查询状态" />
        </div>
        <div class="service">
            <p>
                <a href="#">
                    <img src="Images/QQ_01.gif" /></a> <a href="#">
                        <img src="Images/QQ_02.gif" /></a> <a href="#">
                            <img src="Images/QQ_02.gif" /></a>
            </p>
            <p>
                <a href="#">
                    <img src="Images/taobao_01.gif" /></a> <a href="#">
                        <img src="Images/taobao_02.gif" /></a>
            </p>
        </div>
        <!--hot books start-->
        <user:SpecialBookList runat="server" ID="SpecialBookList" Title="最受欢迎排行" Num="4" />
    </div>
</asp:Content>
