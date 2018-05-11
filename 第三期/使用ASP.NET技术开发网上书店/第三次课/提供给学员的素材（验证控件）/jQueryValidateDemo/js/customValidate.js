
jQuery.validator.addMethod("regex",         //addMethod第1个参数:方法名称
    function(value, element, params) {      //addMethod第2个参数:验证方法，参数（被验证元素的值，被验证元素，参数）
        var exp = new RegExp(params);       //实例化正则对象，参数为传入的正则表达式
        return exp.test(value);             //测试是否匹配
    },
    "格式错误");                            //addMethod第3个参数:默认错误信息

$(function() {
    $("#signupForm").validate(
    {
        rules: {
            txtPassword1: "required",       //密码1必填

            txtPassword2: {                 //密码2的描述多于1项使用对象类型
                required: true,             //必填，这里可以是一个匿名方法
                equalTo: "#txtPassword1",   //必须与密码1相等
                rangelength: [5, 10],       //长度5-10之间
                regex: "^\\w+$"             //使用自定义的验证规则,在上例中新增的部分
            },

            txtEmail: "email"               //电子邮箱必须合法
        },
        messages: {
            txtPassword1: "您必须填写",

            txtPassword2: {
                required: "您必须填写",
                equalTo: "密码不一致",
                rangelength: "长度必须介于{0} 和 {1} 之间的字符串",
                regex: "密码只能是数字、字母与下划线"
            }
        },
        debug: false,  //如果修改为true则表单不会提交
        submitHandler: function() {
            alert("开始提交了");
        }
    });
});



// 手机号码验证
jQuery.validator.addMethod("mobile", function (value, element) {
    var length = value.length;
    var mobile = /^(((13[0-9]{1})|(15[0-9]{1}))+\d{8})$/
    return this.optional(element) || (length == 11 && mobile.test(value));
}, "手机号码格式错误");

// 电话号码验证  
jQuery.validator.addMethod("phone", function (value, element) {
    var tel = /^(0[0-9]{2,3}\-)?([2-9][0-9]{6,7})+(\-[0-9]{1,4})?$/;
    return this.optional(element) || (tel.test(value));
}, "电话号码格式错误");

// 邮政编码验证  
jQuery.validator.addMethod("zipCode", function (value, element) {
    var tel = /^[0-9]{6}$/;
    return this.optional(element) || (tel.test(value));
}, "邮政编码格式错误");

// QQ号码验证  
jQuery.validator.addMethod("qq", function (value, element) {
    var tel = /^[1-9]\d{4,9}$/;
    return this.optional(element) || (tel.test(value));
}, "qq号码格式错误");

// IP地址验证
jQuery.validator.addMethod("ip", function (value, element) {
    var ip = /^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$/;
    return this.optional(element) || (ip.test(value) && (RegExp.$1 < 256 && RegExp.$2 < 256 && RegExp.$3 < 256 && RegExp.$4 < 256));
}, "Ip地址格式错误");

// 字母和数字的验证
jQuery.validator.addMethod("chrnum", function (value, element) {
    var chrnum = /^([a-zA-Z0-9]+)$/;
    return this.optional(element) || (chrnum.test(value));
}, "只能输入数字和字母(字符A-Z, a-z, 0-9)");

// 中文的验证
jQuery.validator.addMethod("chinese", function (value, element) {
    var chinese = /^[\u4e00-\u9fa5]+$/;
    return this.optional(element) || (chinese.test(value));
}, "只能输入中文");

// 下拉框验证
$.validator.addMethod("selectNone", function (value, element) {
    return value == "请选择";
}, "必须选择一项");

// 字节长度验证
jQuery.validator.addMethod("byteRangeLength", function (value, element, param) {
    var length = value.length;
    for (var i = 0; i < value.length; i++) {
        if (value.charCodeAt(i) > 127) {
            length++;
        }
    }
    return this.optional(element) || (length >= param[0] && length <= param[1]);
}, $.validator.format("请确保输入的值在{0}-{1}个字节之间(一个中文字算2个字节)"));