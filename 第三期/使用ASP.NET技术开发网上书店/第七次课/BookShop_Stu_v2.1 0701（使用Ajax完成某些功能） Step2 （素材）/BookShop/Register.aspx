<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookShop.Register" %>
<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        //创建Ajax原生对象
        function createXMLHttpRequest() {
            if (window.ActiveXObject) {  //IE5、IE6
                return new ActiveXObject("Microsoft.XMLHTTP");
            }else if(window.XMLHttpRequest){  //其它浏览器
                return new XMLHttpRequest();
            }
        }

        function userExists(loginId) {
            if (loginId != "") {
                //URL
                var url = "AjaxService/UserExists.aspx?loginId=" + loginId;
                //1、创建Ajax原生对象
                var xhr = createXMLHttpRequest();
                //2、设置回调函数
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4 && xhr.status == 200) {
                        if (xhr.responseText == "true") {
                            $('#loginIdMsg').css("display", "block");
                        } else {
                            $('#loginIdMsg').css("display", "none");
                        }
                    }
                };
                //3、初始化原生对象
                xhr.open("GET", url, true);
                //4、发送请求
                xhr.send(null);
            }
            else {
                $('#loginIdMsg').css("display", "none");
            }

        }

        function registUser() {
            //URL
            var url = "AjaxService/RegistUser.aspx";
            //1、创建Ajax原生对象
            var xhr = createXMLHttpRequest();
            //2、设置回调函数
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4 && xhr.status == 200) {
                    alert(xhr.responseText);
                }
            };
            //3、初始化原生对象
            xhr.open("POST", url, true);
            //4、发送请求
            var loginId = $('#<%= txtLoginId.ClientID%>').val();
            var loginPwd = $('#<%= txtPassword.ClientID%>').val();
            var name = $('#<%= txtName.ClientID%>').val();
            var mail = $('#<%= txtMail.ClientID%>').val();
            var address = $('#<%= txtAddress.ClientID%>').val();
            var phone = $('#<%= txtPhone.ClientID%>').val();

            var userInfo = "loginId=" + escape(loginId) + "&loginPwd=" + escape(loginPwd) + "&name=" + escape(name)
                         + "&mail=" + escape(mail) + "&address=" + escape(address) + "&phone=" + escape(phone);

            xhr.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
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
            <asp:RequiredFieldValidator ID="rfvLoginId" runat="server" ControlToValidate="txtLoginId" Text="请输入用户名"></asp:RequiredFieldValidator>
            <span id="loginIdMsg" style="color:red;display:none">此账号已经被注册</span>
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
                ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}"></asp:RegularExpressionValidator></p>
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
            <asp:Button ID="btnSubmit" runat="server" Text="确定了，马上提交" class="opt_sub" OnClientClick="registUser()"/></p><%--OnClick="btnSubmit_Click"--%>
        <p class="form_sub">加<span>*</span>的为必填项目</p>
        <p class="form_sub">><a href="login.html">已经有账号，马上登录</a><br />
            >如果你已经有“第三波书店”社区账号，请<a href="javascript:alert('书店社区暂未开通');">点这里</a>登录升级</p>
</asp:Content>
