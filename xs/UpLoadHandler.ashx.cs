using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Busines;
namespace xs
{
    /// <summary>
    /// UpLoadHandler 的摘要说明
    /// </summary>
    public class UpLoadHandler : IHttpHandler,IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpFileCollection files = context.Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files[i];
                StudentsUser user = context.Session["user_"] as StudentsUser;
                string fileName = context.Server.MapPath("~/uploads")+"//"+user.Sfzh+".jpg";
                file.SaveAs(fileName);
                using (StudentInfoBLL bll = new StudentInfoBLL())
                {
                    StudentInfo selectInfo = bll.getEntity(user.Sfzh);
                    selectInfo.PicPath = "//uploads//" + user.Sfzh + ".jpg";

                    bll.Update(selectInfo);
                }
            }
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}