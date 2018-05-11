/*主要演示列表和大图视图的切换效果*/
/**
*注意:在页面加载的时候,显示列表视图
*采用的思路是:先获取列表视图中的所有内容,然后再去设置大图视图.
*/
$(function(){
	//默认显示的是列表视图
	//在显示之前,增加一本书(在HTMl里面有个空的div,id='storyBooksssss')
	//这里演示使用js脚本添加一本书,如果是多本书,自己可以模仿搞定.
	function bookList(){
		var book = new Array();
		book[0]=['product_list_01.jpg','模板（这是使用js脚本添加的内容）',5,'郭现杰','XXXXX出版社', '1573年11月',           '数年前，在一次股市的多、空之战中，以赵云狄、林康为首的私募基金—金鼎投资，和以王雨龙为首的私募基金，达成锁仓协议分食利益。殊料，以王雨龙为首的私募基金—鑫利投资背信弃义，导致金鼎投资惨败。以至...',
            '13.10','59折','￥18.90','￥32.00'];
	
	//声明一个字符串来装这些元素
	var html="";
	//可以使用jQuery的遍历器来做
	$.each(book,function(i,element){//i=>索引;element=>迭代的当前元素
		            html+="<div class='product_storyList_content_left'><img src=images/"+element[0]+" alt='图书列表'></div>";
            html+="<div class='product_storyList_content_right'><ul>";
            html+="<li class='product_storyList_content_dash'><a href='#' class='blue_14'>"+element[1]+"</a></li>";
            html+="<li>顾客评分：";
            for(var k=0;k<5;k++){
                if(k<element[2]){
                    html+= "<img src='images/star_red.gif' alt='star'>";
                }
                else{
                    html+= "<img src='images/star_gray.gif' alt='star'>";
                }
            }
            html+="</li>";
            html+="<li>作　者：<a href='#' class='blue_14'>"+element[3]+"</a> 著</li>";
            html+="<li>出版社：<a href='#' class='blue_14'>"+element[4]+"</a></li>";
            html+="<li>出版时间："+element[5]+"</li>";
            html+="<li>"+element[6]+"</li>";
            html+="<li> <dl class='product_content_dd'>";
            html+="<dd><img src='images/product_buy_02.gif' alt='shopping'></dd>";
            html+="<dd><img src='images/product_buy_01.gif' alt='shopping'></dd>";
            html+="<dd>节省："+element[7]+"</dd>";
            html+="<dd>折扣：<span>"+element[8]+"</span></dd>";
            html+="<dd class='footer_dull_red'><span>"+element[9]+"</span></dd>";
            html+="<dd class='product_content_delete'><span>"+element[10]+"</span></dd>";
            html+="</dl></li></ul></div>";
            html+="<div class='product_storyList_content_bottom'></div>";
        });
        $("#storyBooksssss").html(html);
	}
	//调用上面定义的函数bookList(),默认需要显示第一本书
	bookList();
	//需要先去获取列表视图的所有内容,用于单击切换的时候使用
	var list = $("#product_storyList_content").html();
	//设置大图视图的函数
	function getBig(){
		//获取大图视图需要的所有元素
		var $content = $("#product_storyList_content");
		//将这个集合中的元素,拆开,拼成大图视图需要的字符串
		//装图片的div
		var $bookImg = $content.find(".product_storyList_content_left");
		//用来装所有内容的字符串
		var contents = "";
		//遍历每本书的所有的文本内容
		$content.find(".product_storyList_content_right").find("ul").each(function(i,element){
			//一本书,对应一张图片和一些相关的内容
			//图片
			contents += "<div class='big_img_list'><ul><li class='bookImg'>"+$($bookImg[i]).html()+"</li>";
			//找到所有的li,一共有7对li,每对li里面放的内容是不一样的,必须去找到大视图需要的内容,然后再排列
			var $li=$(element).children("li");
			//找到最后一对li,再找下面的价格,价格是包含在span标签里面的
            var $price=$($li[6]).find("span");//得到一个包含价格的集合对象
			//价格
			contents +="<li><dl><dd class='footer_dull_red'>"
                +$($price[1]).text()+"</dd><dd class='product_content_delete'>"
                +$($price[2]).text()+"</dd><dd class='footer_dull_red'>"
                +$($price[0]).text()+"</dd></dl></li>";
				//简介
			contents+="<li class='detail'>"+$($li[5]).html()+"</li>"
			//作者
            contents += "<li class='detail'>"+$($li[2]).html()+"</li>";
			//顾客评分
            contents +="<li class='detail'>"+$($li[1]).html()+"</li>";
			//出版社
            contents +="<li class='detail'>"+$($li[3]).html()+"</li>";
			//出版时间
            contents +="<li class='detail'>"+$($li[4]).html()+"</li></ul></div>";
		});
		return contents;
	}
	//大视图的内容
	var bigBook =getBig();
	//单击事件
	$("#product_array a").click(function(){
		//判断是否是连续单击,如果是,直接返回,不执行操作
		//可以使用is方法来判断,判断该标签是不是一种具体的标签,
		//或者是判断这个标签是否含有一个属性
		//<a class="click" name="array"  href="javascript:void(0)">列表</a>
            //<a name="bigImg" href="javascript:void(0)">大图</a>
			//根据上面的HTML结构,我们可以使用class属性来判断
		if($(this).is("[class='click']")){
				return;
		}
		//是第一次单击,将相邻的a标签的class='click'移除掉
		$(this).siblings().removeClass("click");
		//将当前产生单击事件的a标签增加样式class='click'
		$(this).addClass('click');
		//判断单击的是哪个a标签,可以通过name属性来判断
		if($(this).attr("name")=="array"){//单击了列表
				//清空原来的内容,重新添加列表内容
				$("#product_storyList_content").empty().html(list);
		}else{//单击了大图
			//清空原来的内容,重新添大图内容
			$("#product_storyList_content").empty().html(bigBook);
			//出现边框的样式已经定义好(在layout.css里面),直接使用就ok
			$("#product_storyList_content").find(".big_img_list ul").hover(function(){
				$(this).addClass("over");
				$(this).parent().addClass("over");
			},function(){
				$(this).removeClass("over");
				$(this).parent().removeClass("over");
			});
		}
		
	});
});



