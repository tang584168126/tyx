<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CKEditorDemo1 (4.5).aspx.cs" Inherits="ControlsDemo.CKEditorDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="ckeditor/ckeditor.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <textarea id="TextArea1" cols="20" rows="2" class="ckeditor"></textarea>
        <script type="text/javascript">
            window.onload = function () {
                var editor = CKEDITOR.replace('TextArea1');

                var data = editor.getData;

                var newData = encodeURIComponent(data);
            };
        </script>
    </div>
    </form>
</body>
</html>
