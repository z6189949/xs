<%@ Page Title="" Language="C#" MasterPageFile="~/xsMaste.Master" AutoEventWireup="true" CodeBehind="EntityInfo.aspx.cs" Inherits="xs.EntityInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="scripts/jquery.validate.min.js"></script>
    <script src="scripts/jquerysession.js"></script>
    <link href="Styles/myCss.css" rel="stylesheet" />
    <div class="col-lg-12">
        <h1 class="text-center">考生志愿填报</h1>
        <div class="row">
            <div class="col-lg-8">
                        <div class="input-group">
            <span class="input-group-addon" id="basic-SignUpNum">报名序号</span>
            <input type="text" class="form-control" readonly="true" placeholder="报名序号" id="SignUpNum" aria-describedby="basic-SignUpNum" name="SignUpNum" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Zkzh">高考考号</span>
            <input type="text" class="form-control" readonly="true" placeholder="高考考号" id="Zkzh" aria-describedby="basic-Zkzh" name="Zkzh" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Sfzh">身份证号</span>
            <input type="text" class="form-control" readonly="true" placeholder="身份证号" id="Sfzh" aria-describedby="basic-Sfzh" name="Sfzh" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-StuName">姓名</span>
            <input type="text" class="form-control" readonly="true" placeholder="姓名" id="StuName" aria-describedby="basic-StuName" name="StuName" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Csrq">出生年月</span>
            <input type="text" class="form-control" readonly="true" placeholder="出生年月" id="Csrq" aria-describedby="basic-Csrq" name="Csrq" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Xb">性别</span>
            <input type="text" class="form-control" readonly="true" placeholder="性别" id="Xb" aria-describedby="basic-Xb" name="Xb" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Mobile">移动电话</span>
            <input type="text" class="form-control" readonly="true" placeholder="移动电话" id="Mobile" aria-describedby="basic-Mobile" name="Mobile" />
        </div>
            </div>
            <div class="col-lg-4">
                <div class="row">
                    <div class="col-lg-12 imgfile">
                        <img width="150px" height="200px" src="" id ="imgStuPic"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-8">
                        <input type="file" id="fupload"   name="file" onchange="showPreview(this)"/>
                    </div>
                    <div class ="col-lg-4">
                        <button class="btn-danger" id="btnFileUpLoad">上传</button>
                    </div>
                </div>
            </div>
        </div>

        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Nation">民族</span>
            <select class="form-control" id="Nation" name="Nation" aria-describedby="basic-Nation">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-ZZMM">政治面貌</span>
            <select class="form-control" id="ZZMM" aria-describedby="basic-Nation" name="ZZMM">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Health">健康情况</span>
            <select class="form-control" id="Health" aria-describedby="basic-Nation" name="Health">
                <option value="" disabled="disabled" selected="selected" style="display: none">请选择健康情况</option>
                <option value="1">好</option>
                <option value="2">一般</option>
                <option value="3">比较好</option>
                <option value="4">差</option>
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-KSLB">考生类别</span>
            <select class="form-control" id="KSLB" aria-describedby="basic-Nation" name="KSLB">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-AreaCode_Shi">所在市</span>
            <select class="form-control" id="AreaCode_Shi" aria-describedby="basic-Nation" name="AreaCode_Shi">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-AreaCode">所在县(区)</span>
            <select class="form-control" id="AreaCode" aria-describedby="basic-Nation" name="AreaCode">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Byxx">毕业学校</span>
            <input type="text" class="form-control" placeholder="毕业学校" id="Byxx" aria-describedby="basic-Byxx" name="Byxx" />


        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-BYLB">毕业学校类别</span>
            <select class="form-control" id="BYLB" aria-describedby="basic-Nation" name="BYLB">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-LikeSpecial">有何爱好及特长</span>
            <input type="text" class="form-control" placeholder="有何爱好及特长" id="LikeSpecial" aria-describedby="basic-LikeSpecial" name="LikeSpecial" />
        </div>

        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Tel">固定电话(区号+号码)</span>
            <input type="text" class="form-control" placeholder="固定电话(区号+号码)" id="Tel" aria-describedby="basic-Tel" name="Tel" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Yzbm">邮政编码</span>
            <input type="text" class="form-control" placeholder="邮政编码" id="Yzbm" aria-describedby="basic-Yzbm" name="Yzbm" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-AcceptPeople">联系人</span>

            <input type="text" class="form-control" placeholder="联系人" id="AcceptPeople" aria-describedby="basic-AcceptPeople" name="AcceptPeople" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-Txdz">通知书邮寄地址</span>

            <input type="text" class="form-control" placeholder="通知书邮寄地址" id="Txdz" aria-describedby="basic-Txdz" name="Txdz" />
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-FrsZY">第一志愿专业</span>
            <select class="form-control" id="FrsZY" aria-describedby="basic-Nation" name="FrsZY">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-SecZy">第二志愿专业</span>
            <select class="form-control" id="SecZy" aria-describedby="basic-Nation" name="SecZy">
            </select>
        </div>
        <div class="input-group input-group-top">
            <span class="input-group-addon" id="basic-IsAdjust">是否服从调剂</span>
            <input type="checkbox" id="IsAdjust" name="IsAdjust"/>
        </div>
        <div class="input-group input-group-top">
            <input type="button" class="btn btn-danger" value="提交" id="tijiao" />
            <input type="button" class="btn btn-danger" value="打印" id="dayin" />
        </div>
    </div>
    <script type="text/javascript">

        function GetQueryString(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return unescape(r[2]); return null;
        }
        function showPreview(source) {
            var file = source.files[0];
            if (window.FileReader) {
                var fr = new FileReader();
                console.log(fr);
                var portrait = document.getElementById('imgStuPic');
                fr.onloadend = function (e) {
                    portrait.src = e.target.result;
                };
                fr.readAsDataURL(file);
                portrait.style.display = 'block';
            }
        }
        $(document).ready(function () {
            var id = "0"
            if (GetQueryString("id")!=null) {
                id = GetQueryString("id");
            }
            var data = JSON.stringify({id:id})
           // var user_ = $.session.get("user_");
            $.ajax({
                type: "Post",
                url: "EntityInfo.aspx/getSelectInfo",
                dataType: "Json",
                data:data,
                contentType: "application/json;charset=utf-8",
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    //alert(reValue.message);
                    // alert("首次报名成功，请牢记您的登录用户名：" + reValue.SignUpNum);
                    if (reValue.code == 0) {
                        alert(reValue.message);
                        $(location).attr("href", "Login.aspx");
                    }
                    //alert(reValue.user.StuName)
                    $("#SignUpNum").val(reValue.user.SignUpNum);
                    $("#Zkzh").val(reValue.user.Zkzh);
                    $("#Sfzh").val(reValue.user.Sfzh);
                    $("#StuName").val(reValue.user.StuName);
                    $("#Csrq").val(reValue.user.Csrq);
                    $("#Xb").val(reValue.user.Xb);
                    $("#Mobile").val(reValue.user.Mobile);
                    $("#Nation").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择民族</option>");
                    $.each(reValue.listNation, function (index, element) {
                        $("#Nation").append("<option value=\"" + element.NationCode + "\">" + element.NationName + "</option>");
                    });
                    $("#AreaCode_Shi").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择市区</option>");
                    $.each(reValue.shiAreaCode, function (index, element) {
                        $("#AreaCode_Shi").append("<option value=\"" + element.AreaCode + "\">" + element.AreaName + "</option>");
                    });

                    $("#KSLB").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择考生类别</option>");
                    $.each(reValue.listKslb, function (index, element) {
                        $("#KSLB").append("<option value=\"" + element.KslbDm + "\">" + element.KslbMc + "</option>");
                    });
                    $("#ZZMM").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择政治面貌</option>");
                    $.each(reValue.listZZMM, function (index, element) {
                        $("#ZZMM").append("<option value=\"" + element.ZzmmDm + "\">" + element.ZzmmMc + "</option>");
                    });
                    $("#FrsZY").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择第一志愿专业</option>");
                    $.each(reValue.listZy, function (index, element) {
                        $("#FrsZY").append("<option value=\"" + element.ZYDM + "\">" + element.ZYMC + "</option>");
                    });
                    $("#SecZy").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择第二志愿专业</option>");
                    $.each(reValue.listZy, function (index, element) {
                        $("#SecZy").append("<option value=\"" + element.ZYDM + "\">" + element.ZYMC + "</option>");
                    });
                    $("#BYLB").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择毕业类别</option>");
                    $.each(reValue.listBylb, function (index, element) {
                        $("#BYLB").append("<option value=\"" + element.BylbDm + "\">" + element.BylbMc + "</option>");
                    });
                    function formatDate(dt) {
                        var year = dt.getFullYear();
                        var mouth = dt.getMonth() + 1;
                        var date = dt.getDate();
                        return year + "-" + mouth + "-" + date;
                    }
                    
                    var host = window.location.hostname;
                    var port = window.location.port;
                    var domainName = "http://" + host;
                    if (port != "") {
                        domainName += ":" + port + "//";
                    }
                    function srchttp(pic) {
                        var src1 = pic.substring(0, 5);
                        if (src1 =="local") {
                            return pic;
                        } else {
                            return "localhost:2652/"+pic
                        }
                      }
                    if (reValue.info != null)
                    {
                        var csqr = reValue.info.Csrq;
                        var csqr2 = new Date(parseInt(csqr.slice(6, 19)));
                        $("#Csrq").val(formatDate(csqr2));           
                        $("#Xb").val(reValue.info.Xb == 0 ? '女' : '男');
                        $("#Nation").val(reValue.info.Nation);
                        $("#ZZMM").val(reValue.info.ZZMM);
                        $("#Health").val(reValue.info.Health);
                        $("#KSLB").val(reValue.info.KSLB);
                        $("#AreaCode_Shi").val(reValue.info.AreaCode.substring(0,4)).change();
                        $("#AreaCode").val(reValue.info.AreaCode);
                        $("#Byxx").val(reValue.info.Byyx);
                        $("#BYLB").val(reValue.info.BYLB);
                        $("#LikeSpecial").val(reValue.info.LikeSpecial);
                        $("#Tel").val(reValue.info.Tel);
                        $("#Yzbm").val(reValue.info.Yzbm);
                        $("#Txdz").val(reValue.info.Txdz);
                        $("#AcceptPeople").val(reValue.info.AcceptPeople);

                        $("#imgStuPic").attr("src", domainName+reValue.info.PicPath);
                    }            
                    if (reValue.wish != null)
                    {
                        $("#FrsZY").val(reValue.wish.FrsZY);
                        $("#SecZy").val(reValue.wish.SecZY);
                        if (reValue.wish.IsAdjust == 1) {
                            $("#IsAdjust").attr('checked', 'checked');
                        } else {
                            $("#IsAdjust").removeAttr('checked');
                        }
                    }
                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
        });
        $("#AreaCode_Shi").change(function () {
            var listShi = {
                shiCode: $("#AreaCode_Shi").val()
            };
            var strListShi = JSON.stringify(listShi);
            $.ajax({
                type: "Post",
                url: "EntityInfo.aspx/getXianByShi",
                dataType: "Json",
                contentType: "application/json;charset=utf-8",
                data: strListShi,
                async:false,
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    $("#AreaCode").empty();
                    $("#AreaCode").append("<option value=\"\" disabled=\"disabled\" selected=\"selected\" style=\"display: none\">请选择县市</option>");
                    $.each(reValue.listXian, function (index, element) {
                        $("#AreaCode").append("<option value=\"" + element.AreaCode + "\">" + element.AreaName + "</option>");
                    });

                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
        });
        $("#FrsZY").change(function () {
            var frsValue = $("#FrsZY").get(0).selectedIndex;
            $("#SecZy option").css("display", "inline");
            $("#SecZy option:eq(" + (frsValue) + ")").css("display", "none");
        });
        $("#SecZy").change(function () {
            var secValue = $("#SecZy").val();
            $("#FrsZY option").css("display", "inline");
            $("#FrsZY option:eq(" + (secValue) + ")").css("display", "none");
        });
        $("#tijiao").click(function () {
            var _IsAdjust = 0;
            if ($("#IsAdjust").is(':checked') == true) {
                _IsAdjust = 1;
            }
            var info = {
                SignUpNum: $("#SignUpNum").val(),
                Zkzh: $("#Zkzh").val(),
                Sfzh: $("#Sfzh").val(),
                StuName: $("#StuName").val(),
                Csrq: $("#Csrq").val(),
                Xb: $("#Xb").val(),
                Mobile: $("#Mobile").val(),
                Nation: $("#Nation").val(),
                ZZMM: $("#ZZMM").val(),
                Health: $("#Health").val(),
                KSLB: $("#KSLB").val(),
                AreaCode_Shi: $("#AreaCode_Shi").val(),
                AreaCode: $("#AreaCode").val(),
                Byxx: $("#Byxx").val(),
                BYLB: $("#BYLB").val(),
                LikeSpecial: $("#LikeSpecial").val(),
                Tel: $("#Tel").val(),
                Yzbm: $("#Yzbm").val(),
                Txdz: $("#Txdz").val(),
                FrsZY: $("#FrsZY").val(),
                SecZy: $("#SecZy").val(),
                IsAdjust: _IsAdjust,
                AcceptPeople:$("#AcceptPeople").val(),
            };
            var strInfo = JSON.stringify(info);
            $.ajax({
                type: "Post",
                url: "EntityInfo.aspx/saveInfo",
                dataType: "Json",
                contentType: "application/json;charset=utf-8",
                data: strInfo,
                success: function (data) {
                    var reValue = JSON.parse(data.d);
                    alert(reValue.message);

                },
                error: function (errdata) {
                    alert("后台数据错误");
                }
            });
        });
        ///shuju验证
        $("#form1").validate({
            debug: true,
            rules: {
                Nation: { required: true, },
                ZZMM: { required: true, },
                Health: { required: true, },
                KSLB: { required: true, },
                AreaCode: { required: true, },
                Byxx: { required: true, },
                BYLB: { required: true, },
                LikeSpecial: { required: true, },
                Tel: { required: true, rangelength: [12, 12], isPhone: true, },
                Yzbm: { required: true, rangelength: [6, 6], isYzbmCode: true, },
                Txdz: { required: true, minlength: 10, },
                FrsZY: { required: true, },
                SecZy: { required: true, }
            },
            messages: {

                Nation: { required: "请选择民族", },
                ZZMM: { required: "请选择政治面貌", },
                Health: { required: "请填写身体健康状况", },
                KSLB: { required: "请选择考生类别", },
                AreaCode: { required: "请选择市县", },
                Byxx: { required: "请输入毕业学校", },
                BYLB: { required: "请输入毕业学校类别", },
                LikeSpecial: { required: "请输入爱好", },
                Tel: { required: "请输入固定电话", rangelength: "请输入有效的固定电话", isPhone: "请输入正确的固定电话", },
                Yzbm: { required: "请输入邮政编码", rangelength: "请输入有效的邮政编码", isYzbmCode: "请正确填写邮政编码" },
                Txdz: { required: "请输入通讯地址", minlength: "请准确到门牌号" },
                FrsZY: { required: "请选择第一志愿", },
                SecZy: { required: "请选择第二志愿", }
            },

        });
        jQuery.validator.addMethod("isPhone", function (value, element) {
            var length = value.length;
            //var mobile =  /^(((13[0-9]{1})|(15[0-9]{1})|(18[0-9]{1})|(14[0-9]{1})|(17[0-9]{1}))+\d{8})$/;
            var tel = /^\d{3,4}-?\d{6,9}$/;
            return this.optional(element) || tel.test(value);

        }, "请正确填写您的联系电话");
        jQuery.validator.addMethod("isYzbmCode", function (value, element) {
            var tel = /^[0-9]{6}$/;
            return this.optional(element) || (tel.test(value));
        }, "请正确填写您的邮政编码");
        $("#form1").submit(function () {
            var info = {
                SignUpNum: $("#SignUpNum").val(),
                Zkzh: $("#Zkzh").val(),
                StuName: $("#StuName").val(),
                Sfzh: $("#Sfzh").val(),
                Mobile: $("#Mobile").val(),
                Nation: $("#Nation").val(),
                ZZMM: $("#ZZMM").val(),
                Health: $("#Health").val(),
                KSLB: $("#KSLB").val(),
                AreaCode: $("#AreaCode").val(),
                Byxx: $("#Byxx").val(),
                BYLB: $("#BYLB").val(),
                LikeSpecial: $("#LikeSpecial").val(),
                Tel: $("#Tel").val(),
                Yzbm: $("#Yzbm").val(),
                Txdz: $("#Txdz").val(),
                FrsZY: $("#FrsZY").val(),
                SecZy: $("#SecZy").val()
            };
        }); 
        $("#btnFileUpLoad").click(function () {
            var fileUpLoad = $("#fupload").get(0);
            var files = fileUpLoad.files;
            if (files.length == 0) {
                alert("请选择上传的照片");
                return;
            }
            var data = new FormData();
            for (var i = 0; i < files.length; i++) {
                data.append(files[i].name, files[i]);
            }
            $.ajax({
                url: "UpLoadHandler.ashx",
                type: "POST",
                async: false,
                data: data,
                contentType: false,
                processData: false,
                success: function (result) {
                    alert("success");
                },
                error:function(err){
                    alert(err.statusText);
                }

            });
        });
        $("#dayin").click(function () {
            $.ajax({
                url: "EntityInfo.aspx/pointInfo",
                type: "POST",
                dataType:"json",
                contentType: "application/json;charset=utf-8",
                processData: false,
                success: function (data) {
                    alert("success");
                },
                error: function (err) {
                    alert("打印失败");
                }

            });
        });
    </script>
</asp:Content>
