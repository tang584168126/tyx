<%@ Page Title="" Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookShopWeb.Register" %>
<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="server">
    <link href="Css/register.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div id="action_area" class="member_form">
        <h2 class="action_type">
            <img src="Images/register.gif" alt="会员注册" /></h2>
        <p>
            <label><span>*</span>用户名</label>
            <asp:TextBox CssClass="opt_input" ID="txtLoginId" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valrLoginId" runat="server" ErrorMessage="请输入用户名"
                ControlToValidate="txtLoginId">*</asp:RequiredFieldValidator></p>
        <p>
            <label><span>*</span>真实姓名</label>
            <asp:TextBox CssClass="opt_input" ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valrName" runat="server" ErrorMessage="请输入真实姓名" ControlToValidate="txtName">*</asp:RequiredFieldValidator>5-12个字符或数字组成，可用中文
        </p>
        <p>
            <label><span>*</span>密码</label>
            <asp:TextBox CssClass="opt_input" ID="txtLoginPwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valrPass" runat="server" ErrorMessage="请输入密码" ControlToValidate="txtLoginPwd">*</asp:RequiredFieldValidator></p>
        <p>
            <label><span>*</span>确认密码</label>
            <asp:TextBox CssClass="opt_input" ID="txtPwdAgain" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="valcPwd" runat="server" ErrorMessage="两次密码不一致" ControlToCompare="txtLoginPwd"
                ControlToValidate="txtPwdAgain">*</asp:CompareValidator>
        </p>
        <p>
            <label><span>*</span>Email</label>
            <asp:TextBox CssClass="opt_input" ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valrEmail" runat="server" ErrorMessage="请输入Email"
                ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="valeEmail" runat="server" ErrorMessage="Email格式错误"
                ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        </p>
        <p>
            <label><span>*</span>地址</label>
            <asp:TextBox CssClass="opt_input" ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valrAddr" runat="server" ErrorMessage="请输入地址" ControlToValidate="txtAddress">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <label><span>*</span>手机</label>
            <asp:TextBox CssClass="opt_input" ID="txtTele" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valrTel" runat="server" ErrorMessage="请输入手机号" ControlToValidate="txtTele">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\d{11}"
                ControlToValidate="txtTele" ErrorMessage="手机号位数不正确">*</asp:RegularExpressionValidator>
        </p>
        <p>
            <label><span>*</span>验证码</label>
            <asp:TextBox CssClass="opt_input" ID="txtCode" runat="server"></asp:TextBox>&nbsp;
            <cc1:SerialNumber ID="snCode" runat="server"></cc1:SerialNumber>
            <asp:ValidationSummary ID="valsRegister" runat="server" ShowMessageBox="True" ShowSummary="False" /></p>
        <p class="form_sub">
            <asp:Button ID="btnRegister" OnClick="btnSubmit_Click"  runat="server" Text="确定了，马上提交" CssClass="opt_sub"></asp:Button></p>
        <p class="form_sub">
            &nbsp;加<span>*</span>的为必填项目</p>
        <p class="form_sub">
            <a href="#">已经有账号，马上登录</a><br />
            如果你已经有“第三波书店”社区账号，请点<a href="javascript:alert('书店社区暂未开通');">这里</a>登录升级</p>
    </div>
</asp:Content>
