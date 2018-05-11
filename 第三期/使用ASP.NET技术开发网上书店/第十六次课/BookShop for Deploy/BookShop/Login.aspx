<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookShop.Login" %>

<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <h2 class="action_type"><img src="Images/login_in.gif" alt="会员登录" /></h2>
    <p class="state">欢迎光临第三波书店网站，本站为淘宝网旗下专业在线书店！<br />您可以使用第三波书店的用户名，直接登录。</p>
    <p>
        <label>用户名</label>        
        <asp:TextBox ID="txtLoginId" runat="server" CssClass="opt_input"></asp:TextBox>
    </p>
    <p>
        <label>密&#160;&#160;码</label>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="opt_input"></asp:TextBox>
    </p>
    <p>
        <label>&nbsp;</label>
        <cc1:SerialNumber ID="snCode" runat="server"></cc1:SerialNumber>
    </p>
    <p>
        <label>验证码</label>
        <asp:TextBox ID="txtCode" runat="server" CssClass="opt_input"></asp:TextBox>
    </p>
    <p class="form_sub"><input type="checkbox" name=""  checked="checked" />在此计算机上保留我的密码</p>
    <p class="form_sub">
        <asp:Button ID="btnSubmit" runat="server" Text="登入" class="opt_sub" OnClick="btnSubmit_Click" />        
        <a href="#">忘记密码？</a>
    </p>
</asp:Content>
