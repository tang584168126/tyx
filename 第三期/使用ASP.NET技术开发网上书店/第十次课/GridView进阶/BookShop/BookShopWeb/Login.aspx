<%@ Page Title="" Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookShopWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
    <link href="Css/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div class="login">
        <img src="Images/login_in.gif"/>
        <p class="state">
            欢迎光临第三波书店网站！<br/>
            您可以使用第三波书店的用户名，直接登陆。
        </p>
        <p><label>用户名：</label>
           <asp:TextBox ID="txtLoginId" runat="server" CssClass="opt_input"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvLoginId" runat="server" ControlToValidate="txtLoginId" Text="用户名不可为空！" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p><label>密码：</label>
           <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="opt_input"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvPwd" runat="server" ControlToValidate="txtPwd" Text="密码不可为空！" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p class="form_sub"><input type="checkbox" name="" checked="checked"/> 在此计算机上保留我的密码</p>
        <p class="form_sub">
            <asp:Button id="btnLogin" runat="server" Text="登陆" CssClass="opt_sub" OnClick="btnLogin_Click"/>
            <a href="Register.aspx">还没有注册？</a>
        </p>
    </div>
</asp:Content>
