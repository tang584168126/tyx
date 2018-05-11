<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookShop.Register1" %>
<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <h2 class="action_type">
    <img src="Images/register.gif" alt="会员注册" /></h2>
<%--    <form id="signupForm" method="post" class="member_form" runat="server">--%>
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
<%--    </form>--%>
</asp:Content>
