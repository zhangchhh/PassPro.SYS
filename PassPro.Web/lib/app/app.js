(function ($, owner) {
    /**
     * 注册
     * @returns {} 
     */
    owner.register = function () {
        var phone = $("#_phone").val();
        var email = $("#_email").val();
        var pwd = $("#_password").val();
        var pwd2 = $("#_passwords").val();
        var code = $("#_validateCode").val();
        if (phone == "") {
            layer.tips('请输入手机号', '#_phone', { tips: [1, '#3595CC'], time: 2000 });
            return false;
        }
        if (!(/^1[34578]\d{9}$/.test(phone))) {
            layer.tips('手机号格式不正确', '#_phone', {tips: [1, '#3595CC'],time: 2000});
            return false;
        }
        if (email == "") {
            layer.tips('请输入邮箱', '#_email', { tips: [1, '#3595CC'], time: 2000 });
            return false;
        }
        //var rel = /([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,5})+ /;
        //if (!(rel.test(email))) {
        //    layer.tips('邮箱格式不正确', '#_email', {
        //        tips: [1, '#3595CC'],
        //        time: 2000});
        //    return false;
        //}
        if (pwd == "") { layer.tips("请输入密码", "#_password", { tips: [1, '#3595CC'], time: 2000 });
            return false;
        }
        if (!(/^(\w){6,20}$/.test(pwd))) {
            layer.tips("密码由6-20个字母，数字，组成", "#_password", { tips: [1, "#3595CC"], time: 2000 });
            return false;
        }
        if (pwd2 == "") {
            layer.tips("请输入确认密码", "#_passwords", { time: 2000, tips: [1, "#3595CC"] });
            return false;
        }
        if (!(/^(\w){6,20}$/.test(pwd2))) {
            layer.tips("密码由6-20个字母，数字，组成", "#_password", { time: 2000, tips: [1, "3595CC"] });
            return false;
        }
        if (pwd2 != pwd) {
            layer.tips("两次输入密码不一致", "#_password", { time: 2000, tips: [1, "3595CC"] });
            return false;
        }
        var load = layer.load(0, { shade: 0.1 });
            $.ajax({
                type: "post",
                url: "../Account/ResisterUser",
                data: {
                 password: pwd, phone: phone, email: email, ValidateCode:code
        },
            datatype: "json",
            success: function (result) {
                layer.close(load);
                if (result.Success != undefined) {
                    if (result.Success == true) {
                        layer.close();
                        location.href = "../Account/Login";
                    }
                    else {
                        layer.msg(result.Message);
                    }
                }
                else {
                    layer.msg(result);
                }
            }
        });
    }
    /**
     * 登录
     **/
    owner.login = function () {
        var username = $("#u_name").val();
        var pwd = $("#u_pwd").val();
        if (username == "") {
            layer.tips('请输入邮箱/手机号', '#u_name', {
                tips: [1, '#3595CC'],
                time: 2000
            });
            return;
        }
        if (pwd == "") {
            layer.tips('请输入密码', '#u_pwd', {
                tips: [1, '#3595CC'],
                time: 2000
            });
            return;
        }
        var load = layer.load(0, { shade: 0.1 });
        $.ajax({
            type: "post",
            url: encodeURI("../Account/LoginForUser?username=" + username + "&pwd=" + pwd),
            //data: { username: username, pwd: pwd },
            datatype: "json",
            success: function (result) {
                layer.close(load);
                if (result.Success != undefined) {
                    if (result.Success == true) {
                        location.href = "../Home/Index";
                    }
                    else {
                        layer.msg(result.Message);
                    }
                }
                else {
                    layer.msg(result);
                }
            }
        });
    }
}(jQuery, window.app = {}));