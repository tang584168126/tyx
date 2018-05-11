<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProgressDemo.aspx.cs" Inherits="AjaxChapter08.UpdateProgressDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        数据正在处理中，请耐心等待......
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
                <br/><br/>
                <asp:Button ID="btnSubmit" runat="server" Text="更新时间" OnClick="btnSubmit_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
