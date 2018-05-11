<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PictureDemo.aspx.cs" Inherits="HttpHandlerDemo.PictureDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--
            目的：获取获取具有数字水印的书籍封面图片
            方式：使用具体的Handler方式
            说明：第三波书店封面的命名是根据其ISBN来命名
            步骤：
                1.根据请求来获取isbn
                2.拼接书籍封面图片存放路径 + isbn + .jpg 获取图片的路径
                3.判定图片是否存在，如果不存在，返回默认封面图片
                4.如果存在，则为封面图片添加数字水印
                5.将添加了数字水印的图片响应回客户端
             -->
    <img src="BookCover.ashx?isbn=9025178" />

        <!-- 方式：全局Hanler方式 -->
    <img src="Images/BookCovers/9025178.jpg" />
    </div>
    </form>
</body>
</html>
