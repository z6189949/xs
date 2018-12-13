using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Newtonsoft.Json;
using Busines;
using Entity;
using Common;
using System.Text;

namespace xs
{
    public partial class resetPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]

        public static string restPassword(string Sfzh, string Zkzh)
        {
            int code = 1;
            string message = "发送验证邮件成功，请登陆注册时的电子邮件";
            string fsurl = "";
            StudentsUser user;
            using (StudentsUserBLL bll = new StudentsUserBLL())
            {
                user = bll.getStubySfzh(Sfzh);
            }
            if (user == null)
            {
                code = 0;
                message = "您输入的信息有误请重新输入";
            }
            else if (user.Zkzh != Zkzh)
            {
                code = 0;
                message = "身份证和准考证号不匹配";
            }
            else
            {
                StringBuilder MailContent = new StringBuilder();
                string port = HttpContext.Current.Request.Url.Port.ToString();
                string host = HttpContext.Current.Request.Url.Host;
                if (port != "80")
                {
                    host = @"http://" + host + ":" + port;
                }
                string time_ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string urlhost = host + "/reg_EditPassword.aspx";
                MailContent.Append(string.Format("亲爱的{0}会员：<br/>", user.StuName));
                MailContent.Append("    您好！你于");
                MailContent.Append(time_);
                MailContent.Append("通过<a href='" + urlhost + "'>太原城市职业技术学院自主招生报考网站</a>审请找回密码。<br/>");
                MailContent.Append("　　　为了安全起见，请用户点击以下链接重设个人密码：<br/><br/>");

                string url1 = "?u=" + user.Id + "&t=" + time_;
                fsurl = urlhost + url1;
                MailContent.Append("<a href='" + fsurl + "'>" + fsurl + "</a><br/><br/>");
                MailContent.Append(" (如果无法点击该URL链接地址，请将它复制并粘帖到浏览器的地址输入框，然后单击回车即可。)");

                bool flag = MailService.SendEmailDefault(user.E_mail, MailContent.ToString(), user.StuName + "找回密码");
                if (flag == false)
                {
                    code = 0;
                    message = "邮件发送不成功，请检查E_mail地址是否正确，或与管理员联系！";
                }
            }
            string str3 = JsonConvert.SerializeObject(new { code = code, message = message });
            return str3;
        }
    }
}