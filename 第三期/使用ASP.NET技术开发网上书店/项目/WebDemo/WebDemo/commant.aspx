<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="commant.aspx.cs" Inherits="WebDemo.commant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <style>
  #div2{border:solid 1px #DFDFDF;width:1100px;height:480px;position:absolute;margin-left:100px;}

#div1 { width:240px; height: 350px;padding: 5px; border: 1px solid #ccc; position: relative;
left:0px;float:left;

 }
 body
 {

 }
ul li{list-style:none;padding:3px 2px;}
#bost{margin-left:300px;}

.div3 
{
border:solid #ccc 1px;
width:1100px;height:300px;
}
 .div4 {border:solid #ccc 1px;position:relative;
width:1100px;height:200px;}
.div4 td{float:left;}
.div4 img{float:left;}
#div5 {width:1100px;height:200px;border:solid #ccc 1px;}
.div6{
    width:auto;
    height:auto;
    position:relative;
    top:1200px;
    width:1100px;
    height:200px;
    margin-left:102px;
}
 </style>
</head>
 <body>
     <asp:DataList ID="dlitems" runat="server">
         <HeaderTemplate></HeaderTemplate>
         <ItemTemplate>
<div id="div2">
<div id="div1" >
        <img width="240" height="350" src="images/face/pattern.JPG" alt="甜蜜人生"  title="甜蜜人生"/>
	</div>

	 <ul id="bost">
		<li><h4>书籍名称:<%# Eval("BookName") %> </h4></li>
		<li><h5><span style="color:#646464;font-family:DFKai-SB;">作&nbsp;&nbsp;&nbsp;&nbsp;者:</span> <span style="color:#1A66B3;"><%# Eval("Author") %></span></h5></li>
     	<li><h5><span style="color:#646464;font-family:DFKai-SB">单&nbsp;&nbsp;&nbsp;&nbsp;价:</span> <span style="color:red;font-size:23px;">￥:<%# Eval("SellMoney") %></span></h5></li>
		<li><h5><span style="color:#646464;font-family:DFKai-SB">I S B N:</span> <%# Eval("ISBN") %></h5></li>	
		<li><h5><span style="color:#646464;font-family:DFKai-SB">出版时间:</span><%# Eval("PublisherDate") %></h5></li>
		<li><h5><span style="color:#646464;font-family:DFKai-SB">出 版 社:</span> <span style="color:#1A66B3;font-size:16px;">２1世纪出版社</span></h5></li>
		<li><h5><span style="color:#646464;font-family:DFKai-SB">点击次数:</span> <span style="color:#1A66B3;font-size:20px;"><%# Eval("Clicks") %></span></h5></li>
		</ul>
		<hr/>
		<img src="images/neirong.png"/>
		<div class="div3">
		  <ul>
		  <li><%# Eval("Content") %></li>		
		  </ul>
		</div>
	     <img src="images/mulu.png"/>
   

		<div class="div3">
		  <ul>
		  <li><%# Eval("Content") %></li>
		  </ul>
		</div>
           </ItemTemplate>
           </asp:DataList>

     <asp:DataList ID="dltManger" runat="server" >
         <HeaderTemplate></HeaderTemplate> 
         <ItemTemplate>
		<div class="div6">
	   <img src="images/pinlun.png"/>
        <div class="div4">
		<table class="lost">

		<tr>
		<td style="font-size:12px;color:#DF460F;margin-left:3px;"><img src='<%# Eval("HeadPortrait") %>' />&nbsp;<br/><br/><br/><br/><br/><br/><br/><%# Eval("UserId") %></td>
		</tr>            
		<tr>
	<td style="margin-top:-100px;font-size:15px;"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("Content") %></td>
		</tr>
            	
		<tr >
		<td style="margin-left:830px;margin-top:10px;font-size:13px;"> &nbsp;&nbsp;<%# Eval("Date") %></td>
		</tr>

		</table>
        </div> 
	<div id="div5">
    
		</div>
            <textarea  class="checkOnmt" style="width:1095px;height:140px;font-size:20px;resize:none;" placeholder="说点什么吧！(限制字数：149)"maxlength="149" onchange="this.value=this.value.substring(0, 149)" onkeydown="this.value=this.value.substring(0, 149)" onkeyup="this.value=this.value.substring(0, 149)"></textarea>
    <input type="button" value="上一页" /> <input type="button" value="下一页" />	<input type="submit" value="提交"/>	
        </div>
     
        </ItemTemplate>
 </asp:DataList>
    
</body>
</html>
