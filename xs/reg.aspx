<%@ Page Title="" Language="C#" MasterPageFile="~/xsMaste.Master" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="xs.reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p class="text-center">欢迎报考太原堿市职业技术竽院!为帮助您在規定时限內快捷确办理抿名手续,请务必认真阅读本须知</p>
    <p class="bmxzBt">(一)、网上报名</p>
    <p class="bmxzBt">报名时间：2018年3月25日8:0至3月29日17:00</p>
    <p class="bmxzBt">(二)、现场确认时间</p>
    <p class="bmxzBt">太原市范围内报名考生于4月1日、外地市报名考生于4月12日到字院招生就业办公室办理“信息确认”手续,并进行报名资格审查。</p>
    <p class="bmxzBt">(三)、基本操作程序</p>
    <p class="bmxzP">1、考生仔细阅读本须知后,填写提交个人信息。首欠报名的点击首次报名”;查看或修改信息的点击宣看、修改报名信息”</p>
    <p class="bmxzP">2、按要求如实填写所有项目,特別注主意姓名”、“身份证号码”、高考考号”务必准确填写◆"姓名项需顶格填写,中间不得加空格或其他特殊字符;“身份证号码ˇ须在半角状态下输入,其中末位是字母的X,不得用“号代替</p>
    <p class="bmxzP">3、上传电子照片。为保证信息采集隹确,照片必须符合规定格式要求。电子照近期、正面、1蓝底免到照,Pg格式,图片规格为114像素1像素,30以下(上传的照片直观上要求基本占满照片框且青晰,不得使用生活昭)。</p>
    <p class="bmxzP">4、网上打印《太原堿市职业技木字院2012年自主招生报名表》,要妥善保存,现场确认时需出示此表,谨防丢失。(建议使用激光打印机打印,黑白彩色均可,内容要清晰。该报名表只能从网上直接打印,不得拷贝后打印。</p>
    <p class="bmxzP">5、现场确认φ招生部门将对考生提交的相关信息、上传的照片质里及专业课省统考成绩进行审查,信息无误且符合报名条件的,方可通过,领取准考证</p>
    <p class="bmxzBt">(四)、报名注意事项</p>
    
    <p class="bmxzP">1、本次招生政策,确认本人具备报考条件。</p>
    <p class="bmxzP">2、实行产格的自律制度,对提交信息的真买性员箦,凡弄作黄的,一经发现即取消考试和录取资格</p>
    <p class="bmxzP">3、报名时不得以他人身份证及信息或随g杜撰的信息报名,否则造成其他考生无法实现报名确认等情兄而引起纠纷的,需自行承担全部责任</p>
    <p class="bmxzP">4、报名者信息提交成功后,将会获由系S统提供的一个报名序号,该序喜是考生再次登录和找回密码的重要验证信息,请务必车记。</p>
    <p class="bmxzP">5、本系统以报名序号和密码作为登录的依据,报考人员请保管好自己的登录资料,否则他人误用造成的后果,学院不承担任何责任</p>
    <p class="bmxzP">6、要托他人进行网上抿名的,请务必准确了解报考者信息,以免出现错误信息影响向考试和资格复审特另提示:考生应抓紧时间进行报名,避免由于双望等待,造成后期报名人员过度集中,导致网络繁忙堵塞,累报名及现场确认。考生首次报名完成后,及时查看审核结果,如有错误请及时更正</p>
    <p class="bmxzBt">二、其他事项</p>
    <p class="bmxzP">1、如在同一I地址同一台计算机服名时,每欠报名后请关闭测芡器,重新登录报名,以防个人信息覆盖</p>
    <p class="bmxzP">2、考生必须在规定时间内完成网上报名手续,未按时现场确认者视为放弃考试报名</p>
    <p class="bmxzP">3、为了严肃考风考纪,打造公平竟争的良好环墳,防止违纪行为的发生,原则上考生参考时须持《准考证》和第二代正式《居民身份证》或地公安机关出具的身份证明方可入考场</p>
    <p class="bmxzP">4、如果您在网上报名及《太原城市职业技术字院2013年自主招生报名表》打印过程中遇到技术问题请与太原堿市职业技术竽院招生就业办公室联系,电话:0351-5633111,0351-5633222</p>
    <p class="text-right " style="font-size:20px;font-family: 微软雅黑;">招生就业办公室</p>
    <div class="text-center">
        <a id ="aBmy">
            <input type="button" id="btnChick" class="btn btn-info disabled" value="我已认真阅读须知，现在报名！"/>

        </a>
    </div>
    <script type="text/javascript">
        setInterval("enabledClick()", 6000);
        function enabledClick() {
            if ($("#aBmy").attr("href") != "undefined") {
                $("#aBmy").attr("href", "/reg1.aspx");
                $("#btnChick").removeClass("disabled");
            }
        }
    </script>
</asp:Content>
