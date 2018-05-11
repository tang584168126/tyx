$(function(){
	var $email = $("#email");	//获取文本框
	var $pwd = $("#pwd");	//获取密码框
	var $login=$("#loginForm");	//获取登录按钮
	var regEmail= /^\w+@\w+(\.[a-zA-Z]{2,3}){1,2}$/;	//定义邮箱格式
	var regName=/^[0-9]+$/;	//定义昵称格式
	$login.submit(function(){
		if($email.val()==""){
			alert("请输入Email或昵称！");
			return false;
		}else if(regName.test($email.val())==true){
			alert("昵称输入不合法");
			return false;
		}else{
			if($email.val().indexOf(".")!=-1||$email.val().indexOf("@")!=-1){
				if(regEmail.test($email.val())==false){
					alert("邮箱输入不合法！");
					return false;
				}
			}
			if($pwd.val()==""){
				alert("请输入密码");
				return false;
			}else if($pwd.val().length<6){
				alert("密码必须大于6位数！");
				return false;
			}
			
		}
		
		
	});
	
});