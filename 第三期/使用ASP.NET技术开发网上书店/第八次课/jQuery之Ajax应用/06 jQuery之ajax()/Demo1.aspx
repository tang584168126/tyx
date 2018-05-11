<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="_06_jQuery之ajax__.Demo1" %>

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
                //使用$.ajax()方法提交对test.js文件的请求，注意：数据类型为"script"
                $.ajax({
                    type: "GET",
                    url: "Scripts/test.js",
                    dataType: "script",
                    success: function () {
                        alert("成功！");
                    },
                    error: function () {
                        alert("失败！");
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
