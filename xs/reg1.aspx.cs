using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Busines;
using Entity;
using Newtonsoft.Json;
namespace xs
{
    public partial class reg_sqbm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string getStuTypeList()
        {
            //int code = 1;
            // String message = "成功";
            List<StudentsType> _list = new List<StudentsType>();
            StudentsTypeBLL bll = new StudentsTypeBLL();
            {
                _list = bll.getStuTypeList();
            }
            return JsonConvert.SerializeObject(_list);
        }

        [WebMethod]
        public static string intsertStuUser(string Sfzh, string Password, string Zkzh, string StuName, string StuType, string Mobile, string E_mail)
        {
            int code = 0;
            string message = "错误";
            int _list;
            StudentsUser stuUser = new StudentsUser();
            stuUser.Sfzh = Sfzh;
            stuUser.Password = Password;
            stuUser.Zkzh = Zkzh;
            stuUser.StuName = StuName;
            stuUser.StuType = int.Parse(StuType);
            stuUser.Mobile = Mobile;
            stuUser.E_mail = E_mail;
            stuUser.Bz = "";
            stuUser.Certificate = "";
            stuUser.CheckTime = DateTime.Parse("1900-01-01");
            stuUser.CriterionCouse = "";
            stuUser.IsCheck = 0;
            stuUser.IsCriterion = 0;
            stuUser.IsPlan = 0;
            stuUser.LastLoginDate = DateTime.Now;
            stuUser.LoginCount = 1;
            stuUser.SignUpNum = "00";
            stuUser.State = 1;
            stuUser.RegDate = DateTime.Now;
            using (StudentsUserBLL bll = new StudentsUserBLL())
            {
                try
                {
                    _list = bll.Insert(stuUser);
                    stuUser.SignUpNum = _list.ToString().PadLeft(6, '0');
                    bll.Update(stuUser);
                    code = 1;
                    message = "提交成功 用户名为"+ bll.getStudentsSignUpNumBySfzh(stuUser.Sfzh).SignUpNum;

                }
                catch (Exception)
                {

                    code = 0;
                    message = "提交失败";
                }

            }
            string str = JsonConvert.SerializeObject(new { code = code, message = message });
            return str;

        }



    }
}