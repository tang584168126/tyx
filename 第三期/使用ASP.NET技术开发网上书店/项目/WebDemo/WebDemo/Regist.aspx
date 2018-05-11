<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="WebDemo.Regist" %>

<%@ Register Assembly="MyControls" Namespace="MyControls" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/normalize.css" rel="stylesheet"/>
    <link href="css/jquery-ui.css" rel="stylesheet"/>
    <link href="css/jquery.idealforms.min.css" rel="stylesheet" media="screen"/>

<style type="text/css">
body{font:normal 15px/1.5 Arial, Helvetica, Free Sans, sans-serif;color: #222;background:url(images/pattern.GIF);overflow-y:scroll;padding:60px 0 0 0;}
#myform{width:755px;margin:0 auto;border:1px  solid #ccc;padding:3em;border-radius:3px;box-shadow:0 0 2px rgba(0,0,0,.2);}
#comments{width:350px;height:100px;}

</style>
    <script>
        //客户端验证上传图格式
        function Check_Images()
        {
            var route =document.getElementById("file1").value;
            var layout = route.lastIndexOf(".");
            var pictname = route.substring(layout, route.length);
            if (pictname.toLowerCase() != ".jpg" && pictname.toLowerCase() != ".gif" && pictname.toLowerCase() != ".png" && pictname.toLowerCase() != "") {
                alert("你上传的文件类型为" + pictname + ",图片必须为JPG或GIF或PNG");
                return false;
            } else
            {
                return true;
            }
        }

        //创建Ajax原生对象
        function createXMLHttpRequest()
        {
            if (window.ActiveXObject) {
                return new ActiveXObject("Microsoft.XMLHTTP");
            }
            else if(window.XMLHttpRequest){
                return new XMLHttpRequest();
            }
        }

        function userExists(loginId)
        {
            if (loginId != "") {
                //URL
                var url = "AjaxService/UserRist.aspx?loginId=" + loginId;
                // 创建Ajax原生对象
                var xhr = createXMLHttpRequest();
                //设置回调函数
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4 && xhr.status == 200) {
                        if (xhr.responseText == "true") {
                            $('#loginIdMsg').css("display", "block");
                          
                        } else {
                            $('#loginIdMsg').css("display", "none");
                        }
                    }
                }

                //初始化原生对象
                xhr.open("GET", url, true);
                //发送请求
                xhr.send(null);
            } else {
                $('#loginIdMsg').css("display", "none");
            }
        }

  </script>
</head>
<body>


<div class="row">

  <div class="eightcol last">

     
      <!-- Begin Form -->

    <form id="myform" runat="server"  >
        <asp:ScriptManager ID="script" runat="server"></asp:ScriptManager>      
        <section name="第一步" >
          <div><label>用户名:</label><input id="username" name="username" type="text" runat="server" onblur="userExists(this.value)"/></div>
          <span id="loginIdMsg" style="color:red;display:none;">&nbsp;&nbsp;此账号已经被注册</span>
          <div><label>昵称:</label><input id="userId" name="userId" type="text"  runat="server"/></div>     
          <div><label>密码:</label><input id="pass" name="password" type="password" /></div>
          <div><label>邮箱:</label><input id="email" name="email" data-ideal="required email" type="text"  runat="server"/></div>       
          <div><label>上传头像:</label><%--<input id="file" name="file"  type="file" runat="server"/>--%>
              <asp:FileUpload ID="file1"  name="file" runat="server"  /> 
          </div>
       <div>
        
            
           <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
               <ContentTemplate><cc1:SerialNumber ID="seCode" runat="server"></cc1:SerialNumber></ContentTemplate>
           <Triggers>
               <asp:AsyncPostBackTrigger ControlID="btnChack" EventName="Click" />
           </Triggers>
           </asp:UpdatePanel>
          <br/><br/><asp:TextBox ID="txtCode" runat="server"></asp:TextBox><asp:Button ID="btnChack" runat="server" Text="点击更换" OnClick="btnChack_Click" /></div>
        </section>   
      <div><hr/></div>

      <div>
        <asp:Button ID="btnSumit" runat="server" Text="提交" OnClick="btnSumit_Click" OnClientClick="return Check_Images() " />
        <button id="reset" type="button">重置</button>
      </div>
      
    </form>

    <!-- End Form -->
      </div>
  </div>



<script type="text/javascript" src="js/jquery-1.8.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui.min.js"></script>
<script type="text/javascript" src="js/jquery.idealforms.js"></script>
<script type="text/javascript">
    var options = {

        onFail: function () {
            alert('还有' + $myform.getInvalid().length + '项有误哦！')
        },

        inputs: {
            'password': {
                filters: 'required pass',
            },
            'username': {
                filters: 'required username',
                data: {
                    ajax: { url:'validate.php' }
                }
            },
            'file': {
                filters: 'required file',
                data: { extension: ['jpg'] }
            },
            'userId': {
                filters: 'required userId',              
            },
        }

    };

    var $myform = $('#myform').idealforms(options).data('idealforms');

    $('#reset').click(function () {
        $myform.reset().fresh().focusFirst()
    });

    $myform.focusFirst();
</script>
<div style="text-align:center;">

</div>
</body>
</html>
