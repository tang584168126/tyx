<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RegisterScriptStatic.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="提交" />
    </div>
    <script type="text/javascript">
        document.getElementById('<%= btnSubmit.ClientID %>').onclick = function () {
            if (!confirm('确认提交吗？')) {
                return false;
            }
        }
    </script>
    </form>
</body>
</html>
