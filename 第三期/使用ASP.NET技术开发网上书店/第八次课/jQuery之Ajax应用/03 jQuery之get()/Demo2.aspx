<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo2.aspx.cs" Inherits="_03_jQuery之get__.Demo2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        *{margin:0px;padding:0px;}
        body{font-size:12px;}
        .comment{margin-top:10px;padding:10px;border:1px solid #ccc;background:#ddd;}
            .comment h6{font-size:14px;font-weight:700;}
        .para{margin-top:5px;text-indent:2em;background:#ddd;}
    </style>
    <script src="Scripts/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#send").click(function () {
                //通过$.get()方式提交对Test2.aspx页面的请求，并传递用户名和评论的数据
                //并将返回的数据添加到id为restTest的元素中
                //注意：返回的数据为xml
                //$(data).find(节点)   attr获取属性        text()获取节点内文本
                $.get("Test2.aspx", {
                    username:$("#username").val(),
                    content:$("#content").val()
                }, function (data, textStatus) {
                    var username = $(data).find("comment").attr("username");
                    var content = $(data).find("content").text();
                    var html = "<div class='comment'><h6>"+ username +"：</h6><p class='para'>"+ content +".</p></div>"
                    
                    $("#resText").html(html);
                });
                
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <p>评论：</p><br/>
        <p>姓名：<input type="text" name="username" id="username"/></p><br/>
        <p>内容：<textarea id="content" name="content"></textarea></p>
        <input type="button" id="send" value="提交" />
    </form>
    <div class="comment"> 已有评论：</div>
    <div id="resText" ></div>
</body>
</html>
