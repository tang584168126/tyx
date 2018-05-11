<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/body.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/jquery-2.1.1.js"></script> 
</head>
<body>
    <div class="container">
        <section id="content">
            <form action="#" runat="server">
                <h1>会员登录</h1>
                <div>                    
                    <input type="text" placeholder="邮箱/帐号" required="" id="username" name="username"/>                   
                </div>
                <div>
                    <input type="password"placeholder="密码" required="" id="password" name="password"/>  
                   
                </div>
                <div class="">
                    <span class="help-block u-errormessage" id="js-server-helpinfo">&nbsp;</span>
                </div>
                <div>
                 
                    <!-- <input type="submit" value="Log in" /> -->
                   <%-- <input type="submit" value="登录" class="btn btn-primary" id="js-btn-login" />--%>
                    <asp:Button ID="btnSubmit"  runat="server" Text="登录" OnClick="btnSubmit_Click" />
                    <a href="#">忘记密码?</a>
                    <!-- <a href="#">Register</a> -->
                </div>
            </form>
            <!-- form -->
            <div class="button">
                <span class="help-block u-errormessage" id="Span1">&nbsp;</span>
                <a href="Regist.aspx">注册</a>
            </div>
            <!-- button -->
        </section>
        <!-- content -->
    </div>
    <!-- container -->
    <br/>
    <br/>
    <br/>
    <br/>
    <div style="text-align: center;">
    </div>
</body>
</html>
