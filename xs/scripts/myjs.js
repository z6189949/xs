function checkEmail(email) {
    var re = new RegExp("\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
    if (email.toString() == "") {
        $("#e_mailError").html("请输入正确的邮箱地址");
        $("#e_mailError").show();
        return false;
    } else if (re.test(email) == false) {
        $("#e_mailError").html("请输入正确的邮箱地址");
        $("#e_mailError").show();
        return false;
    }
    $("#e_mailError").hide();
    return true;
}
function checkEmail(email) {
    var re = new RegExp("1[0-9]{10}")
    if (email.toString() == "") {
        $("#mobileError").html("请输入正确的手机号");
        $("#mobileError").show();
        return false;
    } else if (re.test(email) == false) {
        $("#mobileError").html("请输入正确的手机号");
        $("#mobileError").show();
        return false;
    }
    $("#mobileError").hide();
    
    return true;
}

function checkPassword(password, password1) {
    if (password != password1) {
        $("#passwordError").show();
        $("#passwordError").html("两次输入的密码不相同");
        $("#password1Error").show();
        $("#password1Error").html("两次输入的密码不相同");
        return false;
    }
    $("#passwordError").hide();
    $("#password1Error").hide();
    return true;
}

function checkZkzh(zkzh) {
    var date = new Date();
    var year = date.getFullYear().toString().substring(2,4);
    var re = new RegExp("^" + year + "\14[0-9]{10}" + "$");
    if (re.test(zkzh) = false) {
        $("#zkzhError").html("请输入正确的准考证号")
        $("#zkzhError").show();
        return false;
    }
    $("#zkzhError").hide();
    return true;
}
