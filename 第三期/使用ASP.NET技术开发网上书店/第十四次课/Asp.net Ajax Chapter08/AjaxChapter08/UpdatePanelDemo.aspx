<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanelDemo.aspx.cs" Inherits="AjaxChapter08.UpdatePanelDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .test {
            float:left;
            width:300px;
            height:200px;
            border:1px solid red;
            margin:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="test">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <asp:Label ID="lblTime" runat="server"></asp:Label>
                <br/><br/>
                <asp:Button ID="btnSubmit" runat="server"  Text="更新时间" OnClick="btnSubmit_Click"/>
                <br/>
                当UpdateMode值为Always时，要实现局部刷新，就必须将触发回发的控件放在Panel内部
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    
    <div class="test">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <asp:Label ID="lblTime2" runat="server"></asp:Label>
                <br/><br/>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    <asp:Button ID="Button1" runat="server"  Text="更新时间" OnClick="Button1_Click"/>
        <br/>
        当UpdateMode值为Always时，如果触发回发的控件放在Panel外部，则实现全局刷新
        </div>

    <div class="test">
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="lblTime3" runat="server"></asp:Label>
                <br/><br/>
                
            </ContentTemplate>
            <Triggers>
                    <asp:AsyncPostBackTrigger ConTrolID="btnSubmit3" EventName="Click" />
                </Triggers>
        </asp:UpdatePanel>
        <asp:Button ID="btnSubmit3" runat="server"  Text="更新时间" OnClick="btnSubmit3_Click"/>
        <br/>
        当UpdateMode值为Conditional时，如果触发回发的控件放在Panel外部，则要实现局部刷新的条件：
        1.在UpdatePanel控件的Triggers内部，将Panel与控件触发回发的事件关联起来
    </div>

        <div class="test">
        <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
            <ContentTemplate>
                <asp:Label ID="lblTime4" runat="server"></asp:Label>
                <br/><br/>
                <asp:Button ID="btnSubmit4" runat="server"  Text="更新时间" OnClick="btnSubmit4_Click"/>
                <br/>
                当UpdateMode值为Always时，将触发回发的控件放在Panel内部，实现局部刷新
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
   </form>
</body>
</html>
