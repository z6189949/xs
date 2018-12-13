<%@ Page Title="" Language="C#" MasterPageFile="~/xsMaste.Master" AutoEventWireup="true" CodeBehind="resetPass.aspx.cs" Inherits="xs.resetPass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-top: 20px; padding-bottom: 20px;">

        <div class="input-group">
            <span class="input-group-addon" id="basic-sfzh">请输入身份证号</span>
            <input type="text" class="form-control" placeholder="身份证号" id="Sfzh" aria-describedby="basic-sfzh" />
        </div>
        <div class="input-group">
            <span class="input-group-addon" id="basic-zkzh">请输入高考考号</span>
            <input type="text" class="form-control" placeholder="高考考号" id="Zkzh" aria-describedby="basic-zkzh" />
        </div>
        <div class="input-group">
            <button type="button" class="btn btn-default navbar-btn" id="btnLogin">找回密码</button>
        </div>
    </div>
    <script type="text/javascript">
        $("#btnLogin").click(function () {
            if ($("#Sfzh").val().length == 0 || $("#Zkzh").val().length == 0) {
                alert("请输入用户名或者密码");
                return;
            }
            var stuUer = {
                Sfzh: $("#Sfzh").val(),
                Zkzh: $("#Zkzh").val()
            };
            var strSut = JSON.stringify(stuUer);
            $.ajax({
                type: "Post",
                url: "resetPass.aspx/restPassword",
                dataType: "Json",
                contentType: "application/json;charset=utf-8",
                data: strSut,
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    alert(reValue.message);
                    // alert("首次报名成功，请牢记您的登录用户名：" + reValue.SignUpNum);
                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
        })
    </script>
</asp:Content>
