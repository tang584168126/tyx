﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Old.aspx.cs" Inherits="BookShop.Register" %>

<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <meta name="Robots" content="index,follow" />
    <title>"第三波书店"-网上书店</title>
    <link href="CSS/global.css" rel="stylesheet" type="text/css" />
    <link href="CSS/member.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="top">
        <div class="member">
            <ul>
                <li><a href="#">
                    <img src="Images/payVIP.gif" height="18" alt="开通VIP" /></a></li>
                <li><a href="#">
                    <img src="Images/payCoin.gif" height="18" alt="学币中心" /></a></li>
            </ul>
        </div>
        <div class="status">您好，欢迎来到第三波书店^_^   <span><a href="#">【登录】【免费注册】</a></span> </div>
    </div>

    <div id="header">
        <div id="logo">
            <img src="Images/logo.gif" alt="第三波书店" /></div>
        <div id="nav">
            <div id="a_b_01">
                <img src="images/a_b_01.gif" />[<img src="images/taobao.gif" />
                <a href="#">分站</a>]</div>
            <ul id="mainnav">
                <li class="current"><a href="#">首页</a></li>
                <li><a href="#">登录</a></li>
                <li><a href="#">注册</a></li>
                <li><a href="#">商讯</a></li>
                <li><a href="#">购物流程</a></li>
                <li><a href="#">在线客服</a></li>
                <li><a href="#">积分兑换</a></li>
                <li><a href="#">书籍求购</a></li>
                <li><a href="#">帮助</a></li>
            </ul>
        </div>
    </div>

    <div id="container">
        <!--left content-->
        <div id="intro">
            <div id="basket"><a href="#">目前您的购物篮是空的</a></div>
            <div id="search">
                <form action="#" method="post" target="_blank">
                    <input type="text" id="keyword" class="search_key" />
                    <input type="submit" id="s_submit" class="search_sub" value="" />
                </form>
            </div>
            <div id="alltype">
                <h1 class="all_type black"><a href="#">查看所有分类>></a></h1>
                <div id="subnav">
                    <ul class="black">
                        <li><a href="#">VIP中心</a></li>
                        <li><a href="#">新品上架</a></li>
                        <li><a href="#">新书热卖</a></li>
                        <li><a href="#">畅销排行</a></li>
                        <li><a href="#">商务英语</a></li>
                        <li><a href="#">英语口译</a></li>
                        <li><a href="#">日语考试</a></li>
                        <li><a href="#">实用日语</a></li>
                        <li><a href="#">英语考试</a></li>
                        <li><a href="#">实用英语</a></li>
                        <li><a href="#">出国留学</a></li>
                        <li><a href="#">英文原版</a></li>
                        <li><a href="#">考研图书</a></li>
                        <li><a href="#">所有图书</a></li>
                        <li><a href="#">在线读书</a></li>
                        <li><a href="#">电子词典</a></li>
                        <li><a href="#">计算机类</a></li>
                        <li><a href="#">科普读物</a></li>
                        <li><a href="#">建筑门类</a></li>
                    </ul>
                </div>
                <!--subnav end-->
            </div>
            <!--link start-->
            <div id="choice_pub">
                <select name="publishs" id="publishs" class="n_select">
                    <option>>>根据出版社选择图书</option>
                    <option>北京师范大学出版社</option>
                    <option>电子工业出版社</option>
                </select>

                <select name="publishs" id="special" class="n_select">
                    <option>>>根据专题选择图书</option>
                    <option>国庆出游专题</option>
                    <option>新年计划专题</option>
                </select>
            </div>

            <div id="s_b_03"><a href="#">赖世雄美语从头学</a><br />
                <a href="#">沪江团购 ，价格更优惠</a></div>
            <!--link start-->
        </div>

        <div id="action_area">
            <h2 class="action_type">
                <img src="Images/register.gif" alt="会员注册" /></h2>
            <form id="signupForm" method="post" class="member_form" runat="server">
                <p>
                    <label><span>*</span>用户名</label>
                    <asp:TextBox ID="txtLoginId" CssClass="opt_input" runat="server"></asp:TextBox>6-15个字符或数字组成，可用中文名</p>
                <p>
                    <label><span>*</span>密码</label>
                    <asp:TextBox ID="txtPassword" CssClass="opt_input" runat="server"></asp:TextBox>请输入密码</p>
                <p>
                    <label><span>*</span>确认密码</label>
                    <asp:TextBox ID="txtRePassword" CssClass="opt_input" runat="server"></asp:TextBox>请再次输入密码</p>
                <p>
                    <label><span>*</span>真实姓名</label>
                    <asp:TextBox ID="txtName" CssClass="opt_input" runat="server"></asp:TextBox>请输入你的真实姓名</p>
                <p>
                    <label><span>*</span>Email</label>
                    <asp:TextBox ID="txtMail" CssClass="opt_input" runat="server"></asp:TextBox>请输入电子邮件</p>
                <p>
                    <label><span>*</span>地址</label>
                    <asp:TextBox ID="txtAddress" CssClass="opt_input" runat="server"></asp:TextBox>请输入地址</p>
                <p>
                    <label><span>*</span>手机</label>
                    <asp:TextBox ID="txtPhone" CssClass="opt_input" runat="server"></asp:TextBox>请输入电话号码</p>
                <p>
                    <label><span style="visibility:hidden">*</span></label>
                    <cc1:SerialNumber ID="snCode" runat="server"></cc1:SerialNumber><br/>
                    <label><span>*</span>验证码</label>
                    <asp:TextBox ID="txtCode" CssClass="opt_input" runat="server"></asp:TextBox>                    
                    请输入验证码</p>
                <p class="form_sub">
                    <input type="checkbox" name="" checked="checked" />
                    在此计算机上保留我的密码</p>
                <p class="form_sub">
                    <asp:Button ID="btnSubmit" runat="server" Text="确定了，马上提交" class="opt_sub" OnClick="btnSubmit_Click"/></p>
                <p class="form_sub">加<span>*</span>的为必填项目</p>
                <p class="form_sub">><a href="login.html">已经有账号，马上登录</a><br />
                    >如果你已经有“第三波书店”社区账号，请<a href="javascript:alert('书店社区暂未开通');">点这里</a>登录升级</p>
            </form>
        </div>

    </div>

    <div id="footer">
        <!--contac us-->
        <div class="telephone">
            <strong>热线</strong> 021-61508168　<strong>传真</strong> 021-61508168-8020　
            <br />
            <strong>Q Q</strong>375013071  13483528    562655482  1143735195（技术)<br />
            <strong>MSN</strong> hjservice@hotmail.com   <strong>信箱</strong> shop@hjenglish.com<br />
            <strong>帮助</strong> <a href="/help/help.aspx" target="_blank">银行汇款帐户</a> <a href="/help/help.aspx#help_post" target="_blank">邮局汇款地址</a> 	<a href="/help/help.aspx#help_ship" target="_blank">送货方式及费用</a> <a href="http://www.hjenglish.com/down/faq_2.htm" target="_blank">如何进行下载</a>
        </div>
        <!---->
        <div class="imp_link">
            <img src="Images/alipay.gif" alt="支付宝支付" /><img src="Images/online_pay.gif" alt="在线支付" /><br />
            <a href="http://www.hjenglish.com/about/aboutus.htm" target="_blank">网站介绍</a>　<a href="http://www.hjenglish.com/about/partner.htm" target="_blank">合作伙伴</a>　<a href="#" target="_blank">网站地图</a>　<a href="#" target="_blank">联系我们</a><br />
            <a href="#" target="_blank">增值电信业务经营许可证沪B2-20040503</a>
        </div>
    </div>

    <div id="child_site">
        <strong>分站</strong>　 <a href="#" target="_blank">沪江网</a>  <a href="#" target="_blank">听说</a>  <a href="#" target="_blank">口译</a>  <a href="#" target="_blank">CET</a>  <a href="#" target="_blank">考研</a>  <a href="#" target="_blank">雅思</a>  <a href="#" target="_blank">托福</a>  <a href="#" target="_blank">日语</a>  <a href="#" target="_blank">法语</a>  <a href="#" target="_blank">下载</a>  <a href="#" target="_blank">文库</a>  <a href="#" target="_blank">部落</a>  <a href="#" target="_blank">博客</a>  <a href="#" target="_blank">词典</a>  <a href="#" target="_blank">IT新闻</a>  <a href="#" target="_blank">博客园</a>  <a title="新世界日语" href="#" target="_blank">新世界日语</a>  <a title="2010考研书籍推荐专题" href="#" target="_blank">2010考研书籍</a>
    </div>
    <script type="text/javascript" src="Scripts/jquery-1.8.2.js"></script>
    <script type="text/javascript" src="Scripts/jquery.validate.js"></script>
<%--    <script type="text/javascript" src="Scripts/customValidate.js"></script>--%>
</body>
</html>
