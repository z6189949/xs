<%@ Page Title="" Language="C#" MasterPageFile="~/xsMaste.Master" AutoEventWireup="true" CodeBehind="reg_EditPassword.aspx.cs" Inherits="xs.reg_EditPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script src="scripts/dist/jquery.validate.min.js"></script>--%>
   <script src="scripts/jquery.validate.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div style="padding: 10px 10px 10px 10px; margin-left: 33%">
        <div class="input-group input-group-top" >
            <span class="input-group-addon" id="basic-userName">站点登陆的用户名：</span>
            <input type="text" style="width: 300px;" class="form-control" autofocus="autofocus" readonly="true" placeholder="用户名称" aria-describedby="basic-userName" id="userName" />
        </div>
        <input type="hidden" id="stuID" />
        <div class="input-group input-group-top" >
            <span class="input-group-addon" id="basic-sfzh" style="width: 152px;">身  份  证  号：</span>
            <input type="text" class="form-control" style="width: 300px;" autofocus="autofocus" readonly="true" placeholder="用户身份证号" aria-describedby="basic-sfzh" id="sfzh" />
        </div>
        <div class="input-group input-group-top" >
            <span class="input-group-addon" id="basic-stuName" style="width: 152px;">考   生  名  称：</span>
            <input type="text" class="form-control" style="width: 300px;" autofocus="autofocus" readonly="true" placeholder="用户身份名称" aria-describedby="basic-stuName" id="stuName" />
        </div>
        <div class="input-group input-group-top" >
            <span class="input-group-addon" id="basic-password" style="width: 152px;">密   &nbsp;&nbsp;   码：</span>
            <input type="password" style="width: 300px;" class="form-control" autofocus="autofocus" placeholder="请输入密码" aria-describedby="basic-password" id="password" name="password"/>
        </div>
        <div class="input-group input-group-top" >
            <span class="input-group-addon" id="basic-password1" style="width: 152px;">确  认  密  码：</span>
            <input type="password" style="width: 300px;" class="form-control" autofocus="autofocus" placeholder="请输入确认密码" aria-describedby="basic-password1" id="password1" name="password1"/>
        </div>
        <div class=" input-group-btn input-group-top">
            <button type="button" class="btn btn-default navbar-btn" id="editPassword">修改密码</button>
        </div>
    </div>
    <script type="text/javascript">
        //url: window.location.href,
        
        function GetQueryString(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return unescape(r[2]); return null;
        }
        $(document).ready(function () {
            var userID = {
                
                id: GetQueryString("u"),
                time: GetQueryString("t")
            };
            $("#hidden").val(GetQueryString("u"));
            var strUserID = JSON.stringify(userID);
            $.ajax({
                type: "Post",
                url: "reg_EditPassword.aspx/showInfo",
                dataType: "Json",
                contentType: "application/json;charset=utf-8",
                data: strUserID,
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    $("#userName").val(reValue.userSignUpNum);
                    $("#sfzh").val(reValue.userSfzh);
                    $("#stuName").val(reValue.stuName);
                    //alert(reValue.url);
                    //alert(reValue.message);
                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
            ///
           
        });

        $("#form1").validate({
            debug: true,
            rules: {
                password: { required: true, equalTo: "#password1", minlength: 6 },
                password1: { required: true, equalTo: "#password", minlength: 6 },
            },
            messages: {
                password: { required: "请输入密码", equalTo: "与确认密码不相同！", minlength: "密码最少是6个字符!!!" },
                password1: { required: "请再此确认密码", equalTo: "两次密码不相同！", minlength: "密码最少是6个字符!!!" },
            }
        });
        $("#editPassword").click(function () {

            var user =  {
                id:GetQueryString("u"),
                password: $("#password").val()

            };
            var stuUser = JSON.stringify(user);
            $.ajax({
                type: "Post",
                url: "reg_EditPassword.aspx/editPass",
                dataType: "Json",
                contentType: "application/json;charset=utf-8",
                data: stuUser,
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    alert(reValue.message);
                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
        });
    </script>
</asp:Content>
