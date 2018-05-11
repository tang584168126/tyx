<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookShop.Register" %>
<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var xhr;
        function createXMLHttpRequest() {
            if (window.ActiveXObject) {     //IE浏览器
                return new ActiveXObject("Microsoft.XMLHTTP");
            } else if (window.XMLHttpRequest) {   //非IE浏览器
                return new XMLHttpRequest();
            }
        }

        //验证要账户是否已注册
        function userExists(loginId) {
            if (loginId != "") {
                //请求字符串
                var url = "AjaxService/UserExists.aspx?loginId=" + loginId;
                //1、创建XMLHttpRequest对象
                xhr = createXMLHttpRequest();
                //2、设置回调函数
                xhr.onreadystatechange = readyDo;
                //3、初始化XMLHttpRequest对象
                xhr.open("GET", url, true);
                //4、发送请求
                xhr.send();
            } else {
                document.getElementById("loginIdMsg").style.display = "none";
            }
        }

        function readyDo() {
            if (xhr.readyState == 4 && xhr.status == 200) {
                var result = xhr.responseText;

                if (result == "true") {
                    document.getElementById("loginIdMsg").style.display = "inline";
                } else {
                    document.getElementById("loginIdMsg").style.display = "none";
                }
            }
        }

        function registerUser() {
            //请求字符串
            var url = "AjaxService/RegisterUser.aspx";
            //1、创建XMLHttpRequest对象
            xhr = createXMLHttpRequest();
            //2、设置回调函数
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4 && xhr.status == 200) {
                    var result = xhr.responseText;
                    if (result == "注册成功") {
                        alert("注册成功！");
                        window.location.href = "Home.aspx";
                    }
                }
            };
            //3、初始化XMLHttpRequest对象
            xhr.open("POST", url, true);
            //4、发送请求
            var loginId = document.getElementById('<%= txtLoginId.ClientID %>').value;
            var loginPwd = document.getElementById('<%= txtPassword.ClientID %>').value;
            var name = document.getElementById('<%= txtName.ClientID %>').value;
            var mail = document.getElementById('<%= txtMail.ClientID %>').value;
            var address = document.getElementById('<%= txtAddress.ClientID %>').value;
            var phone = document.getElementById('<%= txtPhone.ClientID %>').value;

            var userInfo = "loginId=" + escape(loginId) + "&loginPwd=" + escape(loginPwd) + "&name=" + escape(name) +
                           "&mail=" + escape(name) + "&address=" + escape(address) + "&phone=" + escape(phone);

            xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            xhr.send(userInfo);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
        <h2 class="action_type">
    <img src="Images/register.gif" alt="会员注册" /></h2>
        <p>
            <label><span>*</span>用户名</label>
            <asp:TextBox ID="txtLoginId" CssClass="opt_input" runat="server" onblur="userExists(this.value)"></asp:TextBox>
            <span id="loginIdMsg" style="color:red; display:none">该账户名已注册，请重新输入</span>
            <asp:RequiredFieldValidator ID="rfvLoginId" runat="server" ControlToValidate="txtLoginId" Text="请输入用户名"></asp:RequiredFieldValidator>            
        </p>
        <p>
            <label><span>*</span>密码</label>
            <asp:TextBox ID="txtPassword" CssClass="opt_input" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" Text="请输入密码"></asp:RequiredFieldValidator></p>
        <p>
            <label><span>*</span>确认密码</label>
            <asp:TextBox ID="txtRePassword" CssClass="opt_input" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="cvRepassword" runat="server" ControlToValidate="txtRePassword" ControlToCompare="txtPassword" Text="两次密码输入不一致"></asp:CompareValidator></p>
        <p>
            <label><span>*</span>真实姓名</label>
            <asp:TextBox ID="txtName" CssClass="opt_input" runat="server"></asp:TextBox>5-15个字符或数字组成，可用中文名
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" Text="请输入真实姓名"></asp:RequiredFieldValidator> </p>
        <p>
            <label><span>*</span>Email</label>
            <asp:TextBox ID="txtMail" CssClass="opt_input" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvMail" runat="server" ControlToValidate="txtMail" Text="请输入Email"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revMail" runat="server" ControlToValidate="txtMail" Text="Email格式错误"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator></p>
        <p>
            <label><span>*</span>地址</label>
            <asp:TextBox ID="txtAddress" CssClass="opt_input" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" Text="请输入地址"></asp:RequiredFieldValidator></p>
        <p>
            <label><span>*</span>电话号码</label>
            <asp:TextBox ID="txtPhone" CssClass="opt_input" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" Text="请输入手机号"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" Text="手机号位数不正确" 
                ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}">*</asp:RegularExpressionValidator></p>
        <p>
            <label><span style="visibility:hidden">*</span></label>
            <cc1:SerialNumber ID="snCode" runat="server"></cc1:SerialNumber><br/>
            <label><span>*</span>验证码</label>
            <asp:TextBox ID="txtCode" CssClass="opt_input" runat="server"></asp:TextBox>                    
            <asp:RequiredFieldValidator ID="rfvCode" runat="server" ControlToValidate="txtCode" Text="请输入验证码"></asp:RequiredFieldValidator></p>
        <p class="form_sub">
            <input type="checkbox" name="" checked="checked" />
            在此计算机上保留我的密码</p>
        <p class="form_sub">
            <%--OnClick="btnSubmit_Click"--%>
            <asp:Button ID="btnSubmit" runat="server" Text="确定了，马上提交" class="opt_sub" OnClientClick="registerUser();return false;"/></p>
        <p class="form_sub">加<span>*</span>的为必填项目</p>
        <p class="form_sub">><a href="login.html">已经有账号，马上登录</a><br />
            >如果你已经有“第三波书店”社区账号，请<a href="javascript:alert('书店社区暂未开通');">点这里</a>登录升级</p>
</asp:Content>
