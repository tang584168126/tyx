<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CKEditorDemo2 (3.6).aspx.cs" Inherits="ControlsDemo.CKEditorDemo2" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="ckeditor%203.6/ckeditor.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server"></CKEditor:CKEditorControl>
    </div>
    </form>
</body>
</html>
