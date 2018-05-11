<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MessageBoard.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>青鸟留言板</title>
    <link href="Style/style.css" rel="stylesheet" />
    <script src="Scripts/Script.js"></script>
    <script src="Scripts/jquery-1.7.1.js"></script>
</head>
<body>
    <div align="center">
        <div>
            <h3>
                青鸟留言板</h3>
        </div>
        &nbsp;
        <div>
            <div id="admin">
                管理员：<asp:TextBox ID="txtAdmin" style="width:100px;" runat="server"></asp:TextBox>
                密码：<asp:TextBox ID="txtPassword" style="width: 100px;" runat="server"></asp:TextBox>
                <img src="VerifyCode.aspx" alt="看不清？点击更换" onclick="this.src=this.src+'?'" style="width: 121px; height: 29px" />
                <asp:TextBox ID="txtValidCode" style="width: 70px;" runat="server"></asp:TextBox>
                <asp:Button ID="btnLogIn" runat="server" Text="登 录" />
            </div>           
            <div id="messageContainer">
                <div class="t">
                    <div class="tt">
                        <div class="tt1">
                            <img src="images/face/face1.gif" />
                            &nbsp;作者：accp</div>
                        <div align="right">
                            <a href='mailto:wei.qiao@prd.com'>
                                <img alt="qwe" src="Images/ico_email.gif" /></a> &nbsp; <a href='www.sohu.com' target="_blank">
                                    <img alt="qwe" src="Images/website.gif" /></a>
                        </div>
                    </div>
                    <div>
                        <div class="tt2">
                            <img src="images/face/1.gif" />
                        </div>
                        <div class="tt3">
                            <div align="left" class="tt4">
                                大家好</div>
                            <div class="gray" align="right">
                                1# 发表：2007-8-1 12:12:12&nbsp;</div>
                        </div>
                    </div>
                </div>
                <div class='t'>
                    <div class='tt'>
                        <div class='tt1'>
                            <img src='images/face/face1.gif' />
                            &nbsp;作者：jbns</div>
                        <div align='right'>
                            <a href='mailto:wei.qiao@prd.com'>
                                <img src='Images/ico_email.gif' /></a> &nbsp; <a href='www.sohu.com' target='_blank'>
                                    <img alt='qwe' src='Images/website.gif' /></a>
                        </div>
                    </div>
                    <div>
                        <div class='tt2'>
                            <img src='images/face/5.gif' />
                        </div>
                        <div class='tt3'>
                            <div align='left' class='tt4'>
                                很高兴见到各位</div>
                            <div class='gray' align='right'>
                                2# 发表：2007-8-1 16:12:12&nbsp;</div>
                        </div>
                    </div>
                </div>
            </div>
            <div style="width: 800px; clear: both; border-bottom: #999999 1px solid;" align="right">
                <asp:Button ID="btnPre" runat="server" Text="上一页" />
                <asp:Button ID="btnNext" runat="server" Text="下一页" />
            </div>
            <div style="width: 800px" align="left">
                <div style="width: 300px; position: relative; float: left">
                    &nbsp;
                    <div>
                        用 户 名</div>
                    <div style="position: relative; left: 100px; top: -18px; width: 200px;">
                        <asp:TextBox ID="txtUserName" runat="server" value="请输入您的名字" CssClass="gray input"></asp:TextBox>
                    </div>
                    <div>
                        请选择头像</div>
                    <div style="position: relative; left: 100px; top: -18px; width: 200px;">
                        <select id="ddlHeader">
                            <option value="Images/face/1.gif">头相1</option>
                            <option value="Images/face/2.gif">头相2</option>
                            <option value="Images/face/3.gif">头相3</option>
                            <option value="Images/face/4.gif">头相4</option>
                            <option value="Images/face/5.gif">头相5</option>
                            <option value="Images/face/6.gif">头相6</option>
                            <option value="Images/face/7.gif">头相7</option>
                            <option value="Images/face/8.gif">头相8</option>
                            <option value="Images/face/9.gif">头相9</option>
                            <option value="Images/face/10.gif">头相10</option>
                            <option value="Images/face/11.gif">头相11</option>
                            <option value="Images/face/12.gif">头相12</option>
                            <option value="Images/face/13.gif">头相13</option>
                            <option value="Images/face/14.gif">头相14</option>
                            <option value="Images/face/15.gif">头相15</option>
                            <option value="Images/face/16.gif">头相16</option>
                            <option value="Images/face/17.gif">头相17</option>
                            <option value="Images/face/18.gif">头相18</option>
                            <option value="Images/face/19.gif">头相19</option>
                            <option value="Images/face/20.gif">头相20</option>
                        </select>
                    </div>
                    <div>
                        Email</div>
                    <div style="position: relative; left: 100px; top: -18px; width: 200px;">
                        <asp:TextBox ID="txtEmail" value="请输入您的Email" CssClass="gray input" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        个人网站</div>
                    <div style="position: relative; left: 100px; top: -18px; width: 200px;">
                        <asp:TextBox ID="txtWebSite" value="请输入您的网站" CssClass="gray input" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div id="divHeader" style="padding-top: 30px;">
                    <img id="imgHeader" alt="" />
                </div>
                <div style="clear: both">
                    <div>
                        表情</div>
                    <div style="position: relative; left: 100px; top: -18px">
                        <asp:RadioButtonList ID="rblFace" runat="server">
                            <asp:ListItem><img src="images/face/face1.gif" /></asp:ListItem>
                            <asp:ListItem><img src="images/face/face2.gif" /></asp:ListItem>
                        </asp:RadioButtonList>
                        <input id="Radio1" type="radio" name="a1" value="Radio1" />
                        <img src="images/face/face1.gif" /><input id="Radio2" type="radio" name="a1" value="Radio2" />
                        <img src="images/face/face2.gif" /><input id="Radio3" type="radio" name="a1" value="Radio3" />
                        <img src="images/face/face3.gif" /><input id="Radio4" type="radio" name="a1" value="Radio4" />
                        <img src="images/face/face4.gif" /><input id="Radio5" type="radio" name="a1" value="Radio5" />
                        <img src="images/face/face5.gif" /><input id="Radio6" type="radio" name="a1" value="Radio6" />
                        <img src="images/face/face6.gif" /><input id="Radio7" type="radio" name="a1" value="Radio7" />
                        <img src="images/face/face7.gif" /><input id="Radio8" type="radio" name="a1" value="Radio8" />
                        <img src="images/face/face8.gif" /><input id="Radio9" type="radio" name="a1" value="Radio9" />
                        <img src="images/face/face9.gif" /><input id="Radio10" type="radio" name="a1" value="Radio10" />
                        <img src="images/face/face10.gif" /><br />
                        <input id="Radio11" type="radio" name="a1" value="Radio11" />
                        <img src="images/face/face11.gif" /><input id="Radio12" type="radio" name="a1" value="Radio12" />
                        <img src="images/face/face12.gif" /><input id="Radio13" type="radio" name="a1" value="Radio13" />
                        <img src="images/face/face13.gif" /><input id="Radio14" type="radio" name="a1" value="Radio14" />
                        <img src="images/face/face14.gif" /><input id="Radio15" type="radio" name="a1" value="Radio15" />
                        <img src="images/face/face15.gif" /><input id="Radio16" type="radio" name="a1" value="Radio16" />
                        <img src="images/face/face16.gif" /><input id="Radio17" type="radio" name="a1" value="Radio17"
                            checked="checked" />
                        <img src="images/face/face17.gif" /><input id="Radio18" type="radio" name="a1" value="Radio18" />
                        <img src="images/face/face18.gif" /><input id="Radio19" type="radio" name="a1" value="Radio19" />
                        <img src="images/face/face19.gif" /><input id="Radio20" type="radio" name="a1" value="Radio20" />
                        <img src="images/face/face20.gif" />
                    </div>
                    <div>
                        留言信息</div>
                    <div style="position: relative; left: 100px; top: -18px">
                        &nbsp;<asp:TextBox ID="txtMessage" rows="5" cols="55" style="height: 131px;
                            width: 444px;" runat="server" AutoPostBack="True"></asp:TextBox>
                        &nbsp;</div>
                    <div align="center" style="position: relative; left: -50px; width: 500px">
                        <asp:Button ID="btnSubmit" runat="server" Text="提交" style="width: 69px;" />
                        &nbsp;&nbsp;
                        <input type="checkbox" id="chkIsHide" />悄悄话
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
