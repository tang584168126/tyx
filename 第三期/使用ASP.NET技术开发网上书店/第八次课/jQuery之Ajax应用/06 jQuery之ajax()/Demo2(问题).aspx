﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo2(问题).aspx.cs" Inherits="_06_jQuery之ajax__.Demo2" %>

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
                //使用$.ajax()方法提交对test.json文件的请求，注意：数据类型为"json"
                //并在成功获取数据后，拼接数据并插入到id为resText的元素中
                $.ajax({
                    type: "GET",
                    url: "Scripts/test.json",
                    dataType: "json",
                    success: function (data) {
                        var html = '';
                        $.each(data, function (index, comment) {
                            html += '<div class="comment"><h6>' + comment['username'] + ':</h6><p class="para">' + comment['content'] + '</p></div>';
                        })
                        $("#resText").empty();
                        $("#resText").html(html);
                    }
                });
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <input type="button" id="send" value="加载" />
        <div class="comment">
            已有评论：
        </div>
        <div id="resText" ></div>
    </form>
</body>
</html>
