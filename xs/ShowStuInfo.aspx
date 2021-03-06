﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowStuInfo.aspx.cs" Inherits="xs.ShowStuInfo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生信息浏览</title>
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.js"></script>
    <script src="scripts/jqPaginator.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>姓名</th>
                        <%--<th>性别</th>--%>
                        <th>身份证</th>
                        <th>高考考号</th>
                        <th>手机号</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
            <nav class="text-center">
                <ul class="pagination"></ul>
            </nav>
            <div class="text-center">
                <a class="btn" id="btnOut">导出全部数据到EXCEL</a>&nbsp;&nbsp;
                <a class="btn" id="btnOutAll">导出考生所有信息</a>
                <a href="#" id ="aFileDu">下载</a>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#aFileDu').hide()
            $('.pagination').jqPaginator(
                {
                    totalPages: 100,
                    visiblePages: 5,
                    currentPage: 1,
                    totalCounts: 1000,
                    first: '<li class="first"><a href="javascript:void(0);">第一页</a></li>',
                    prev: '<li class="prev"><a href="javascript:void(0);">上一页</a></li>',
                    statistics: '<li class="disabled"><a>共{{totalPages}}页 共{{totalCounts}}条</a></li>',
                    next: '<li class="next"><a href="javascript:void(0);">下一页</a></li>',
                    last: '<li class="last"><a href="javascript:void(0);">最后一页</a></li>',
                    page: '<li class = "page"><a href="javascript:void(0);">{{page}}</a></li>',
                    onPageChange: function (num, type) {
                        $(".table-hover tbody").empty();
                        var pagePar = JSON.stringify({
                            pageIndex: num,
                            pageSize: 1
                        });
                        $.ajax({
                            type: 'post',
                            url: "ShowStuInfo.aspx/getStudentInfoPage",
                            contentType: "application/json;charset=utf-8",
                            data: pagePar,
                            dataType: 'json',
                            success: function (data) {
                                var obj = JSON.parse(data.d);
                                if (obj.code == 1) {
                                    var tr = "";
                                    $.each(obj.stuInfoPage.Items, function (index, item) {
                                        tr = tr + "<tr>";
                                        tr = tr + "<td>" + item.StuName + "</td>"
                                        tr = tr + "<td>" + item.Sfzh + "</td>"
                                        tr = tr + "<td>" + item.Zkzh + "</td>"
                                        tr = tr + "<td>" + item.Mobile + "</td>"
                                        tr = tr + "</tr>";


                                    });
                                    $(".table-hover tbody").append(tr);
                                }
                                $('.pagination').jqPaginator('option', {
                                    totalPages: obj.stuInfoPage.TotalPages,
                                    totalCounts: obj.stuInfoPage.TotalItems
                                })
                            },
                            error: function (error) { }
                        });
                    }
                })
        });
        $("#btnOut").click(function () {
            $.ajax({
                type: 'post',
                url: "ShowStuInfo.aspx/getAllDataToExcel",
                contentType: "application/json;charset=utf-8",
                async:false,
                dataType: 'json',
                success: function (data) {
                    var obj = JSON.parse(data.d);
                    if (obj.code == 1) {
                        //var btnOut
                        $("#aFileDu").show().attr("href", obj.filePath);
                    }
                },
                error: function (error) {
                    alert("error")
                }
            })
        }
);
        $("#btnOutAll").click(function () {
            $.ajax({
                type: 'post',
                url: "ShowStuInfo.aspx/getAllStu",
                contentType: "application/json;charset=utf-8",
                dataType: 'json',
                success: function (data) {
                    var obj = JSON.parse(data.d);
                    if (obj.code == 1) {
                        //var btnOut
                        $("#aFileDu").show().attr("href", obj.filePath);
                    }
                },
                error: function (error) {
                    alert("error")
                }
            })
        })
    </script>
</body>
</html>
