<%@ Page Title="" Language="C#" MasterPageFile="~/xsMaste.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="xs.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-6 col-md-6 hidden-xs hidden-sm">
        <img src="Images/jxtp.gif" alt="太原城市职业技术学院" />
    </div>
    <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 img_GongNen">
                <img src="Images/scbm.jpg" alt="首次报名" id="imgScbm" />
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 img_GongNen">
                <img src="Images/scck.jpg" alt="查看修改" />
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-left">
                首次报名，第一次报考的考生。<br />
                查看/修改信息：已报名考生可登录查看/修改信息。
            </div>
        </div>
    </div>
    <div class="col-lg col-md-3 col-sm-3 col-xs-12 text-center" style="background-color: silver; margin-top: 30px;">
        <h4>公告</h4>
        <br />
        兴华街九丰路三号太原城市职业技术学院<br />
        兴华街九丰路三号太原城市职业技术学院<br />
        兴华街九丰路三号太原城市职业技术学院<br />
        兴华街九丰路三号太原城市职业技术学院<br />
        <br />
    </div>
    <script type="text/javascript">
        $("#imgScbm").click(function () {
            //alert("发生单击事件！");
            $.ajax({
                type: 'Post', //网页往后台传送数据的方式 Post Get
                url: 'Default.aspx/getIsStart', //访问的地址
                dataType: 'json', //网页和WebService之间的数据传输格式
                contentType: "application/json;charset=utf-8",    //发送信息给服务器时，内容编码的类型
                success: function (responseData) { //成功返回数据执行的方法
                    var obj = JSON.parse(responseData.d);
                    if (obj.code == 1) {
                        $(location).attr('href', obj.url);
                    } else {
                        alert(obj.message);
                    }
                },
                error: function () {
                    alert("错误");
                } //后台发生错误时执行的方法
            });
        });
        /*document.getElementById("imgScbm").onclick = function () {
            alert("发生单击事件！");
        };*/
    </script>


</asp:Content>
