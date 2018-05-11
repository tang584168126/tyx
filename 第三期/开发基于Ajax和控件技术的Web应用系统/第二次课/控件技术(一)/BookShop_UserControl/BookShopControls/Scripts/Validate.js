//验证函数，textbox为DOM对象，valType为验证类型
function checkNoZeroInteger(textbox, valType) {
    if(valType == "NoZeroInteger"){
        var reg = /^\+?[1-9][0-9]*$/;   //验证非零整数的正则表达式

        if(!reg.exec(textbox.value)){         //验证不通过
            alert("不是正确非零正整数！");    //输出提示
            textbox.value = "";               //清空输入框
        }
    }else if(valType == "BigChar"){
        var reg = /^[A-Z]+$/;                 //验证大写字母的正则表达式
        if(!reg.exec(textbox.value)){
            alert("只能是大写字母！");        //输出提示
            textbox.value = "";               //清空输入框
        }
    }
}