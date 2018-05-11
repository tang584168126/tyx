<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="_08_jQuery之AjaxEvent.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        * { margin:0; padding:0;}
        body { font-size:12px;}
        #loading{
            width:80px;
	        height: 20px;
	        background:#bbb;
	        color:#000;
	        display:none;
        }
        img{border:0;height:100px;width:100px;}
        .comment { margin-top:10px; padding:10px; border:1px solid #ccc;background:#DDD;}
        .comment h6 { font-weight:700; font-size:14px;}
        .para { margin-top:5px; text-indent:2em;background:#DDD;}
</style>
 
    <script src="Scripts/jquery.js" type="text/javascript"></script>
 <script>
     $(function () {       
         $("#send2").click(function () {
             $.get("Test1.aspx", {
                 username: $("#username").val(),
                 content: $("#content").val()
             }, function (data, textStatus) {
                 $("#resText").html(data); // 把返回的数据添加到页面上
             });
         })

         $.ajaxPrefilter(function (options) {
             options.global = true;       //启动全局Ajax事件
         });

         //共用这2个全局的ajax事件
         $("#loading").ajaxStart(function () {
             $(this).show();
         });
         $("#loading").ajaxStop(function () {
             $(this).hide();
         });

     })
   </script>

</head>
<body>
    <br/>
    <div id="loading">加载中...</div>

    <form id="form1">
    <p>评论:</p>
     <p>姓名: <input type="text" name="username" id="username" /></p>
     <p>内容: <textarea name="content" id="content" ></textarea></p>
     <p><input type="button" id="send2" value="提交"/></p>
    </form>
    <div  class='comment'>已有评论：</div>
    <div id="resText" >
    </div>
</body>
</html>
