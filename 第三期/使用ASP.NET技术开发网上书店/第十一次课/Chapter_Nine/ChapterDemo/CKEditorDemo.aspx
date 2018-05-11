<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CKEditorDemo.aspx.cs" Inherits="ChapterDemo.CKEditorDemo" %>


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
        <input id="Submit1" type="submit" value="submit" onclick="saveData()" />
        <script type="text/javascript">
            var editor = CKEDITOR.replace('TextArea1');

            function saveData() {
                if (editor.getData() == '') {
                    alert('There is no data available.');
                }
                //提交之前需要用encodeURIComponent格式化一下
            }
        </script>
    </div>
    </form>
</body>
</html>
