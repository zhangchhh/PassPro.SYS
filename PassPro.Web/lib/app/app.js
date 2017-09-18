(function ($, owner) {
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
            url: encodeURI("../Account/LoginForUser?username=" + username + "&pwd="+pwd),
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