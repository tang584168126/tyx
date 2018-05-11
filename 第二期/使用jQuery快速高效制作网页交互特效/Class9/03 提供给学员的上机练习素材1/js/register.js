/**
 * @author LaoGong
 */
$(function(){
	function validate(e){
		//判断数据是否正确
		var flag=true;
		//获取当前ID属性值
		var id=$(e).attr("id");
		//获取当前文本款的值
		var vals=$(e).val();
		switch(id){
			case "email":
				//清空提示框
				$("#email_prompt").html("").removeClass();
				//定义邮箱正则表达式
				var reg=/^\w+@\w+(\.[a-zA-Z]{2,3}){1,2}$/;
				//判断用户名
				if(!reg.test(vals)){
					$("#email_prompt").html("邮箱格式不正确，请重新输入！！").addClass("register_prompt_error");
					$(e).removeClass().addClass("register_input register_input_Blur")
					flag=false;
				}else{
					$("#email_prompt").html("").removeClass().addClass("register_prompt_ok");
					$(e).removeClass().addClass("register_input");
				}
				break;
			case "nickName":
				//清空提示框
				$("#nickName_prompt").html("").removeClass();;
				//定义昵称正则表达式
				var reg=/^([\u4e00-\u9fa5]|\w|[@!#$%&*])+$/;
				if(!reg.test(vals)){
					$("#nickName_prompt").html("昵称格式不正确，请重新输入！").addClass("register_prompt_error");
					$(e).removeClass().addClass("register_input register_input_Blur")
					flag=false;
				}else{
					$("#nickName_prompt").html("").removeClass().addClass("register_prompt_ok");
					$(e).removeClass().addClass("register_input");
				}
				break;
			case "pwd":
				//清空提示框
				$("#pwd_prompt").html("").removeClass();
				if(vals.length<6||vals.length>18){
					$("#pwd_prompt").html("密码长度为6-18，请重新输入！").addClass("register_prompt_error");
					$(e).removeClass().addClass("register_input register_input_Blur")
					flag=false;
				}else{
					$("#pwd_prompt").html("").removeClass().addClass("register_prompt_ok");
					$(e).removeClass().addClass("register_input");
				}
				
				break;
			case "repwd":
				//清空提示框
				$("#repwd_prompt").html("").removeClass();;
				//获取第一次输入密码
				var pwds=$("#pwd").val();
				if(vals==""){
					$(e).removeClass().addClass("register_input register_input_Blur")
					$("#repwd_prompt").html("请再次输入你的密码！！").addClass("register_prompt_error");
					flag=false;
				}else if(pwds!=vals){
					$("#repwd_prompt").html("两次密码不一致，请重新输入！").addClass("register_prompt_error");
					$(e).removeClass().addClass("register_input register_input_Blur")
					flag=false;
				}else{
					$("#repwd_prompt").html("").removeClass().addClass("register_prompt_ok");
					$(e).removeClass().addClass("register_input");
				}
			break;
			default:
				break;
		}
		return flag;
	}
	//绑定邮箱验证事件
	$("#email").focus(function(){
		$(this).removeClass().addClass("register_input register_input_Focus")
		$("#email_prompt").removeClass().addClass("register_prompt").html("此邮箱为你登陆当当网账号！！");
	}).blur(function(){
		validate(this);
		});
	//绑定昵称验证事件
	$("#nickName").focus(function(){
		$(this).removeClass().addClass("register_input register_input_Focus")
		$("#nickName_prompt").removeClass().addClass("register_prompt").html("必填项，用户昵称！！");
	}).blur(function(){
		validate(this);
		});
	//绑定密码验证事件
	$("#pwd").focus(function(){
		$(this).removeClass().addClass("register_input register_input_Focus")
		$("#pwd_prompt").removeClass().addClass("register_prompt").html("必填项，密码！！！！");
	}).blur(function(){
		validate(this);
		});
	//绑定重复密码验证事件
	$("#repwd").focus(function(){
		$(this).removeClass().addClass("register_input register_input_Focus")
		$("#repwd_prompt").removeClass().addClass("register_prompt").html("必填项，请重复您的密码！！");
	}).blur(function(){
		validate(this);
		});
	//提交表单验证事件
	$("#myform").submit(function(){
		var flag=true;
		$(this).find("input[id]").each(function(i,e){
			if(!validate(e)){
				
				flag=false;
			}
		});
		return flag;
	});
	//提交按钮动画
	$("#registerBtn").hover(function(){
		$(this).attr("src","images/register_btn_over.gif");
	},function(){
		$(this).attr("src","images/register_btn_out.gif");
	});
	//省市级联
    var cityList = new Array();
    cityList['北京市'] = ['朝阳区','东城区','西城区', '海淀区','宣武区','丰台区','怀柔','延庆','房山'];
    cityList['上海市'] = ['宝山区','长宁区','丰贤区', '虹口区','黄浦区','青浦区','南汇区','徐汇区','卢湾区'];
    cityList['广州省'] = ['广州市','惠州市','汕头市','珠海市','佛山市','中山市','东莞市'];
    cityList['深圳市'] = ['福田区', '罗湖区', '盐田区', '宝安区', '龙岗区', '南山区', '深圳周边'];
    cityList['重庆市'] = ['俞中区', '南岸区', '江北区', '沙坪坝区', '九龙坡区', '渝北区', '大渡口区', '北碚区'];
    cityList['天津市'] = ['和平区', '河西区', '南开区', '河北区', '河东区', '红桥区', '塘古区', '开发区'];
    cityList['江苏省'] = ['南京市','苏州市','无锡市'];
    cityList['浙江省'] = ['杭州市','宁波市','温州市'];
    cityList['四川省'] = ['四川省','成都市'];
    cityList['海南省'] = ['海口市'];
    cityList['福建省'] = ['福州市','厦门市','泉州市','漳州市'];
    cityList['山东省'] = ['济南市','青岛市','烟台市'];
    cityList['江西省'] = ['江西省','南昌市'];
    cityList['广西省'] = ['柳州市','南宁市'];
    cityList['安徽省'] = ['安徽省','合肥市'];
    cityList['河北省'] = ['邯郸市','石家庄市'];
    cityList['河南省'] = ['郑州市','洛阳市'];
    cityList['湖北省'] = ['武汉市','宜昌市'];
    cityList['湖南省'] = ['湖南省','长沙市'];
    cityList['陕西省'] = ['陕西省','西安市'];
    cityList['山西省'] = ['山西省','太原市'];
    cityList['黑龙江省'] = ['黑龙江省','哈尔滨市'];
    cityList['其他'] = ['其他'];
    $("#province").append(function(){
        var html="";
        for (var i in cityList){
            html+="<option value="+i+">"+i+"</option>";
        }
        return $(html);
    });
    $("#province").change(function(){
        var v= $(this).val();
        var html="";
        if(v=="请选择省/城市"){
            html="<option>请选择城市/地区</option>";
            $("#city").html(html);
            return;
        }
        var citys=cityList[v];
        $.each(citys,function(i,n){
            html+="<option value="+n+">"+n+"</option>";
        });
        $("#city").html(html);
    });
})
