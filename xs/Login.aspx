<%@ Page Title="" Language="C#" MasterPageFile="~/xsMaste.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="xs.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-top: 20px; padding-bottom: 20px"></div>
    <div class="input-group">
        <span class="input-group-addon" id="basic-addon1">用户名</span>
        <input type="text" class="form-control" placeholder="用户名" id="userName" aria-describedby="basic-addon1" />
    </div>
    <div class="input-group">
        <span class="input-group-addon" id="basic-password">密 码</span>
        <input type="text" class="form-control" placeholder="密码" id="password" aria-describedby="basic-password" />
    </div>
    <div class="input-group">
        <button type="button" class="btn btn-default navbar-btn" id="btnLogin">登陆</button>
        <a href="resetPass.aspx">找回用户名或密码</a>
    </div>
    <script type="text/javascript">
        function on_return() {
            if (window.event.keyCode == 13) {
                if (document.all('btnLogin') != null) {
                    document.all('btnLogin').click();
                }
            }
        }
        $("body").attr("onkeydown", "on_return()");
        $("#btnLogin").click(function () {
            if ($("#userName").val().length == 0 || $("#password").val().length == 0) {
                alert("请输入用户名或者密码");
                return;
            }
            var stuUer = {
                userName: $("#userName").val(),
                password: $("#password").val()
            };
            var strSut = JSON.stringify(stuUer);
            $.ajax({
                type: "Post",
                url: "Login.aspx/Login1",
                dataType: "Json",
                contentType: "application/json;charset=utf-8",
                data: strSut,
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    alert(reValue.message);
                    if (reValue.code == 1) {
                        window.location.href = "/EntityInfo.aspx";
                    }
                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
        })
    </script>
</asp:Content>
