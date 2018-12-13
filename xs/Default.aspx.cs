using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Configuration;

namespace xs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //AJAX
        [WebMethod]
        public static string getIsStart()
        {
            string returnValue = "";
            string str3 = "{\"code\":\"0\",\"url\":\"#\",\"message\":\"现在报名还未开始！\"}";//
            string str1 = "{\"code\":\"1\",\"url\":\"reg.aspx\",\"message\":\"现在可以报名！\"}";//
            string str2 = "{\"code\":\"2\",\"url\":\"#\",\"message\":\"现在报名已结束！\"}";//
            DateTime strartTime = DateTime.Parse(WebConfigurationManager.AppSettings["startTime"]);
            DateTime endTime = DateTime.Parse(WebConfigurationManager.AppSettings["endTime"]);
            if (DateTime.Now >= strartTime && DateTime.Now <= endTime)
            {
                returnValue = str1;
            }
            if (DateTime.Now < strartTime)
            {
                returnValue = str3;
            }
            if (DateTime.Now > endTime)
            {
                returnValue = str2;
            }
            return returnValue;
        }
    }
}