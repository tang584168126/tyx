(function(){
var f=navigator.userAgent.toLowerCase();google.isOpera=f.indexOf("opera")!=-1;google.isIE=document.all&&f.indexOf("msie")!=-1&&!google.isOpera;google.isSafari=f.indexOf("safari")!=-1;google.time=function(){return(new Date).getTime()};google.log=function(a,c){(new Image).src="/gen_204?atyp=i&ct="+a+"&cad="+c+"&zx="+google.time()};google.xhr=function(){var a=null;if(window.XMLHttpRequest)try{a=new XMLHttpRequest}catch(c){}else if(window.ActiveXObject)for(var d=0,b;b=["MSXML2.XMLHTTP.6.0","MSXML2.XMLHTTP.3.0",
"MSXML2.XMLHTTP","Microsoft.XMLHTTP"][d++];)try{a=new ActiveXObject(b);break}catch(c){}return a};function g(a,c,d){var b=document.defaultView&&document.defaultView.getComputedStyle(a,""),e=b&&b.getPropertyValue(c);return document.defaultView&&b&&typeof e=="string"&&(d?e:parseInt(e,10))}google.getHeight=function(a){return g(a,"height")||a.offsetHeight};google.getWidth=function(a){return g(a,"width")||a.offsetWidth};google.getColor=function(a){return a.currentStyle?a.currentStyle.color:g(a,"color",
1)};google.rhs=function(){};window.google.bind=function(a,c,d){var b="on"+c;if(a.addEventListener)a.addEventListener(c,d,false);else if(a.attachEvent)a.attachEvent(b,d);else{var e=a[b];a[b]=function(){var h=e.apply(this,arguments),i=d.apply(this,arguments);return h==undefined?i:(i==undefined?h:i&&h)}}};
})();
(function(){
window.google.stringify=function(a){var c,d,j,b="",f;switch(typeof a){case "object":if(a)if(a instanceof Array||typeof a.join=="function"&&typeof a.reverse=="function"){for(d=0;d<a.length;++d){f=window.google.stringify(a[d]);if(b)b+=",";b+=f}return"["+b+"]"}else if(typeof a.toString!="undefined"){for(d in a){f=a[d];if(typeof f!="undefined"&&typeof f!="function"){f=window.google.stringify(f);if(b)b+=",";b+=window.google.stringify(d)+":"+f}}return"{"+b+"}"}return"null";case "number":return isFinite(a)?
String(a):"null";case "string":j=a.length;b='"';for(d=0;d<j;d+=1){c=a.charAt(d);if(c>=" "){if(c=="\\"||c=='"')b+="\\";b+=c}else switch(c){case "\n":b+="\\n";break;case "\r":b+="\\r";break;case "\t":b+="\\t";break;default:c=c.charCodeAt();b+="\\u00"+Math.floor(c/16).toString(16)+(c%16).toString(16);break}}return b+'"';case "boolean":return String(a);default:return"null"}};google.History={};var e=[],g="#";google.History.client=function(a){e.push(a);return e.length-1};var h,i;function k(){var a=h.value;i=!(!a)?eval("("+a+")"):{}}google.History.save=function(a,c){if(h){k();if(!i[g])i[g]={};i[g][a]=c;h.value=google.stringify(i)}};function l(){i=null;h=document.getElementById("hcache");h&&window.setTimeout(function(){k();for(var a=0;a<e.length;++a)if(i&&i[g]&&i[g][a])e[a].call(null,i[g][a])},0)}l();google.rein.push(function(){g=google.pageState;l()});
})();
(function(){
var a,b;google.rhs=function(){if(!google.drhs)if(document.getElementById("mbEnd")&&(a||b)){var d=google.getHeight(document.getElementById("rhsline")),c=a?google.getHeight(a):0;if(b)c+=google.getHeight(b)+18;document.getElementById("rhspad").style.height=c>d?Math.min(9999,c-d)+"px":(google.isIE?"":0)}};function e(){a=document.getElementById("tads");b=document.getElementById("3po");google.rhs()}e();google.bind(window,"resize",google.rhs);google.rein.push(e);
})();
(function(){
var c=false,f=null,g=true,aa=c,h,i,l,m="",n=f;var ba=f;var o=f,p=f,r=-1,s,t,u,v,w,A,B,C=0,D=0,E=f,F=0;var J;
var N=f,O=0;
function ca(){if(!w)return;da();P();w.value=A.value="";window.clearTimeout(n);window.clearInterval(ba);m=B="";n=o=p=f;r=-1;C=D=F=0;J=0;N=f;O=0;}
var Q=0,fa=new RegExp("^[\\s\\u1100-\\u11FF\\u3040-\\u30FF\\u3130-\\u318F\\u31F0-\\u31FF\\u3400-\\u4DBF\\u4E00-\\u9FFF\\uAC00-\\uD7A3\\uF900-\\uFAFF\\uFF65-\\uFFDC]+$");
function ga(a,b,d,e,j){s=a;t=b;i=l=h=t.value;if(!b.init){google.bind(s,"submit",ha);t.setAttribute("autocomplete","off");google.bind(t,"blur",function(){Q||P();Q=0});google.bind(t,"keydown",R);t.onkeyup=S;w=ia("aq","f");A=ia("oq",i);u=
document.createElement("table");u.cellSpacing=u.cellPadding="0";v=u.style;u.className="gac_m";s.appendChild(u);b.init=g}P();U();if(!aa){ja();aa=g}B=["/complete/search","?hl=",google.kHL,(d?"&ds="+d:""),(e?"&pq="+encodeURIComponent(e):"")].join("");i=l=h=t.value;J=ka(t);ba=window.setInterval(function(){var k=t.value;k!=h&&V(0);h=k},10);
W();}
function ja(){var a=document.createElement("style");document.getElementsByTagName("head")[0].appendChild(a);var b=f;b=a.sheet;var d=f;if(!b){d=document.createTextNode("");a.appendChild(d)}var e=function(k,q){
var x=k+" { "+q+" }";if(b){b.insertRule(x,b.cssRules.length);}else d.data+=x+"\n";};e(".gac_m","font-size:13px;cursor:default;line-height:17px;border:1px solid black;z-index:99;background:white;position:absolute;margin:0;");e(".gac_b","background:#36c;color:white;");var j="white-space:nowrap;overflow:hidden;text-align:left;padding-left:3px;";e(".gac_c",j);e(".gac_d","white-space:nowrap;overflow:hidden;text-align:right;font-size:10px;color:green;padding:0 3px");e(".gac_b td","color:white");
e(".gac_f td","padding:0 3px 2px;font-size:10px;line-height:15px");e(".gac_e","text-align:right;color:#00c;text-decoration:underline");}
function U(){if(u){v.left=la(t,"offsetLeft")+"px";v.top=la(t,"offsetTop")+t.offsetHeight-1+"px";v.width=t.offsetWidth+"px";}}function ia(a,b){var d=document.createElement("input");d.type="hidden";d.name=a;d.value=b;return s.appendChild(d)}
function R(a){var b=a.keyCode;if(b==27&&na()){P();X(i);a.cancelBubble=g;return a.returnValue=c}if(b==38||b==40){D++;D%3==1&&V(b);return c}}function S(a){var b=a.keyCode;if(D==0&&!(b==38||b==40))V(b);D=0;return !(b==38||b==40)}
function V(a){if(a==38||a==40){Q=1;t.blur();window.setTimeout(function(){t.focus()},10)}if(t.value!=h){i=t.value;J=ka(t);A.value=i}a==40&&oa(r+1);a==38&&oa(r-1);U();if(m!=i&&!E)E=window.setTimeout(P,500);h=t.value;h==""&&!n&&W()}function pa(){if(F)return;if(p)p.className="gac_a";this.className="gac_b";p=this;for(var a=0,b;b=o[a];a++)b==p&&(r=a)}
function oa(a){if(!m&&i){l="";W();return}if(i!=m||!n)return;if(!o||o.length<=0)return;if(!na()){Y();return}var b=o.length-1;if(p)p.className="gac_a";if(a==b||a==-1){r=-1;X(i);t.focus();w.value="f";return}else if(a>b)a=0;else if(a<-1)a=b-1;r=a;p=o.item(a);p.className="gac_b";X(p.completeString);w.value=p.completeId}
function P(){if(E){window.clearTimeout(E);E=f}v&&(v.visibility="hidden");}function Y(){v&&(v.visibility="visible");U();F=1}function na(){return!!v&&v.visibility=="visible"}
function da(){if(u){u.innerHTML="";}}
function qa(a){C>0&&C--;if(!u||a[0]!=i)return;if(E){window.clearTimeout(E);E=f}m=a[0];da();var d=c;for(var e=0,j;e<a[1].length;e++)if(j=a[1][e]){d=g;var k=u.insertRow(-1);k.onclick=function(){X(this.completeString);ha();s.onsubmit&&s.onsubmit()==c||s.submit();};k.onmousedown=Z;k.onmouseover=pa;k.onmousemove=function(){if(F){F=0;pa.call(this)}};k.completeString=
j[0];k.completeId=j[2];k.className="gac_a";var q=document.createElement("td");$(q,j[0]);q.className="gac_c";k.appendChild(q);var x=document.createElement("td");$(x,j[1]);x.className="gac_d";k.appendChild(x);}var ma=a.length>2,M,y;if(ma||d){var z=u.insertRow(-1);z.onmousedown=Z;z.className="gac_f";M=document.createElement("td");M.style.color="gray";M.style.whiteSpace="nowrap";y=document.createElement("td");y.className="gac_e";z.appendChild(M);z.appendChild(y)}if(ma){$(M,"据当地法律法规和政策，部分结果未予显示。");d=g;}
if(d){var T=document.createElement("span");T.style.cursor="pointer";y.appendChild(T);$(T,"关闭");T.onclick=function(){P();m="";window.clearTimeout(n);
n=f;w.value="x"}}r=-1;o=u.rows;(o&&o.length>0?Y:P)()}function ha(){P();if(A.value!=t.value)w.value=o&&o.item(r)&&o.item(r).completeId;else{A.value="";if(C>=10||O>=3)w.value="o"}}
function W(){if(O>=3)return;if(l!=i&&i){C++;ra(encodeURIComponent(i));t.focus()}l=i;var a=100;for(var b=1;b<=(C-2)/2;++b)a*=
2;a+=50;n=window.setTimeout(W,a)}function X(a){if(t)t.value=h=a}function la(a,b){var d=0;while(a){d+=a[b];a=a.offsetParent}return d}function $(a,b){a.appendChild(document.createTextNode(b))}
function Z(a){a.stopPropagation();return c}
function sa(){var a=f;if(typeof XMLHttpRequest!="undefined")a=new XMLHttpRequest;return a}
function ra(a){N&&N.readyState!=0&&N.readyState!=4&&N.abort();if(N)N.onreadystatechange=function(){};N=sa();if(N){N.open("GET",B+"&xhr=t&q="+a+"&cp="+J,g);N.onreadystatechange=function(){if(N.readyState==4)switch(N.status){case 403:O=1000;break;case 302:case 500:case 502:case 503:O++;break;case 200:qa(eval(N.responseText));default:O=0}};N.send(f)}}
function ka(a){var b=0,d=0;if(ta(a)){b=a.selectionStart;d=a.selectionEnd}return b&&d&&b==d?b:0}
function ta(a){try{return typeof a.selectionStart=="number"}catch(b){return c}}window.google.ac={i:ga,h:qa,u:X};google.bind(window,"resize",U);google.dstr.push(ca);
})();
(function(){
var k="/intl/zh-CN/images/toolbar_animation_20090618.png",l=52,m=37,n=75,o=100;function p(b,d,c,a,e){return{url:b,name:d,tooltip:c,color:a,yAdjust:e}}var q=[p("http://video.google.cn/","\u89c6\u9891","\u641c\u7d22\u70ed\u95e8\u7f51\u7edc\u89c6\u9891","#54a70d",[2,5]),p("http://images.google.cn/","\u56fe\u7247","\u641c\u7d22\u5168\u7403\u7684\u56fe\u7247","#3b79e7",[2,5]),p("http://www.google.cn/gouwu","\u8d2d\u7269","\u641c\u7d22\u5546\u54c1\u548c\u8d2d\u7269\u4fe1\u606f","#d93c08",[3,7]),p("http://ditu.google.cn/",
"\u5730\u56fe","\u67e5\u8be2\u5730\u5740\u3001\u635c\u7d22\u5468\u8fb9\u548c\u89c4\u5212\u8def\u7ebf","#e8d40f",[4,9]),p("http://www.google.cn/music/homepage","\u97f3\u4e50","\u641c\u7d22\u548c\u53d1\u73b0\u97f3\u4e50","#3b92e7",[3,7]),p("http://translate.google.cn/","\u7ffb\u8bd1","\u5728\u7ebf\u7ffb\u8bd1\u5916\u6587\u6bb5\u843d\u3001\u7f51\u9875\u3001\u641c\u7d22\u7ed3\u679c","#54a70d",[2,5]),p("http://www.265.com/","265\u5bfc\u822a","\u5b9e\u7528\u7f51\u5740\u5927\u5168\uff0c\u4fbf\u6377\u76f4\u8fbe\u5e38\u7528\u7f51\u7ad9",
"#ea7408",[2,5])],r=[];function s(b,d){while(d&&b!=d)d=d.parentNode;return d==b}function u(b,d){return function(c){c=c||window.event;var a=r[d],e=b=="mouseover",g=c.target||c.srcElement,f=c.relatedTarget||(e?c.fromElement:c.toElement),h=!f||s(a.element,f),i=s(a.element,g);if(e&&!h||!e&&(!f||i&&!h)){var j=a.icon;j.mouseTimeout=window.clearTimeout(j.mouseTimeout);var t=e?1:-1;if(j.b!=t)j.mouseTimeout=window.setTimeout(j.e(t,undefined),e?o/3:o)}}}function v(b,d,c){google.bind(b,d,u(d,c))}function w(b,
d,c){this.c=b;var a=document.createElement("div"),e=b.color,g="background-color:"+e,f="width:1px;height:1px;"+g+";float:",h='<div style="height:1px;overflow:hidden"><div style="'+f+'left"></div><div style="'+f+'right"></div></div>',i="margin:0 1px;height:1px;overflow:hidden;"+g;a.innerHTML='<div style="display:none;position:absolute;top:0;left:0;z-index:2;background:#fff;cursor:pointer;cursor:hand"><a href="'+d+'" style="color:#444;text-decoration:none" target=_blank><div style="'+i+'"></div><div style="text-align:center;border-left:1px solid;border-right:1px solid;border-color:'+
e+'">'+h+'<div style="margin:0 auto;white-space:nowrap;padding:.2em 0 0"><span style="font-size:83%">'+c+"</span></div>"+h+'</div><div style="'+i+'"></div><div style="height:4px" align="center"><div style="position:relative;top:-1px;z-index:3;width:8px;overflow:hidden;margin:0 auto;height:4px;background:no-repeat -260px '+-b.spriteCoordinateList[0].y+'px"></div></div></a></div>';this.h=a.getElementsByTagName("span")[0];document.body.appendChild(a);a.firstChild.firstChild.lastChild.firstChild.style.backgroundImage=
"url("+k+")";this.element=a.firstChild;var j=r.length;r.push({icon:b,element:this.element});v(this.element,"mouseover",j);v(this.element,"mouseout",j)}w.prototype.play=function(b){var d=this.c.element.firstChild,c={left:-d.offsetLeft,top:0};while(d){c.left+=d.offsetLeft;c.top+=d.offsetTop;d=d.offsetParent}var a=this.element.style;if(a.display=="none"){a.visibility="hidden";a.display="block"}var e=this.element.offsetHeight,g=this.h.offsetWidth+14;if(a.visibility=="hidden"){a.display="none";a.visibility=
"visible"}a.width=g+"px";c.left-=(g-this.c.element.parentNode.offsetWidth)/2;c.top-=e-3;c.top+=20*Math.pow(1-b/this.c.frames,3);a.left=c.left+"px";a.top=c.top+"px";if(b==0||this.c.b<0)a.display="none";else{a.display="";var f=b/this.c.frames;if("opacity"in a)a.opacity=f;else if("MozOpacity"in a)a.MozOpacity=f;else if("KhtmlOpacity"in a)a.KhtmlOpacity=f;else if("filter"in a)a.filter="alpha(opacity="+f*100+")"}};function x(b,d,c,a,e){this.element=b;this.mouseTimeout=null;this.frames=d.length-1;this.spriteCoordinateList=
d;this.color=c;this.d=null;this.g=b.getElementsByTagName("div")[1];this.i=new w(this,a,e);this.b=-1;this.a=1;var g=r.length;r.push({icon:this,element:b});v(b,"mouseover",g);v(b,"mouseout",g)}x.prototype.e=function(b,d){var c=this;return function(){c.f(b,d)}};x.prototype.f=function(b,d){if(b){this.b=b;this.mouseTimeout=window.clearTimeout(this.mouseTimeout);this.d=window.clearTimeout(this.d)}if(typeof d!="undefined")this.a=d;var c=this.spriteCoordinateList[this.a];this.g.style.backgroundPosition=-c.x+
"px "+-c.y+"px";this.i.play(this.a);var a=this.element.getElementsByTagName("span")[0].style;if(this.b<0){a.color="#444";a.textDecoration="none"}else{a.color=this.color;a.textDecoration="underline"}this.a+=this.b;if(this.a>this.frames)this.a=this.frames-1;else if(this.a<0)this.a=1;else this.d=window.setTimeout(this.e(undefined,undefined),n)};google.y.first.push(function(){var b=document.getElementById("tb");if(b){try{document.execCommand("BackgroundImageCache",false,true)}catch(d){}var c='<table style="margin:2em auto;border-collapse:collapse;line-height:1.4em" cellpadding="3" cellspacing="2" border="0"><tr>';
for(var a=0;a<q.length;++a){var e=q[a];e.url="/url?ct=pro&cd="+a+"&source=cwh&q="+encodeURIComponent(e.url);var g=[],f=m*a;for(var h=0;h<7;++h)if(h>4)g.push({x:l*4,y:f-e.yAdjust[h-5]});else g.push({x:l*h,y:f});e.coordinates=g;c+='<td valign=bottom style="text-align:center;padding:0 .35em 0 .4em;margin:0;cursor:pointer;cursor:hand"><a style="color:#444;text-decoration:none;vertical-align:bottom" href="'+e.url+'" target=_blank><div><div style="width:52px;height:37px;margin:.5em auto;cursor:pointer;cursor:hand;background:no-repeat 0 '+
-f+'px"></div><span style="white-space:nowrap;font-size:83%">'+e.name+"</span></div></a></td>"}c+="</tr></table>";b.innerHTML=c;var i=b.getElementsByTagName("a");for(var a=0;a<i.length;++a){i[a].firstChild.firstChild.style.backgroundImage="url("+k+")";new x(i[a],q[a].coordinates,q[a].color,q[a].url,q[a].tooltip)}}});
})();
(function(){
window.ManyBox={};var e,g,h=1,j=google.History.client(i);function k(a){for(var b in e)if(e[b].c&&a(e[b]))return}function l(a,b,c,d,f){this.c=a;this.i=b;this.B=d;this.o=f;this.q="/mbd?"+(b?"docid="+b:"")+"&resnum="+a.replace(/[^0-9]/,"")+"&mbtype="+d+"&usg="+c+"&hl="+(google.kHL||"");this.e={};this.l="";g[a]={r:0,D:this.e,i:this.i,h:0};this.n=0}l.prototype.append=function(a){this.l+="&"+a.join("&")};function m(a,b){return document.getElementById("mb"+b+a.c)}function n(a,b){a.g.style.paddingTop=b+"px";
a.g.style.display=a.g.innerHTML?"":"none";if(b>a.n)a.n=b}function o(a){if(!a.A){a.A=1;a.d=m(a,"b");a.j=0;a.a=m(a,"l");a.m=a.a.getElementsByTagName("DIV")[0];a.p=a.a.getElementsByTagName("A")[0];a.z=a.p.innerHTML;a.o=a.o||a.z;a.m.title="点击获得详细信息";a.a.F=function(b,c){var d=r(a.a),f=s(a.a);return b>d-5&&b<d+google.getWidth(a.a)+5&&c>f-5&&c<f+google.getHeight(a.a)+5};a.g=m(a,"f");n(a,0);a.a.onmousedown=t(a);a.a.onclick=u(a);a.a.go=function(){a.a.onmousedown();a.a.onclick()}}}function t(a){return function(){if(g[a.c].h){if(a.I++<3)google.log("manybox",[a.j?"close":"open","&id=",a.c,"&docid=",a.i,"&mbtype=",a.B,a.l].join(""))}else{var b=google.xhr();if(b){b.open("GET",a.q+a.l+"&zx="+google.time());a.t=0;b.onreadystatechange=function(){if(b.readyState==4){var c=0;if(b.status==200)try{eval(b.responseText);c=1}catch(d){}if(!c&&!a.C){g[a.c].h=0;a.C=1;a.q+="&cad=retry";a.a.onmousedown()}else{a.u&&v(a);a.t=0}}};a.t=1;b.send(null)}g[a.c].h=(a.I=1)}}}function u(a){return function(){g[a.c].h||
a.a.onmousedown();(a.u=a.t)||v(a)}}function z(a){if(!a.e.k){a.e.k="\x3cfont color\x3dred\x3e错误：\x3c/font\x3e服务器无法完成您的请求。请在 30 秒后再次尝试。";a.G=a.a.onclick;a.a.onclick=function(){h=0;v(a);h=1;a.b.parentNode.removeChild(a.b);g[a.c].h=(a.e.k=(a.v=0));a.a.onclick=a.G}}if(!a.v){a.v=1;var b=document.getElementById("res");a.H=b&&r(a.d)>r(b)+google.getWidth(b);a.b=document.createElement("div");n(a,0);a.b.style.position="absolute";a.b.style.paddingTop=(a.b.style.paddingBottom="6px");a.b.style.display="none";a.b.className="med";var c=document.createElement("div");
a.b.appendChild(c);c.className="std";c.innerHTML=a.e.k;a.g.parentNode.insertBefore(a.b,a.g)}}function i(a){h=0;ManyBox.init();k(function(b){if(b.i==a[b.c].i){b.e=a[b.c].D;if(a[b.c].r!=b.j)v(b)}else a[b.c].h=0});g=a;h=1;google.History.save(j,g)}ManyBox.create=function(a,b,c,d,f){return new l(a,b,c,d,f)};ManyBox.register=function(a,b,c,d,f){return e[a]=ManyBox.create(a,b,c,d,f)};google.bind(document,
"click",function(a){a=a||window.event;var b=a.target||a.srcElement;while(b.parentNode){if(b.tagName=="A"||b.onclick)return;b=b.parentNode}k(function(c){if(c.a.F(a.clientX,a.clientY)){c.a.go();return 1}})});function A(){e={};g={};history.navigationMode=history.navigationMode&&"fast"}A();ManyBox.init=function(){k(o)};function B(a,b){a.b.style.clip="rect(0px,"+(a.d.width||"34em")+","+(b||1)+"px,0px)"}l.prototype.insert=function(a){this.e.k=a;google.History.save(j,g)};function s(a){return a.offsetTop+
(a.offsetParent?s(a.offsetParent):0)}function C(a){return a.offsetLeft+(a.offsetParent?C(a.offsetParent):0)}function r(a){return C(a)}function D(a){a.f=m(a,"cb");var b=a.f&&a.f.getAttribute("mbopen");if(b){eval(b);a.onopen(a.f)}}function E(a){a.b.style.display="none";a.m.style.backgroundPosition="-114px -78px";a.p.innerHTML=a.z;a.j=(g[a.c].r=0);google.History.save(j,g)}function F(a,b,c,d,f){var w=c>0?150:75,x=google.time()-f,y=x<w&&h?
x/w*c:(d>1?c-10:c),p=Math.max(a.s,b+y),q=p-a.s;B(a,q);a.d.style.height=p<0?0:(q?p+"px":"");n(a,Math.max(0,q-5));google.rhs();if(Math.abs(y)<Math.abs(c))window.setTimeout(function(){F(a,b,c,d-1,f)},30);else window.setTimeout(function(){c<0?E(a):D(a);if(!google.isIE&&a.H)a.b.style.width="100px";a.b.style.position=(a.d.style.height="");n(a,0);google.rhs();a.d.w=0},0)}function v(a){a.u=0;if(!a.d.w){a.d.w=1;var b;if(!a.j){a.s=google.getHeight(a.d);z(a);n(a,0);a.n=0;k(function(d){d.m.title=""});a.m.style.backgroundPosition=
"-126px -78px";a.p.innerHTML=a.o;B(a,1);a.b.style.position="absolute";a.b.style.display="";a.j=(g[a.c].r=1);google.History.save(j,g);b=a.b.offsetHeight}else{var c=a.f&&a.f.getAttribute("mbclose");if(c){eval(c);a.onclose(a.f)}b=a.s-google.getHeight(a.d);a.g.style.display="none";n(a,a.n);a.b.style.position="absolute"}F(a,google.getHeight(a.d),b,google.isSafari?2:1,google.time())}}google.dstr&&google.dstr.push(A);
})();
(function(){
var g,h;var i;function l(){g=document.createElement("style");document.getElementsByTagName("head")[0].appendChild(g);h=g.sheet;if(!h){i=document.createTextNode("");g.appendChild(i)}}
google.addCSSRule=function(a,b){g||l();var f=a+"{"+b+"}";if(!h){i.data+=f;return}h.insertRule(f,h.cssRules.length);};google.acrs=function(a){for(var b=a.split(/{|}/),d=1;d<b.length;d+=2)google.addCSSRule(b[d-1],b[d])};google.Toolbelt={};
var m=null,n=false,o=document.location.href.match("^.*?://[^/]*")[0],p,q;function s(a,b){q=document.getElementById("tbd");p=q.innerHTML=a;b||google.Toolbelt.toggle();google.j&&google.j.trap&&google.j.trap()}var t=google.History.client(function(a){s(a.content,a.open==google.Toolbelt.isToolbeltOpen())}),u=google.History.client(function(a){google.acrs(a)});google.Toolbelt.ascrs=function(a){google.acrs(a);google.History.save(u,a)};var v=[];google.Toolbelt.registerToolbeltCallback=function(a){v.push(a)};
google.Toolbelt.updateTbo=function(a){for(var b=document.getElementsByTagName("A"),d=0,c;c=b[d++];)if(c.href.match("^("+o+")?/(?!url|aclk|[^?]*$)")&&c!=m&&!c.href.match("[?&]tbo=u(&|$)")){c.href=c.href.replace(/([?&])tbo=[^&](&|$)/,"$1")+(a?"&tbo=1":"");}for(var d=0,f;f=document.forms[d++];)if(f.action.match("/search$")){for(var r=0,z=0,j;j=f.elements[z++];)if(j.name==
"tbo"&&!a){j.parentNode.removeChild(j);r=1}if(!r&&a){var k=document.createElement("input");k.type="hidden";k.value="1";k.name="tbo";f.appendChild(k)}}};function w(a){document.body.className=document.body.className.replace(/\btbo\b/,"")+(a?" tbo":"");google.Toolbelt.updateTbo(a);for(var b=0,d;d=v[b++];)d()}google.Toolbelt.isToolbeltOpen=function(){return document.body.className.match(/\btbo\b/)!=null};
google.Toolbelt.toggle=function(a,b){b=b||window.event;if(a)m=a;b&&b.stopPropagation&&b.stopPropagation();q=document.getElementById("tbd");if(!q)return true;p=q.innerHTML;var d=q.getElementsByTagName("DIV").length>0,c=google.Toolbelt.isToolbeltOpen();if(c){w(false);google.log("toolbelt","0&ei="+google.kEI);n=true}else if(d){w(true);n&&google.log("toolbelt","1&ei="+google.kEI)}else{mbtb1.insert=s;var e=google.xhr();if(e){e.open("GET",[google.pageState?google.pageState.replace("#","/mbd?"):google.base_href.replace(/^\/search\?/,
"/mbd?"),"&mbtype=29&resnum=1&tbo=1",mbtb1.tbs?"&tbs="+mbtb1.tbs:"","&docid=",mbtb1.docid,"&usg=",mbtb1.usg,"&zx=",google.time()].join(""));e.onreadystatechange=function(){if(e.readyState==4&&e.status==200)try{eval(e.responseText)}catch(f){window.location.replace(a.href)}};e.send(null)}return false}google.History.save(t,{content:p,open:!c});return false};function x(a){for(;a&&a.className!="tbt";)a=a.parentNode;return a}
google.Toolbelt.cdrClk=function(){var a=document.getElementById("cdr_opt");if(a){a.className="tbots";var b=x(a);if(b){for(var d=0,c;c=b.childNodes[d++];)if(c.className=="tbos")c.className="tbotu";var e=document.getElementById("cdr_min");e&&e.focus()}}};function y(a){return a.replace(/_/g,"_1").replace(/,/g,"_2").replace(/:/g,"_3")}
google.Toolbelt.cdrSbt=function(){var a=document.getElementById("cdr_frm");if(a){for(var b,d=0,c;c=a.childNodes[d++];)if(c.nodeType==1&&c.name=="tbs")b=c;var e=y(document.getElementById("cdr_min").value),f=y(document.getElementById("cdr_max").value);b.value=b.value.replace(/(cd_min:)([^,]*)/,"$1"+e).replace(/(cd_max:)([^,]*)/,"$1"+f)}};
google.Toolbelt.tbosClk=function(a){var b=a||window.event,d=b.target||b.srcElement;if(d&&d.className=="tbotu"){d.className="tbos";var c=x(d);if(c)for(var e=0,f;f=c.childNodes[e++];)if(f.className=="tbots")f.className="tbou"}};
})();
if(!window.gbar||!gbar.close){window.gbar={};(function(){var h=window.gbar,j,k;function l(b){var c=window.encodeURIComponent&&(document.forms[0].q||"").value;if(c)b.href=b.href.replace(/([?&])q=[^&]*|$/,function(i,f){return(f||"&")+"q="+encodeURIComponent(c)})}h.qs=l;function n(b,c,i,f,d,a){var e=document.getElementById(b),g=e.style;if(e){g.left=f?"auto":c+"px";g.right=f?c+"px":"auto";g.top=i+"px";g.visibility=k?"hidden":"visible";if(d){g.width=d+"px";g.height=a+"px"}else{n(j,c,i,f,e.offsetWidth,e.offsetHeight);k=k?"":b}}}h.tg=function(b){b=b||window.event;var c=0,i,f=window.navExtra,d,a=b.target||b.srcElement;b.cancelBubble=true;if(a.className!="gb3")a=a.parentNode;if(!j){d=document.createElement(Array.every||window.createPopup?"iframe":"div");d.frameBorder="0";d.src="#";j=a.parentNode.appendChild(d).id="gbs";document.onclick=h.close}var e=a.getAttribute("aria-owns")||"gbi",g=a.offsetWidth,o=a.offsetTop>20?46:24,m;do c+=a.offsetLeft||0;while(a=a.offsetParent);if(e=="gbi")for(d=document.getElementById(e);f&&(i=f.pop());)d.insertBefore(i,d.firstChild).className="gb2";else m=c=(document.documentElement.clientWidth||document.body.clientWidth)-c-g;k!=e&&h.close();n(e,c,o,m)};h.close=function(){k&&n(k,0,0)}})();;};
(function (){
var a="google";if(window[a]){window[a].a={};window[a].b=1;window[a].report=function(h,g,i){var d="";{if(window[a].pt){d+="&srt="+window[a].pt;delete window[a].pt}try{d+="&tran="+window.external.tran}catch(n){}}{var j=document.getElementById("csi");if(j.value)return;j.value=1}var b=h.t,e=b.start;delete b.start;var k=[];for(var f in b)e&&k.push(f+"."+(b[f]>e?b[f]-e:e-b[f]));if(g)for(var l in g)d+="&"+l+"="+g[l];var c=new Image,m=window[a].b++;window[a].a[m]=c;c.onload=(c.onerror=function(){delete window[a].a[m]});
c.src=[i?i:"/csi","?v=3","&s="+(window[a].sn?window[a].sn:"GWS")+"&action=",h.name,d,"&rt=",k.join(",")].join("");c=null}};window.setTimeout(function(){if(google.timers&&google.timers.load.t){google.timers.load.t.xjs=(new Date).getTime();google.timers.load.t.ol&&google.report(google.timers.load,google.kCSI)}},0);
})();
if(google.y.first){for(var a=0,b;b=google.y.first[a];++a)b();delete google.y.first}for(a in google.y)google.y[a][1]?google.y[a][1].apply(google.y[a][0]):google.y[a][0].go();google.y.x=google.x;google.x=function(d,c){c&&c.apply(d);return false};google.y.first=[];
