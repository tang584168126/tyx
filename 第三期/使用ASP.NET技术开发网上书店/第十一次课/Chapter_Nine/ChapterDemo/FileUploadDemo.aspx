<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadDemo.aspx.cs" Inherits="ChapterDemo.FileUploadDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" lang="javascript">
        function CheckImg(FileUpload)
        {
            var mine = FileUpload.value;
            var type = mine.toLowerCase().substr(mine.lastIndexOf("."));
            if (type != ".jpg")
            {
                FileUpload.value = "";
                alert("图片仅支持jpg格式");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="fuImg" runat="server" onchange="CheckImg(this)" />
        <asp:Button ID="btnSubmit" runat="server" Text="上传" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
