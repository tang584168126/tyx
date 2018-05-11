<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>焦点书店首页</title>
    <link rel="stylesheet" href="css/home_1.css" type="text/css" media="screen"/>
    <link href="css/lanrenzhijia.css" type="text/css" rel="stylesheet" />
    <script>
        //创建Ajax原生对象
        function createXMLHttpRequest() {
            if (window.ActiveXObject) {  //IE5、IE6
                return new ActiveXObject("Microsoft.XMLHTTP");
            } else if (window.XMLHttpRequest) {  //其它浏览器
                return new XMLHttpRequest();
            }
        }
        function getBook(BookName)
        {
            if (BookName != "")
            {
                var xhr = createXMLHttpRequest();
                if (xhr.readyState == 4 && xhr.status == 200) {
                    var dom = xhr.responseXML;
                    document.getElementById("picture").innerHTML = dom.getElementsByTagName("Picture")[0].childNodes[0].nodeValue;
                    document.getElementById("bookName").innerHTML = dom.getElementsByTagName("BookName")[0].childNodes[0].nodeValue;
                    document.getElementById("author").innerHTML = dom.getElementsByTagName("Author")[0].childNodes[0].nodeValue;

                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <!--页眉-->
<div class="Head">
	<div class="Logo"><img src="images/LOGO.jpg" /></div>
    <div class="Bar">
       	<ul class="navbox" id="a">
			<li><a href="home.html">首页</a></li>
			<li><a href="Login.aspx">登录</a></li>
			<li><a href="Regist.aspx">注册</a></li>
			<li><a href="#">关于我们</a></li>
		</ul>
        <div class="style_1">
            <div id="searchform">
            <%--<form method="get" id="searchform" action="#">--%>
                <fieldset>
                <input id="s" name="s" type="text" value="书名或者作者名" class="text_input" onblur="if(this.value==''){this.value='书名或者作者名';}" onfocus="if(this.value =='书名或者作者名') {this.value=''; }" />
                <input name="submit" type="submit" value /> </fieldset></div>
            <%--</form>--%>
        </div>
    </div>
	</div>


<!--内容-->
<div id="Louti">
	<img src="images/xxpic.png" class="top"/>
    <ul>
    	<li><asp:Label ID="lblHot" runat="server" Text="热门推荐"></asp:Label></li>
        <li><asp:Label ID="lblStore" runat="server" Text="小说"></asp:Label></li>
        <li><asp:Label ID="lblLetter" runat="server" Text="文学"></asp:Label></li>
        <li><asp:Label ID="lblFood" runat="server" Text="美食"></asp:Label></li>
        <li><asp:Label ID="lblReader" runat="server" Text="读者作品"></asp:Label></li>
        <li><asp:Label ID="lblSkill" runat="server" Text="技术"></asp:Label></li>
        <li><asp:Label ID="lblListen" runat="server" Text="听小说"></asp:Label></li>
    </ul>
    <img src="images/top.png">
</div>
<div class="box" style="background:url(images/setting_6.jpg);">&nbsp;
 <div class="background_1">
        <div class="foucebox" style="text-align:justify;">
          <div class="bd">
            <div class="showDiv"> <a href="#"><img src="images/小说/宣传图/1_1.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2 style="bottom: 60px;"><a href="#">花千骨</a></h2>
                <p style="bottom: 10px;">没有正邪没有善恶_只有师父</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/2_2.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2 style="bottom: 60px;"><a href="#">四大名著</a></h2>
                <p style="bottom: 10px;">中国文学之最_四大名著</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/3_3.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2 style="bottom: 60px;"><a href="#">完美世界</a></h2>
                <p style="bottom: 10px;">多买多贱_绝对不能错过</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/4_4.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2><a href="#">星舞斗魂</a></h2>
                <p style="bottom: 10px;">作者：忍者</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/5_5.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2><a href="#">逆天戒指</a></h2>
                <p style="bottom: 10px;">时间会为你疗伤</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/6_6.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2><a href="#">阿弥陀佛</a></h2>
                <p style="bottom: 10px;">百万级畅销书《乖，摸摸头》</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/7_7.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2><a href="#">大神戒</a></h2>
                <p style="bottom: 10px;">大神戒_平凡的世界</p>
              </div>
            </div>
            <div class="showDiv"><a href="#"><img src="images/小说/宣传图/8_8.jpg" /></a>
              <div class="foucebox_bg"></div>
              <div>
                <h2><a href="#">最强兵王</a></h2>
                <p style="bottom: 10px;">进口的不一定是最好的，但却特色频出</p>
              </div>
            </div>
          </div>
          <div class="hd">
            <ul>
              <li class="on"><a href="#"><img src="images/小说/缩略图/1.jpg" /><span class="txt">花千骨</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/2.jpg" /><span class="txt">四大名著</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/3.jpg" /><span class="txt">完美世界</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/4.jpg" /><span class="txt">星舞斗魂</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/5.jpg" /><span class="txt">逆天戒指</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/6.jpg" /><span class="txt">阿弥陀佛</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/7.jpg" /><span class="txt">大神戒</span><span class="txt_bg"></span><span class="mask"></span></a></li>
              <li><a href="#"><img src="images/小说/缩略图/8.jpg" /><span class="txt">最强兵王</span><span class="txt_bg"></span><span class="mask"></span></a></li>
            </ul>
          </div>
 </div>
</div>
<div class="box" style="background:url(images/setting_7.jpg)">&nbsp;
 <div class="background">
     <div class="first">
         <asp:DataList ID="dl1" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">热门推荐</li>
                     <li><span id="picture"></span><span id="bookName"></span><span id="author"></span></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list" onmouseover="getBook(this.innerHTML)" onmouseout="closeBook()"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="second">
         <asp:DataList ID="dl2" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">新书上架</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="third">
         <asp:DataList ID="dl3" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">字数大神</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="forth">
         <asp:DataList ID="dl4" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">最近完本</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
 </div>
</div>
<div class="box" style="background:url(images/setting_5.jpg)">&nbsp;
 <div class="background">
    <div class="first">
         <asp:DataList ID="dl5" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">热门推荐</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="second">
         <asp:DataList ID="dl6" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">新书上架</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="third">
         <asp:DataList ID="dl7" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">字数大神</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="forth">
         <asp:DataList ID="dl8" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">最近完本</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
 </div>
</div>
<div class="box" style="background:url(images/setting_4.jpg)">&nbsp;
 <div class="background">
 	<div class="first">
         <asp:DataList ID="dl9" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">热门推荐</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="second">
         <asp:DataList ID="dl10" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">新书上架</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="third">
         <asp:DataList ID="dl11" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">字数大神</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="forth">
         <asp:DataList ID="dl12" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">最近完本</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
 </div>
</div>
<div class="box" style="background:url(images/setting_3.jpg)">&nbsp;
 <div class="background">
 	<div class="first">
         <asp:DataList ID="dl13" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">热门推荐</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="second">
         <asp:DataList ID="dl14" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">新书上架</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="third">
         <asp:DataList ID="dl15" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">字数大神</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="forth">
         <asp:DataList ID="dl16" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">最近完本</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
 </div>
</div>
<div class="box" style="background:url(images/setting_2.jpg)">&nbsp;
 <div class="background">
 	<div class="first">
         <asp:DataList ID="dl17" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">热门推荐</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="second">
         <asp:DataList ID="dl18" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">新书上架</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="third">
         <asp:DataList ID="dl19" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">字数大神</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
     <div class="forth">
         <asp:DataList ID="dl20" runat="server">
             <HeaderTemplate>
                 <ul>
                     <li style="background:blue;">最近完本</li>
                     <li><img src='<%# Eval("Picture")  %>' /><%# Eval("BookName") %><%# Eval("Author") %></li>
                 </ul>
             </HeaderTemplate>
             <ItemTemplate>
                 <ul>
                     <li><a href="Command.aspx?ISBN=<%# Eval("ISBN") %>" class="list"><%# Eval("BookName") %></a></li>
                 </ul>
             </ItemTemplate>
         </asp:DataList>
     </div>
 </div>
</div>
<div class="box" style="background:url(images/setting_1.jpg)">&nbsp;
 <div class="background">
     
     </div>
 </div>
</div>

<!--页尾-->
    </form>
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
<script type="text/javascript" src="js/home_js.js"></script>
<script src="js/jquery.SuperSlide.js"></script> 
<script>
    jQuery(".foucebox").slide({ effect: "fold", autoPlay: true, delayTime: 300, startFun: function (i) { jQuery(".foucebox .showDiv").eq(i).find("h2").css({ display: "none", bottom: 0 }).animate({ opacity: "show", bottom: "60px" }, 300); jQuery(".foucebox .showDiv").eq(i).find("p").css({ display: "none", bottom: 0 }).animate({ opacity: "show", bottom: "10px" }, 300); } });
</script>
</body>
</html>
